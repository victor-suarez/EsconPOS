using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmContrasenia : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();
        public string MensajeRespuesta { get; set; }

        #endregion Variables y constantes

        #region Funciones

        private void CambiarContrasenia()
        {
            string MensajeFinal = "";
            if (!ValEntReq()) return;
            try
            {
                //Buscar el usuario (empleado) que está loggeado
                var emp = (from e in context.Empleados
                           where e.EmpleadoID == Global.glUsuario
                           select e).FirstOrDefault();
                //Cambiar el hash de la contraseña
                string passwd = Global.GetStringSha256Hash(TxtNuevaContrasenia.Text.Trim());
                context.Empleados.Attach(emp);
                emp.PasswdHash = passwd;
                //Guardar cambios
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MensajeFinal = "Error cambiando la contraseña del usuario. " + ex.Message;
                MensajeRespuesta = MensajeFinal;
                SetStatus(MensajeFinal, true);
                DialogResult = DialogResult.Cancel;
                if (!this.Modal)
                {
                    ((MDIEsconPos)this.MdiParent).SetStatus(MensajeFinal);
                }
                Close();
            }

            MensajeFinal = "Nueva contraseña establecida con éxito.";
            MensajeRespuesta = MensajeFinal;
            SetStatus(MensajeFinal);
            MensajeRespuesta = MensajeFinal;
            DialogResult = DialogResult.OK;
            if (!this.Modal)
            {
                ((MDIEsconPos)this.MdiParent).SetStatus(MensajeFinal);
            }
            Close();
        }

        private void IncluirBtnEye(TextBox txt)
        {
            var btn = new Button();
            btn.AutoSize = false;
            btn.Size = new Size(25, txt.ClientSize.Height + 2);
            btn.Location = new Point(txt.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.Ver;
            btn.TabStop = false;
            btn.MouseDown += btn_MouseDown;
            btn.MouseUp += btn_MouseUp;
            //btn.Visible = false;
            txt.Controls.Add(btn);
        }

        private void SetStatus(string Status = "", bool Error = false)
        {
            if (Error)
                lblStatus.ForeColor = Color.Red;
            else
                lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Text = Status;
        }

        private bool ValEntReq()
        {
            if (TxtNuevaContrasenia.Text.Trim().Length == 0 || TxtConfirmaContrasenia.Text.Trim().Length == 0)
            {
                TxtNuevaContrasenia.Focus();
                SetStatus("Debe transcribir y confirmar su nueva contraseña. Datos incompletos.", true);
                return false;
            }
            if (TxtNuevaContrasenia.Text.Trim() != TxtConfirmaContrasenia.Text.Trim())
            {
                TxtConfirmaContrasenia.Focus();
                SetStatus("Su confirmación no coincide con la contraseña ingresada. Datos inválidos.", true);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmContrasenia()
        {
            InitializeComponent();
        }

        private void Btn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            ((TextBox)((Button)sender).Parent).UseSystemPasswordChar = false;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            ((TextBox)((Button)sender).Parent).UseSystemPasswordChar = true;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            CambiarContrasenia();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FrmContrasenia_Load(object sender, EventArgs e)
        {
            IncluirBtnEye(TxtNuevaContrasenia);
        }

        private void Txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
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