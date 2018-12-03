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
    public partial class FrmPuntoDeVenta : Form
    {
        private mainEntities context = new mainEntities();
        private void CargarCombos()
        {
            CargarIdent();
            CargarClientes();
            CargarVendedores();
            CargarMarcas();
            CargarClases();
            CargarProductos();
        }
        private void CargarClases()
        {
            CmbClases.DataSource = context.TiposProductos
                .Where(t => t.Activo == 1)
                .ToList();
            CmbClases.DisplayMember = "TipoProducto";
            CmbClases.ValueMember = "TipoProductoID";
            CmbClases.SelectedIndex = -1;
        }
        private void CargarClientes(long TipoID = -1, string NroID = null)
        {
            CmbClientes.DataSource = context.Clientes
                .Where(c => (c.IdentificacionID == TipoID || TipoID == -1)
                            &&
                            (c.NroDocIdent == NroID || NroID == null))
                .ToList();
            CmbClientes.DisplayMember = "Nombre";
            CmbClientes.ValueMember = "ClienteID";
            CmbClientes.SelectedIndex = -1;
        }
        private void CargarIdent()
        {
            CmbTipoIDCli.DataSource = context.Identificaciones.ToList();
            CmbTipoIDCli.DisplayMember = "Identificacion";
            CmbTipoIDCli.ValueMember = "IdentificacionID";
            CmbTipoIDCli.SelectedIndex = -1;

            CmbTipoIDEmp.DataSource = context.Identificaciones.ToList();
            CmbTipoIDEmp.DisplayMember = "Identificacion";
            CmbTipoIDEmp.ValueMember = "IdentificacionID";
            CmbTipoIDEmp.SelectedIndex = -1;
        }
        private void CargarMarcas()
        {
            CmbMarcas.DataSource = context.Marcas
                .Where(m => m.Activo == 1)
                .ToList();
            CmbMarcas.DisplayMember = "Marca";
            CmbMarcas.ValueMember = "MarcaID";
            CmbMarcas.SelectedIndex = -1;
        }
        private void CargarProductos(long MarcaID = -1, long TipoProductoID = -1)
        {
            CmbProductos.DataSource = context.Productos
                .Where(p => (p.MarcaID == MarcaID || MarcaID == -1)
                            &&
                            (p.TipoProductoID == TipoProductoID || TipoProductoID == -1)
                            &&
                            p.Activo == 1)
                .ToList();
            CmbProductos.DisplayMember = "Producto";
            CmbProductos.ValueMember = "ProductoID";
            CmbProductos.SelectedIndex = -1;
        }
        private void CargarVendedores(long TipoID = -1, string NroID = null)
        {
            CmbEmpleados.DataSource = context.Empleados
                .Where(v => (v.IdentificacionID == TipoID || TipoID == -1)
                            &&
                            (v.NroDocIdent == NroID || NroID == null))
                .ToList();
            CmbEmpleados.DisplayMember = "Nombre";
            CmbEmpleados.ValueMember = "EmpleadoID";
            CmbEmpleados.SelectedIndex = -1;
        }
        private void ClearCrt()
        {
            CmbTipoIDCli.SelectedIndex = -1;
            TxtNroIDCli.Text = "";
            CmbClientes.SelectedIndex = -1;
            CmbTipoIDEmp.SelectedIndex = -1;
            TxtNroIDEmp.Text = "";
            CmbEmpleados.SelectedIndex = -1;
            TxtProdCodigo.Text = "";
            CmbMarcas.SelectedIndex = -1;
            CmbClases.SelectedIndex = -1;
            CmbProductos.SelectedIndex = -1;
            NumCantidad.Value = 0;
            NumValorUnit.Value = 0;
            NumDescuento.Value = 0;
        }
        private void Eliminar()
        {

        }
        private void Agregar()
        {

        }
        private void CalcularTotales()
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
        private void CmbClases_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((TiposProductos)e.ListItem).Codigo + "-" + ((TiposProductos)e.ListItem).TipoProducto;
        }
        private void CmbMarcas_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Marcas)e.ListItem).Codigo + "-" + ((Marcas)e.ListItem).Marca;
        }
        private void CmbTipoID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Iniciales + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }
        public FrmPuntoDeVenta()
        {
            InitializeComponent();
        }
        private void FrmPuntoDeVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }
        private void FrmPuntoDeVenta_Load(object sender, EventArgs e)
        {
            CargarCombos();

        }
        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }
        private void CmbTipoIDCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarClientes(((Identificaciones)CmbTipoIDCli.SelectedItem).IdentificacionID);
        }
        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }
        private void CmbTipoIDEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarVendedores(((Identificaciones)CmbTipoIDEmp.SelectedItem).IdentificacionID);
        }
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }
        private void CmbClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos(CmbMarcas.SelectedIndex < 0 ? -1 : ((Marcas)CmbMarcas.SelectedItem).MarcaID, CmbClases.SelectedIndex < 0 ? -1 : ((TiposProductos)CmbClases.SelectedItem).TipoProductoID);
        }
        private void CmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos(CmbMarcas.SelectedIndex < 0 ? -1 : ((Marcas)CmbMarcas.SelectedItem).MarcaID, CmbClases.SelectedIndex < 0 ? -1 : ((TiposProductos)CmbClases.SelectedItem).TipoProductoID);
        }
        private void TxtNroIDCli_TextChanged(object sender, EventArgs e)
        {
            CargarClientes(NroID:TxtNroIDCli.Text.Trim());
        }
        private void TxtNroIDEmp_TextChanged(object sender, EventArgs e)
        {
            CargarVendedores(NroID: TxtNroIDEmp.Text.Trim());
        }
    }
}
