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
        private bool LoggedIN = false;

        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void Entrada()
        {
            SetStatus("Abriendo la base de datos...");
            try
            {
                Conx.OpenDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error abriendo la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SetStatus("Buscando el usuario...");
            Empleados Usuario = new Empleados(Conx);
            if (Usuario.EmpleadoAdminDefinido())
            {
                try
                {
                    Global.Empleado = Usuario.Entrada(txtUsuario.Text.ToUpper(), txtContrasenia.Text);
                    if (Global.Empleado == null)
                    { 
                        MessageBox.Show("Empleado no está definido en el sistema.","Datos inválidos",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error buscando el usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                SetStatus("Configuración del sistema (1era vez)...");
                FrmConfiguracion fconf = new FrmConfiguracion();
                fconf.ShowDialog();
            }
            try
            {
                SetStatus("Buscando datos de la caja...");
                Cajas Caja = new Cajas(Conx);
                Global.Caja = Caja.Buscar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la entrada al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoggedIN = true;
            SetStatus();
            Close();
        }

        private void SetStatus(string StrStatus = "", bool Error = false)
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
            LoggedIN = false;
            Global.Empleado = null;
            Global.Caja = null;
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

        private void FrmEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.LoggedIN = LoggedIN;
        }
    }
}
