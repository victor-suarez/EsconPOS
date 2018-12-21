using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmMoneda : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarMonedas(string OrderBy = "Nombre")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroMoneda = TxtFiltroMoneda.Text.Trim();
            DgvMonedas.DataSource = context.Monedas
                                    .Select(m => new
                                    {
                                        ID = m.MonedaID,
                                        Código = m.Codigo,
                                        Nombre = m.Moneda,
                                        Factor_Cambiario = m.FactorCambiario,
                                        En_Uso = m.Activo == 0 ? "NO" : "SI"
                                    })
                                    .Where(m =>
                                          (m.Código.Contains(FiltroCodigo) || FiltroCodigo == "")
                                          &&
                                          (m.Nombre.Contains(FiltroMoneda) || FiltroMoneda == "")
                                    )
                                    .OrderBy(OrderBy)
                                    .ToList();
            DgvMonedas.Columns["ID"].Visible = false;
            DgvMonedas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtMoneda.Text = "";
            ChkPorDefecto.Checked = false;
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
                var mon = context.Monedas.Single(m => m.MonedaID == ID);
                context.Monedas.Attach(mon);
                context.Monedas.Remove(mon);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando moneda.");
                return;
            }
            SetStatus("Moneda eliminada.");
            ClearCrt();
            CargarMonedas();
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
                    var moneda = new Monedas
                    {
                        Codigo = TxtCodigo.Text,
                        Moneda = TxtMoneda.Text,
                        PorDefecto = ChkPorDefecto.Checked ? 1 : 0,
                        FactorCambiario = (double)NumFactorCambio.Value,
                        Activo = ChkActiva.Checked ? 1 : 0,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = Global.glUsuario
                    };
                    context.Monedas.Add(moneda);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos de la moneda.");
                    return;
                }
                SetStatus("Empleado agregado.");
            } //(CmbTipoIDEmpleado.Tag == null)
            else //(CmbTipoIDEmpleado.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var mon = context.Monedas.Single(m => m.MonedaID == ID);
                    context.Monedas.Attach(mon);

                    mon.Codigo = TxtCodigo.Text;
                    mon.Moneda = TxtMoneda.Text;
                    mon.PorDefecto = ChkPorDefecto.Checked ? 1 : 0;
                    mon.FactorCambiario = (double)NumFactorCambio.Value;
                    mon.Activo = ChkActiva.Checked ? 1 : 0;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos de la moneda.");
                    return;
                }
                SetStatus("Moneda modificada.");
            }; //(CmbTipoIDEmpleado.Tag != null)
            ClearCrt();
            CargarMonedas();
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
            var mon = (from m in context.Monedas
                       where m.MonedaID == ID
                       select m).First();

            TxtCodigo.Text = mon.Codigo;
            TxtCodigo.Tag = mon.MonedaID;
            TxtMoneda.Text = mon.Moneda;
            ChkActiva.Checked = (mon.Activo == 1);
            ChkPorDefecto.Checked = (mon.PorDefecto == 1);
            NumFactorCambio.Value = (decimal)mon.FactorCambiario;
            TssLblAgregado.Text = mon.EmpleadoAdd.Login.ToLower() + " " + mon.AgregadoEl;
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
                MessageBox.Show("Debe transcribir el código ISO de la moneda.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtMoneda.Text.Trim().Length == 0)
            {
                TxtMoneda.Focus();
                MessageBox.Show("Debe transcribir el nombre de la moneda.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmMoneda()
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

        private void DgvMonedas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvMonedas["ID", e.RowIndex].Value.ToString()));
            TabMonedas.SelectTab("PagEditar");
        }

        private void DgvMonedas_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarMonedas(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void FrmMoneda_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmMoneda_Load(object sender, EventArgs e)
        {
            CargarMonedas();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroMoneda);
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
                //if(((TextBox)sender).Name == "TxtCorreoElectronicoCliente") RibBtnGuardar.
            }
        }

        #endregion Métodos
    }
}