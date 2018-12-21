namespace EsconPOS.forms
{
    partial class FrmContrasenia
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNuevaContrasenia = new System.Windows.Forms.TextBox();
            this.TxtConfirmaContrasenia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.Icono = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nueva contraseña:";
            // 
            // TxtNuevaContrasenia
            // 
            this.TxtNuevaContrasenia.Location = new System.Drawing.Point(224, 6);
            this.TxtNuevaContrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNuevaContrasenia.MaxLength = 20;
            this.TxtNuevaContrasenia.Name = "TxtNuevaContrasenia";
            this.TxtNuevaContrasenia.Size = new System.Drawing.Size(190, 26);
            this.TxtNuevaContrasenia.TabIndex = 1;
            this.TxtNuevaContrasenia.UseSystemPasswordChar = true;
            this.TxtNuevaContrasenia.Enter += new System.EventHandler(this.Txt_Enter);
            this.TxtNuevaContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtConfirmaContrasenia
            // 
            this.TxtConfirmaContrasenia.Location = new System.Drawing.Point(224, 42);
            this.TxtConfirmaContrasenia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConfirmaContrasenia.MaxLength = 20;
            this.TxtConfirmaContrasenia.Name = "TxtConfirmaContrasenia";
            this.TxtConfirmaContrasenia.Size = new System.Drawing.Size(190, 26);
            this.TxtConfirmaContrasenia.TabIndex = 3;
            this.TxtConfirmaContrasenia.UseSystemPasswordChar = true;
            this.TxtConfirmaContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirmar contraseña:";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Location = new System.Drawing.Point(54, 76);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(171, 30);
            this.BtnCambiar.TabIndex = 4;
            this.BtnCambiar.Text = "&Cambiar contraseña";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            this.BtnCambiar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_KeyDown);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(240, 76);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(171, 30);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "Ca&ncelar cambio";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 123);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(423, 18);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Icono
            // 
            this.Icono.Image = global::EsconPOS.Properties.Resources.Contraseña;
            this.Icono.Location = new System.Drawing.Point(3, 3);
            this.Icono.Name = "Icono";
            this.Icono.Size = new System.Drawing.Size(40, 38);
            this.Icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icono.TabIndex = 8;
            this.Icono.TabStop = false;
            // 
            // FrmContrasenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 141);
            this.Controls.Add(this.Icono);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnCambiar);
            this.Controls.Add(this.TxtConfirmaContrasenia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNuevaContrasenia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContrasenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.FrmContrasenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNuevaContrasenia;
        private System.Windows.Forms.TextBox TxtConfirmaContrasenia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCambiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox Icono;
    }
}