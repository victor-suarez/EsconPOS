using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsconPOS.classes;

namespace EsconPOS.forms
{
    public partial class FrmEntrada : Form
    {
        private Datos Conx = Datos.Conx;
        public bool LoggedIN = false;

        public FrmEntrada()
        {
            InitializeComponent();
        }
        private void Entrada()
        {
            try
            {
                Conx.OpenDatabase();
                Empleados Usuario = new Empleados(Conx);
                if(Usuario.EmpleadoAdminDefinido())
                {
                    Usuario = Usuario.Entrada(txtUsuario.Text, txtContrasenia.Text);
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                if(ex.Message == "Usuario no defnido en el sistema.")

                MessageBox.Show(ex.Message, "Error en la entrada al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            try
            {
                Cajas Caja = new Cajas(Conx);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la entrada al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoggedIN = true;
            Close();
        }
        private void SetStatus(string StrStatus, bool Error = false)
        {
            if (Error)
                lblStatus.ForeColor = Color.Red;
            else
                lblStatus.ForeColor = SystemColors.ControlText;
            lblStatus.Text = StrStatus;
            lblStatus.Refresh();
        }
        private bool ValEntReq()
        {
            if (txtUsuario.Text.Trim().Length == 0)
            {
                txtUsuario.Focus();
                MessageBox.Show("Debe transcribir el código del usuario.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtContrasenia.Text.Trim().Length == 0)
            {
                txtContrasenia.Focus();
                MessageBox.Show("Debe transcribir la contraseña del usuario.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if(ValEntReq()) Entrada();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }
        private void TxtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

    }
}
