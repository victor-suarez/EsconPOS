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
        private bool CajaAbierta = false;
        private FrmCliente FrmCli = null;
        private FrmEmpleado FrmEmp = null;
        private FrmEmpresa FrmEpr = null;
        private FrmMoneda FrmMon = null;
        private FrmMarca FrmMar = null;
        private FrmClase FrmCla = null;
        private FrmProducto FrmPro = null;

        public MDIEsconPos()
        {
            InitializeComponent();
        }

        private void AbrirCerrarCaja()
        {
            CajaAbierta = !CajaAbierta;
            if (CajaAbierta)
            {
            }
            else
            {
            }
        }

        private void IniciarInfo()
        {
            this.Text = "EsconPOS V:" +
                        System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Major.ToString() + "." +
                        System.Reflection.Assembly.GetEntryAssembly().GetName().Version.MajorRevision.ToString() + "." +
                        System.Reflection.Assembly.GetEntryAssembly().GetName().Version.Minor.ToString() +
                       " - " + Global.Empresa.NombreComercial;
            TsslCaja.Text = Global.Caja.Descripcion;
            TsslEmpleado.Text = Global.Empleado.Nombre;
            TsslFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
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

        private void TssbCaja_Click(object sender, EventArgs e)
        {
            AbrirCerrarCaja();
        }

        private void TssbSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
