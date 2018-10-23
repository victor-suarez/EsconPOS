using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EsconPOS.forms;

namespace EsconPOS
{
    public partial class FrmEsconPOS : Form
    {
        private bool CajaAbierta = false;
        public FrmEsconPOS()
        {
            InitializeComponent();
        }

        private void EntradaUsuario()
        {
            Form loggin = new FrmEntrada();
            loggin.ShowDialog();
        }
        private void FrmEsconPOS_Load(object sender, EventArgs e)
        {
            // MOSTRAR LOGIN
            if (!this.CajaAbierta) EntradaUsuario();
        }
    }
}
