using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmFormasPago : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarFormasPago(string OrderBy = "Orden")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroFormaPago = TxtFiltroFormaPago.Text.Trim();
            DgvFormasPago.DataSource = context.FormasPagos
                                    .Select(f => new
                                    {
                                        ID = f.FormaPagoID,
                                        Código = f.Codigo,
                                        Descripción = f.FormaPago,
                                        Orden = f.Orden,
                                        Requiere_Aut = f.RequiereAutorizacion == 0 ? "NO" : "SI",
                                        En_Uso = f.Activo == 0 ? "NO" : "SI"
                                    })
                                    .Where(f =>
                                           (f.Código.StartsWith(FiltroCodigo) || FiltroCodigo == "")
                                           &&
                                           (f.Descripción.Contains(FiltroFormaPago) || FiltroFormaPago == "")
                                           )
                                    .OrderBy(OrderBy)
                                    .ToList();
            DgvFormasPago.Columns["ID"].Visible = false;
            DgvFormasPago.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtFormaPago.Text = "";
            NumOrden.Value = DgvFormasPago.RowCount + 1;
            ChkRequiereAutorizacion.Checked = false;
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
                var fp = context.FormasPagos.Single(f => f.FormaPagoID == ID);
                context.FormasPagos.Attach(fp);
                context.FormasPagos.Remove(fp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando marca.");
                return;
            }
            SetStatus("Marca eliminada.");
            ClearCrt();
            CargarFormasPago();
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
                    var formapago = new FormasPagos
                    {
                        Codigo = TxtCodigo.Text,
                        FormaPago = TxtFormaPago.Text,
                        Orden = (long)NumOrden.Value,
                        RequiereAutorizacion = ChkRequiereAutorizacion.Checked ? 1 : 0,
                        Activo = ChkActiva.Checked ? 1 : 0,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = Global.glUsuario
                    };
                    context.FormasPagos.Add(formapago);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos de la forma de pago.");
                    return;
                }
                SetStatus("Forma de pago agregada.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var fp = context.FormasPagos.Single(f => f.FormaPagoID == ID);
                    context.FormasPagos.Attach(fp);

                    fp.Codigo = TxtCodigo.Text;
                    fp.FormaPago = TxtFormaPago.Text;
                    fp.Orden = (long)NumOrden.Value;
                    fp.RequiereAutorizacion = ChkRequiereAutorizacion.Checked ? 1 : 0;
                    fp.Activo = ChkActiva.Checked ? 1 : 0;
                    fp.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    fp.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos de la forma de pago.");
                    return;
                }
                SetStatus("Forma de pago modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarFormasPago();
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
            var fp = (from f in context.FormasPagos
                      where f.FormaPagoID == ID
                      select f).FirstOrDefault();

            TxtCodigo.Text = fp.Codigo;
            TxtCodigo.Tag = fp.FormaPagoID;
            TxtFormaPago.Text = fp.FormaPago;
            NumOrden.Value = fp.Orden;
            ChkRequiereAutorizacion.Checked = (fp.RequiereAutorizacion == 1);
            ChkActiva.Checked = (fp.Activo == 1);
            TssLblAgregado.Text = fp.EmpleadoAdd.Login.ToLower() + " " + fp.AgregadoEl;
            if (fp.EmpleadoUpd != null)
                TssLblModificado.Text = (fp.EmpleadoUpd.Login.ToLower() + " " + fp.ModificadoEl) ?? "";
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
                MessageBox.Show("Debe transcribir un código para la forma de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtFormaPago.Text.Trim().Length == 0)
            {
                TxtFormaPago.Focus();
                MessageBox.Show("Debe transcribir la descripción de la forma de pago.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmFormasPago()
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

        private void DgvFormasPago_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvFormasPago["ID", e.RowIndex].Value.ToString()));
            TabFormaPago.SelectTab("PagEditar");
        }

        private void DgvFormasPago_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarFormasPago(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void FrmFormasPago_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmFormasPago_Load(object sender, EventArgs e)
        {
            CargarFormasPago();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroFormaPago);
            Left = 10;
            Top = 10;
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
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

        #endregion Métodos
    }
}