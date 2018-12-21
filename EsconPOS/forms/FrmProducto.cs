using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmProducto : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarCombos()
        {
            CargarMarcas();
            CargarTipoProductos();
            CargarUnidades();
            CargarImpuestos();
        }

        private void CargarImpuestos()
        {
            CmbImpuestos.DataSource = context.Impuestos
                .Where(i => i.Activo == 1)
                .OrderBy("Impuesto")
                .ToList();
            CmbImpuestos.DisplayMember = "Impuesto";
            CmbImpuestos.ValueMember = "ImpuestoID";
            CmbImpuestos.SelectedIndex = -1;
        }

        private void CargarMarcas()
        {
            CmbMarcas.DataSource = context.Marcas
                                    .Where(m => m.Activo == 1)
                                    .OrderBy("Marca")
                                    .ToList();
            CmbMarcas.DisplayMember = "Marca";
            CmbMarcas.ValueMember = "MarcaID";
            CmbMarcas.SelectedIndex = -1;

            CmbFiltroMarca.DataSource = context.Marcas
                                        .Where(m => m.Activo == 1)
                                        .OrderBy("Codigo")
                                        .ToList();
            CmbFiltroMarca.DisplayMember = "Codigo";
            CmbFiltroMarca.ValueMember = "MarcaID";
            CmbFiltroMarca.SelectedIndex = -1;
        }

        private void CargarProductos(string OrderBy = "Producto")
        {
            string FiltroCodigoBarra = TxtFiltroCodigoBarra.Text.Trim();
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroMarca = CmbFiltroMarca.SelectedIndex < 0 ? "" : CmbFiltroMarca.Text.Substring(0, CmbFiltroMarca.Text.IndexOf("-"));
            string FiltroTipo = CmbFiltroTipo.SelectedIndex < 0 ? "" : CmbFiltroTipo.Text.Substring(0, CmbFiltroTipo.Text.IndexOf("-"));
            string FiltroProducto = TxtFiltroProducto.Text.Trim();
            DgvProductos.DataSource = context.Productos
                                        .Select(p => new
                                        {
                                            ID = p.ProductoID,
                                            Cod_Marca = p.Marcas.Codigo,
                                            Cod_Tipo = p.TiposProductos.Codigo,
                                            Activo = p.Activo,
                                            Código = p.Codigo,
                                            Código_Barra = p.CodigoBarra,
                                            Marca = p.Marcas.Marca,
                                            Tipo = p.TiposProductos.TipoProducto,
                                            Producto = p.Producto,
                                            PrecioUnit = p.ValorUnitario
                                        })
                                        .Where(p => p.ID > 0
                                                    &&
                                                    p.Activo == 1
                                                    &&
                                                    (p.Código_Barra.StartsWith(FiltroCodigoBarra) || FiltroCodigoBarra == "")
                                                    &&
                                                    (p.Código.StartsWith(FiltroCodigo) || FiltroCodigo == "")
                                                    &&
                                                    (p.Cod_Marca == FiltroMarca || FiltroMarca == "")
                                                    &&
                                                    (p.Cod_Tipo == FiltroTipo || FiltroTipo == "")
                                                    &&
                                                    (p.Producto.Contains(FiltroProducto) || FiltroProducto == "")
                                                )
                                        .OrderBy(OrderBy)
                                        .ToList();
            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.Columns["Cod_Marca"].Visible = false;
            DgvProductos.Columns["Cod_Tipo"].Visible = false;
            DgvProductos.Columns["Activo"].Visible = false;
            DgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void CargarTipoProductos()
        {
            CmbTipos.DataSource = context.TiposProductos
                                    .Where(t => t.Activo == 1)
                                    .OrderBy("TipoProducto")
                                    .ToList();
            CmbTipos.DisplayMember = "TipoProducto";
            CmbTipos.ValueMember = "TipoProductoID";
            CmbTipos.SelectedIndex = -1;

            CmbFiltroTipo.DataSource = context.TiposProductos
                                        .Where(t => t.Activo == 1)
                                        .OrderBy("Codigo")
                                        .ToList();
            CmbFiltroTipo.DisplayMember = "Codigo";
            CmbFiltroTipo.ValueMember = "TipoProductoID";
            CmbFiltroTipo.SelectedIndex = -1;
        }

        private void CargarUnidades()
        {
            CmbUnidades.DataSource = context.UnidadesMedidas
                .Where(um => um.Activo == 1)
                .OrderBy("UnidadMedida")
                .ToList();
            CmbUnidades.DisplayMember = "UnidadMedida";
            CmbUnidades.ValueMember = "UnidadMedidaID";
            CmbUnidades.SelectedIndex = -1;
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtCodigoBarra.Text = "";
            CmbMarcas.SelectedIndex = -1;
            CmbTipos.SelectedIndex = -1;
            TxtProducto.Text = "";
            TxtPresentacion.Text = "";
            CmbUnidades.SelectedIndex = -1;
            CmbImpuestos.SelectedIndex = -1;
            NumCostoUnitario.Value = 0;
            NumPrecioUnitario.Value = 0;
            TxtCodigo.Focus();
        }

        private string CreaCodigoProd()
        {
            string Codigo = "";
            string Marca = CmbMarcas.SelectedIndex == -1 ? "" : ((Marcas)CmbMarcas.SelectedItem).Codigo;
            string Clase = CmbTipos.SelectedIndex == -1 ? "" : ((TiposProductos)CmbTipos.SelectedItem).Codigo;
            int Consecutivo = (from p in context.Productos where (p.Marcas.Codigo == Marca || Marca == "") && (p.TiposProductos.Codigo == Clase || Clase == "") select Codigo.Substring(Codigo.Length - 4, 4)).Count() + 1;
            string Siguiente = Consecutivo.ToString("0000");
            Codigo = Marca + (Marca.Length > 0 ? "-" : "") + Clase + (Clase.Length > 0 ? "-" : "") + Siguiente;
            return Codigo;
        }

        private void Eliminar()
        {
            if (TxtCodigo.Tag == null) return;
            if (MessageBox.Show("¿Seguro desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(TxtCodigo.Tag.ToString());
                var pro = context.Productos.Single(p => p.ProductoID == ID);
                context.Productos.Attach(pro);
                context.Productos.Remove(pro);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando producto.");
                return;
            }
            SetStatus("Producto eliminado.");
            ClearCrt();
            CargarProductos();
            Cursor.Current = Cursors.Default;
        }

        private void Guardar()
        {
            if (TxtCodigo.Text.Trim().Length == 0) TxtCodigo.Text = CreaCodigoProd();
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if (TxtCodigo.Tag == null)
            {
                try
                {
                    var prod = new Productos
                    {
                        Codigo = TxtCodigo.Text.Trim(),
                        CodigoBarra = TxtCodigoBarra.Text.Trim(),
                        Producto = TxtProducto.Text.Trim(),
                        TipoProductoID = ((TiposProductos)CmbTipos.SelectedItem).TipoProductoID,
                        MarcaID = ((Marcas)CmbMarcas.SelectedItem).MarcaID,
                        ImpuestoID = ((Impuestos)CmbImpuestos.SelectedItem).ImpuestoID,
                        UnidadMedidaID = ((UnidadesMedidas)CmbUnidades.SelectedItem).UnidadMedidaID,
                        Presentacion = TxtPresentacion.Text.Trim(),
                        CostoUnitario = (Double)NumCostoUnitario.Value,
                        ValorUnitario = (Double)NumPrecioUnitario.Value,
                        Activo = 1,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = Global.glUsuario
                    };
                    context.Productos.Add(prod);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos del producto.");
                    return;
                }
                SetStatus("Producto agregado.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var pro = context.Productos.Single(p => p.ProductoID == ID);
                    context.Productos.Attach(pro);

                    pro.Codigo = TxtCodigo.Text.Trim();
                    pro.CodigoBarra = TxtCodigoBarra.Text.Trim();
                    pro.Producto = TxtProducto.Text.Trim();
                    pro.TipoProductoID = ((TiposProductos)CmbTipos.SelectedItem).TipoProductoID;
                    pro.MarcaID = ((Marcas)CmbMarcas.SelectedItem).MarcaID;
                    pro.ImpuestoID = ((Impuestos)CmbImpuestos.SelectedItem).ImpuestoID;
                    pro.UnidadMedidaID = ((UnidadesMedidas)CmbUnidades.SelectedItem).UnidadMedidaID;
                    pro.Presentacion = TxtPresentacion.Text.Trim();
                    pro.CostoUnitario = (Double)NumCostoUnitario.Value;
                    pro.ValorUnitario = (Double)NumPrecioUnitario.Value;
                    pro.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    pro.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos del producto.");
                    return;
                }
                SetStatus("Producto modificado.");
            }; //(.Tag != null)
            ClearCrt();
            CargarProductos();
            Cursor.Current = Cursors.Default;
        }

        private void IncluirBtnClear(TextBox txt)
        {
            var btn = new Button();
            btn.AutoSize = false;
            btn.Size = new Size(25, txt.ClientSize.Height + 2);
            btn.Location = new Point(txt.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.ClearTxt;
            btn.Click += btn_Click;
            btn.KeyDown += btn_KeyDown;
            btn.PreviewKeyDown += btn_PreviewKeyDown;
            //btn.Visible = false;
            txt.Controls.Add(btn);
        }

        private void MoverRegistroToCrt(long ID)
        {
            var pro = (from p in context.Productos
                       where p.ProductoID == ID
                       select p).First();

            TxtCodigo.Text = pro.Codigo;
            TxtCodigo.Tag = pro.ProductoID;
            TxtCodigoBarra.Text = pro.CodigoBarra;
            CmbMarcas.SelectedValue = pro.MarcaID;
            CmbTipos.SelectedValue = pro.TipoProductoID;
            TxtProducto.Text = pro.Producto;
            TxtPresentacion.Text = pro.Presentacion;
            CmbUnidades.SelectedValue = pro.UnidadMedidaID;
            CmbImpuestos.SelectedValue = pro.ImpuestoID;
            NumCostoUnitario.Value = (decimal)pro.CostoUnitario;
            NumPrecioUnitario.Value = (decimal)pro.ValorUnitario;
            TssLblAgregado.Text = pro.EmpleadoAdd.Login.ToLower() + " " + pro.AgregadoEl;
            if (pro.EmpleadoUpd != null)
                TssLblModificado.Text = (pro.EmpleadoUpd.Login.ToLower() + " " + pro.ModificadoEl) ?? "";
            else
                TssLblModificado.Text = "";
        }

        private void SetStatus(string Status = "", bool Error = false)
        {
            if (Error)
                TssLblStatus.ForeColor = Color.Red;
            else
                TssLblStatus.ForeColor = SystemColors.ControlText;
            TssLblStatus.Text = Status;
        }

        private bool ValEntReq()
        {
            if (TxtCodigo.Text.Trim().Length == 0)
            {
                TxtCodigo.Focus();
                MessageBox.Show("Debe transcribir el código del producto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtProducto.Text.Trim().Length == 0)
            {
                TxtProducto.Focus();
                MessageBox.Show("Debe transcribir la descripción del producto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbUnidades.SelectedIndex == -1)
            {
                CmbUnidades.Focus();
                MessageBox.Show("Debe seleccionar la unidad de medida del producto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbImpuestos.SelectedIndex == -1)
            {
                CmbImpuestos.Focus();
                MessageBox.Show("Debe seleccionar el tipo de impuesto que rige al producto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((TextBox)((Button)sender).Parent).Clear();
        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                SelectNextControl((Button)sender, true, true, true, false);
            }
        }

        private void btn_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Return) e.IsInputKey = true;
        }

        private void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            if (CmbMarcas.Text.Trim() == "" || CmbMarcas.SelectedIndex != -1) return;
            try
            {
                var marca = new Marcas
                {
                    Codigo = CmbMarcas.Text.Substring(0, 5).ToUpper(),
                    Marca = CmbMarcas.Text.Trim(),
                    Activo = 1,
                    AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glUsuario
                };
                context.Marcas.Add(marca);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos de la marca.");
                return;
            }
            CargarMarcas();
            SetStatus("Marca de productos agregada.");
        }

        private void BtnAgregarTipo_Click(object sender, EventArgs e)
        {
            if (CmbTipos.Text.Trim() == "" || CmbTipos.SelectedIndex != -1) return;
            try
            {
                context.TiposProductos.Add
                (
                    new TiposProductos
                    {
                        Codigo = CmbTipos.Text.Substring(0, 5).ToUpper(),
                        TipoProducto = CmbTipos.Text.Trim(),
                        Activo = 1,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = Global.glUsuario
                    }
                );
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos de la clase.");
                return;
            }
            CargarTipoProductos();
            SetStatus("Clase de productos agregada.");
        }

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                ((ComboBox)sender).SelectedIndex = -1;
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CmbFiltroMarca_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Marcas)e.ListItem).Codigo + "-" + ((Marcas)e.ListItem).Marca;
        }

        private void CmbFiltroTipo_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((TiposProductos)e.ListItem).Codigo + "-" + ((TiposProductos)e.ListItem).TipoProducto;
        }

        private void CmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAgregarMarca.TabStop = (CmbMarcas.SelectedIndex < 0);
        }

        private void CmbTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnAgregarTipo.TabStop = (CmbTipos.SelectedIndex < 0);
        }

        private void DgvProductos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarProductos(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroCodigoBarra);
            IncluirBtnClear(TxtFiltroProducto);
            CargarCombos();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                if (((NumericUpDown)sender).Name == "NumPrecioUnitario")
                    TsBtnGuardar_Click(null, null);
                else
                    SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void Tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectNextControl((TabControl)sender, true, true, true, false);
        }

        private void TsBtnDeshacer_Click(object sender, EventArgs e)
        {
            ClearCrt();
        }

        private void TsBtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void TsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        #endregion Métodos
    }
}