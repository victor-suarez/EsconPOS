using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmMarca : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarMarcas(string OrderBy = "Nombre")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroMarca = TxtFiltroMarca.Text.Trim();
            DgvMarcas.DataSource = context.Marcas
                                    .Select(m => new
                                    {
                                        ID = m.MarcaID,
                                        Activo = m.Activo,
                                        Código = m.Codigo,
                                        Nombre = m.Marca,
                                        En_Uso = m.Activo == 0 ? "NO" : "SI"
                                    })
                                    .Where(m =>
                                           (m.Código.StartsWith(FiltroCodigo) || FiltroCodigo == "")
                                           &&
                                           (m.Nombre.Contains(FiltroMarca) || FiltroMarca == "")
                                           )
                                    .OrderBy(OrderBy)
                                    .ToList();
            DgvMarcas.Columns["ID"].Visible = false;
            DgvMarcas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtMarca.Text = "";
            ChkActiva.Checked = false;
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            TxtCodigo.Focus();
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
                var mar = context.Marcas.Single(m => m.MarcaID == ID);
                context.Marcas.Attach(mar);
                context.Marcas.Remove(mar);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
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
                    var marca = new Marcas
                    {
                        Codigo = TxtCodigo.Text,
                        Marca = TxtMarca.Text,
                        Activo = ChkActiva.Checked ? 1 : 0,
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
                    mar.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos de la marca.");
                    return;
                }
                SetStatus("Marca de productos modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarMarcas();
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
            //btn.Visible = false;
            txt.Controls.Add(btn);
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

        #endregion Funciones

        #region Métodos

        public FrmMarca()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((TextBox)((Button)sender).Parent).Clear();
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

        private void DgvMarcas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarMarcas(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
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
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroMarca);
            Left = 10;
            Top = 10;
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

        #endregion Métodos
    }
}