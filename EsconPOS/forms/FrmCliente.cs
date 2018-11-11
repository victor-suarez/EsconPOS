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

            CmbDepartamento.DataSource = context.Departamentos.ToList();
            CmbDepartamento.DisplayMember = "Departamento";
            CmbDepartamento.ValueMember = "Departamento";
        }

        private void ClearCrt()
        {
            CmbTipoIDCliente.SelectedIndex = -1;
            CmbTipoIDCliente.Tag = null;
            TxtNroIDCliente.Text = "";
            TxtNombreCliente.Text = "";
            TxtDireccionCliente.Text = "";
            CmbDistrito.SelectedIndex = -1;
            TxtNroTelefonicoCliente.Text = "";
            TxtCorreoElectronicoCliente.Text = "";
        }

        private void Eliminar()
        {

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
                    if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                    {
                        MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando datos del cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                      .SelectMany(x => x.ValidationErrors)
                                                                                                      .Select(x => x.ErrorMessage);
                        var fullErrorMessage = string.Join("; ", DbErrors);
                        var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                        MessageBox.Show(exceptionMessage, "Error guardando datos del cliente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                    return;
                }
            } //(CmbTipoIDCliente.Tag == null)
            else //(CmbTipoIDCliente.Tag != null)
            {

            }; //(CmbTipoIDCliente.Tag != null)

            //Buscar el cliente que acaba de agregar
            var cli = (from c in context.Clientes
                       where c.IdentificacionID == ((Identificaciones)CmbTipoIDCliente.SelectedItem).IdentificacionID
                       && c.NroDocIdent == TxtNroIDCliente.Text
                       select c).First();
            try
            {
                //Buscar la empresa en Global y agregarle el cliente
                var empr = (from e in context.Empresas
                            where e.EmpresaID == Global.Empresa.EmpresaID
                            select e).First();
                if (empr != null)
                    empr.Clientes.Add(cli);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                if (((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors.Count() == 0)
                {
                    MessageBox.Show(ex.Source + "\r\n" + ex.Message, "Error guardando la relación cliente - empresa.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var DbErrors = ((System.Data.Entity.Validation.DbEntityValidationException)ex).EntityValidationErrors
                                                                                                  .SelectMany(x => x.ValidationErrors)
                                                                                                  .Select(x => x.ErrorMessage);
                    var fullErrorMessage = string.Join("; ", DbErrors);
                    var exceptionMessage = string.Concat(ex.Message, "\n\rErrores de validación en la base de datos: \n\r", fullErrorMessage);
                    MessageBox.Show(exceptionMessage, "Error guardando la relación cliente - empresa.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                return;
            }

            ClearCrt();
            Cursor.Current = Cursors.Default;
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

        private void FrmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CargarCombos();
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
