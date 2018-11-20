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
    public partial class FrmClase : Form
    {
        private mainEntities context = new mainEntities();

        private void CargarClases()
        {
            var dataset = context.TiposProductos
                .Select(t => new {
                    ID = t.TipoProductoID,
                    Codigo = t.Codigo,
                    Nombre = t.TipoProducto,
                    En_Uso = t.Activo == 0 ? "NO" : "SI"
                }).ToList();
            DgvClases.DataSource = dataset;
            DgvClases.Columns["ID"].Visible = false;
        }

        private void CargarCombos()
        {
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtClase.Text = "";
            ChkActiva.Checked = false;
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
        }

        private void MoverRegistroToCrt(long ID)
        {
            var cls = (from c in context.TiposProductos
                       where c.TipoProductoID == ID
                       select c).First();

            TxtCodigo.Text = cls.Codigo;
            TxtClase.Text = cls.TipoProducto;
            ChkActiva.Checked = (cls.Activo == 1);
            TssLblAgregado.Text = cls.EmpleadoAdd.Login.ToLower() + " " + cls.AgregadoEl;
            if (cls.EmpleadoUpd != null)
                TssLblModificado.Text = (cls.EmpleadoUpd.Login.ToLower() + " " + cls.ModificadoEl) ?? "";
            else
                TssLblModificado.Text = "";
        }

        private void Eliminar()
        {
            if (TxtCodigo.Tag == null) return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(TxtCodigo.Tag.ToString());
                var cls = context.TiposProductos.Single(c => c.TipoProductoID == ID);
                context.TiposProductos.Attach(cls);
                context.TiposProductos.Remove(cls);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                {
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error eliminando clase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error eliminando clase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }
            SetStatus("Clase eliminada.");
            ClearCrt();
            CargarClases();
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
                    context.TiposProductos.Add
                    (
                        new TiposProductos
                        {
                            Codigo = TxtCodigo.Text,
                            TipoProducto = TxtClase.Text,
                            Activo = ChkActiva.Checked ? 1 : 0,
                            AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            AgregadoPor = Global.Usuario.UsuarioID
                        }
                    );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                    {
                        MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando datos de la clase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                      .SelectMany(x => x.ValidationErrors)
                                                                                                      .Select(x => x.ErrorMessage);
                        var fullErrorMessage = string.Join("; ", DbErrors);
                        var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                        MessageBox.Show(exceptionMessage, "Error guardando datos de la clase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    return;
                }
                SetStatus("Clase de productos agregada.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var cls = context.TiposProductos.Single(c => c.TipoProductoID == ID);
                    context.TiposProductos.Attach(cls);

                    cls.Codigo = TxtCodigo.Text;
                    cls.TipoProducto = TxtClase.Text;
                    cls.Activo = ChkActiva.Checked ? 1 : 0;
                    cls.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cls.ModificadoPor = Global.Usuario.UsuarioID;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                    {
                        MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error modificando datos de la clase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                      .SelectMany(x => x.ValidationErrors)
                                                                                                      .Select(x => x.ErrorMessage);
                        var fullErrorMessage = string.Join("; ", DbErrors);
                        var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                        MessageBox.Show(exceptionMessage, "Error modificando datos de la clase.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    return;
                }
                SetStatus("Clase de productos modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarClases();
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
                MessageBox.Show("Debe transcribir un código para la clase de productos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtClase.Text.Trim().Length == 0)
            {
                TxtClase.Focus();
                MessageBox.Show("Debe transcribir el nombre de la clase de productos.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Chk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((CheckBox)sender, true, true, true, false);
            }
        }

        private void DgvClases_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MoverRegistroToCrt(long.Parse(DgvClases["ID", e.RowIndex].Value.ToString()));
            TabClases.SelectTab("PagEditar");
        }

        public FrmClase()
        {
            InitializeComponent();
        }

        private void FrmClase_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmClase_Load(object sender, EventArgs e)
        {
            CargarClases();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
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
