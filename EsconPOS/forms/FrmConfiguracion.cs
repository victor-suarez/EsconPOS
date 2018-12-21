using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmConfiguracion : Form
    {
        #region Variables y constantes

        public bool Resultado = false;
        private const int CMB_ANCHO_MAXIMO = 340;
        private const int CMB_ANCHO_MINIMO = 40;
        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        public void CargarCombos()
        {
            CmbTipoIDEmpresa.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDEmpresa.DisplayMember = "Identificacion";
            CmbTipoIDEmpresa.ValueMember = "IdentificacionID";

            CmbTipoIDEmpleado.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDEmpleado.DisplayMember = "Identificacion";
            CmbTipoIDEmpleado.ValueMember = "IdentificacionID";

            CmbDepartamento.DataSource = context.Departamentos.OrderBy("UBIGEO").ToList();
            CmbDepartamento.DisplayMember = "Departamento";
            CmbDepartamento.ValueMember = "Departamento";
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            Empresas empr;
            Empleados empl;
            Cajas caja;
            try
            {
                empr = new Empresas
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
                };
                context.Empresas.Add(empr);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos de la empresa.");
                return;
            }

            try
            {
                empl = new Empleados
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
                };
                context.Empleados.Add(empl);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos del administrador.");
                return;
            }
            // Guardar la relación Empleado / Empresa
            empr.Empleados.Add(empl);
            context.SaveChanges();
            try
            {
                caja = new Cajas
                {
                    CajaID = (int)NumCajaID.Value,
                    Descripcion = TxtDescripcion.Text,
                    FechaHoraEstado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };
                context.Cajas.Add(caja);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos de la caja.");
                return;
            }
            Resultado = true;
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
            btn.MouseDown += btn_MouseDown;
            btn.MouseUp += btn_MouseUp;
            //btn.Visible = false;
            txt.Controls.Add(btn);
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
            if (CmbTipoIDEmpleado.SelectedIndex == -1)
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
            if (TxtPassword.Text.Trim().Length < 6)
            {
                TxtPassword.Focus();
                MessageBox.Show("La contraseña de entrada al sistema debe tener mínimo 6 caracteres.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        #endregion Funciones

        #region Métodos

        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            ((TextBox)((Button)sender).Parent).UseSystemPasswordChar = false;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            ((TextBox)((Button)sender).Parent).UseSystemPasswordChar = true;
        }

        private void ChkEsSupervisor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((CheckBox)sender, true, true, true, false);
            }
        }

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }

        private void CmbDepartamento_Enter(object sender, EventArgs e)
        {
            CmbDepartamento.BringToFront();
            CmbDepartamento.Width = CMB_ANCHO_MAXIMO;
        }

        private void CmbDepartamento_Leave(object sender, EventArgs e)
        {
            CmbDepartamento.Width = CMB_ANCHO_MINIMO;
        }

        private void CmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            CmbProvincia.DataSource = (from p in context.Provincias where p.DepartamentoID == ((Departamentos)(CmbDepartamento.SelectedItem)).DepartamentoID select p).OrderBy("UBIGEO").ToList();
            CmbProvincia.DisplayMember = "Provincia";
            CmbProvincia.ValueMember = "Provincia";
        }

        private void CmbDistrito_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Distritos)e.ListItem).UBIGEO.Substring(4, 2) + "-" + ((Distritos)e.ListItem).Distrito;
        }

        private void CmbProvincia_Enter(object sender, EventArgs e)
        {
            CmbProvincia.BringToFront();
            CmbProvincia.Width = CMB_ANCHO_MAXIMO;
        }

        private void CmbProvincia_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Provincias)e.ListItem).UBIGEO.Substring(2, 2) + "-" + ((Provincias)e.ListItem).Provincia;
        }

        private void CmbProvincia_Leave(object sender, EventArgs e)
        {
            CmbProvincia.Width = CMB_ANCHO_MINIMO;
        }

        private void CmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            CmbDistrito.DataSource = (from d in context.Distritos where d.ProvinciaID == ((Provincias)(CmbProvincia.SelectedItem)).ProvinciaID select d).OrderBy("UBIGEO").ToList();
            CmbDistrito.DisplayMember = "Distrito";
            CmbDistrito.ValueMember = "Distrito";
        }

        private void ComboDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Departamentos)e.ListItem).UBIGEO + "-" + ((Departamentos)e.ListItem).Departamento;
        }

        private void ComboID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Codigo + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }

        private void FrmConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.LoggedIN = Resultado;
        }

        private void FrmConfiguracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarCombos();
            IncluirBtnEye(TxtPassword);
        }

        private void Num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                e.Handled = true;
                SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void TsBtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void TsBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Siguiente campo cuando presiona [ENTER]
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                //TxtDescripcion
                if (((TextBox)sender).Name == "")
                    TsBtnGuardar_Click(null, null);
                else
                    SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        #endregion Métodos
    }
}