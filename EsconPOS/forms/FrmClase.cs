using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmClase : Form
    {
        #region Veriables y constantes

        private mainEntities context = new mainEntities();

        #endregion Veriables y constantes

        #region Funciones

        private void CargarClases(string OrderBy = "Nombre")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroClase = TxtFiltroClase.Text.Trim();
            DgvClases.DataSource = context.TiposProductos
                                    .Select(t => new
                                    {
                                        ID = t.TipoProductoID,
                                        Código = t.Codigo,
                                        Nombre = t.TipoProducto,
                                        En_Uso = t.Activo == 0 ? "NO" : "SI"
                                    })
                                    .Where(t => (t.Código.Contains(FiltroCodigo) || FiltroCodigo == "")
                                                &&
                                                (t.Nombre.Contains(FiltroClase) || FiltroClase == ""))
                                    .OrderBy(OrderBy)
                                    .ToList();
            DgvClases.Columns["ID"].Visible = false;
            DgvClases.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                var cls = context.TiposProductos.Single(c => c.TipoProductoID == ID);
                context.TiposProductos.Attach(cls);
                context.TiposProductos.Remove(cls);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando clase.");
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
                    cls.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos de la clase.");
                    return;
                }
                SetStatus("Clase de productos modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarClases();
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
            var cls = (from c in context.TiposProductos
                       where c.TipoProductoID == ID
                       select c).First();

            TxtCodigo.Text = cls.Codigo;
            TxtCodigo.Tag = cls.TipoProductoID;
            TxtClase.Text = cls.TipoProducto;
            ChkActiva.Checked = (cls.Activo == 1);
            TssLblAgregado.Text = cls.EmpleadoAdd.Login.ToLower() + " " + cls.AgregadoEl;
            if (cls.EmpleadoUpd != null)
                TssLblModificado.Text = (cls.EmpleadoUpd.Login.ToLower() + " " + cls.ModificadoEl) ?? "";
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

        #endregion Funciones

        #region Métodos

        public FrmClase()
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

        private void DgvClases_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvClases["ID", e.RowIndex].Value.ToString()));
            TabClases.SelectTab("PagEditar");
        }

        private void DgvClases_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarClases(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
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
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroClase);
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

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            CargarClases();
        }
    }
}