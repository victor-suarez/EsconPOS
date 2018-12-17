using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmEntrada : Form
    {
        #region Variables y constantes

        //private Datos Conx = Datos.Conx;
        private bool LoggedIN = false;

        #endregion Variables y constantes

        #region Funciones

        private void Entrada()
        {
            try
            {
                SetStatus("Abriendo la base de datos...");

                using(var context = new mainEntities())
                {
                    try
                    {
                        SetStatus("Buscando el administrador...");
                        // Verificar la existencia de un usuario administrador
                        var adm = (from a in context.Empleados
                                   where a.EsAdministrador == 1
                                   select a).FirstOrDefault();
                        if (adm == null)
                        {
                            SetStatus("Configuración del sistema (1era vez)...");
                            FrmConfiguracion fconf = new FrmConfiguracion();
                            fconf.ShowDialog(this);
                            return;
                        };
                    }
                    catch (Exception ex)
                    {
                        Global.MensajeError(ex, "Error buscando el administrador.");
                        return;
                    }

                    try
                    {
                        SetStatus("Buscando datos del usuario...");
                        // Lo necesito en una variable porque no puedo pasarle la función a LINQ.
                        string passwd = Global.GetStringSha256Hash(txtContrasenia.Text.Trim());
                        var user = (from u in context.Usuarios
                                    where u.Login == TxtLogin.Text.ToUpper().Trim()
                                    && u.PasswdHash == passwd
                                    select u).FirstOrDefault();
                        if (user == null)
                        {
                            MessageBox.Show("Usuario o contraseña inválidos.", "Error buscando el usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        };
                        Global.glUsuario = user.UsuarioID;
                    }
                    catch (Exception ex)
                    {
                        Global.MensajeError(ex, "Error buscando el usuario.");
                        return;
                    }

                    try
                    {
                        SetStatus("Buscando datos del empleado...");
                        var emp = (from e in context.Empleados
                                   where e.EmpleadoID == Global.glUsuario
                                   select e).First();
                        if (emp != null)
                        {
                            Global.glEmpleado = emp.EmpleadoID;
                            Global.glNomEmpleado = emp.Nombre;
                            SetStatus("Buscando datos de la empresa...");
                            var empr = emp.Empresas.First();
                            if (empr != null)
                            {
                                Global.glEmpresa = empr.EmpresaID;
                                Global.glNomEmpresa = empr.NombreComercial;
                                Global.glDistritoEmpresa = empr.DistritoID;
                            }
                        }

                        SetStatus("Buscando datos de la caja...");
                        var pos = (from p in context.Cajas
                                   select p).First();
                        if (pos != null)
                        {
                            Global.glCaja = pos.CajaID;
                            Global.glNomCaja = pos.Descripcion;
                        }
                    }
                    catch (Exception ex)
                    {
                        Global.MensajeError(ex, "Error buscando el empleado.");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error buscando el usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
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
            if (TxtLogin.Text.Trim().Length == 0)
            {
                TxtLogin.Focus();
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

        #endregion Funciones

        #region Métodos

        public FrmEntrada()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LoggedIN = false;
            //Global.Empleado = null;
            //Global.Caja = null;
            Close();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (ValEntReq()) Entrada();
        }

        private void FrmEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.LoggedIN = LoggedIN;
        }

        private void TxtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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