using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmDocumento : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarTiposDocumentos(string OrderBy = "Descripción")
        {
            string FiltroCodigo = TxtFiltroCodigo.Text.Trim();
            string FiltroIniciales = TxtFiltroIniciales.Text.Trim();
            string FiltroTipoDocumento = TxtFiltroTipoDocumento.Text.Trim();
            DgvTiposDocumentos.DataSource = context.TiposDocumentos
                                            .Select(t => new
                                            {
                                                ID = t.TipoDocumentoID,
                                                Código = t.Codigo,
                                                Iniciales = t.Iniciales,
                                                Descripción = t.TipoDocumento,
                                                En_Uso = t.Activo == 0 ? "NO" : "SI"
                                            })
                                            .Where(t =>
                                                   (t.Código.StartsWith(FiltroCodigo) || FiltroCodigo == "")
                                                   &&
                                                   (t.Iniciales.Contains(FiltroIniciales) || FiltroIniciales == "")
                                                   &&
                                                   (t.Descripción.Contains(FiltroTipoDocumento) || FiltroTipoDocumento == "")
                                                   )
                                            .OrderBy(OrderBy)
                                            .ToList();
            DgvTiposDocumentos.Columns["ID"].Visible = false;
            DgvTiposDocumentos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            TxtCodigo.Text = "";
            TxtCodigo.Tag = null;
            TxtIniciales.Text = "";
            TxtTipoDocumento.Text = "";
            NumNroSiguiente.Value = 1;
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
                var tipo_doc = context.TiposDocumentos.Single(t => t.TipoDocumentoID == ID);
                context.TiposDocumentos.Attach(tipo_doc);
                context.TiposDocumentos.Remove(tipo_doc);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando tipo de documento.");
                return;
            }
            SetStatus("Tipo de documento eliminado.");
            ClearCrt();
            CargarTiposDocumentos();
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
                    var tipo_doc = new TiposDocumentos
                    {
                        Codigo = TxtCodigo.Text,
                        Iniciales = TxtIniciales.Text,
                        TipoDocumento = TxtTipoDocumento.Text,
                        NroSiguiente = (long)NumNroSiguiente.Value,
                        Activo = ChkActivo.Checked ? 1 : 0,
                    };
                    context.TiposDocumentos.Add(tipo_doc);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos del tipo de documento.");
                    return;
                }
                SetStatus("tipo de documento agregado.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(TxtCodigo.Tag.ToString());
                    var tipo_doc = context.TiposDocumentos.Single(t => t.TipoDocumentoID == ID);
                    context.TiposDocumentos.Attach(tipo_doc);

                    tipo_doc.TipoDocumentoID = ID;
                    tipo_doc.Codigo = TxtCodigo.Text;
                    tipo_doc.Iniciales = TxtIniciales.Text;
                    tipo_doc.TipoDocumento = TxtTipoDocumento.Text;
                    tipo_doc.Activo = ChkActivo.Checked ? 1 : 0;
                    tipo_doc.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    tipo_doc.ModificadoPor = Global.glUsuario;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos del tipo de documento.");
                    return;
                }
                SetStatus("Tipo de documento modificado.");
            }; //(.Tag != null)
            ClearCrt();
            CargarTiposDocumentos();
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
            var tipo = (from t in context.TiposDocumentos
                        where t.TipoDocumentoID == ID
                        select t).First();

            TxtCodigo.Text = tipo.Codigo;
            TxtCodigo.Tag = tipo.TipoDocumentoID;
            TxtIniciales.Text = tipo.Iniciales;
            TxtTipoDocumento.Text = tipo.TipoDocumento;
            NumNroSiguiente.Value = tipo.NroSiguiente;
            ChkActivo.Checked = (tipo.Activo == 1);
            if (tipo.EmpleadoUpd != null)
                TssLblModificado.Text = (tipo.EmpleadoUpd.Login.ToLower() + " " + tipo.ModificadoEl) ?? "";
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
                MessageBox.Show("Debe transcribir un código para el tipo de documento.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtIniciales.Text.Trim().Length == 0)
            {
                TxtCodigo.Focus();
                MessageBox.Show("Debe transcribir las iniciales para el tipo de documento.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtTipoDocumento.Text.Trim().Length == 0)
            {
                TxtTipoDocumento.Focus();
                MessageBox.Show("Debe transcribir la descripción del tipo de documento.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos y eventos

        public FrmDocumento()
        {
            InitializeComponent();
        }

        private void FrmDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            CargarTiposDocumentos();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            IncluirBtnClear(TxtFiltroCodigo);
            IncluirBtnClear(TxtFiltroIniciales);
            IncluirBtnClear(TxtFiltroTipoDocumento);
            Left = 10;
            Top = 10;
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

        private void DgvTiposDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvTiposDocumentos["ID", e.RowIndex].Value.ToString()));
            TabTiposDocumentos.SelectTab("PagEditar");
        }

        private void DgvTiposDocumentos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarTiposDocumentos(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
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
            }
        }

        private void TxtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarTiposDocumentos();
        }

        #endregion Métodos y eventos
    }
}