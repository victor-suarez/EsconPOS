using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmEmpresa : Form
    {
        #region Variables y constantes

        private const int CMB_ANCHO_MAXIMO = 340;
        private const int CMB_ANCHO_MINIMO = 40;
        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarCombos()
        {
            CmbTipoIDEmpresa.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDEmpresa.DisplayMember = "Identificacion";
            CmbTipoIDEmpresa.ValueMember = "IdentificacionID";

            CmbDepartamento.DataSource = context.Departamentos.OrderBy("Codigo").ToList();
            CmbDepartamento.DisplayMember = "Departamento";
            CmbDepartamento.ValueMember = "DepartamentoID";
        }

        private void CargarEmpresas(string OrderBy = "NombreComercial")
        {
            string FiltroTipoID = CmbFiltroTipoID.SelectedIndex == -1 ? "" : CmbFiltroTipoID.Text.Substring(0, CmbFiltroTipoID.Text.IndexOf("-"));
            string FiltroNroID = TxtFiltroNroID.Text.Trim();
            string FiltroNombre = TxtFiltroNombre.Text.Trim();

            DgvEmpresas.DataSource = context.Empresas
                                        .Select(e => new
                                        {
                                            ID = e.EmpresaID,
                                            NombreComercial = e.NombreComercial,
                                            Identificación = e.Identificaciones.Iniciales + "-" + e.NroDocIdent,
                                            Teléfonos = e.NroTelefonico,
                                            Distrito = e.Distritos.UBIGEO + "-" + e.Distritos.Distrito
                                        })
                                        .Where(e =>
                                                (e.Identificación.StartsWith(FiltroTipoID) || FiltroTipoID == "")
                                                &&
                                                (e.Identificación.Contains(FiltroNroID) || FiltroNroID == "")
                                                &&
                                                (e.NombreComercial.Contains(FiltroNombre) || FiltroNombre == "")
                                              )
                                        .OrderBy(OrderBy)
                                        .ToList();
            DgvEmpresas.Columns["ID"].Visible = false;
            DgvEmpresas.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            CmbTipoIDEmpresa.SelectedIndex = -1;
            CmbTipoIDEmpresa.Tag = null;
            TxtNroIDEmpresa.Text = "";
            TxtNombreComercial.Text = "";
            TxtRazonSocial.Text = "";
            TxtDireccionEmpresa.Text = "";
            TxtUrbanizacion.Text = "";
            CmbDistrito.SelectedIndex = -1;
            CmbProvincia.SelectedIndex = -1;
            CmbDepartamento.SelectedIndex = -1;
            TxtNroTelefonicoEmpresa.Text = "";
            TxtCorreoElectronicoEmpresa.Text = "";
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
        }

        private void Eliminar()
        {
            if (CmbTipoIDEmpresa.Tag == null) return;
            if (MessageBox.Show("¿Seguro desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(CmbTipoIDEmpresa.Tag.ToString());
                var emp = context.Empresas.Single(e => e.EmpresaID == ID);
                context.Empresas.Attach(emp);
                context.Empresas.Remove(emp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando empresa.");
                return;
            }
            SetStatus("Empresa eliminada.");
            ClearCrt();
            CargarEmpresas();
            Cursor.Current = Cursors.Default;
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if (CmbTipoIDEmpresa.Tag == null)
            {
                try
                {
                    var empr = new Empresas
                    {
                        IdentificacionID = ((Identificaciones)CmbTipoIDEmpresa.SelectedItem).IdentificacionID,
                        NroDocIdent = TxtNroIDEmpresa.Text,
                        NombreComercial = TxtNombreComercial.Text,
                        RazonSocial = TxtRazonSocial.Text,
                        Direccion = TxtDireccionEmpresa.Text.Trim() == "" ? null : TxtDireccionEmpresa.Text.Trim(),
                        DistritoID = ((Distritos)CmbDistrito.SelectedItem).DistritoID,
                        Urbanizacion = TxtUrbanizacion.Text.Trim() == "" ? null : TxtUrbanizacion.Text.Trim(),
                        NroTelefonico = TxtNroTelefonicoEmpresa.Text.Trim() == "" ? null : TxtNroTelefonicoEmpresa.Text.Trim(),
                        CorreoElectronico = TxtCorreoElectronicoEmpresa.Text.Trim() == "" ? null : TxtCorreoElectronicoEmpresa.Text.Trim(),
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = Global.glUsuario
                    };
                    context.Empresas.Add(empr);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos de la empresa.");
                    return;
                }
                SetStatus("Empresa agregada.");
            } //(CmbTipoIDCliente.Tag == null)
            else //(CmbTipoIDCliente.Tag != null)
            {
                try
                {
                    long ID = long.Parse(CmbTipoIDEmpresa.Tag.ToString());
                    var emp = context.Empresas.Single(e => e.EmpresaID == ID);
                    context.Empresas.Attach(emp);
                    emp.IdentificacionID = ((Identificaciones)CmbTipoIDEmpresa.SelectedItem).IdentificacionID;
                    emp.NroDocIdent = TxtNroIDEmpresa.Text;
                    emp.NombreComercial = TxtNombreComercial.Text;
                    emp.RazonSocial = TxtRazonSocial.Text;
                    emp.Direccion = TxtDireccionEmpresa.Text.Trim() == "" ? null : TxtDireccionEmpresa.Text.Trim();
                    emp.DistritoID = ((Distritos)CmbDistrito.SelectedItem).DistritoID;
                    emp.Urbanizacion = TxtUrbanizacion.Text.Trim() == "" ? null : TxtUrbanizacion.Text.Trim();
                    emp.NroTelefonico = TxtNroTelefonicoEmpresa.Text.Trim() == "" ? null : TxtNroTelefonicoEmpresa.Text.Trim();
                    emp.CorreoElectronico = TxtCorreoElectronicoEmpresa.Text.Trim() == "" ? null : TxtCorreoElectronicoEmpresa.Text.Trim();
                    emp.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    emp.ModificadoPor = Global.glUsuario;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos de la empresa.");
                    return;
                }
                SetStatus("Empresa modificada.");
            }; //(CmbTipoIDCliente.Tag != null)
            ClearCrt();
            CargarEmpresas();
            Cursor.Current = Cursors.Default;
        }

        private void MoverRegistroToCrt(long ID)
        {
            var emp = (from e in context.Empresas
                       where e.EmpresaID == ID
                       select e).First();
            CmbTipoIDEmpresa.SelectedValue = emp.IdentificacionID;
            CmbTipoIDEmpresa.Tag = ID;
            TxtNroIDEmpresa.Text = emp.NroDocIdent;
            TxtNombreComercial.Text = emp.NombreComercial;
            TxtRazonSocial.Text = emp.RazonSocial;
            TxtDireccionEmpresa.Text = emp.Direccion ?? "";
            TxtUrbanizacion.Text = emp.Urbanizacion ?? ""; ;
            CmbDepartamento.SelectedValue = emp.Distritos.Provincias.DepartamentoID;
            CmbProvincia.SelectedValue = emp.Distritos.Provincias.ProvinciaID;
            CmbDistrito.SelectedValue = emp.DistritoID;
            TxtNroTelefonicoEmpresa.Text = emp.NroTelefonico ?? "";
            TxtCorreoElectronicoEmpresa.Text = emp.CorreoElectronico ?? "";
            TssLblAgregado.Text = emp.EmpleadoAdd.Login.ToLower() + " " + emp.AgregadoEl;
            if (emp.EmpleadoUpd != null)
                TssLblModificado.Text = (emp.EmpleadoUpd.Login.ToLower() + " " + emp.ModificadoEl) ?? "";
            else
                TssLblModificado.Text = "";
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
                TxtNombreComercial.Focus();
                MessageBox.Show("Debe transcribir el nombre comercial de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtRazonSocial.Text.Trim().Length == 0)
            {
                TxtRazonSocial.Focus();
                MessageBox.Show("Debe transcribir la razón social de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (CmbDistrito.SelectedIndex == -1)
            {
                CmbDistrito.Focus();
                MessageBox.Show("Debe seleccionar la ubicación (UBIGEO) de la empresa.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void Cmb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }

        private void Cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        private void CmbDepartamento_Enter(object sender, EventArgs e)
        {
            CmbDepartamento.BringToFront();
            CmbDepartamento.Width = CMB_ANCHO_MAXIMO;
        }

        private void CmbDepartamento_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Departamentos)e.ListItem).UBIGEO + "-" + ((Departamentos)e.ListItem).Departamento;
        }

        private void CmbDepartamento_Leave(object sender, EventArgs e)
        {
            CmbDepartamento.Width = CMB_ANCHO_MINIMO;
        }

        private void CmbDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CmbDepartamento.SelectedIndex == -1) return;
            CmbProvincia.DataSource = (from p in context.Provincias where p.DepartamentoID == ((Departamentos)(CmbDepartamento.SelectedItem)).DepartamentoID select p).OrderBy("UBIGEO").ToList();
            CmbProvincia.DisplayMember = "Provincia";
            CmbProvincia.ValueMember = "ProvinciaID";
        }

        private void CmbDistrito_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Distritos)e.ListItem).UBIGEO.Substring(4, 2) + "-" + ((Distritos)e.ListItem).Distrito;
        }

        private void CmbID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Codigo + "-" + ((Identificaciones)e.ListItem).Identificacion;
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
            if (CmbProvincia.SelectedIndex == -1) return;
            CmbDistrito.DataSource = (from d in context.Distritos where d.ProvinciaID == ((Provincias)(CmbProvincia.SelectedItem)).ProvinciaID select d).OrderBy("UBIGEO").ToList();
            CmbDistrito.DisplayMember = "Distrito";
            CmbDistrito.ValueMember = "DistritoID";
        }

        private void DgvEmpresas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvEmpresas["ID", e.RowIndex].Value.ToString()));
            TabEmpresas.SelectTab("TabEditar");
        }

        private void FrmEmpresa_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEmpresas();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
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

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                e.Handled = true;
                SelectNextControl((TextBox)sender, true, true, true, false);
                //if(((TextBox)sender).Name == "TxtCorreoElectronicoCliente") RibBtnGuardar.
            }
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            CargarEmpresas();
        }

        #endregion Métodos
    }
}