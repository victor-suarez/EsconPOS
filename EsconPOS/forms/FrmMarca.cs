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
    public partial class FrmMarca : Form
    {
        private mainEntities context = new mainEntities();

        private void CargarMarcas()
        {
            var dataset = context.Marcas
                .Select(m => new {
                    ID = m.MarcaID,
                    Codigo = m.Codigo,
                    Nombre = m.Marca,
                    En_Uso = m.Activo == 0 ? "NO" : "SI"
                }).ToList();
            DgvMarcas.DataSource = dataset;
            DgvMarcas.Columns["ID"].Visible = false;
            DgvMarcas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtMarca.Text = "";
            ChkActiva.Checked = false;
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
        }

        private void MoverRegistroToCrt(long ID)
        {
            var mar = (from m in context.Marcas
                       where m.MarcaID == ID
                       select m).First();

            TxtCodigo.Text = mar.Codigo;
            TxtCodigo.Tag = mar.MarcaID;
            TxtMarca.Text = mar.Marca;
            ChkActiva.Checked = (mar.Activo == 1);
            TssLblAgregado.Text = mar.EmpleadoAdd.Login.ToLower() + " " + mar.AgregadoEl;
            if (mar.EmpleadoUpd != null)
                TssLblModificado.Text = (mar.EmpleadoUpd.Login.ToLower() + " " + mar.ModificadoEl) ?? "";
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
                var mar = context.Marcas.Single(m => m.MarcaID == ID);
                context.Marcas.Attach(mar);
                context.Marcas.Remove(mar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                    Global.MensajeErrorBd(ex, "Error eliminando marca.");
                else
                    Global.MensajeError(ex, "Error eliminando marca.");
                return;
            }
            SetStatus("Marca eliminada.");
            ClearCrt();
            CargarMarcas();
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
                    context.Marcas.Add
                    (
                        new Marcas
                        {
                            Codigo = TxtCodigo.Text,
                            Marca = TxtMarca.Text,
                            Activo = ChkActiva.Checked ? 1 : 0,
                            AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            AgregadoPor = Global.Usuario.UsuarioID
                        }
                    );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error guardando datos de la marca.");
                    else
                        Global.MensajeError(ex, "Error guardando datos de la marca.");
                    return;
                }
                SetStatus("Marca de productos agregada.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var mar = context.Marcas.Single(m => m.MarcaID == ID);
                    context.Marcas.Attach(mar);

                    mar.Codigo = TxtCodigo.Text;
                    mar.Marca = TxtMarca.Text;
                    mar.Activo = ChkActiva.Checked ? 1 : 0;
                    mar.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    mar.ModificadoPor = Global.Usuario.UsuarioID;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error modificando datos de la marca.");
                    else
                        Global.MensajeError(ex, "Error modificando datos de la marca.");
                    return;
                }
                SetStatus("Marca de productos modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarMarcas();
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
                MessageBox.Show("Debe transcribir un código para la marca.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtMarca.Text.Trim().Length == 0)
            {
                TxtMarca.Focus();
                MessageBox.Show("Debe transcribir el nombre de la marca.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DgvMarcas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvMarcas["ID", e.RowIndex].Value.ToString()));
            TabMarcas.SelectTab("PagEditar");
        }

        public FrmMarca()
        {
            InitializeComponent();
        }

        private void FrmMarca_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            CargarMarcas();
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
