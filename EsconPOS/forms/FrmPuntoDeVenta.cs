﻿using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmPuntoDeVenta : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void Agregar()
        {
        }

        private void AgregarClienteRapido()
        {
            if (!ValCliEntReq()) return;
            try
            {
                var clie = new Clientes
                {
                    IdentificacionID = ((Identificaciones)CmbTipoIDCli.SelectedItem).IdentificacionID,
                    NroDocIdent = TxtNroIDCli.Text.Trim(),
                    Nombre = CmbClientes.Text.Trim(),
                    Direccion = null,
                    PaisID = null,
                    DistritoID = Global.glDistritoEmpresa,
                    NroTelefonico = null,
                    CorreoElectronico = null,
                    FechaNacimiento = null,
                    Activo = 1,
                    AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glUsuario
                };
                context.Clientes.Add(clie);
                context.SaveChanges();
                CargarClientes();
                CmbClientes.SelectedValue = clie.ClienteID;
                SetStatus("Cliente agregado.");
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos del cliente.");
                return;
            }
        }

        private void AgregarVendedorRapido()
        {
            if (!ValVenEntReq()) return;
            try
            {
                var empl = new Empleados
                {
                    IdentificacionID = ((Identificaciones)CmbTipoIDEmp.SelectedItem).IdentificacionID,
                    NroDocIdent = TxtNroIDEmp.Text,
                    Nombre = CmbEmpleados.Text,
                    Direccion = null,
                    Telefono = null,
                    CorreoElectronico = null,
                    Login = CmbEmpleados.Text.Trim().Replace(" ", "").Substring(0, 8).ToUpper(),
                    PasswdHash = "",
                    EsSupervisor = 0,
                    EsAdministrador = 0,
                    Activo = 1,
                    AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    AgregadoPor = Global.glUsuario
                };
                context.Empleados.Add(empl);
                context.SaveChanges();
                CargarVendedores();
                CmbEmpleados.SelectedValue = empl.EmpleadoID;
                SetStatus("Vendedor agregado.");
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error guardando datos del vendedor.");
                return;
            }
        }

        private void CalcularTotales()
        {
        }

        private void CargarClases()
        {
            CmbClases.DataSource = context.TiposProductos
                                    .Where(t => t.Activo == 1)
                                    .OrderBy("Codigo")
                                    .ToList();
            CmbClases.DisplayMember = "TipoProducto";
            CmbClases.ValueMember = "TipoProductoID";
            CmbClases.SelectedIndex = -1;
        }

        private void CargarClientes()
        {
            string FiltroTipoID = CmbTipoIDCli.SelectedIndex == -1 ? "" : ((Identificaciones)CmbTipoIDCli.SelectedItem).Codigo;
            string FiltroNroID = TxtNroIDCli.Text.Trim();
            CmbClientes.DataSource = context.Clientes
                                        .Where(c => (c.Identificaciones.Codigo == FiltroTipoID || FiltroTipoID == "")
                                                    &&
                                                    (c.NroDocIdent.Contains(FiltroNroID) || FiltroNroID == ""))
                                        .OrderBy("Nombre")
                                        .ToList();
            CmbClientes.DisplayMember = "Nombre";
            CmbClientes.ValueMember = "ClienteID";
            CmbClientes.SelectedIndex = -1;
        }

        private void CargarCombos()
        {
            CargarIdent();
            CargarClientes();
            CargarVendedores();
            CargarMarcas();
            CargarClases();
            CargarProductos();
        }

        private void CargarIdent()
        {
            CmbTipoIDCli.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDCli.DisplayMember = "Identificacion";
            CmbTipoIDCli.ValueMember = "IdentificacionID";
            CmbTipoIDCli.SelectedIndex = -1;

            CmbTipoIDEmp.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
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

        private void CargarProductos()
        {
            long MarcaID = CmbMarcas.SelectedIndex < 0 ? -1 : ((Marcas)CmbMarcas.SelectedItem).MarcaID;
            long TipoProductoID = CmbClases.SelectedIndex < 0 ? -1 : ((TiposProductos)CmbClases.SelectedItem).TipoProductoID;
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

        private void CargarVendedores()
        {
            string FiltroTipoID = CmbTipoIDEmp.SelectedIndex == -1 ? "" : ((Identificaciones)CmbTipoIDEmp.SelectedItem).Codigo;
            string FiltroNroID = TxtNroIDEmp.Text.Trim();
            CmbEmpleados.DataSource = context.Empleados
                                        .Where(v => (v.Identificaciones.Codigo == FiltroTipoID || FiltroTipoID == "")
                                                    &&
                                                    (v.NroDocIdent.Contains(FiltroNroID) || FiltroNroID == ""))
                                        .OrderBy("Nombre")
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

        private void SetStatus(string Status = "", bool Error = false)
        {
            if (Error)
                TssLblStatus.ForeColor = Color.Red;
            else
                TssLblStatus.ForeColor = SystemColors.ControlText;
            TssLblStatus.Text = Status;
        }

        private bool ValCliEntReq()
        {
            if (CmbTipoIDCli.SelectedIndex == -1)
            {
                CmbTipoIDCli.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDCli.Text.Trim().Length == 0)
            {
                TxtNroIDCli.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbClientes.Text.Trim().Length == 0)
            {
                CmbClientes.Focus();
                MessageBox.Show("Debe transcribir el nombre del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValEntReq()
        {
            return true;
        }

        private bool ValVenEntReq()
        {
            if (CmbTipoIDEmp.SelectedIndex == -1)
            {
                CmbTipoIDEmp.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDEmp.Text.Trim().Length == 0)
            {
                TxtNroIDEmp.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación del vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbEmpleados.Text.Trim().Length == 0)
            {
                CmbEmpleados.Focus();
                MessageBox.Show("Debe transcribir el nombre del vendedor.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmPuntoDeVenta()
        {
            InitializeComponent();
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteRapido();
        }

        private void BtnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarVendedorRapido();
        }

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }

        private void CmbClases_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((TiposProductos)e.ListItem).Codigo + "-" + ((TiposProductos)e.ListItem).TipoProducto;
        }

        private void CmbClases_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CmbMarcas_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Marcas)e.ListItem).Codigo + "-" + ((Marcas)e.ListItem).Marca;
        }

        private void CmbMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CmbTipoID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Iniciales + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }

        private void CmbTipoIDCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void CmbTipoIDEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarVendedores();
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

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((NumericUpDown)sender, true, true, true, false);
            }
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
            }
        }

        private void TxtNroIDCli_TextChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void TxtNroIDEmp_TextChanged(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        #endregion Métodos
    }
}