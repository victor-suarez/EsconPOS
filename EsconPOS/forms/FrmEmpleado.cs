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
    public partial class FrmEmpleado : Form
    {
        private mainEntities context = new mainEntities();

        private void CargaEmpleados()
        {
            var dataset = context.Empleados
                .Select(e => new {
                    ID = e.EmpleadoID,
                    Nombres = e.Nombre,
                    Identificación = e.Identificaciones.Iniciales + "-" + e.NroDocIdent,
                    Teléfonos = e.Telefono
                }).ToList();
            DgvEmpleados.DataSource = dataset;
            DgvEmpleados.Columns["ID"].Visible = false;
        }

        private void CargarCombos()
        {
            CmbTipoIDEmpleado.DataSource = context.Identificaciones.ToList();
            CmbTipoIDEmpleado.DisplayMember = "Identificacion";
            CmbTipoIDEmpleado.ValueMember = "IdentificacionID";

            CmbDepartamento.DataSource = context.Departamentos.ToList();
            CmbDepartamento.DisplayMember = "Departamento";
            CmbDepartamento.ValueMember = "DepartamentoID";
        }

        private void ClearCrt()
        {

        }

        private void MoverRegistroToCrt(long ID)
        {

        }

        private void Eliminar()
        {

        }

        private void Guardar()
        {

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
            return true;
        }

        private void CmbID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Codigo + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }
        private void CmbDepartamento_Enter(object sender, EventArgs e)
        {
            CmbDepartamento.Width = 340;
        }

        private void CmbDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Departamentos)e.ListItem).UBIGEO + "-" + ((Departamentos)e.ListItem).Departamento;
        }

        private void CmbDepartamento_Leave(object sender, EventArgs e)
        {
            CmbDepartamento.Width = 50;
        }

        private void CmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbDepartamento.SelectedIndex == -1) return;
            CmbProvincia.DataSource = (from p in context.Provincias where p.DepartamentoID == ((Departamentos)(CmbDepartamento.SelectedItem)).DepartamentoID select p).ToList();
            CmbProvincia.DisplayMember = "Provincia";
            CmbProvincia.ValueMember = "ProvinciaID";
        }

        private void CmbProvincia_Enter(object sender, EventArgs e)
        {
            CmbProvincia.Width = 340;
        }

        private void CmbProvincia_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Provincias)e.ListItem).UBIGEO.Substring(2, 2) + "-" + ((Provincias)e.ListItem).Provincia;
        }

        private void CmbProvincia_Leave(object sender, EventArgs e)
        {
            CmbProvincia.Width = 50;
        }

        private void CmbProvincia_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbProvincia.SelectedIndex == -1) return;
            CmbDistrito.DataSource = (from d in context.Distritos where d.ProvinciaID == ((Provincias)(CmbProvincia.SelectedItem)).ProvinciaID select d).ToList();
            CmbDistrito.DisplayMember = "Distrito";
            CmbDistrito.ValueMember = "DistritoID";
        }

        private void CmbDistrito_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Distritos)e.ListItem).UBIGEO.Substring(4, 2) + "-" + ((Distritos)e.ListItem).Distrito;
        }

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void FrmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargaEmpleados();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
        }

        //Siguiente campo cuando presiona [ENTER]
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
                //if(((TextBox)sender).Name == "TxtCorreoElectronicoCliente") RibBtnGuardar.
            }
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

    }
}
