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
        //private Datos Conx = Datos.Conx;

        public void CargarIdentificaciones()
        {
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
            //Empleados Emp = new Empleados(Conx);
            //Identificaciones ItemID = (Identificaciones)CmbIdentificacionID.SelectedItem;
            //int ID = ItemID.IdentificacionID;
            //try
            //{
            //    Emp.Agregar(ID,
            //                TxtNroDocIdent.Text,
            //                TxtNombre.Text,
            //                TxtDireccion.Text,
            //                TxtTelefonos.Text,
            //                TxtCorreoElectronico.Text,
            //                TxtLogin.Text,
            //                TxtPassword.Text,
            //                ChkEsSupervisor.Checked,
            //                true);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error guardando el administrador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //Cajas Caja = new Cajas(Conx);
            //try
            //{
            //    Caja.Agregar((int)NumCajaID.Value, TxtDescripcion.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Error guardando la caja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
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

        private void FrmConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global.LoggedIN = Resultado;
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
