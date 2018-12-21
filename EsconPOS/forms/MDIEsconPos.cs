using EsconPOS.classes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class MDIEsconPos : Form
    {
        #region Variables privadas

        private static bool CajaAbierta = false;
        private mainEntities context = new mainEntities();
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
        private FrmUnidadMedida FrmUnd = null;

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
            TssbCaja.Image = CajaAbierta ? Properties.Resources.CajaAbierta : Properties.Resources.CajaCerrada;
            TssbCaja.Text = CajaAbierta ? "Cerrar &Caja" : "Abrir &Caja";
            TsmiIncluirFactura.Visible = CajaAbierta;
            TsmiAbrirCuenta.Visible = CajaAbierta;
            Cursor.Current = Cursors.Default;
        }

        private void IniciarBotones()
        {
            TssbCaja.Visible = true;
            TssbAdministrar.Visible = true;
            if (Global.glEsAdministrador)
            {
                TssbUbicacion.Visible = true;
                TssbSunat.Visible = true;
                TssbProductos.Visible = true;
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

        private void TsmiClases_Click(object sender, EventArgs e)
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

        private void TsmiClientes_Click(object sender, EventArgs e)
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

        private void TsmiEmpleados_Click(object sender, EventArgs e)
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

        private void TsmiEmpresas_Click(object sender, EventArgs e)
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

        private void TsmiFormasPago_Click(object sender, EventArgs e)
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

        private void TsmiIncluirFactura_Click(object sender, EventArgs e)
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

        private void TsmiMarcas_Click(object sender, EventArgs e)
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

        private void TsmiMiContrasenia_Click(object sender, EventArgs e)
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

        private void TsmiMonedas_Click(object sender, EventArgs e)
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

        private void TsmiProductosServicios_Click(object sender, EventArgs e)
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

        private void TsmiUnidadesMedida_Click(object sender, EventArgs e)
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

        private void TssbCaja_ButtonClick(object sender, EventArgs e)
        {
            AbrirCerrarCaja();
        }

        private void TssbSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro desea cerrar el sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        #endregion Propiedades y métodos
    }
}