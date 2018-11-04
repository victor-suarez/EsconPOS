using EsconPOS.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmConfiguracion : Form
    {
        public bool Resultado = false;
        private mainEntities context = new mainEntities();
        //private Datos Conx = Datos.Conx;

        public void CargarIdentificaciones()
        {
            CmbIdentificacionID.DataSource = context.Identificaciones.ToList();
            CmbIdentificacionID.DisplayMember = "Identificacion";
            CmbIdentificacionID.ValueMember = "IdentificacionID";
            //CmbIdentificacionID.Items.Clear();
            //Identificaciones TiposIDs = new Identificaciones(Conx);
            //foreach (Identificaciones ListTiposIDs in TiposIDs.Listar())
            //{
            //    CmbIdentificacionID.Items.Add(ListTiposIDs);
            //}
        }

        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            try
            {
                Identificaciones ItemID = (Identificaciones)CmbIdentificacionID.SelectedItem;
                context.Empleados.Add(
                    new Empleados
                    {
                        IdentificacionID = ItemID.IdentificacionID,
                        NroDocIdent = TxtNroDocIdent.Text,
                        Nombre = TxtNombre.Text,
                        Direccion = TxtDireccion.Text,
                        Telefono = TxtTelefonos.Text,
                        CorreoElectronico = TxtCorreoElectronico.Text,
                        Login = TxtLogin.Text,
                        PasswdHash = Global.GetStringSha256Hash(TxtPassword.Text),
                        EsSupervisor = ChkEsSupervisor.Checked ? 1 : 0,
                        EsAdministrador = 1,
                        Activo = 1,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = -1
                    }
                );
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                if(((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                {
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando el administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error guardando el administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }

            try
            {
                context.Cajas.Add(
                    new Cajas
                    {
                        CajaID = (int)NumCajaID.Value,
                        Descripcion = TxtDescripcion.Text,
                        FechaHoraEstado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                    }
                );
               context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                {
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error guardando la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }
            Resultado = true;
            Close();
        }

        private bool ValEntReq()
        {
            if (CmbIdentificacionID.SelectedIndex == -1 )
            {
                CmbIdentificacionID.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroDocIdent.Text.Trim().Length == 0)
            {
                TxtNroDocIdent.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNombre.Text.Trim().Length == 0)
            {
                TxtNombre.Focus();
                MessageBox.Show("Debe transcribir el nombre del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtLogin.Text.Trim().Length == 0)
            {
                TxtLogin.Focus();
                MessageBox.Show("Debe transcribir el código de usuario de entrada al sistema del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtPassword.Text.Trim().Length == 0)
            {
                TxtPassword.Focus();
                MessageBox.Show("Debe transcribir la contraseña de entrada al sistema del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtDescripcion.Text.Trim().Length == 0)
            {
                TxtDescripcion.Focus();
                MessageBox.Show("Debe transcribir un nombre o descripción de la caja.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void FrmConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.LoggedIN = Resultado;
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarIdentificaciones();
        }

        private void RibBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void RibBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Siguiente campo cuando presiona [ENTER]
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }
    }
}
