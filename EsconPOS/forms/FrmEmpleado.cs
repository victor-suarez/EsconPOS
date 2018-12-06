using EsconPOS.classes;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Dynamic;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmEmpleado : Form
    {
        #region Variables y constantes

        private mainEntities context = new mainEntities();

        #endregion Variables y constantes

        #region Funciones

        private void CargarCombos()
        {
            CmbTipoIDEmpleado.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbTipoIDEmpleado.DisplayMember = "Identificacion";
            CmbTipoIDEmpleado.ValueMember = "IdentificacionID";

            CmbFiltroTipoID.DataSource = context.Identificaciones.OrderBy("Codigo").ToList();
            CmbFiltroTipoID.DisplayMember = "Iniciales";
            CmbFiltroTipoID.ValueMember = "IdentificacionID";
        }

        private void CargarEmpleados(string OrderBy = "Nombres")
        {
            string FiltroTipoID = CmbFiltroTipoID.Text;
            string FiltroNroID = TxtFiltroNroID.Text.Trim();
            string FiltroNombre = TxtFiltroNombre.Text.Trim();
            string FiltroNroTelefonico = TxtFilterNroTelefonico.Text.Trim();
            DgvEmpleados.DataSource = context.Empleados
                                        .Where(e => e.EmpleadoID > 0)
                                        .Select(e => new
                                        {
                                            ID = e.EmpleadoID,
                                            Nombres = e.Nombre,
                                            Identificación = e.Identificaciones.Iniciales + "-" + e.NroDocIdent,
                                            Teléfonos = e.Telefono
                                        })
                                        .Where(e => (e.Identificación.StartsWith(FiltroTipoID) || FiltroTipoID == "")
                                                    &&
                                                    (e.Identificación.Contains(FiltroNroID) || FiltroNroID == "")
                                                    &&
                                                    (e.Nombres.Contains(FiltroNombre) || FiltroNombre == "")
                                                    &&
                                                    (e.Teléfonos.Contains(FiltroNroTelefonico) || FiltroNroTelefonico == "")
                                            )
                                        .OrderBy(OrderBy)
                                        .ToList();
            DgvEmpleados.Columns["ID"].Visible = false;
            DgvEmpleados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void ClearCrt()
        {
            CmbTipoIDEmpleado.SelectedIndex = -1;
            TxtNroIDEmpleado.Text = "";
            TxtNombreEmpleado.Text = "";
            TxtDireccionEmpleado.Text = "";
            TxtTelefonoEmpleado.Text = "";
            TxtCorreoElectronicoEmpleado.Text = "";
            ChkEsSupervisor.Checked = false;
            TxtUsuario.Text = "";
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
        }

        private void Eliminar()
        {
            if (CmbTipoIDEmpleado.Tag == null) return;
            if (MessageBox.Show("¿Seguro desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                long ID = long.Parse(CmbTipoIDEmpleado.Tag.ToString());
                var emp = context.Empleados.Single(e => e.EmpleadoID == ID);
                context.Empleados.Attach(emp);
                context.Empleados.Remove(emp);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Global.MensajeError(ex, "Error eliminando empleado.");
                return;
            }
            SetStatus("Empleado eliminado.");
            ClearCrt();
            CargarEmpleados();
            Cursor.Current = Cursors.Default;
        }

        private void Guardar()
        {
            if (!ValEntReq()) return;
            Cursor.Current = Cursors.WaitCursor;
            if (CmbTipoIDEmpleado.Tag == null)
            {
                try
                {
                    var empl = new Empleados
                    {
                        IdentificacionID = ((Identificaciones)CmbTipoIDEmpleado.SelectedItem).IdentificacionID,
                        NroDocIdent = TxtNroIDEmpleado.Text,
                        Nombre = TxtNombreEmpleado.Text,
                        Direccion = TxtDireccionEmpleado.Text.Trim() == "" ? null : TxtDireccionEmpleado.Text.Trim(),
                        Telefono = TxtTelefonoEmpleado.Text.Trim() == "" ? null : TxtTelefonoEmpleado.Text.Trim(),
                        CorreoElectronico = TxtCorreoElectronicoEmpleado.Text.Trim() == "" ? null : TxtCorreoElectronicoEmpleado.Text.Trim(),
                        Login = TxtUsuario.Text.Trim(),
                        PasswdHash = "",
                        EsSupervisor = ChkEsSupervisor.Checked ? 1 : 0,
                        EsAdministrador = 0,
                        Activo = 1,
                        AgregadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                        AgregadoPor = Global.glUsuario
                    };
                    context.Empleados.Add(empl);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error guardando datos del empleado.");
                    return;
                }
                SetStatus("Empleado agregado.");
            } //(.Tag == null)
            else //(.Tag != null)
            {
                try
                {
                    long ID = long.Parse(CmbTipoIDEmpleado.Tag.ToString());
                    var emp = context.Empleados.Single(e => e.EmpleadoID == ID);
                    context.Empleados.Attach(emp);

                    emp.IdentificacionID = ((Identificaciones)CmbTipoIDEmpleado.SelectedItem).IdentificacionID;
                    emp.NroDocIdent = TxtNroIDEmpleado.Text;
                    emp.Nombre = TxtNombreEmpleado.Text;
                    emp.Direccion = TxtDireccionEmpleado.Text.Trim() == "" ? null : TxtDireccionEmpleado.Text.Trim();
                    emp.Telefono = TxtTelefonoEmpleado.Text.Trim() == "" ? null : TxtTelefonoEmpleado.Text.Trim();
                    emp.CorreoElectronico = TxtCorreoElectronicoEmpleado.Text.Trim() == "" ? null : TxtCorreoElectronicoEmpleado.Text.Trim();
                    emp.EsSupervisor = ChkEsSupervisor.Checked ? 1 : 0;
                    emp.Login = TxtUsuario.Text.Trim();
                    emp.ModificadoEl = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    emp.ModificadoPor = Global.glUsuario;
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Global.MensajeError(ex, "Error modificando datos del empleado.");
                    return;
                }
                SetStatus("Empleado modificado.");
            }; //(.Tag != null)
            ClearCrt();
            CargarEmpleados();
            Cursor.Current = Cursors.Default;
        }

        private void IncluirBtnClear(TextBox txt)
        {
            var btn = new Button();
            btn.AutoSize = false;
            btn.Size = new Size(25, txt.ClientSize.Height + 2);
            btn.Location = new Point(txt.ClientSize.Width - btn.Width, -1);
            btn.Cursor = Cursors.Default;
            btn.Image = Properties.Resources.ClearTxt;
            btn.Click += btn_Click;
            //btn.Visible = false;
            txt.Controls.Add(btn);
        }

        private void MoverRegistroToCrt(long ID)
        {
            var emp = (from e in context.Empleados
                       where e.EmpleadoID == ID
                       select e).First();

            CmbTipoIDEmpleado.SelectedValue = emp.IdentificacionID;
            CmbTipoIDEmpleado.Tag = ID;
            TxtNroIDEmpleado.Text = emp.NroDocIdent;
            TxtNombreEmpleado.Text = emp.Nombre;
            TxtDireccionEmpleado.Text = emp.Direccion ?? "";
            TxtTelefonoEmpleado.Text = emp.Telefono ?? "";
            TxtCorreoElectronicoEmpleado.Text = emp.CorreoElectronico ?? "";
            ChkEsSupervisor.Checked = (emp.EsSupervisor == 1);
            TxtUsuario.Text = emp.Login;
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
            if (TxtNombreEmpleado.Text.Trim().Length == 0)
            {
                TxtNombreEmpleado.Focus();
                MessageBox.Show("Debe transcribir el nombre del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (TxtUsuario.Text.Trim().Length == 0)
            {
                TxtUsuario.Focus();
                MessageBox.Show("Debe transcribir el nombre de usuario del empleado.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        #endregion Funciones

        #region Métodos

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ((TextBox)((Button)sender).Parent).Clear();
        }

        private void Chk_KeyPress(object sender, KeyPressEventArgs e)
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
                SelectNextControl((ComboBox)sender, true, true, true, false);
            }
        }

        private void CmbID_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Identificaciones)e.ListItem).Codigo + "-" + ((Identificaciones)e.ListItem).Identificacion;
        }

        private void DgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            MoverRegistroToCrt(long.Parse(DgvEmpleados["ID", e.RowIndex].Value.ToString()));
            TabEmpleados.SelectTab("TabEditar");
        }

        private void DgvEmpleados_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarEmpleados(((DataGridView)sender).Columns[e.ColumnIndex].HeaderText);
        }

        private void FrmEmpleado_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
            context.Dispose();
        }

        private void FrmEmpleado_Load(object sender, EventArgs e)
        {
            CargarCombos();
            CargarEmpleados();
            TssLblAgregado.Text = "";
            TssLblModificado.Text = "";
            Left = 10;
            Top = 10;
            IncluirBtnClear(TxtFiltroNroID);
            IncluirBtnClear(TxtFiltroNombre);
            IncluirBtnClear(TxtFilterNroTelefonico);
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

        #endregion Métodos
    }
}