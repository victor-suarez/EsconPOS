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
        public MDIEsconPos()
        {
            InitializeComponent();
        }

        private void IniciarInfo()
        {
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
            TsslFecha.Text = DateTime.Now.ToString("dddd, dd de MMMM de yyyy");
            TsslHora.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void ribbonOrbMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void RibBtnAbrirCaja_Click(object sender, EventArgs e)
        {
            if (CajaAbierta)
            {
                CajaAbierta = false;
                RibBtnAbrirCaja.LargeImage = Properties.Resources.CajaCerrada;
                RibBtnAbrirCaja.Text = "Abrir Caja";
            }
            else
            {
                CajaAbierta = true;
                RibBtnAbrirCaja.LargeImage = Properties.Resources.CajaAbierta;
                RibBtnAbrirCaja.Text = "Cerrar Caja";
            }
        }
    }
}
