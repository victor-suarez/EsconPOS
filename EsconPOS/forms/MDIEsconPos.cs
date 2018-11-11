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

        public MDIEsconPos()
        {
            InitializeComponent();
        }

        private void AbrirCerrarCaja()
        {
            CajaAbierta = !CajaAbierta;
            if (CajaAbierta)
            {
                RibBtnCaja.LargeImage = Properties.Resources.CajaCerrada;
                RibBtnCaja.Text = "Abrir Caja";
            }
            else
            {
                RibBtnCaja.LargeImage = Properties.Resources.CajaAbierta;
                RibBtnCaja.Text = "Cerrar Caja";
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

        private void ribbonOrbMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RibBtnAbrir_Click(object sender, EventArgs e)
        {
            AbrirCerrarCaja();
        }

        private void RibBtnEmpleados_Click(object sender, EventArgs e)
        {
        }

        private void RibBtnClientes_Click(object sender, EventArgs e)
        {
            FrmCli = new forms.FrmCliente();
            FrmCli.MdiParent = this;
            FrmCli.Show();
        }
    }
}
