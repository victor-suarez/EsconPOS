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
    public partial class FrmCliente : Form
    {
        private mainEntities context = new mainEntities();

        public void CargarCombos()
        {
            CmbTipoIDCliente.DataSource = context.Identificaciones.ToList();
            CmbTipoIDCliente.DisplayMember = "Identificacion";
            CmbTipoIDCliente.ValueMember = "IdentificacionID";
        }

        private void Eliminar()
        {

        }

        private void Guardar()
        {

        }
        private bool ValEntReq()
        {

            return true;
        }

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void RibBtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarCombos();
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
            e.Value = ((Provincias)e.ListItem).UBIGEO.Substring(2, 2) + "-" + ((Provincias)e.ListItem).Provincia;
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

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
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
