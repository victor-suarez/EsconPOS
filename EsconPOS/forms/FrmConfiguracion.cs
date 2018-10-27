using EsconPOS.classes;
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
    public partial class FrmConfiguracion : Form
    {
        private Datos Conx = Datos.Conx;
        public void CargarIdentificaciones()
        {
            CmbIdentificacionID.Items.Clear();
            Identificaciones cID = new Identificaciones(Conx);
        }
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {

        }
    }
}
