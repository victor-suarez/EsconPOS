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
    }
}
