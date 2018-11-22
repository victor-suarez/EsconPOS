﻿using System;
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
        private const int CMB_ANCHO_MINIMO = 40;
        private const int CMB_ANCHO_MAXIMO = 340;

        private void CargaClientes()
        {
            var dataset = context.Clientes
                .Select(c => new { ID = c.ClienteID,
                                   Nombres = c.Nombre,
                                   Identificación = c.Identificaciones.Iniciales + "-" + c.NroDocIdent,
                                   Teléfonos = c.NroTelefonico,
                                   País = c.Paises.Pais,
                                   Distrito = c.Distritos.UBIGEO + "-" + c.Distritos.Distrito
                                 }).ToList();
            DgvClientes.DataSource = dataset;
            DgvClientes.Columns["ID"].Visible = false;
            DgvClientes.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
        }

        private void CargarCombos()
        {
            CmbTipoIDCliente.DataSource = context.Identificaciones.ToList();
            CmbTipoIDCliente.DisplayMember = "Identificacion";
            CmbTipoIDCliente.ValueMember = "IdentificacionID";

            CmbDepartamento.DataSource = context.Departamentos.ToList();
            CmbDepartamento.DisplayMember = "Departamento";
            CmbDepartamento.ValueMember = "DepartamentoID";
        }

        private void ClearCrt()
        {
            CmbTipoIDCliente.SelectedIndex = -1;
            CmbTipoIDCliente.Tag = null;
            TxtNroIDCliente.Text = "";
            TxtNombreCliente.Text = "";
            TxtDireccionCliente.Text = "";
            CmbDistrito.SelectedIndex = -1;
            CmbProvincia.SelectedIndex = -1;
            CmbDepartamento.SelectedIndex = -1;
            TxtNroTelefonicoCliente.Text = "";
            TxtCorreoElectronicoCliente.Text = "";
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
        }

        private void MoverRegistroToCrt(long ID)
        {
            var cli = (from c in context.Clientes
                       where c.ClienteID == ID
                       select c).First();
            CmbTipoIDCliente.SelectedValue = cli.IdentificacionID;
            CmbTipoIDCliente.Tag = ID;
            TxtNroIDCliente.Text = cli.NroDocIdent;
            TxtNombreCliente.Text = cli.Nombre;
            TxtDireccionCliente.Text = cli.Direccion ?? "";
            TxtNroTelefonicoCliente.Text = cli.NroTelefonico ?? "";
            TxtCorreoElectronicoCliente.Text = cli.CorreoElectronico ?? "";
            CmbDepartamento.SelectedValue = cli.Distritos.Provincias.DepartamentoID;
            CmbProvincia.SelectedValue = cli.Distritos.Provincias.ProvinciaID;
            CmbDistrito.SelectedValue = cli.DistritoID;
            TssLblAgregado.Text = cli.EmpleadoAdd.Login.ToLower() + " " + cli.AgregadoEl;
            if (cli.EmpleadoUpd != null)
                TssLblModificado.Text = (cli.EmpleadoUpd.Login.ToLower() + " " + cli.ModificadoEl) ?? "";
            else
                TssLblModificado.Text = "";
        }

        private void Eliminar()
        {
            if (CmbTipoIDCliente.Tag == null) return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(CmbTipoIDCliente.Tag.ToString());
                var cli = context.Clientes.Single(c => c.ClienteID == ID);
                context.Clientes.Attach(cli);
                context.Clientes.Remove(cli);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                    Global.MensajeErrorBd(ex, "Error eliminando cliente.");
                else
                    Global.MensajeError(ex, "Error eliminando cliente.");
                return;
            }
            SetStatus("Cliente eliminado.");
            ClearCrt();
            CargaClientes();
            Cursor.Current = Cursors.Default;
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if(CmbTipoIDCliente.Tag == null)
            {
                try
                {
                    context.Clientes.Add(
                        new Clientes{
                                        IdentificacionID = ((Identificaciones)CmbTipoIDCliente.SelectedItem).IdentificacionID,
                                        NroDocIdent = TxtNroIDCliente.Text,
                                        Nombre = TxtNombreCliente.Text,
                                        Direccion = TxtDireccionCliente.Text.Trim() == "" ? null : TxtDireccionCliente.Text.Trim(),
                                        PaisID = ((Departamentos)CmbDepartamento.SelectedItem).PaisID,
                                        DistritoID = ((Distritos)CmbDistrito.SelectedItem).DistritoID,
                                        NroTelefonico = TxtNroTelefonicoCliente.Text.Trim() == "" ? null : TxtNroTelefonicoCliente.Text.Trim(),
                                        CorreoElectronico = TxtCorreoElectronicoCliente.Text.Trim() == "" ? null : TxtCorreoElectronicoCliente.Text.Trim(),
                                        Activo = 1,
                                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                                        AgregadoPor = Global.Usuario.UsuarioID
                                    }
                                        );
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error guardando datos del cliente.");
                    else
                        Global.MensajeError(ex, "Error guardando datos del cliente.");
                    return;
                }
                SetStatus("Cliente agregado.");
            } //(CmbTipoIDCliente.Tag == null)
            else //(CmbTipoIDCliente.Tag != null)
            {
                try
                {
                    long ID = long.Parse(CmbTipoIDCliente.Tag.ToString());
                    var cli = context.Clientes.Single(c => c.ClienteID == ID);
                    context.Clientes.Attach(cli);
                    cli.IdentificacionID = ((Identificaciones)CmbTipoIDCliente.SelectedItem).IdentificacionID;
                    cli.NroDocIdent = TxtNroIDCliente.Text;
                    cli.Nombre = TxtNombreCliente.Text;
                    cli.Direccion = TxtDireccionCliente.Text.Trim() == "" ? null : TxtDireccionCliente.Text.Trim();
                    cli.PaisID = ((Departamentos)CmbDepartamento.SelectedItem).PaisID;
                    cli.DistritoID = ((Distritos)CmbDistrito.SelectedItem).DistritoID;
                    cli.NroTelefonico = TxtNroTelefonicoCliente.Text.Trim() == "" ? null : TxtNroTelefonicoCliente.Text.Trim();
                    cli.CorreoElectronico = TxtCorreoElectronicoCliente.Text.Trim() == "" ? null : TxtCorreoElectronicoCliente.Text.Trim();
                    cli.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    cli.ModificadoPor = Global.Usuario.UsuarioID;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex is System.Data.Entity.Validation.DbEntityValidationException)
                        Global.MensajeErrorBd(ex, "Error modificando datos del cliente.");
                    else
                        Global.MensajeError(ex, "Error modificando datos del cliente.");
                    return;
                }
                SetStatus("Cliente modificado.");
            }; //(CmbTipoIDCliente.Tag != null)
            ClearCrt();
            CargaClientes();
            Cursor.Current = Cursors.Default;
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
            if (CmbTipoIDCliente.SelectedIndex == -1)
            {
                CmbTipoIDCliente.Focus();
                MessageBox.Show("Debe seleccionar el tipo de documento de identificación del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNroIDCliente.Text.Trim().Length == 0)
            {
                TxtNroIDCliente.Focus();
                MessageBox.Show("Debe transcribir el número de documento de identificación del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtNombreCliente.Text.Trim().Length == 0)
            {
                TxtNombreCliente.Focus();
                MessageBox.Show("Debe transcribir el nombre comercial del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbDistrito.SelectedIndex == -1)
            {
                CmbDistrito.Focus();
                MessageBox.Show("Debe seleccionar la ubicación (UBIGEO) del cliente.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void CmbID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Codigo + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }

        private void CmbDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Departamentos)e.ListItem).UBIGEO + "-" + ((Departamentos)e.ListItem).Departamento;
        }

        private void CmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbDepartamento.SelectedIndex == -1) return;
            CmbProvincia.DataSource = (from p in context.Provincias where p.DepartamentoID == ((Departamentos)(CmbDepartamento.SelectedItem)).DepartamentoID select p).ToList();
            CmbProvincia.DisplayMember = "Provincia";
            CmbProvincia.ValueMember = "ProvinciaID";
        }

        private void CmbProvincia_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Provincias)e.ListItem).UBIGEO.Substring(2, 2) + "-" + ((Provincias)e.ListItem).Provincia;
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

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargaClientes();
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

        private void DgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MoverRegistroToCrt(long.Parse(DgvClientes["ID", e.RowIndex].Value.ToString()));
            TabClientes.SelectTab("TabEditar");
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

        private void CmbProvincia_Enter(object sender, EventArgs e)
        {
            CmbProvincia.BringToFront();
            CmbProvincia.Width = CMB_ANCHO_MAXIMO;
        }

        private void CmbProvincia_Leave(object sender, EventArgs e)
        {
            CmbProvincia.Width = CMB_ANCHO_MINIMO;
        }
    }
}
