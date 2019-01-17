using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmImpuesto : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Subrutinas y funciones

        private void CargarImpuestos(string OrderBy = "Nombre")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroImpuesto = TxtFiltroImpuesto.Text.Trim();
            string FiltroTipo = TxtFiltroTipo.Text.Trim();
            string FiltroIniciales = TxtFiltroIniciales.Text.Trim();

            DgvImpuestos.DataSource = context.Impuestos
                                    .Select(i => new
                                    {
                                        ID = i.ImpuestoID,
                                        Código = i.Codigo,
                                        Nombre = i.Impuesto,
                                        Tipo = i.Tipo,
                                        Iniciales = i.Iniciales,
                                        Tasa = i.Tasa,
                                        En_Uso = i.Activo == 0 ? "NO" : "SI"
                                    })
                                    .Where(i =>
                                          (i.Código.Contains(FiltroCodigo) || FiltroCodigo == "")
                                          &&
                                          (i.Nombre.Contains(FiltroImpuesto) || FiltroImpuesto == "")
                                          &&
                                          (i.Tipo.Contains(FiltroTipo) || FiltroTipo == "")
                                          &&
                                          (i.Iniciales.Contains(FiltroIniciales) || FiltroIniciales == "")
                                    )
                                    .OrderBy(OrderBy)
                                    .ToList();
            DgvImpuestos.Columns["ID"].Visible = false;
            DgvImpuestos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtImpuesto.Text = "";
            TxtTipo.Text = "";
            TxtCategoria.Text = "";
            TxtIniciales.Text = "";
            NumTasa.Value = 0;
            DtpValidoDesde.Value = DateTime.Now;
            ChkActivo.Checked = false;
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
                var impuesto = context.Impuestos.Single(i => i.ImpuestoID == ID);
                context.Impuestos.Attach(impuesto);
                context.Impuestos.Remove(impuesto);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando impuesto.");
                return;
            }
            SetStatus("Tipo de impuesto eliminada.");
            ClearCrt();
            CargarImpuestos();
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
                    var impuesto = new Impuestos
                    {
                        Codigo = TxtCodigo.Text,
                        Impuesto = TxtImpuesto.Text,
                        Tipo = TxtTipo.Text,
                        Categoria = TxtCategoria.Text,
                        Iniciales = TxtIniciales.Text,
                        Tasa = (double)NumTasa.Value,
                        ValidoDesde = DtpValidoDesde.Value.ToString("yyyy-MM-dd"),
                        ValidoHasta = null,
                        Activo = ChkActivo.Checked ? 1 : 0
                    };
                    context.Impuestos.Add(impuesto);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos del tipo de impuesto.");
                    return;
                }
                SetStatus("Tipo de impuesto agregado.");
            } //(CmbTipoIDEmpleado.Tag == null)
            else //(CmbTipoIDEmpleado.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var impuesto = context.Impuestos.Single(i => i.ImpuestoID == ID);
                    context.Impuestos.Attach(impuesto);

                    impuesto.ImpuestoID = ID;
                    impuesto.Codigo = TxtCodigo.Text;
                    impuesto.Impuesto = TxtImpuesto.Text;
                    impuesto.Tipo = TxtTipo.Text;
                    impuesto.Categoria = TxtCategoria.Text;
                    impuesto.Iniciales = TxtIniciales.Text;
                    impuesto.Tasa = (double)NumTasa.Value;
                    impuesto.ValidoDesde = DtpValidoDesde.Value.ToString("yyyy-MM-dd 00:00:00");
                    impuesto.ValidoHasta = null;
                    impuesto.Activo = ChkActivo.Checked ? 1 : 0;
                    impuesto.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    impuesto.ModificadoPor = Global.glUsuario;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos del tipo de impuesto.");
                    return;
                }
                SetStatus("Tipo de impuesto modificado.");
            }; //(CmbTipoIDEmpleado.Tag != null)
            ClearCrt();
            CargarImpuestos();
            Cursor.Current = Cursors.Default;
        }

        #endregion Subrutinas y funciones

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
            var impuesto = (from i in context.Impuestos
                            where i.ImpuestoID == ID
                            select i).First();

            TxtCodigo.Text = impuesto.Codigo;
            TxtCodigo.Tag = impuesto.ImpuestoID;

            TxtImpuesto.Text = impuesto.Impuesto;
            TxtTipo.Text = impuesto.Tipo;
            TxtCategoria.Text = impuesto.Categoria;
            TxtIniciales.Text = impuesto.Iniciales;
            NumTasa.Value = (decimal)impuesto.Tasa;
            DtpValidoDesde.Value = DateTime.ParseExact(impuesto.ValidoDesde, "yyyy-MM-dd HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
            ChkActivo.Checked = (impuesto.Activo == 1);
            TssLblAgregado.Text = "";
            if (impuesto.EmpleadoUpd != null)
                TssLblModificado.Text = impuesto.EmpleadoUpd.Login.ToLower() + " " + impuesto.ModificadoEl;
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
                MessageBox.Show("Debe transcribir el código del tipo de impuesto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtImpuesto.Text.Trim().Length == 0)
            {
                TxtImpuesto.Focus();
                MessageBox.Show("Debe transcribir el nombre del tipo de impuesto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtTipo.Text.Trim().Length == 0)
            {
                TxtTipo.Focus();
                MessageBox.Show("Debe transcribir el tipo del impuesto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtCategoria.Text.Trim().Length == 0)
            {
                TxtCategoria.Focus();
                MessageBox.Show("Debe transcribir la categoría del tipo de impuesto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtIniciales.Text.Trim().Length == 0)
            {
                TxtIniciales.Focus();
                MessageBox.Show("Debe transcribir las iniciales del tipo de impuesto.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #region Objetos y métodos

        public FrmImpuesto()
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
                TsBtnGuardar_Click(null, null);
            }
        }

        private void DgvImpuestos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvImpuestos["ID", e.RowIndex].Value.ToString()));
            TabImpuestos.SelectTab("PagEditar");
        }

        private void DgvImpuestos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarImpuestos(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void Dtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                SelectNextControl((DateTimePicker)sender, true, true, true, false);
            }
        }

        private void FrmImpuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmImpuesto_Load(object sender, EventArgs e)
        {
            CargarImpuestos();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroImpuesto);
            IncluirBtnClear(TxtFiltroTipo);
            IncluirBtnClear(TxtFiltroIniciales);
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
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
                //if(((TextBox)sender).Name == "TxtCorreoElectronicoCliente") RibBtnGuardar.
            }
        }

        #endregion Objetos y métodos
    }
}