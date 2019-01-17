namespace EsconPOS.forms
{
    partial class FrmImpresora
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
            this.TxtPrn = new System.Windows.Forms.TextBox();
            this.BtnImprimir = new System.Windows.Forms.Button();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.PnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtPrn
            // 
            this.TxtPrn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtPrn.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrn.Location = new System.Drawing.Point(0, 0);
            this.TxtPrn.Multiline = true;
            this.TxtPrn.Name = "TxtPrn";
            this.TxtPrn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtPrn.ShortcutsEnabled = false;
            this.TxtPrn.Size = new System.Drawing.Size(332, 462);
            this.TxtPrn.TabIndex = 0;
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Location = new System.Drawing.Point(17, 12);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.Size = new System.Drawing.Size(92, 24);
            this.BtnImprimir.TabIndex = 0;
            this.BtnImprimir.Text = "&Imprimir [ESC]";
            this.BtnImprimir.UseVisualStyleBackColor = true;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtnCerrar);
            this.PnlButtons.Controls.Add(this.BtnImprimir);
            this.PnlButtons.Location = new System.Drawing.Point(54, 468);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(224, 41);
            this.PnlButtons.TabIndex = 1;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(116, 12);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(92, 24);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.Text = "&Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 515);
            this.ControlBox = false;
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.TxtPrn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImpresora";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Activated += new System.EventHandler(this.FrmImpresora_Activated);
            this.Load += new System.EventHandler(this.FrmImpresora_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmImpresora_KeyPress);
            this.PnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtPrn;
        private System.Windows.Forms.Button BtnImprimir;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Button BtnCerrar;
    }
}