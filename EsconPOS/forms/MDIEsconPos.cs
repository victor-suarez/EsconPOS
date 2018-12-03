using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EsconPOS.classes;

namespace EsconPOS.forms
{
    public partial class MDIEsconPos : Form
    {
        private mainEntities context = new mainEntities();

        private static bool CajaAbierta = false;
        private FrmCliente FrmCli = null;
        private FrmEmpleado FrmEmp = null;
        private FrmEmpresa FrmEpr = null;
        private FrmMoneda FrmMon = null;
        private FrmUnidadMedida FrmUnd = null;
        private FrmMarca FrmMar = null;
        private FrmClase FrmCla = null;
        private FrmProducto FrmPro = null;
        private FrmPuntoDeVenta FrmPos = null;

        public MDIEsconPos()
        {
            InitializeComponent();
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
            TssbCaja.Text = CajaAbierta ? "Cerrar Caja" : "Abrir Caja";
            TsmiIncluirFactura.Visible = CajaAbierta;
            TsmiAbrirCuenta.Visible = CajaAbierta;
            Cursor.Current = Cursors.Default;
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

        private void SetStatus(string StrStatus = "", bool Error = false)
        {
            if (Error)
                TsslStatus.ForeColor = Color.Red;
            else
                TsslStatus.ForeColor = SystemColors.ControlText;
            TsslStatus.Text = StrStatus;
        }

        private void MDIEsconPos_Load(object sender, EventArgs e)
        {
            IniciarInfo();
        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            TsslFecha.Text = DateTime.Now.ToString("dddd, d de MMMM de yyyy");
            TsslHora.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void TsmiClases_Click(object sender, EventArgs e)
        {
            FrmCla = new forms.FrmClase();
            FrmCla.MdiParent = this;
            FrmCla.Show();
        }

        private void TsmiClientes_Click(object sender, EventArgs e)
        {
            FrmCli = new forms.FrmCliente();
            FrmCli.MdiParent = this;
            FrmCli.Show();
        }

        private void TsmiEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmp = new forms.FrmEmpleado();
            FrmEmp.MdiParent = this;
            FrmEmp.Show();
        }

        private void TsmiEmpresas_Click(object sender, EventArgs e)
        {
            FrmEpr = new forms.FrmEmpresa();
            FrmEpr.MdiParent = this;
            FrmEpr.Show();
        }

        private void TsmiMarcas_Click(object sender, EventArgs e)
        {
            FrmMar = new forms.FrmMarca();
            FrmMar.MdiParent = this;
            FrmMar.Show();
        }

        private void TsmiMonedas_Click(object sender, EventArgs e)
        {
            FrmMon = new forms.FrmMoneda();
            FrmMon.MdiParent = this;
            FrmMon.Show();
        }

        private void TsmiProductosServicios_Click(object sender, EventArgs e)
        {
            FrmPro = new forms.FrmProducto();
            FrmPro.MdiParent = this;
            FrmPro.Show();
        }

        private void TsmiUnidadesMedida_Click(object sender, EventArgs e)
        {
            FrmUnd = new forms.FrmUnidadMedida();
            FrmUnd.MdiParent = this;
            FrmUnd.Show();
        }

        private void TssbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void TssbCaja_ButtonClick(object sender, EventArgs e)
        {
            AbrirCerrarCaja();

        }

        private void TsmiIncluirFactura_Click(object sender, EventArgs e)
        {
            FrmPos = new forms.FrmPuntoDeVenta();
            FrmPos.MdiParent = this;
            FrmPos.Show();
        }
    }
}
