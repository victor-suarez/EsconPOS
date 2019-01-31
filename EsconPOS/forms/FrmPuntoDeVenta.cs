using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmPuntoDeVenta : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();
        private bool isLoading = true;
        private TotalesDoc LineaTotales;
        private string Numeros = "0123456789" + Convert.ToChar(Keys.Return) + Convert.ToChar(Keys.Back);
        private Documentos UltimoDoc;
        private FrmImpresora vPrinter = null;
        // Esto para sacar los datos de impresión.

        private struct TotalesDoc
        {
            // Estos campos son por item
            private decimal _MontoBruto;

            // Estos campos son por documento
            private decimal _MontoDescuento;

            private decimal _MontoDtoXItems;
            private decimal _MontoExcento;
            private decimal _MontoGravado;
            private decimal _MontoImpuestos;
            private decimal _MontoNeto;

            // Estos campos son por pago
            private decimal _MontoPago;

            private decimal _SubTotal;

            //public TotalesDoc(decimal MtoBrut, decimal MtoGrav, decimal MtoImpts, decimal MtoExen, decimal MtoSubTotal, decimal MtoDesc, decimal MtoNeto)
            //{
            //    MontoBruto = MtoBrut;
            //    MontoGravado = MtoGrav;
            //    MontoImpuestos = MtoImpts;
            //    MontoExcento = MtoExen;
            //    SubTotal = MtoSubTotal;
            //    MontoDescuentos = MtoDesc;
            //    MontoNeto = MtoNeto;
            //}
            public double MontoBruto { get { return (double)_MontoBruto; } }

            public double MontoDescuento { get { return (double)_MontoDescuento; } }

            public double MontoDtoXItems { get { return (double)_MontoDtoXItems; } }

            public double MontoExcento { get { return (double)_MontoExcento; } }

            public double MontoGravado { get { return (double)_MontoGravado; } }

            public double MontoImpuestos { get { return (double)_MontoImpuestos; } }

            public double MontoNeto { get { return (double)_MontoNeto; } }

            public double MontoPagado { get { return (double)_MontoPago; } }

            public double SubTotal { get { return (double)_SubTotal; } }

            public void AgregaPago(decimal MontoPago)
            {
                _MontoPago += MontoPago;
            }

            public void CalculaTotalDocumento(decimal MontoBruto, decimal MontoDctoXItem, decimal MontoImpuesto, decimal MontoDescuento)
            {
                _MontoBruto += MontoBruto;
                _MontoDtoXItems += MontoDctoXItem;
                if (MontoImpuesto == 0)
                    _MontoExcento += (MontoBruto - MontoDctoXItem);
                else
                    _MontoGravado += (MontoBruto - MontoDctoXItem);
                _MontoImpuestos += MontoImpuesto;
                _SubTotal += (MontoBruto - MontoDctoXItem + MontoImpuesto);

                _MontoDescuento = MontoDescuento;
                _MontoNeto = _SubTotal - MontoDescuento;
            }

            public void Clear()
            {
                _MontoBruto = 0;
                _MontoDescuento = 0;
                _MontoDtoXItems = 0;
                _MontoExcento = 0;
                _MontoGravado = 0;
                _MontoImpuestos = 0;
                _MontoNeto = 0;
                _MontoPago = 0;
                _SubTotal = 0;
            }

            public decimal PorPagar()
            {
                return _MontoNeto - _MontoPago;
            }
        }

        #endregion Variables y constantes

        #region Funciones

        private void ActualizaTotalesDoc()
        {
            LblMontoBruto.Text = LineaTotales.MontoBruto.ToString("N2");
            LblDescuentos.Text = LineaTotales.MontoDtoXItems.ToString("N2");
            LblImpuestos.Text = LineaTotales.MontoImpuestos.ToString("N2");
            LblMontoNeto.Text = LineaTotales.MontoNeto.ToString("N2");
            LblMontoPagado.Text = LineaTotales.MontoPagado.ToString("N2");
        }

        private void AgregarClienteRapido()
        {
            if (!ValCliEntReq()) return;
            try
            {
                var clie = new Clientes
                {
                    IdentificacionID = ((Identificaciones)CmbTipoIDCli.SelectedItem).IdentificacionID,
                    NroDocIdent = TxtNroIDCli.Text.Trim(),
                    Nombre = CmbClientes.Text.Trim(),
                    Direccion = null,
                    PaisID = null,
                    DistritoID = Global.glDistritoEmpresa,
                    NroTelefonico = null,
                    CorreoElectronico = null,
                    FechaNacimiento = null,
                    Activo = 1,
                    AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glUsuario
                };
                context.Clientes.Add(clie);
                context.SaveChanges();
                CargarClientes();
                CmbClientes.SelectedValue = clie.ClienteID;
                SetStatus("Cliente agregado.");
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos del cliente.");
                return;
            }
        }

        private void AgregarFormaPago()
        {
            if (!ValPagEntReq()) return;
            //if (!ExisteFormaPago(((FormasPagos)CmbFormaPago.SelectedItem).FormaPagoID))
            {
                // Agregar fila al grid
                int NewRowIdx = DgvPagos.Rows.Add(
                                                    ((FormasPagos)CmbFormaPago.SelectedItem).Codigo,
                                                    NumMontoPago.Value.ToString("N2"),
                                                    CmbBanco.SelectedIndex == -1 ? "" : ((Bancos)CmbBanco.SelectedItem).Iniciales,
                                                    TxtNroDocPago.Text.Trim(),
                                                    TxtNroAutPago.Text.Trim()
                                                );

                DgvPagos.Rows[NewRowIdx].Tag = new Pagos
                {
                    FormaPagoID = ((FormasPagos)CmbFormaPago.SelectedItem).FormaPagoID,
                    MonedaID = ((Monedas)cmbMonedas.SelectedItem).MonedaID,
                    MontoPago = (double)NumMontoPago.Value,
                    BancoID = CmbBanco.SelectedIndex == -1 ? -1 : ((Bancos)CmbBanco.SelectedItem).BancoID,
                    NroDocPago = TxtNroDocPago.Text.Trim() == "" ? null : TxtNroDocPago.Text.Trim(),
                    Autorizacion = TxtNroAutPago.Text.Trim() == "" ? null : TxtNroAutPago.Text.Trim(),
                    AgregadoEl = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glEmpleado
                };
                LineaTotales.AgregaPago(NumMontoPago.Value);
                ActualizaTotalesDoc();
                if (LineaTotales.MontoPagado == LineaTotales.MontoNeto)
                {
                    GuardarDocumento();
                }
                else
                {
                    ClearFormaPago();
                }
            }
        }

        private void AgregarItemDoc()
        {
            if (!ValItemEntReq()) return;
            if (ItemYaExiste(TxtProdCodigo.Text))
            {
                SetStatus("Item ya está seleccionado.", true);
                return;
            }

            // ((ValorUnitario * Cantidad) - Descuento) + ((ValorUnitario * Cantidad) - Descuento)  * (TasaImpuesto / 100))
            decimal SubTotalItem = (NumValorUnit.Value * NumCantidad.Value) - NumDescuento.Value;
            decimal FactorImpuesto = (decimal)(((Productos)CmbProductos.SelectedItem).Impuestos.Tasa / 100);
            decimal MontoImpuesto = SubTotalItem * FactorImpuesto;
            decimal TotalItem = SubTotalItem + MontoImpuesto;
            //DataGridViewImageCell DgvImage = new DataGridViewImageCell();
            //DgvImage.Value = Properties.Resources.Quitar;
            int idxRow = DgvProdServ.Rows.Add(
                                                TxtProdCodigo.Text,                 // 0
                                                CmbProductos.Text,                  // 1
                                                NumValorUnit.Value.ToString("N2"),  // 2
                                                NumCantidad.Value.ToString("N2"),   // 3
                                                NumDescuento.Value.ToString("N2"),  // 4
                                                SubTotalItem.ToString("N2"),        // 5
                                                MontoImpuesto.ToString("N2"),       // 6
                                                TotalItem.ToString("N2")            // 7
                                            );
            DgvProdServ.Rows[idxRow].Tag = new ItemsDocumentos
            {
                ItemID = idxRow + 1,
                ProductoID = ((Productos)CmbProductos.SelectedItem).ProductoID,
                ValorUnitario = ((Productos)CmbProductos.SelectedItem).ValorUnitario,
                Cantidad = (long)NumCantidad.Value,
                MontoDescuento = (double)NumDescuento.Value,
                SubTotal = (double)SubTotalItem,
                ImpuestoID = ((Productos)CmbProductos.SelectedItem).ImpuestoID,
                TasaImpuesto = ((Productos)CmbProductos.SelectedItem).Impuestos.Tasa,
                MontoImpuesto = (double)MontoImpuesto,
                MontoNeto = (double)TotalItem,
                VendidoPor = ((Empleados)CmbEmpleados.SelectedItem).EmpleadoID,
                EsDevolucion = 0
            };
            DgvProdServ.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            LineaTotales.CalculaTotalDocumento((NumValorUnit.Value * NumCantidad.Value), NumDescuento.Value, MontoImpuesto, NumDctoGlobal.Value);
            ActualizaTotalesDoc();
            ClearItem();
            TxtProdCodigo.Focus();
        }

        private void AgregarVendedorRapido()
        {
            if (!ValVenEntReq()) return;
            try
            {
                var empl = new Empleados
                {
                    IdentificacionID = ((Identificaciones)CmbTipoIDEmp.SelectedItem).IdentificacionID,
                    NroDocIdent = TxtNroIDEmp.Text,
                    Nombre = CmbEmpleados.Text,
                    Direccion = null,
                    Telefono = null,
                    CorreoElectronico = null,
                    Login = CmbEmpleados.Text.Trim().Replace(" ", "").Substring(0, 8).ToUpper(),
                    PasswdHash = "",
                    EsSupervisor = 0,
                    EsAdministrador = 0,
                    Activo = 1,
                    AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glUsuario
                };
                context.Empleados.Add(empl);
                context.SaveChanges();
                CargarVendedores();
                CmbEmpleados.SelectedValue = empl.EmpleadoID;
                SetStatus("Vendedor agregado.");
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos del vendedor.");
                return;
            }
        }

        private void CargarBancos()
        {
            CmbBanco.DataSource = context.Bancos
                                  .Where(b => b.Activo == 1)
                                  .OrderBy("Nombre")
                                  .ToList();
            CmbBanco.DisplayMember = "Nombre";
            CmbBanco.ValueMember = "BancoID";
            if (CmbBanco.Items.Count == 1)
                CmbBanco.SelectedIndex = 0;
            else
                CmbBanco.SelectedIndex = -1;
        }

        private void CargarClases()
        {
            CmbClases.DataSource = context.TiposProductos
                                    .Where(t => t.Activo == 1)
                                    .OrderBy("Codigo")
                                    .ToList();
            CmbClases.DisplayMember = "TipoProducto";
            CmbClases.ValueMember = "TipoProductoID";
            if (CmbClases.Items.Count == 1)
                CmbClases.SelectedIndex = 0;
            else
                CmbClases.SelectedIndex = -1;
        }

        private void CargarClientes()
        {
            string FiltroTipoID = CmbTipoIDCli.SelectedIndex == -1 ? "" : ((Identificaciones)CmbTipoIDCli.SelectedItem).Codigo;
            string FiltroNroID = TxtNroIDCli.Text.Trim();
            CmbClientes.DataSource = context.Clientes
                                        .Where(c => (c.Identificaciones.Codigo == FiltroTipoID || FiltroTipoID == "")
                                                    &&
                                                    (c.NroDocIdent.Contains(FiltroNroID) || FiltroNroID == ""))
                                        .OrderBy("Nombre")
                                        .ToList();
            CmbClientes.DisplayMember = "Nombre";
            CmbClientes.ValueMember = "ClienteID";
            if (CmbClientes.Items.Count == 1)
                CmbClientes.SelectedIndex = 0;
            else
                CmbClientes.SelectedIndex = -1;
        }

        private void CargarCombos()
        {
            CargarIdent();
            CargarClientes();
            CargarVendedores();
            CargarMarcas();
            CargarClases();
            CargarProductos();
            CargarMonedas();
            CargarBancos();
            CargarFormasPago();
        }

        private void CargarFormasPago()
        {
            CmbFormaPago.DataSource = context.FormasPagos
                                        .Where(f => f.Activo == 1)
                                        .OrderBy("Orden")
                                        .ToList();
            CmbFormaPago.DisplayMember = "FormaPago";
            CmbFormaPago.ValueMember = "FormaPagoID";
            if (CmbFormaPago.Items.Count > 0)
                CmbFormaPago.SelectedIndex = 0;
        }

        private void CargarIdent()
        {
            CmbTipoIDCli.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDCli.DisplayMember = "Identificacion";
            CmbTipoIDCli.ValueMember = "IdentificacionID";
            CmbTipoIDCli.SelectedIndex = -1;

            CmbTipoIDEmp.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDEmp.DisplayMember = "Identificacion";
            CmbTipoIDEmp.ValueMember = "IdentificacionID";
            CmbTipoIDEmp.SelectedIndex = -1;
        }

        private void CargarMarcas()
        {
            CmbMarcas.DataSource = context.Marcas.Where(m => m.Activo == 1).ToList();
            CmbMarcas.DisplayMember = "Marca";
            CmbMarcas.ValueMember = "MarcaID";
            if (CmbMarcas.Items.Count == 1)
                CmbMarcas.SelectedIndex = 0;
            else
                CmbMarcas.SelectedIndex = -1;
        }

        private void CargarMonedas()
        {
            cmbMonedas.DataSource = context.Monedas.Where(m => m.Activo == 1).OrderBy("MonedaID").ToList();
            cmbMonedas.DisplayMember = "Moneda";
            cmbMonedas.ValueMember = "MonedaID";
            if (cmbMonedas.Items.Count > 0)
                cmbMonedas.SelectedIndex = 0;
        }

        private void CargarProductos()
        {
            isLoading = true;
            long MarcaID = CmbMarcas.SelectedIndex < 0 ? -1 : ((Marcas)CmbMarcas.SelectedItem).MarcaID;
            long TipoProductoID = CmbClases.SelectedIndex < 0 ? -1 : ((TiposProductos)CmbClases.SelectedItem).TipoProductoID;
            CmbProductos.DataSource = context.Productos
                                        .Where(p => (p.MarcaID == MarcaID || MarcaID == -1)
                                                    &&
                                                    (p.TipoProductoID == TipoProductoID || TipoProductoID == -1)
                                                    &&
                                                    p.Activo == 1)
                                        .OrderBy("Producto")
                                        .ToList();
            CmbProductos.DisplayMember = "Producto";
            CmbProductos.ValueMember = "ProductoID";
            if (MarcaID == -1 && TipoProductoID == -1)
                CmbProductos.SelectedIndex = -1;
            if (CmbProductos.Items.Count == 1)
                CmbProductos.SelectedIndex = 0;
            else
                CmbProductos.SelectedIndex = -1;

            isLoading = false;
        }

        private void CargarVendedores()
        {
            string FiltroTipoID = CmbTipoIDEmp.SelectedIndex == -1 ? "" : ((Identificaciones)CmbTipoIDEmp.SelectedItem).Codigo;
            string FiltroNroID = TxtNroIDEmp.Text.Trim();
            CmbEmpleados.DataSource = context.Empleados
                                        .Where(v => (v.Identificaciones.Codigo == FiltroTipoID || FiltroTipoID == "")
                                                    &&
                                                    (v.NroDocIdent.Contains(FiltroNroID) || FiltroNroID == ""))
                                        .OrderBy("Nombre")
                                        .ToList();
            CmbEmpleados.DisplayMember = "Nombre";
            CmbEmpleados.ValueMember = "EmpleadoID";
            if (CmbEmpleados.Items.Count == 1)
                CmbEmpleados.SelectedIndex = 0;
            else
                CmbEmpleados.SelectedIndex = -1;
        }

        private void ClearCrt()
        {
            CmbTipoIDCli.SelectedIndex = -1;
            TxtNroIDCli.Text = "";
            CmbClientes.SelectedIndex = -1;
            CmbTipoIDEmp.SelectedIndex = -1;
            TxtNroIDEmp.Text = "";
            CmbEmpleados.SelectedIndex = -1;
            TxtProdCodigo.Text = "";
            CmbMarcas.SelectedIndex = -1;
            CmbClases.SelectedIndex = -1;
            CmbProductos.SelectedIndex = -1;
            NumCantidad.Value = 0;
            NumValorUnit.Value = 0;
            NumDescuento.Value = 0;
            UltimoDoc = null;
            DgvProdServ.Rows.Clear();

            cmbMonedas.SelectedIndex = 0;
            LblMontoBruto.Text = 0.ToString("N2");
            LblDescuentos.Text = 0.ToString("N2");
            LblImpuestos.Text = 0.ToString("N2");
            LblMontoNeto.Text = 0.ToString("N2");
            LblMontoPagado.Text = 0.ToString("N2");

            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";

            // Limpiar / Ocultar forma de pago.
            DgvPagos.Rows.Clear();
            GbxPago.Visible = false;

            PnlDatosEntrada.Enabled = true;
            DgvProdServ.Enabled = true;
            PnlTotales.Enabled = true;
            LineaTotales.Clear();

            CmbTipoIDCli.Focus();
        }

        private void ClearFormaPago()
        {
            CmbFormaPago.SelectedIndex = 0;
            ChkTotal.Checked = false;
            NumMontoPago.Value = 0;
            CmbBanco.SelectedIndex = -1;
            TxtNroDocPago.Text = "";
            TxtNroAutPago.Text = "";
            CmbFormaPago.Focus();
        }

        private void ClearItem()
        {
            TxtProdCodigo.Text = "";
            CmbMarcas.SelectedIndex = -1;
            CmbClases.SelectedIndex = -1;
            CmbProductos.SelectedIndex = -1;
            NumCantidad.Value = 0;
            NumValorUnit.Value = 0;
            NumDescuento.Value = 0;
        }

        private decimal ToDecimalGringo(string Num)
        {
            return decimal.Parse(Num.ToString().Replace(".", "").Replace(",", "."), new CultureInfo("us-US"));
        }

        private void EliminarItem(object sender, int Idx)
        {
            if (((DataGridView)sender).Name == "DgvProdServ")
            {
                decimal MontoBruto = ToDecimalGringo(DgvProdServ["colProdServValorUnitario", Idx].Value.ToString()) * ToDecimalGringo(DgvProdServ["colProdServCantidad", Idx].Value.ToString());
                decimal MontoDcto = ToDecimalGringo(DgvProdServ["colProdServDescuento", Idx].Value.ToString());
                decimal MontoImpuesto = ToDecimalGringo(DgvProdServ["colProdServImpuestos", Idx].Value.ToString());
                // Negativos (* -1) porque estoy eliminando la línea
                LineaTotales.CalculaTotalDocumento(MontoBruto * -1, MontoDcto * -1, MontoImpuesto * -1, NumDctoGlobal.Value);
                ActualizaTotalesDoc();
                TxtProdCodigo.Focus();
            }
            else if (((DataGridView)sender).Name == "DgvPagos")
            {
                decimal MontoPago = ToDecimalGringo(DgvPagos["colFormaPagoMonto", Idx].Value.ToString());
                // Negativo (* -1) porque estoy eliminando la línea
                LineaTotales.AgregaPago(MontoPago * -1);
                ActualizaTotalesDoc();
                CmbFormaPago.Focus();
            }
           ((DataGridView)sender).Rows.RemoveAt(((DataGridView)sender).SelectedRows[0].Index);
        }

        private bool ExisteFormaPago(long ID)
        {
            foreach (DataGridViewRow row in DgvPagos.Rows)
            {
                if (((Pagos)row.Tag).FormaPagoID == ID) return true;
            };
            return false;
        }

        private void GuardarDocumento()
        {
            Documentos documento = null;
            if (!ValDocEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;

            //
            // Buscar el tipo de documento que se va a utilizar...
            // Usos de los tipos de documentos:
            // "FAC" para faturas
            // "DEV" para devoluciones
            // "NCR" para notas de crédito
            // "NDB" paea notas de débito
            //
            TiposDocumentos TiposDoc;
            try
            {
                TiposDoc = (from t in context.TiposDocumentos
                            join u in context.UsosDocumentos
                            on t.UsoID equals u.UsoID
                            where u.Codigo == "FAC"
                            select t).FirstOrDefault();
                if (TiposDoc == null)
                {
                    MessageBox.Show("Tipo de documento no está definido en el sistema.", "Error buscando siguiente número de documento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error buscando siguiente número de documento.");
                Cursor.Current = Cursors.Default;
                return;
            }

            //
            // Actualizar e siguiente número de documento
            //
            context.TiposDocumentos.Attach(TiposDoc);
            TiposDoc.NroSiguiente = TiposDoc.NroSiguiente + 1;
            TiposDoc.ModificadoPor = Global.glEmpleado;
            TiposDoc.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            context.SaveChanges();

            //
            // Abro una Mega Transacción...
            //
            context.Database.BeginTransaction();

            //
            // Creo el nuevo documento
            //
            try
            {
                documento = new Documentos
                {
                    NroDocumento = (long)TiposDoc.NroSiguiente,
                    TipoDocumentoID = TiposDoc.TipoDocumentoID,
                    CodDocumento = TiposDoc.Iniciales + "-" + TiposDoc.NroSiguiente.ToString("00000000"),
                    FechaDocumento = DateTime.Now.ToString("yyyy-MM-dd"),
                    HoraDocumento = DateTime.Now.ToString("HH:mm:ss"),
                    EmpresaID = ((Empleados)CmbEmpleados.SelectedItem).Empresas.FirstOrDefault().EmpresaID,
                    ClienteID = ((Clientes)CmbClientes.SelectedItem).ClienteID,
                    EmpleadoID = ((Empleados)CmbEmpleados.SelectedItem).EmpleadoID,
                    CajaID = Global.glCaja,
                    MonedaID = ((Monedas)cmbMonedas.SelectedItem).MonedaID,
                    TotalProductos = DgvProdServ.RowCount,
                    MontoBruto = (double)LineaTotales.MontoBruto,
                    MontoGravado = (double)LineaTotales.MontoGravado,
                    MontoImpuestos = (double)LineaTotales.MontoImpuestos,
                    MontoExcento = (double)LineaTotales.MontoExcento,
                    SubTotal = (double)LineaTotales.SubTotal,
                    MontoDescuentos = (double)NumDctoGlobal.Value,
                    MontoNeto = (double)LineaTotales.MontoNeto - (double)NumDctoGlobal.Value,
                    MontoPagado = LineaTotales.MontoPagado,
                    AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glEmpleado
                };
                context.Documentos.Add(documento);
                context.SaveChanges();
                UltimoDoc = documento;
            }
            catch (Exception ex)
            {
                context.Database.CurrentTransaction.Rollback();
                Global.MensajeError(ex, "Error guardando inicialmente del documento.");
                Cursor.Current = Cursors.Default;
                return;
            }

            //
            // Agrego los items al documento agregado
            //
            foreach (DataGridViewRow row in DgvProdServ.Rows)
            {
                try
                {
                    var itemDoc = new ItemsDocumentos
                    {
                        //DocumentoID = (long)TiposDoc.NroSiguiente,
                        ItemID = ((ItemsDocumentos)row.Tag).ItemID,
                        ProductoID = ((ItemsDocumentos)row.Tag).ProductoID,
                        ValorUnitario = ((ItemsDocumentos)row.Tag).ValorUnitario,
                        Cantidad = ((ItemsDocumentos)row.Tag).Cantidad,
                        ImpuestoID = ((ItemsDocumentos)row.Tag).ImpuestoID,
                        TasaImpuesto = ((ItemsDocumentos)row.Tag).TasaImpuesto,
                        MontoImpuesto = ((ItemsDocumentos)row.Tag).MontoImpuesto,
                        MontoDescuento = ((ItemsDocumentos)row.Tag).MontoDescuento,
                        MontoNeto = ((ItemsDocumentos)row.Tag).MontoNeto,
                        VendidoPor = ((ItemsDocumentos)row.Tag).VendidoPor,
                        EsDevolucion = ((ItemsDocumentos)row.Tag).EsDevolucion
                    };
                    documento.ItemsDocumentos.Add(itemDoc);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    context.Database.CurrentTransaction.Rollback();
                    Global.MensajeError(ex, "Error guardando un detalle del documento.");
                    Cursor.Current = Cursors.Default;
                    return;
                }
            }

            //
            // Agregar los pagos al documento agregado
            //
            foreach (DataGridViewRow row in DgvPagos.Rows)
            {
                try
                {
                    var pago = new Pagos
                    {
                        //DocumentoID = documento.DocumentoID,
                        FormaPagoID = ((Pagos)row.Tag).FormaPagoID,
                        MonedaID = ((Pagos)row.Tag).MonedaID,
                        MontoPago = ((Pagos)row.Tag).MontoPago,
                        BancoID = ((Pagos)row.Tag).BancoID == -1 ? null : ((Pagos)row.Tag).BancoID,
                        NroDocPago = ((Pagos)row.Tag).NroDocPago,
                        Autorizacion = ((Pagos)row.Tag).Autorizacion,
                        AgregadoEl = ((Pagos)row.Tag).AgregadoEl,
                        AgregadoPor = ((Pagos)row.Tag).AgregadoPor
                    };
                    documento.Pagos.Add(pago);
                    context.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    context.Database.CurrentTransaction.Rollback();
                    Global.MensajeError(ex, "Error guardando una forma de pago.");
                    Cursor.Current = Cursors.Default;
                    return;
                }
            }

            //
            // Guardar todo en la base de datos
            //
            try
            {
                context.Database.CurrentTransaction.Commit();
            }
            catch (System.Exception ex)
            {
                Global.MensajeError(ex, "Error guardando el documento en la base de datos.");
                Cursor.Current = Cursors.Default;
                return;
            }
            ImprimirFactura();
            vPrinter.Show();
            ClearCrt();
            Cursor.Current = Cursors.Default;
        }

        private void ImprimirFactura()
        {
            Empresas empresa;
            vPrinter = new FrmImpresora();
            vPrinter.MdiParent = this.MdiParent;
            vPrinter.PrinterWidth = 40;

            // HEADER EMPRESA
            try
            {
                empresa = (from e in context.Empresas
                           where e.EmpresaID == Global.glEmpresa
                           select e).Single();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error buscando los datos de la empresa.");
                return;
            }
            vPrinter.Print(empresa.RazonSocial, 'C');
            vPrinter.Print(empresa.Identificaciones.Iniciales + ": " + empresa.NroDocIdent.ToString(), 'C');
            vPrinter.Print(empresa.Direccion, 'C');
            vPrinter.Print(empresa.NroTelefonico, 'C');
            vPrinter.Print();

            // HEADER FACTURA
            vPrinter.Print("Factura: " + UltimoDoc.CodDocumento);
            vPrinter.Print(UltimoDoc.FechaDocumento + "  " + UltimoDoc.HoraDocumento);
            vPrinter.Print(new string('.', 40));

            // DATOS CLIENTE
            vPrinter.Print("Cliente: " + UltimoDoc.Clientes.Nombre);
            vPrinter.Print(UltimoDoc.Clientes.Identificaciones.Iniciales + ": " + UltimoDoc.Clientes.NroDocIdent.ToString());
            vPrinter.Print();

            // DATOS CAJERO
            vPrinter.Print(Global.glNomCaja);
            vPrinter.Print(Global.glNomEmpleado);
            vPrinter.Print(new string('.', 40));

            // PRODUCTOS
            foreach (DataGridViewRow row in DgvProdServ.Rows)
            {
                ItemsDocumentos item = (ItemsDocumentos)row.Tag;
                vPrinter.Print(item.Cantidad.ToString("##") + " X " + item.ValorUnitario.ToString("N2"));

                string descripcion = context.Productos.Where(p => p.ProductoID == item.ProductoID).Select(p => p.Producto).Single();
                if (descripcion.Length > 20)
                    vPrinter.Print(descripcion.Substring(0, 20) + (item.MontoImpuesto == 0 ? " E " : " G ") + item.SubTotal.ToString("N2").PadLeft(16));
                else
                    vPrinter.Print(descripcion.PadRight(20) + (item.MontoImpuesto == 0 ? " E " : " G ") + item.SubTotal.ToString("N2").PadLeft(16));
            }
            // FORMAS DE PAGO
            vPrinter.Print("FORMA DE PAGO");
            foreach (DataGridViewRow row in DgvPagos.Rows)
            {
                string Codigo = context.FormasPagos.Where(f => f.FormaPagoID == ((Pagos)row.Tag).FormaPagoID).Select(f => f.Codigo).Single();
                vPrinter.Print(Codigo + ((Pagos)row.Tag).MontoPago.ToString("N2").PadLeft(39 - Codigo.Length));
            }
            // TOTALES
            vPrinter.Print("num. de items = " + DgvProdServ.Rows.Count.ToString("F0"));
            vPrinter.Print(new string('.', 40));
            vPrinter.Print("SubTotal:  " + UltimoDoc.MontoBruto.ToString("N2").PadLeft(28));
            vPrinter.Print("Impuestos: " + UltimoDoc.MontoImpuestos.ToString("N2").PadLeft(28));
            vPrinter.Print("Total:     " + UltimoDoc.MontoNeto.ToString("N2").PadLeft(28));
            // CIERRE
            vPrinter.Print(new string('.', 40));
        }

        private bool ItemYaExiste(string Codigo)
        {
            foreach (DataGridViewRow r in DgvProdServ.Rows)
            {
                if (r.Cells[0].Value.ToString() == Codigo)
                    return true;
            }
            return false;
        }

        private void RecibirPago()
        {
            // ¿Hay un documento abierto?
            if (DgvProdServ.RowCount == 0)
            {
                SetStatus("No hay un documento abierto!", true);
                return;
            }
            PnlDatosEntrada.Enabled = false;
            DgvProdServ.Enabled = false;
            PnlTotales.Enabled = false;
            GbxPago.Visible = true;

            //FrmPago fPago = new FrmPago();
            //fPago.documento = doc;
            //fPago.MtoFaltante = doc.MontoNeto;
            //fPago.MtoPagado = 0;
            //fPago.MtoSobrante = 0;
            //fPago.ShowDialog();
        }

        private void SeleccionarProducto()
        {
            if (CmbProductos.SelectedIndex == -1) return;
            var producto = (Productos)CmbProductos.SelectedItem;
            TxtProdCodigo.Text = producto.Codigo;
            if (producto.PorFraccion == 0) NumCantidad.Value = 1;
            NumValorUnit.Value = (Decimal)producto.ValorUnitario;
        }

        private void SetStatus(string Status = "", bool Error = false)
        {
            if (Error)
                TssLblStatus.ForeColor = Color.Red;
            else
                TssLblStatus.ForeColor = SystemColors.ControlText;
            TssLblStatus.Text = Status;
        }

        private bool ValCliEntReq()
        {
            if (CmbTipoIDCli.SelectedIndex == -1)
            {
                CmbTipoIDCli.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDCli.Text.Trim().Length == 0)
            {
                TxtNroIDCli.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbClientes.Text.Trim().Length == 0)
            {
                CmbClientes.Focus();
                MessageBox.Show("Debe transcribir el nombre del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValDocEntReq()
        {
            if (CmbClientes.SelectedIndex == -1)
            {
                CmbClientes.Focus();
                MessageBox.Show("Debe seleccionar el cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbEmpleados.SelectedIndex == -1)
            {
                CmbEmpleados.Focus();
                MessageBox.Show("Debe seleccionar el vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (DgvProdServ.RowCount == 0)
            {
                TxtProdCodigo.Focus();
                MessageBox.Show("Debe seleccionar por lo menos un producto o servicio.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (cmbMonedas.SelectedIndex == -1)
            {
                cmbMonedas.Focus();
                MessageBox.Show("Debe seleccionar la moneda de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValItemEntReq()
        {
            if (CmbClientes.SelectedIndex == -1)
            {
                CmbClientes.Focus();
                MessageBox.Show("Debe seleccionar el cliente de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbEmpleados.SelectedIndex == -1)
            {
                CmbEmpleados.Focus();
                MessageBox.Show("Debe seleccionar el empleado/vendedor de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtProdCodigo.Text.Length == 0)
            {
                TxtProdCodigo.Focus();
                MessageBox.Show("Debe seleccionar un producto de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbProductos.SelectedIndex == -1)
            {
                CmbProductos.Focus();
                MessageBox.Show("Debe seleccionar un producto de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (NumCantidad.Value == 0)
            {
                NumCantidad.Focus();
                MessageBox.Show("La cantidad no puede ser cero.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (NumDescuento.Value > 0 && NumDescuento.Value > (NumValorUnit.Value * NumCantidad.Value))
            {
                NumDescuento.Focus();
                MessageBox.Show("El descuento por item no puede ser mayor al sub-total.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (NumDescuento.Value > 0 && NumDescuento.Value > (NumValorUnit.Value * NumCantidad.Value) * (decimal)(((Productos)CmbProductos.SelectedItem).Impuestos.Tasa / 100))
            {
                NumDescuento.Focus();
                MessageBox.Show("El descuento por item no puede ser mayor al impuesto.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool ValPagEntReq()
        {
            if (CmbFormaPago.SelectedIndex == -1)
            {
                CmbFormaPago.Focus();
                MessageBox.Show("Debe seleccionar la forma del pago de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (NumMontoPago.Value == 0)
            {
                NumMontoPago.Focus();
                MessageBox.Show("Debe transcribir el monto del pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (((FormasPagos)CmbFormaPago.SelectedItem).RequiereBanco == 1 && CmbBanco.SelectedIndex == -1)
            {
                CmbBanco.Focus();
                MessageBox.Show("Debe seleccionar el banco emisor del documento de pago de la lista.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (((FormasPagos)CmbFormaPago.SelectedItem).RequiereNumero == 1 && TxtNroDocPago.Text.Trim().Length == 0)
            {
                TxtNroDocPago.Focus();
                MessageBox.Show("Debe transcribir el número del documento de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (((FormasPagos)CmbFormaPago.SelectedItem).RequiereAutorizacion == 1 && TxtNroAutPago.Text.Trim().Length == 0)
            {
                TxtNroAutPago.Focus();
                MessageBox.Show("Debe transcribir el código de autorización emitido por el emisor del documento de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValVenEntReq()
        {
            if (CmbTipoIDEmp.SelectedIndex == -1)
            {
                CmbTipoIDEmp.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDEmp.Text.Trim().Length == 0)
            {
                TxtNroIDEmp.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación del vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbEmpleados.Text.Trim().Length == 0)
            {
                CmbEmpleados.Focus();
                MessageBox.Show("Debe transcribir el nombre del vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void VerifPagCamposReq()
        {
            if (CmbFormaPago.SelectedIndex == -1) return;
            var formapago = (FormasPagos)CmbFormaPago.SelectedItem;

            LblBanco.Visible = (formapago.RequiereBanco == 1);
            CmbBanco.Visible = (formapago.RequiereBanco == 1);
            LblNroDocPago.Visible = (formapago.RequiereNumero == 1);
            TxtNroDocPago.Visible = (formapago.RequiereNumero == 1);
            LblNroAutPago.Visible = (formapago.RequiereAutorizacion == 1);
            TxtNroAutPago.Visible = (formapago.RequiereAutorizacion == 1);

            GbxDatosAdicionales.Visible = ((formapago.RequiereBanco == 1) || (formapago.RequiereNumero == 1) || formapago.RequiereAutorizacion == 1);
        }

        #endregion Funciones

        #region Métodos

        public FrmPuntoDeVenta()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Enter(object sender, EventArgs e)
        {
            if (((Button)sender).Name == "BtnAgregarCliente")
            {
                if (CmbClientes.SelectedIndex != -1) SelectNextControl((Button)sender, true, true, true, false);
            }
            else if (((Button)sender).Name == "BtnAgregarEmpleado")
            {
                if (CmbEmpleados.SelectedIndex != -1) SelectNextControl((Button)sender, true, true, true, false);
            }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteRapido();
        }

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarVendedorRapido();
        }

        private void BtnAgregarPago_Click(object sender, EventArgs e)
        {
            AgregarFormaPago();
        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarItemDoc();
        }

        private void BtnCancelarPago_Click(object sender, EventArgs e)
        {
            // Limpiar / Ocultar forma de pago.
            LineaTotales.AgregaPago((decimal)LineaTotales.MontoPagado * -1);
            ActualizaTotalesDoc();

            DgvPagos.Rows.Clear();
            GbxPago.Visible = false;

            PnlDatosEntrada.Enabled = true;
            DgvProdServ.Enabled = true;
            PnlTotales.Enabled = true;
        }

        private void BtnQuitarItem_Click(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count == 0) return;
            EliminarItem(sender, ((DataGridView)sender).SelectedRows[0].Index);
        }

        private void ChkTotal_Click(object sender, EventArgs e)
        {
            if (ChkTotal.Checked)
            {
                NumMontoPago.Value = LineaTotales.PorPagar();
            }
        }

        // Siguiente campo cuando presiona[ENTER].
        private void ChkTotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                SelectNextControl((CheckBox)sender, true, true, true, false);
            }
        }

        //private void ChkTotal_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //}

        // Siguiente campo cuando presiona [ENTER]. Limpia selección cuando presiona [ESC].
        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (((ComboBox)sender).Name == "CmbFormaPago")
                    ((ComboBox)sender).SelectedIndex = 0;
                else
                    ((ComboBox)sender).SelectedIndex = -1;
            }
        }

        private void CmbClases_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((TiposProductos)e.ListItem).Codigo + "-" + ((TiposProductos)e.ListItem).TipoProducto;
        }

        private void CmbClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CmbFormaPago_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            VerifPagCamposReq();
        }

        private void CmbMarcas_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Marcas)e.ListItem).Codigo + "-" + ((Marcas)e.ListItem).Marca;
        }

        private void CmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isLoading) return;
            SeleccionarProducto();
        }

        private void CmbTipoID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Iniciales + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }

        private void CmbTipoIDCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CmbTipoIDEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        private void Dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Solo para la columna de Quitar.
            if (((DataGridView)sender).Name == "DgvProdServ" && (e.RowIndex < 0 || e.ColumnIndex != 8)) return;
            if (((DataGridView)sender).Name == "DgvPagos" && (e.RowIndex < 0 || e.ColumnIndex != 5)) return;
            EliminarItem(sender, e.RowIndex);
        }

        private void Dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (((DataGridView)sender).SelectedRows.Count == 0) return;
                EliminarItem(sender, ((DataGridView)sender).SelectedRows[0].Index);
            }
        }

        private void FrmPuntoDeVenta_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(this.toolStrip, (ToolStrip)this.MdiParent.Controls["toolStrip"]);
            DgvProdServ.Width = this.Width - DgvProdServ.Left - 27;
            PnlTotales.Left = DgvProdServ.Right - PnlTotales.Width;
            PnlTotales.Top = this.Height - toolStrip.Height - statusStrip.Height - PnlTotales.Height - 38;
            DgvProdServ.Height = this.Height - toolStrip.Height - statusStrip.Height - DgvProdServ.Top - PnlTotales.Height - 38;
        }

        private void FrmPuntoDeVenta_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge((ToolStrip)this.MdiParent.Controls["toolStrip"]);
        }

        private void FrmPuntoDeVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            ToolStripManager.RevertMerge((ToolStrip)this.MdiParent.Controls["toolStrip"]);
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmPuntoDeVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            //this.WindowState = FormWindowState.Normal;

            this.Width = this.MdiParent.ClientSize.Width - 6;
            this.Height = this.MdiParent.ClientSize.Height - 90;

            DgvProdServ.Width = this.Width - DgvProdServ.Left - 27;
            PnlTotales.Left = DgvProdServ.Right - PnlTotales.Width;
            PnlTotales.Top = this.Height - statusStrip.Height - PnlTotales.Height - 38;
            DgvProdServ.Height = this.Height - statusStrip.Height - DgvProdServ.Top - PnlTotales.Height - 38;
            CargarCombos();
            CmbTipoIDCli.Focus();
        }

        private void FrmPuntoDeVenta_SizeChanged(object sender, EventArgs e)
        {
            DgvProdServ.Width = this.Width - DgvProdServ.Left - 27;
            PnlTotales.Left = DgvProdServ.Right - PnlTotales.Width;
            PnlTotales.Top = this.Height - statusStrip.Height - PnlTotales.Height - 38;
            DgvProdServ.Height = this.Height - statusStrip.Height - DgvProdServ.Top - PnlTotales.Height - 38;
        }

        private void GbxPago_VisibleChanged(object sender, EventArgs e)
        {
            if (GbxPago.Visible)
                CmbFormaPago.Focus();
            else
            {
                ClearFormaPago();
            }
        }

        private void Num_Enter(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (((NumericUpDown)sender).Name == "NumDctoGlobal")
                    TsBtnRecibirPago_Click(null, null);
                else if (((NumericUpDown)sender).Name == "NumMontoPago")
                {
                    if (!GbxDatosAdicionales.Visible)
                    {
                        BtnAgregarPago_Click(NumMontoPago, null);
                    }
                    else
                    {
                        CmbBanco.Focus();
                    }
                }
                else
                    SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void NumDctoGlobal_ValueChanged(object sender, EventArgs e)
        {
            LblMontoNeto.Text = (LineaTotales.SubTotal - (double)NumDctoGlobal.Value).ToString("N2");
        }

        private void TsBtnDeshacer_Click(object sender, EventArgs e)
        {
            ClearCrt();
        }

        private void TsBtnRecibirPago_Click(object sender, EventArgs e)
        {
            RecibirPago();
        }

        private void TsBtnSalir_Click(object sender, EventArgs e)
        {
            if (vPrinter != null) vPrinter.Close();
            vPrinter = null;
            this.Close();
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                if (((TextBox)sender).Name == "TxtNroAutPago")
                    BtnAgregarPago_Click(null, null);
                else
                    SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(Keys.Return))
            {
                // Reciben solamente dígitos numéricos
                if (((TextBox)sender).Name == "TxtNroDocPago" || ((TextBox)sender).Name == "TxtNroAutPago")
                {
                    if (!Numeros.Contains(e.KeyChar.ToString()))
                        e.Handled = true;
                }
            }
        }

        private void TxtNroIDCli_TextChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void TxtNroIDEmp_TextChanged(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        #endregion Métodos
    }
}