using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmUnidadMedida : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarUnidades(string OrderBy = "Descripción")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroUnidad = TxtFiltroUnidad.Text.Trim();
            string FiltroIniciales = TxtFiltroIniciales.Text.Trim();
            DgvUnidades.DataSource = context.UnidadesMedidas
                                      .Select(u => new
                                      {
                                          ID = u.UnidadMedidaID,
                                          Código = u.Codigo,
                                          Descripción = u.UnidadMedida,
                                          Iniciales = u.Iniciales,
                                          En_Uso = u.Activo == 0 ? "NO" : "SI"
                                      })
                                      .Where(u => (u.Código.Contains(FiltroCodigo) || FiltroCodigo == "")
                                                  &&
                                                  (u.Descripción.Contains(FiltroUnidad) || FiltroUnidad == "")
                                                  &&
                                                  (u.Iniciales.Contains(FiltroIniciales) || FiltroIniciales == "")
                                            )
                                      .OrderBy(OrderBy)
                                      .ToList();
            DgvUnidades.Columns["ID"].Visible = false;
            DgvUnidades.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            DgvUnidades.AllowUserToResizeColumns = true;
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtUnidadMedida.Text = "";
            TxtIniciales.Text = "";
            ChkActiva.Checked = false;
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
                var und = context.UnidadesMedidas.Single(u => u.UnidadMedidaID == ID);
                context.UnidadesMedidas.Attach(und);
                context.UnidadesMedidas.Remove(und);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando unidad de medida.");
                return;
            }
            SetStatus("Unidad de medida eliminada.");
            ClearCrt();
            CargarUnidades();
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
                    var medida = new UnidadesMedidas
                    {
                        Codigo = TxtCodigo.Text,
                        UnidadMedida = TxtUnidadMedida.Text,
                        Iniciales = string.IsNullOrEmpty(TxtIniciales.Text) ? null : TxtIniciales.Text.Length > 6 ? TxtIniciales.Text.Substring(0, 6) : TxtIniciales.Text,
                        Activo = ChkActiva.Checked ? 1 : 0
                    };
                    context.UnidadesMedidas.Add(medida);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos de la unidad de medida.");
                    return;
                }
                SetStatus("Unidad de medida de productos agregada.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var und = context.UnidadesMedidas.Single(u => u.UnidadMedidaID == ID);
                    context.UnidadesMedidas.Attach(und);

                    und.UnidadMedidaID = long.Parse(TxtCodigo.Tag.ToString());
                    und.Codigo = TxtCodigo.Text;
                    und.UnidadMedida = TxtUnidadMedida.Text;
                    und.Iniciales = string.IsNullOrEmpty(TxtIniciales.Text) ? null : TxtIniciales.Text.Length > 6 ? TxtIniciales.Text.Substring(0, 6) : TxtIniciales.Text;
                    und.Activo = ChkActiva.Checked ? 1 : 0;
                    und.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    und.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos de la unidad de medida.");
                    return;
                }
                SetStatus("Unidad de medida de productos modificada.");
            }; //(.Tag != null)
            ClearCrt();
            CargarUnidades();
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
            var und = (from u
                       in context.UnidadesMedidas
                       where u.UnidadMedidaID == ID
                       select u).First();

            TxtCodigo.Text = und.Codigo;
            TxtCodigo.Tag = und.UnidadMedidaID;
            TxtUnidadMedida.Text = und.UnidadMedida;
            TxtIniciales.Text = und.Iniciales ?? "";
            ChkActiva.Checked = (und.Activo == 1);
            if (und.EmpleadoUpd != null)
                TssLblModificado.Text = (und.EmpleadoUpd.Login.ToLower() + " " + und.ModificadoEl) ?? "";
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
                MessageBox.Show("Debe transcribir un código para la unidad de medida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtUnidadMedida.Text.Trim().Length == 0)
            {
                TxtUnidadMedida.Focus();
                MessageBox.Show("Debe transcribir el nombre de la unidad de medida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtIniciales.Text.Trim().Length == 0)
            {
                TxtIniciales.Focus();
                MessageBox.Show("Debe transcribir las iniciales de la unidad de medida.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmUnidadMedida()
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

        private void DgvUnidades_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvUnidades["ID", e.RowIndex].Value.ToString()));
            TabUnidades.SelectTab("PagEditar");
        }

        private void DgvUnidades_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarUnidades(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void FrmUnidadMedida_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmUnidadMedida_Load(object sender, EventArgs e)
        {
            CargarUnidades();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroUnidad);
            IncluirBtnClear(TxtFiltroIniciales);
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
            CargarUnidades();
        }

        #endregion Métodos
    }
}