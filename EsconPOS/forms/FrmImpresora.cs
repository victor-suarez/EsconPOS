using System;
using System.Drawing;
using System.Windows.Forms;

namespace EsconPOS.forms
{
    public partial class FrmImpresora : Form
    {
        #region Variables, constantes privadas y propiedades públicas

        private int _PrinterWidth;
        public int PrinterWidth
        {
            get { return _PrinterWidth; }
            set
            {
                if (value > 132) value = 132;
                if (value < 40) value = 40;
                _PrinterWidth = value;
            }
        }

        #endregion Variables, constantes privadas y propiedades públicas

        #region Funciones

        public void Clear()
        {
            TxtPrn.Clear();
        }

        public void InicializaPrinter()
        {
            Font ActualFont = TxtPrn.Font;
            Size TextSize = TextRenderer.MeasureText(new string('W', PrinterWidth), ActualFont);
            this.Width = TextSize.Width + 24;
            //if (PrinterWidth > 40)
            //{
            //    this.Width = this.MdiParent.ClientSize.Width - 12;
            //}
            //else
            //{
            //    this.Width = (int)(this.MdiParent.ClientSize.Width / 2.5);
            //}
            this.Top = this.MdiParent.ClientRectangle.Top;
            this.Left = this.MdiParent.ClientSize.Width - this.Width - 12;
            this.Height = this.MdiParent.ClientSize.Height - 90;
            TxtPrn.Height = this.Height - PnlButtons.Height - 6;
            PnlButtons.Top = this.Height - PnlButtons.Height - 6;
            PnlButtons.Left = (int)((this.Width - PnlButtons.Width) / 2);
        }

        public void Print(string Value = "", char Padded = 'L')
        {
            if (Value != "" && Value != null)
            {
                if (Value.Trim().Length > PrinterWidth)
                    PrintLongLines(Value, Padded);
                else
                {
                    if (Padded == 'L')
                    {
                        TxtPrn.AppendText(Value.TrimStart());
                    }
                    else if (Padded == 'R')
                    {
                        if (Value.TrimEnd().Length > PrinterWidth) Value = Value.Substring(0, PrinterWidth);
                        TxtPrn.AppendText(Value.PadLeft(PrinterWidth));
                    }
                    else if (Padded == 'C')
                    {
                        int left = (PrinterWidth - Value.TrimEnd().Length) / 2;
                        TxtPrn.AppendText(Value.TrimEnd().PadLeft(left + Value.TrimEnd().Length));
                    }
               }
            }
            TxtPrn.AppendText("\r\n");
        }

        private void PrintLongLines(string Value, char Padded)
        {
            int ChunkSize = 0;
            for (int ChrIdx = 0; ChrIdx < Value.Length; ChrIdx += PrinterWidth)
            {
                if (PrinterWidth + ChrIdx > Value.Length)
                    ChunkSize = Value.Length - ChrIdx;
                else
                    ChunkSize = PrinterWidth;
                if (Padded == 'L')
                {
                    TxtPrn.AppendText(Value.Substring(ChrIdx, ChunkSize).Trim());
                }
                if (Padded == 'R')
                {
                    TxtPrn.AppendText(Value.Substring(ChrIdx, ChunkSize).Trim().PadLeft(PrinterWidth));
                }
                if (Padded == 'C')
                {
                    int left = 0;
                    if(ChunkSize == PrinterWidth)
                        TxtPrn.AppendText(Value.Substring(ChrIdx, ChunkSize).Trim());
                    else
                    {
                        left = (PrinterWidth - ChunkSize) / 2;
                        TxtPrn.AppendText(Value.Substring(ChrIdx, ChunkSize).PadLeft(left + ChunkSize));
                    }
                }
                TxtPrn.AppendText("\r\n");
            }
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
            InicializaPrinter();
            this.BringToFront();
        }

        #endregion Objetos y métodos

        private void FrmImpresora_Activated(object sender, EventArgs e)
        {
        }
    }
}