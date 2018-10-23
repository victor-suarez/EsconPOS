namespace EsconPOS
{
    partial class FrmEsconPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEsconPOS));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAbrirCaja = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslCajero = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAbrirCaja});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(942, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // tsbAbrirCaja
            // 
            this.tsbAbrirCaja.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbrirCaja.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbrirCaja.Image")));
            this.tsbAbrirCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbrirCaja.Name = "tsbAbrirCaja";
            this.tsbAbrirCaja.Size = new System.Drawing.Size(23, 22);
            this.tsbAbrirCaja.Text = "Abrir la caja";
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus,
            this.tsslCajero,
            this.tsslFechaHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 390);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(942, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslCajero
            // 
            this.tsslCajero.Name = "tsslCajero";
            this.tsslCajero.Size = new System.Drawing.Size(142, 21);
            this.tsslCajero.Text = "Nombre del Cajero";
            this.tsslCajero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsslFechaHora
            // 
            this.tsslFechaHora.Name = "tsslFechaHora";
            this.tsslFechaHora.Size = new System.Drawing.Size(254, 21);
            this.tsslFechaHora.Text = "xxxxxxxxx, 99 de xxxxxxxxxx de 9999";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(531, 21);
            this.tsslStatus.Spring = true;
            this.tsslStatus.Text = "toolStripStatusLabel2";
            this.tsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmEsconPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 416);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Name = "FrmEsconPOS";
            this.Text = "Escon POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEsconPOS_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbAbrirCaja;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslCajero;
        private System.Windows.Forms.ToolStripStatusLabel tsslFechaHora;
    }
}

