using EsconPOS.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class MDIEsconPos : Form
    {
        #region Mdi Childs Forms List

        private static int ChildCont = 1;
        private List<Form> ChildFormList = new List<Form>();

        #endregion Mdi Childs Forms List

        #region Variables privadas

        private static bool CajaAbierta = false;
        private mainEntities context = new mainEntities();
        private FrmBanco FrmBco = null;
        private FrmClase FrmCla = null;
        private FrmCliente FrmCli = null;
        private FrmEmpleado FrmEmp = null;
        private FrmEmpresa FrmEpr = null;
        private FrmFormasPago FrmFpg = null;
        private FrmMarca FrmMar = null;
        private FrmMoneda FrmMon = null;
        private FrmContrasenia FrmPas = null;
        private FrmPuntoDeVenta FrmPos = null;
        private FrmProducto FrmPro = null;
        private FrmImpuesto FrmTax = null;
        private FrmUnidadMedida FrmUnd = null;
        private bool IsClosing = false;

        #endregion Variables privadas

        #region Funciones privadas

        public void SetStatus(string StrStatus = "", bool Error = false)
        {
            if (Error)
                TsslStatus.ForeColor = Color.Red;
            else
                TsslStatus.ForeColor = SystemColors.ControlText;
            TsslStatus.Text = StrStatus;
        }

        private void AbrirCerrarCaja()
        {
            Cursor.Current = Cursors.WaitCursor;
            CajaAbierta = !CajaAbierta;

            context.CajaLog.Add(
                new CajaLog
                {
                    CajaID = Global.glCaja,
                    TransaccionID = CajaAbierta ? 1 : 4, // APERTURA, CIERRE
                    EmpleadoID = Global.glEmpleado,
                    Monto = 0,
                    Fecha = DateTime.Now.ToString("yyyy-MM-dd"),
                    Hora = DateTime.Now.ToString("HH:mm:ss")
                }
            );
            var pos = context.Cajas.Single(p => p.CajaID == Global.glCaja);
            context.Cajas.Attach(pos);
            pos.Abierta = CajaAbierta ? 1 : 0;
            pos.FechaHoraEstado = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            context.SaveChanges();
            TssbPpalCaja.Image = CajaAbierta ? Properties.Resources.CajaAbierta : Properties.Resources.CajaCerrada;
            TssbPpalCaja.Text = CajaAbierta ? "Cerrar &Caja" : "Abrir &Caja";
            TsmiCajaIncluirFactura.Visible = CajaAbierta;
            TsmiCajaAbrirCuenta.Visible = CajaAbierta;
            Cursor.Current = Cursors.Default;
        }

        private void IniciarBotones()
        {
            TssbPpalCaja.Visible = true;
            TssbPpalAdministrar.Visible = true;
            if (Global.glEsAdministrador)
            {
                TssbPpalUbicacion.Visible = true;
                TssbPpalSunat.Visible = true;
                TssbPpalProductos.Visible = true;
            }
        }

        private void IniciarInfo()
        {
            this.Text = "EsconPOS V:" +
                        System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Major.ToString() + "." +
                        System.Reflection.Assembly.GetEntryAssembly().GetName().Version.MajorRevision.ToString() + "." +
                        System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Minor.ToString() +
                       " - " + Global.glNomEmpresa;
            TsslCaja.Text = Global.glNomCaja;
            TsslEmpleado.Text = Global.glNomEmpleado;
            TsslFecha.Text = DateTime.Now.ToLongDateString();
            TsslHora.Text = DateTime.Now.ToShortTimeString();
            TmrHora.Start();
        }

        #endregion Funciones privadas

        #region Propiedades y métodos

        public MDIEsconPos()
        {
            InitializeComponent();
        }

        private void MDIEsconPos_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsClosing = true;
            if (CajaAbierta) AbrirCerrarCaja();
        }

        private void MDIEsconPos_Load(object sender, EventArgs e)
        {
            IniciarInfo();
        }

        private void MDIEsconPos_Shown(object sender, EventArgs e)
        {
            // Verificar permimsos????
            if (!Global.CambiarContrasenia)
                IniciarBotones();
            else
            {
                FrmPas = new FrmContrasenia();
                //FrmPas.MdiParent = this;
                if (FrmPas.ShowDialog() == DialogResult.OK)
                {
                    IniciarBotones();
                    SetStatus(FrmPas.MensajeRespuesta);
                }
                else
                    SetStatus(FrmPas.MensajeRespuesta, true);
            }
        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            TsslFecha.Text = DateTime.Now.ToLongDateString();
            TsslHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void TsmiAdminClientes_Click(object sender, EventArgs e)
        {
            if (FrmCli != null && !FrmCli.IsDisposed)
            {
                FrmCli.BringToFront();
                return;
            }
            FrmCli = new forms.FrmCliente();
            FrmCli.MdiParent = this;
            FrmCli.Show();
        }

        private void TsmiAdminEmpleados_Click(object sender, EventArgs e)
        {
            if (FrmEmp != null && !FrmEmp.IsDisposed)
            {
                FrmEmp.BringToFront();
                return;
            }
            FrmEmp = new forms.FrmEmpleado();
            FrmEmp.MdiParent = this;
            FrmEmp.Show();
        }

        private void TsmiAdminEmpresas_Click(object sender, EventArgs e)
        {
            if (FrmEpr != null && !FrmEpr.IsDisposed)
            {
                FrmEpr.BringToFront();
                return;
            }
            FrmEpr = new forms.FrmEmpresa();
            FrmEpr.MdiParent = this;
            FrmEpr.Show();
        }

        private void TsmiAdminFormasPago_Click(object sender, EventArgs e)
        {
            if (FrmFpg != null && !FrmFpg.IsDisposed)
            {
                FrmFpg.BringToFront();
                return;
            }
            FrmFpg = new forms.FrmFormasPago();
            FrmFpg.MdiParent = this;
            FrmFpg.Show();
        }

        private void TsmiAdminMiContrasenia_Click(object sender, EventArgs e)
        {
            if (FrmPas != null && !FrmPas.IsDisposed)
            {
                FrmPas.BringToFront();
                return;
            }
            FrmPas = new forms.FrmContrasenia();
            FrmPas.MdiParent = this;
            FrmPas.Show();
            FrmPas.StartPosition = FormStartPosition.CenterParent;
        }

        private void TsmiCajaIncluirFactura_Click(object sender, EventArgs e)
        {
            if (FrmPos != null && !FrmPos.IsDisposed)
            {
                FrmPos.BringToFront();
                return;
            }
            FrmPos = new forms.FrmPuntoDeVenta();
            FrmPos.MdiParent = this;
            FrmPos.Show();
            //ToolStripManager.Merge(FrmPos.toolStrip, this.toolStrip);
        }

        private void TsmiProdClases_Click(object sender, EventArgs e)
        {
            if (FrmCla != null && !FrmCla.IsDisposed)
            {
                FrmCla.BringToFront();
                return;
            }
            FrmCla = new forms.FrmClase();
            FrmCla.MdiParent = this;
            FrmCla.Show();
        }

        private void TsmiProdMarcas_Click(object sender, EventArgs e)
        {
            if (FrmMar != null && !FrmMar.IsDisposed)
            {
                FrmMar.BringToFront();
                return;
            }
            FrmMar = new forms.FrmMarca();
            FrmMar.MdiParent = this;
            FrmMar.Show();
        }

        private void TsmiProdServicios_Click(object sender, EventArgs e)
        {
            if (FrmPro != null && !FrmPro.IsDisposed)
            {
                FrmPro.BringToFront();
                return;
            }
            FrmPro = new forms.FrmProducto();
            FrmPro.MdiParent = this;
            FrmPro.Show();
        }

        private void TsmiSunatBancos_Click(object sender, EventArgs e)
        {
            if (FrmBco != null && !FrmBco.IsDisposed)
            {
                FrmBco.BringToFront();
                return;
            }
            FrmBco = new forms.FrmBanco();
            FrmBco.MdiParent = this;
            FrmBco.Show();
        }

        private void TsmiSunatImpuestos_Click(object sender, EventArgs e)
        {
            if (FrmTax != null && !FrmTax.IsDisposed)
            {
                FrmTax.BringToFront();
                return;
            }
            FrmTax = new forms.FrmImpuesto();
            FrmTax.MdiParent = this;
            FrmTax.Show();
        }

        private void TsmiSunatMonedas_Click(object sender, EventArgs e)
        {
            if (FrmMon != null && !FrmMon.IsDisposed)
            {
                FrmMon.BringToFront();
                return;
            }
            FrmMon = new forms.FrmMoneda();
            FrmMon.MdiParent = this;
            FrmMon.Show();
        }

        private void TsmiSunatUnidadesMedida_Click(object sender, EventArgs e)
        {
            if (FrmUnd != null && !FrmUnd.IsDisposed)
            {
                FrmUnd.BringToFront();
                return;
            }
            FrmUnd = new forms.FrmUnidadMedida();
            FrmUnd.MdiParent = this;
            FrmUnd.Show();
        }

        private void TsmiWindowCierraTodas_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in this.MdiChildren)
            {
                ChildForm.Close();
            }
        }

        private void TsmiWindowHorizontal_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TsmiWindowMinimizarTodas_Click(object sender, EventArgs e)
        {
            foreach (Form ChildForm in this.MdiChildren)
            {
                ChildForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void TsmiWindowVertical_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void Tssb_ButtonClick(object sender, EventArgs e)
        {
            if (((ToolStripSplitButton)sender).Name == "TssbPpalCaja")
            {
                AbrirCerrarCaja();
            }
            ((ToolStripSplitButton)sender).ShowDropDown();
        }

        private void TssbSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cerrar el sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void TssbWindowCascada_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        #endregion Propiedades y métodos

        private void AddItemToWindowList(Form f)
        {
            ToolStripItem item = TssbPpalWindow.DropDownItems.Add(ChildCont++.ToString("##") + " " + f.Text);
            item.Tag = f;
            item.Click += TssbChildFormList_Click;
            f.Activate();
        }

        private void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            Form f = (Form)sender;
            RemoveItemFromWindowList(f);
        }

        private void MDIEsconPos_MdiChildActivate(object sender, EventArgs e)
        {
            Form f = this.ActiveMdiChild;

            if (f == null)
            {
                //the last child form was just closed
                return;
            }

            if (!ChildFormList.Contains(f))
            {
                //a new child form was created
                ChildFormList.Add(f);
                AddItemToWindowList(f);
                f.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            }
            else
            {
                //activated existing form
                foreach (var item in TssbPpalWindow.DropDownItems)
                {
                    if (item.GetType() == typeof(ToolStripMenuItem))
                    {
                        if (((ToolStripMenuItem)item).Text.Contains(f.Text))
                            ((ToolStripMenuItem)item).Checked = true;
                        else
                            ((ToolStripMenuItem)item).Checked = false;
                    }
                }
            }
        }

        private void RemoveItemFromWindowList(Form f)
        {
            if (IsClosing) return;
            ChildFormList.Remove(f);
            ChildCont = 1;
            for (int idx = TssbPpalWindow.DropDownItems.Count; idx > 0; idx--)
            {
                ToolStripItem tsi = TssbPpalWindow.DropDownItems[idx - 1];
                if (tsi.Tag != null) TssbPpalWindow.DropDownItems.Remove(tsi);
            }
            // Re-create Childs Forms List
            foreach (Form child in ChildFormList)
            {
                AddItemToWindowList(child);
                f.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            }
        }

        private void TssbChildFormList_Click(object sender, EventArgs e)
        {
            ((Form)((ToolStripItem)sender).Tag).Activate();
        }
    }
}