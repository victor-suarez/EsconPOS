using EsconPOS.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmProducto : Form
    {
        private mainEntities context = new mainEntities();

        private void CargarCombos()
        {
            CargarMarcas();
            CargarTipoProductos();
            CargarUnidades();
            CmbImpuestos.DataSource = context.Impuestos.ToList();
            CmbImpuestos.DisplayMember = "Impuesto";
            CmbImpuestos.ValueMember = "ImpuestoID";
        }

        private void CargarMarcas()
        {
            CmbMarcas.DataSource = context.Marcas
                .Where(m => m.Activo == 1)
                .ToList();
            CmbMarcas.DisplayMember = "Marca";
            CmbMarcas.ValueMember = "MarcaID";
        }

        private void CargarTipoProductos()
        {
            CmbTipos.DataSource = context.TiposProductos
                .Where(p => p.Activo == 1)
                .ToList();
            CmbTipos.DisplayMember = "TipoProducto";
            CmbTipos.ValueMember = "TipoProductoID";
        }

        private void CargarUnidades()
        {
            CmbUnidades.DataSource = context.UnidadesMedidas
                .Where(um => um.Activo == 1)
                .ToList();
            CmbUnidades.DisplayMember = "UnidadMedida";
            CmbUnidades.ValueMember = "UnidadMedidaID";
        }

        private void CargarProductos()
        {
            var dataset = context.Productos
                .Where(p => p.ProductoID > 0 && p.Activo == 1)
                .Select(p => new {
                    ID = p.ProductoID,
                    Código = p.Codigo,
                    Producto = p.Producto,
                    PrecioUnit = p.PrecioUnitario
                }).ToList();
            DgvProductos.DataSource = dataset;
            DgvProductos.Columns["ID"].Visible = false;
            DgvProductos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

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
            NumPrecioUnitario.Value = (decimal)pro.PrecioUnitario;
            TssLblAgregado.Text = pro.EmpleadoAdd.Login.ToLower() + " " + pro.AgregadoEl;
            if (pro.EmpleadoUpd != null)
                TssLblModificado.Text = (pro.EmpleadoUpd.Login.ToLower() + " " + pro.ModificadoEl) ?? "";
            else
                TssLblModificado.Text = "";
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
                if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                    Global.MensajeErrorBd(ex, "Error eliminando producto.");
                else
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
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if (TxtCodigo.Tag == null)
            {
                try
                {
                    context.Productos.Add
                    (
                        new Productos
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
                            PrecioUnitario = (Double)NumPrecioUnitario.Value,
                            Activo = 1,
                            AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            AgregadoPor = Global.Usuario.UsuarioID
                        }
                    );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error guardando datos del producto.");
                    else
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
                    pro.PrecioUnitario = (Double)NumPrecioUnitario.Value;
                    pro.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    pro.ModificadoPor = Global.Usuario.UsuarioID;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error modificando datos del producto.");
                    else
                        Global.MensajeError(ex, "Error modificando datos del producto.");
                    return;
                }
                SetStatus("Producto modificado.");
            }; //(.Tag != null)
            ClearCrt();
            CargarProductos();
            Cursor.Current = Cursors.Default;
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

        public FrmProducto()
        {
            InitializeComponent();
        }
        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }

        private void FrmProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarProductos();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
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
    }
}
