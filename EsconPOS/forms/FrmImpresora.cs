using System;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmImpresora : Form
    {
        #region Variables, constantes privadas y propiedades públicas

        private int _PrinterWidth;
        public int PrinterWidth { get { return _PrinterWidth; } set { _PrinterWidth = value; } }

        #endregion Variables, constantes privadas y propiedades públicas

        #region Funciones

        public void Clear()
        {
            TxtPrn.Clear();
        }

        public void Print(string Value = "", char Padded = 'L')
        {
            if (Value != "")
            {
                if (Padded == 'L')
                {
                    TxtPrn.AppendText(Value);
                }
                else if (Padded == 'R')
                {
                    if (Value.Length > PrinterWidth) Value = Value.Substring(0, PrinterWidth);
                    TxtPrn.AppendText(Value.PadLeft(PrinterWidth));
                }
                else if (Padded == 'C')
                {
                    string Filler = new string(' ', (int)((PrinterWidth - Value.Length) / 2));
                    TxtPrn.AppendText(Filler + Value);
                }
            }
            TxtPrn.AppendText("\r\n");
        }

        public void InicializaPrinter()
        {
            if (PrinterWidth > 40)
            {
                this.Width = this.MdiParent.ClientSize.Width - 12;
            }
            else
            {
                this.Width = (int)(this.MdiParent.ClientSize.Width / 2.5);
            }
            this.Top = 0;
            this.Left = this.MdiParent.ClientSize.Width - this.Width - 3;
            this.Height = this.MdiParent.ClientSize.Height - 90;
            TxtPrn.Height = this.Height - PnlButtons.Height- 6;
            PnlButtons.Top = this.Height - PnlButtons.Height - 6;
            PnlButtons.Left = (int)((this.Width - PnlButtons.Width) / 2);
        }

        #endregion Funciones

        #region Objetos y métodos

        public FrmImpresora()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmImpresora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Escape))
            {
                e.Handled = true;
                BtnImprimir_Click(sender, null);
            }
        }

        private void FrmImpresora_Load(object sender, EventArgs e)
        {
            //InicializaPrinter();
            this.BringToFront();
        }

        #endregion Objetos y métodos

        private void FrmImpresora_Activated(object sender, EventArgs e)
        {

        }
    }
}