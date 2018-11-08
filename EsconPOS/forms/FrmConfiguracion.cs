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

        public void CargarCombos()
        {
            CmbTipoIDEmpresa.DataSource = context.Identificaciones.ToList();
            CmbTipoIDEmpresa.DisplayMember = "Identificacion";
            CmbTipoIDEmpresa.ValueMember = "IdentificacionID";
            
            CmbTipoIDEmpleado.DataSource = context.Identificaciones.ToList();
            CmbTipoIDEmpleado.DisplayMember = "Identificacion";
            CmbTipoIDEmpleado.ValueMember = "IdentificacionID";

            CmbDepartamento.DataSource = context.Departamentos.ToList();
            CmbDepartamento.DisplayMember = "Departamento";
            CmbDepartamento.ValueMember = "Departamento";
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
                context.Empresas.Add(
                    new Empresas
                    {
                        IdentificacionID = ((Identificaciones)CmbTipoIDEmpresa.SelectedItem).IdentificacionID,
                        NroDocIdent = TxtNroIDEmpresa.Text,
                        NombreComercial = TxtNombreComercial.Text,
                        RazonSocial = TxtRazonSocial.Text,
                        Direccion = null,
                        Urbanizacion = null,
                        NroTelefonico = null,
                        CorreoElectronico = null,
                        DistritoID = ((Distritos)(CmbDistrito.SelectedItem)).DistritoID,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = -1
                    }
               );
               context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                {
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando datos de la empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error guardando datos de la empresa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }
            // Localizo la empresa que acabo de ingresar
            var empr = (from e in context.Empresas
                        where e.IdentificacionID == ((Identificaciones)CmbTipoIDEmpresa.SelectedItem).IdentificacionID
                        && e.NroDocIdent == TxtNroIDEmpresa.Text
                        select e).First();

            try
            {
                context.Empleados.Add(
                    new Empleados
                    {
                        IdentificacionID = ((Identificaciones)CmbTipoIDEmpleado.SelectedItem).IdentificacionID,
                        NroDocIdent = TxtNroIDEmpleado.Text,
                        Nombre = TxtNombre.Text,
                        Direccion = null,
                        Telefono = null,
                        CorreoElectronico = null,
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
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando datos del administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error guardando datos del administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }
            // Localizo el empleado que acabo de ingresar
            var empl = (from e in context.Empleados
                        where e.IdentificacionID == ((Identificaciones)CmbTipoIDEmpleado.SelectedItem).IdentificacionID
                        && e.NroDocIdent == TxtNroIDEmpleado.Text
                        select e).First();
            // Guardar la relación Empleado / Empresa
            empr.Empleados.Add(empl);
            context.SaveChanges();
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
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando datos de la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error guardando datos de la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }
            Resultado = true;
            Close();
        }

        private bool ValEntReq()
        {
            if (CmbTipoIDEmpresa.SelectedIndex == -1)
            {
                CmbTipoIDEmpresa.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDEmpresa.Text.Trim().Length == 0)
            {
                TxtNroIDEmpresa.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNombreComercial.Text.Trim().Length == 0)
            {
                TxtNombre.Focus();
                MessageBox.Show("Debe transcribir el nombre comercial de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtRazonSocial.Text.Trim().Length == 0)
            {
                TxtNombre.Focus();
                MessageBox.Show("Debe transcribir la razón social de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbDistrito.SelectedIndex == -1)
            {
                CmbDistrito.Focus();
                MessageBox.Show("Debe seleccionar la ubicación (UBIGEO) de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbTipoIDEmpleado.SelectedIndex == -1 )
            {
                CmbTipoIDEmpleado.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDEmpleado.Text.Trim().Length == 0)
            {
                TxtNroIDEmpleado.Focus();
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
            CargarCombos();
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

        private void ChkEsSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((CheckBox)sender, true, true, true, false);
            }
        }

        private void ComboID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Codigo + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }

        private void ComboDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Departamentos)e.ListItem).UBIGEO + "-" + ((Departamentos)e.ListItem).Departamento;
        }

        private void CmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            CmbProvincia.DataSource = (from p in context.Provincias where p.DepartamentoID == ((Departamentos)(CmbDepartamento.SelectedItem)).DepartamentoID select p).ToList();
            CmbProvincia.DisplayMember = "Provincia";
            CmbProvincia.ValueMember = "Provincia";
        }

        private void CmbProvincia_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Provincias)e.ListItem).UBIGEO.Substring(2,2) + "-" + ((Provincias)e.ListItem).Provincia;
        }

        private void CmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            CmbDistrito.DataSource = (from d in context.Distritos where d.ProvinciaID == ((Provincias)(CmbProvincia.SelectedItem)).ProvinciaID select d).ToList();
            CmbDistrito.DisplayMember = "Distrito";
            CmbDistrito.ValueMember = "Distrito";
        }

        private void CmbDistrito_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Distritos)e.ListItem).UBIGEO.Substring(4, 2) + "-" + ((Distritos)e.ListItem).Distrito;
        }

        private void NumCajaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }
    }
}
