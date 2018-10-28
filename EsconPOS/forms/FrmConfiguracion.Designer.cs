namespace EsconPOS.forms
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.GboxAdministrador = new System.Windows.Forms.GroupBox();
            this.ChkEsSupervisor = new System.Windows.Forms.CheckBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefonos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtNroDocIdent = new System.Windows.Forms.TextBox();
            this.CmbIdentificacionID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GboxCaja = new System.Windows.Forms.GroupBox();
            this.NumCajaID = new System.Windows.Forms.NumericUpDown();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RibbonMenu = new System.Windows.Forms.Ribbon();
            this.RibTabInicio = new System.Windows.Forms.RibbonTab();
            this.RibPanelAcciones = new System.Windows.Forms.RibbonPanel();
            this.RibBtnGuardar = new System.Windows.Forms.RibbonButton();
            this.RibBtnSalir = new System.Windows.Forms.RibbonButton();
            this.GboxAdministrador.SuspendLayout();
            this.GboxCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCajaID)).BeginInit();
            this.SuspendLayout();
            // 
            // GboxAdministrador
            // 
            this.GboxAdministrador.Controls.Add(this.ChkEsSupervisor);
            this.GboxAdministrador.Controls.Add(this.TxtPassword);
            this.GboxAdministrador.Controls.Add(this.label8);
            this.GboxAdministrador.Controls.Add(this.TxtLogin);
            this.GboxAdministrador.Controls.Add(this.label7);
            this.GboxAdministrador.Controls.Add(this.TxtCorreoElectronico);
            this.GboxAdministrador.Controls.Add(this.label6);
            this.GboxAdministrador.Controls.Add(this.TxtTelefonos);
            this.GboxAdministrador.Controls.Add(this.label5);
            this.GboxAdministrador.Controls.Add(this.TxtDireccion);
            this.GboxAdministrador.Controls.Add(this.TxtNombre);
            this.GboxAdministrador.Controls.Add(this.TxtNroDocIdent);
            this.GboxAdministrador.Controls.Add(this.CmbIdentificacionID);
            this.GboxAdministrador.Controls.Add(this.label4);
            this.GboxAdministrador.Controls.Add(this.label3);
            this.GboxAdministrador.Controls.Add(this.label2);
            this.GboxAdministrador.Controls.Add(this.label1);
            this.GboxAdministrador.Location = new System.Drawing.Point(20, 118);
            this.GboxAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxAdministrador.Name = "GboxAdministrador";
            this.GboxAdministrador.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxAdministrador.Size = new System.Drawing.Size(665, 362);
            this.GboxAdministrador.TabIndex = 0;
            this.GboxAdministrador.TabStop = false;
            this.GboxAdministrador.Text = "Administrador";
            // 
            // ChkEsSupervisor
            // 
            this.ChkEsSupervisor.AutoSize = true;
            this.ChkEsSupervisor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkEsSupervisor.Location = new System.Drawing.Point(196, 329);
            this.ChkEsSupervisor.Name = "ChkEsSupervisor";
            this.ChkEsSupervisor.Size = new System.Drawing.Size(146, 24);
            this.ChkEsSupervisor.TabIndex = 16;
            this.ChkEsSupervisor.Text = "Es supervisor?";
            this.ChkEsSupervisor.UseVisualStyleBackColor = true;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(196, 297);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(211, 26);
            this.TxtPassword.TabIndex = 15;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 300);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contraseña:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Location = new System.Drawing.Point(196, 263);
            this.TxtLogin.MaxLength = 20;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(211, 26);
            this.TxtLogin.TabIndex = 13;
            this.TxtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Usuario:";
            // 
            // TxtCorreoElectronico
            // 
            this.TxtCorreoElectronico.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtCorreoElectronico.Location = new System.Drawing.Point(196, 231);
            this.TxtCorreoElectronico.MaxLength = 255;
            this.TxtCorreoElectronico.Name = "TxtCorreoElectronico";
            this.TxtCorreoElectronico.Size = new System.Drawing.Size(454, 26);
            this.TxtCorreoElectronico.TabIndex = 11;
            this.TxtCorreoElectronico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo E.:";
            // 
            // TxtTelefonos
            // 
            this.TxtTelefonos.Location = new System.Drawing.Point(196, 199);
            this.TxtTelefonos.MaxLength = 100;
            this.TxtTelefonos.Name = "TxtTelefonos";
            this.TxtTelefonos.Size = new System.Drawing.Size(454, 26);
            this.TxtTelefonos.TabIndex = 9;
            this.TxtTelefonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfonos:";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(196, 128);
            this.TxtDireccion.MaxLength = 255;
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(454, 65);
            this.TxtDireccion.TabIndex = 7;
            this.TxtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(196, 94);
            this.TxtNombre.MaxLength = 100;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(454, 26);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtNroDocIdent
            // 
            this.TxtNroDocIdent.Location = new System.Drawing.Point(196, 60);
            this.TxtNroDocIdent.MaxLength = 20;
            this.TxtNroDocIdent.Name = "TxtNroDocIdent";
            this.TxtNroDocIdent.Size = new System.Drawing.Size(211, 26);
            this.TxtNroDocIdent.TabIndex = 3;
            this.TxtNroDocIdent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroDocIdent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // CmbIdentificacionID
            // 
            this.CmbIdentificacionID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbIdentificacionID.FormattingEnabled = true;
            this.CmbIdentificacionID.Location = new System.Drawing.Point(196, 26);
            this.CmbIdentificacionID.Name = "CmbIdentificacionID";
            this.CmbIdentificacionID.Size = new System.Drawing.Size(454, 28);
            this.CmbIdentificacionID.TabIndex = 1;
            this.CmbIdentificacionID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro de Identificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Identificación:";
            // 
            // GboxCaja
            // 
            this.GboxCaja.Controls.Add(this.NumCajaID);
            this.GboxCaja.Controls.Add(this.TxtDescripcion);
            this.GboxCaja.Controls.Add(this.label10);
            this.GboxCaja.Controls.Add(this.label9);
            this.GboxCaja.Location = new System.Drawing.Point(20, 490);
            this.GboxCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxCaja.Name = "GboxCaja";
            this.GboxCaja.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxCaja.Size = new System.Drawing.Size(665, 99);
            this.GboxCaja.TabIndex = 1;
            this.GboxCaja.TabStop = false;
            this.GboxCaja.Text = "Caja";
            // 
            // NumCajaID
            // 
            this.NumCajaID.Location = new System.Drawing.Point(196, 26);
            this.NumCajaID.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.NumCajaID.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCajaID.Name = "NumCajaID";
            this.NumCajaID.Size = new System.Drawing.Size(66, 26);
            this.NumCajaID.TabIndex = 1;
            this.NumCajaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCajaID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCajaID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(196, 59);
            this.TxtDescripcion.MaxLength = 100;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(454, 26);
            this.TxtDescripcion.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro de Caja:";
            // 
            // RibbonMenu
            // 
            this.RibbonMenu.CaptionBarVisible = false;
            this.RibbonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RibbonMenu.Location = new System.Drawing.Point(0, 0);
            this.RibbonMenu.Minimized = false;
            this.RibbonMenu.Name = "RibbonMenu";
            // 
            // 
            // 
            this.RibbonMenu.OrbDropDown.BorderRoundness = 8;
            this.RibbonMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.RibbonMenu.OrbDropDown.Name = "";
            this.RibbonMenu.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.RibbonMenu.OrbDropDown.TabIndex = 0;
            this.RibbonMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.RibbonMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.RibbonMenu.Size = new System.Drawing.Size(696, 110);
            this.RibbonMenu.TabIndex = 2;
            this.RibbonMenu.Tabs.Add(this.RibTabInicio);
            this.RibbonMenu.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.RibbonMenu.TabSpacing = 4;
            this.RibbonMenu.Text = "Acciones";
            // 
            // RibTabInicio
            // 
            this.RibTabInicio.Name = "RibTabInicio";
            this.RibTabInicio.Panels.Add(this.RibPanelAcciones);
            this.RibTabInicio.Text = "Inicio";
            // 
            // RibPanelAcciones
            // 
            this.RibPanelAcciones.ButtonMoreVisible = false;
            this.RibPanelAcciones.Items.Add(this.RibBtnGuardar);
            this.RibPanelAcciones.Items.Add(this.RibBtnSalir);
            this.RibPanelAcciones.Name = "RibPanelAcciones";
            this.RibPanelAcciones.Text = "Acciones";
            // 
            // RibBtnGuardar
            // 
            this.RibBtnGuardar.Image = global::EsconPOS.Properties.Resources.Guardar;
            this.RibBtnGuardar.LargeImage = global::EsconPOS.Properties.Resources.Guardar;
            this.RibBtnGuardar.Name = "RibBtnGuardar";
            this.RibBtnGuardar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnGuardar.SmallImage")));
            this.RibBtnGuardar.Text = "Guardar";
            this.RibBtnGuardar.Click += new System.EventHandler(this.RibBtnGuardar_Click);
            // 
            // RibBtnSalir
            // 
            this.RibBtnSalir.Image = global::EsconPOS.Properties.Resources.Salir;
            this.RibBtnSalir.LargeImage = global::EsconPOS.Properties.Resources.Salir;
            this.RibBtnSalir.Name = "RibBtnSalir";
            this.RibBtnSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnSalir.SmallImage")));
            this.RibBtnSalir.Text = "Salir";
            this.RibBtnSalir.Click += new System.EventHandler(this.RibBtnSalir_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 598);
            this.Controls.Add(this.RibbonMenu);
            this.Controls.Add(this.GboxCaja);
            this.Controls.Add(this.GboxAdministrador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración inicial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfiguracion_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.GboxAdministrador.ResumeLayout(false);
            this.GboxAdministrador.PerformLayout();
            this.GboxCaja.ResumeLayout(false);
            this.GboxCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCajaID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxAdministrador;
        private System.Windows.Forms.CheckBox ChkEsSupervisor;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtCorreoElectronico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtTelefonos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtNroDocIdent;
        private System.Windows.Forms.ComboBox CmbIdentificacionID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GboxCaja;
        private System.Windows.Forms.NumericUpDown NumCajaID;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Ribbon RibbonMenu;
        private System.Windows.Forms.RibbonTab RibTabInicio;
        private System.Windows.Forms.RibbonPanel RibPanelAcciones;
        private System.Windows.Forms.RibbonButton RibBtnGuardar;
        private System.Windows.Forms.RibbonButton RibBtnSalir;
    }
}