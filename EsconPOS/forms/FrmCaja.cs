using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmCaja : Form
    {
        private mainEntities context = new mainEntities();

        public FrmCaja()
        {
            InitializeComponent();
        }
        private void CargarCombos()
        {
        }
        private void ClearCrt()
        {
        }
        private void MoverRegistroToCrt(long ID)
        {
        }
        private void Eliminar()
        {
        }
        private void Guardar()
        {
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
            return true;
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
    }
}
