using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmBanco : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarBancos(string OrderBy = "Nombre")
        {
            string FiltroIniciales = TxtFiltroIniciales.Text.Trim();
            string FiltroBanco = TxtFiltroBanco.Text.Trim();
            DgvBancos.DataSource = context.Bancos
                                    .Select(b => new
                                    {
                                        ID = b.BancoID,
                                        Iniciales = b.Iniciales,
                                        Nombre = b.Nombre,
                                        En_Uso = b.Activo == 0 ? "NO" : "SI"
                                    })
                                    .Where(b =>
                                           (b.Iniciales.StartsWith(FiltroIniciales) || FiltroIniciales == "")
                                           &&
                                           (b.Nombre.Contains(FiltroBanco) || FiltroBanco == "")
                                           )
                                    .OrderBy(OrderBy)
                                    .ToList();
            DgvBancos.Columns["ID"].Visible = false;
            DgvBancos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            TxtBanco.Text = "";
            TxtBanco.Tag = null;
            TxtIniciales.Text = "";
            TxtCodigo.Text = "";
            TxtBIN.Text = "";
            ChkActiva.Checked = false;
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            TxtBanco.Focus();
        }

        private void Eliminar()
        {
            if (TxtBanco.Tag == null) return;
            if (MessageBox.Show("¿Seguro desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(TxtBanco.Tag.ToString());
                var banco = context.Bancos.Single(b => b.BancoID == ID);
                context.Bancos.Attach(banco);
                context.Bancos.Remove(banco);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando banco.");
                return;
            }
            SetStatus("Banco eliminado.");
            ClearCrt();
            CargarBancos();
            Cursor.Current = Cursors.Default;
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if (TxtBanco.Tag == null)
            {
                try
                {
                    var banco = new Bancos
                    {
                        Nombre = TxtBanco.Text.Trim(),
                        Iniciales = TxtIniciales.Text.Trim(),
                        Codigo = TxtCodigo.Text.Trim() == "" ? null: TxtCodigo.Text.Trim(),
                        BIN = TxtBIN.Text.Trim() == "" ? null: TxtBIN.Text.Trim(),
                        Activo = ChkActiva.Checked ? 1 : 0
                        //AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        //AgregadoPor = Global.glUsuario
                    };
                    context.Bancos.Add(banco);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos del banco.");
                    return;
                }
                SetStatus("Banco agregado.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtBanco.Tag.ToString());
                    var banco = context.Bancos.Single(b => b.BancoID == ID);
                    context.Bancos.Attach(banco);

                    banco.BancoID = ID;
                    banco.Nombre = TxtBanco.Text.Trim();
                    banco.Iniciales = TxtIniciales.Text.Trim();
                    banco.Codigo = TxtCodigo.Text.Trim() == "" ? null : TxtCodigo.Text.Trim();
                    banco.BIN = TxtBIN.Text.Trim() == "" ? null : TxtBIN.Text.Trim();
                    banco.Activo = ChkActiva.Checked ? 1 : 0;
                    banco.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    banco.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos del banco.");
                    return;
                }
                SetStatus("Banco modificado.");
            }; //(.Tag != null)
            ClearCrt();
            CargarBancos();
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
            txt.Controls.Add(btn);
        }

        private void MoverRegistroToCrt(long ID)
        {
            var banco = (from b in context.Bancos
                         where b.BancoID == ID
                         select b).FirstOrDefault();

            TxtBanco.Text = banco.Nombre;
            TxtBanco.Tag = banco.BancoID;
            TxtIniciales.Text = banco.Iniciales;
            TxtCodigo.Text = banco.Codigo;
            TxtBIN.Text = banco.BIN;
            ChkActiva.Checked = (banco.Activo == 1);
            //TssLblAgregado.Text = banco.EmpleadoAdd.Login.ToLower() + " " + banco.AgregadoEl;
            //if (banco.EmpleadoUpd != null)
            //    TssLblModificado.Text = (banco.EmpleadoUpd.Login.ToLower() + " " + banco.ModificadoEl) ?? "";
            //else
            //    TssLblModificado.Text = "";
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
            if (TxtBanco.Text.Trim().Length == 0)
            {
                TxtBanco.Focus();
                MessageBox.Show("Debe transcribir el nombre de la entidad financiera.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtIniciales.Text.Trim().Length == 0)
            {
                TxtIniciales.Focus();
                MessageBox.Show("Debe transcribir las iniciales de la entidad financiera.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            //if (TxtCodigo.Text.Trim().Length == 0)
            //{
            //    TxtCodigo.Focus();
            //    MessageBox.Show("Debe transcribir un código para la entidad financiera.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            //if (TxtBIN.Text.Trim().Length == 0)
            //{
            //    TxtBIN.Focus();
            //    MessageBox.Show("Debe transcribir el Número de Identificación Bancaria (BIN).", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return false;
            //}
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmBanco()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((TextBox)((Button)sender).Parent).Clear();
        }

        private void btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void Chk_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((CheckBox)sender, true, true, true, false);
            }
        }

        private void DgvBancos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvBancos["ID", e.RowIndex].Value.ToString()));
            TabBancos.SelectTab("PagEditar");
        }

        private void DgvBancos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarBancos(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void FrmBanco_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            CargarBancos();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            IncluirBtnClear(TxtFiltroIniciales);
            IncluirBtnClear(TxtFiltroBanco);
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

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarBancos();
        }

        #endregion Métodos
    }
}