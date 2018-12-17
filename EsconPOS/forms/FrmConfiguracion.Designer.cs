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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtNroIDEmpleado = new System.Windows.Forms.TextBox();
            this.CmbTipoIDEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GboxCaja = new System.Windows.Forms.GroupBox();
            this.NumCajaID = new System.Windows.Forms.NumericUpDown();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GboxEmpresa = new System.Windows.Forms.GroupBox();
            this.CmbDistrito = new System.Windows.Forms.ComboBox();
            this.CmbProvincia = new System.Windows.Forms.ComboBox();
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNombreComercial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNroIDEmpresa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoIDEmpresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.GboxAdministrador.SuspendLayout();
            this.GboxCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCajaID)).BeginInit();
            this.GboxEmpresa.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GboxAdministrador
            // 
            this.GboxAdministrador.Controls.Add(this.ChkEsSupervisor);
            this.GboxAdministrador.Controls.Add(this.TxtPassword);
            this.GboxAdministrador.Controls.Add(this.label8);
            this.GboxAdministrador.Controls.Add(this.TxtLogin);
            this.GboxAdministrador.Controls.Add(this.label7);
            this.GboxAdministrador.Controls.Add(this.TxtNombre);
            this.GboxAdministrador.Controls.Add(this.TxtNroIDEmpleado);
            this.GboxAdministrador.Controls.Add(this.CmbTipoIDEmpleado);
            this.GboxAdministrador.Controls.Add(this.label3);
            this.GboxAdministrador.Controls.Add(this.label2);
            this.GboxAdministrador.Controls.Add(this.label1);
            this.GboxAdministrador.Location = new System.Drawing.Point(16, 264);
            this.GboxAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxAdministrador.Name = "GboxAdministrador";
            this.GboxAdministrador.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxAdministrador.Size = new System.Drawing.Size(598, 213);
            this.GboxAdministrador.TabIndex = 1;
            this.GboxAdministrador.TabStop = false;
            this.GboxAdministrador.Text = "Administrador";
            // 
            // ChkEsSupervisor
            // 
            this.ChkEsSupervisor.AutoSize = true;
            this.ChkEsSupervisor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkEsSupervisor.Location = new System.Drawing.Point(176, 184);
            this.ChkEsSupervisor.Name = "ChkEsSupervisor";
            this.ChkEsSupervisor.Size = new System.Drawing.Size(132, 24);
            this.ChkEsSupervisor.TabIndex = 10;
            this.ChkEsSupervisor.Text = "Es supervisor?";
            this.ChkEsSupervisor.UseVisualStyleBackColor = true;
            this.ChkEsSupervisor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ChkEsSupervisor_KeyPress);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(176, 152);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(190, 26);
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.UseSystemPasswordChar = true;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Contraseña:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtLogin.Location = new System.Drawing.Point(176, 121);
            this.TxtLogin.MaxLength = 20;
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(190, 26);
            this.TxtLogin.TabIndex = 7;
            this.TxtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Usuario:";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(176, 90);
            this.TxtNombre.MaxLength = 255;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(409, 26);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtNroIDEmpleado
            // 
            this.TxtNroIDEmpleado.Location = new System.Drawing.Point(176, 59);
            this.TxtNroIDEmpleado.MaxLength = 20;
            this.TxtNroIDEmpleado.Name = "TxtNroIDEmpleado";
            this.TxtNroIDEmpleado.Size = new System.Drawing.Size(190, 26);
            this.TxtNroIDEmpleado.TabIndex = 3;
            this.TxtNroIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // CmbTipoIDEmpleado
            // 
            this.CmbTipoIDEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoIDEmpleado.FormattingEnabled = true;
            this.CmbTipoIDEmpleado.Location = new System.Drawing.Point(176, 26);
            this.CmbTipoIDEmpleado.Name = "CmbTipoIDEmpleado";
            this.CmbTipoIDEmpleado.Size = new System.Drawing.Size(307, 28);
            this.CmbTipoIDEmpleado.TabIndex = 1;
            this.CmbTipoIDEmpleado.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboID_Format);
            this.CmbTipoIDEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro de Identificación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Identificación:";
            // 
            // GboxCaja
            // 
            this.GboxCaja.Controls.Add(this.NumCajaID);
            this.GboxCaja.Controls.Add(this.TxtDescripcion);
            this.GboxCaja.Controls.Add(this.label10);
            this.GboxCaja.Controls.Add(this.label9);
            this.GboxCaja.Location = new System.Drawing.Point(16, 487);
            this.GboxCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxCaja.Name = "GboxCaja";
            this.GboxCaja.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GboxCaja.Size = new System.Drawing.Size(598, 99);
            this.GboxCaja.TabIndex = 2;
            this.GboxCaja.TabStop = false;
            this.GboxCaja.Text = "Caja";
            // 
            // NumCajaID
            // 
            this.NumCajaID.Location = new System.Drawing.Point(176, 26);
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
            this.NumCajaID.Size = new System.Drawing.Size(59, 26);
            this.NumCajaID.TabIndex = 1;
            this.NumCajaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCajaID.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCajaID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(176, 59);
            this.TxtDescripcion.MaxLength = 100;
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(409, 26);
            this.TxtDescripcion.TabIndex = 3;
            this.TxtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nro de Caja:";
            // 
            // GboxEmpresa
            // 
            this.GboxEmpresa.Controls.Add(this.CmbDistrito);
            this.GboxEmpresa.Controls.Add(this.CmbProvincia);
            this.GboxEmpresa.Controls.Add(this.CmbDepartamento);
            this.GboxEmpresa.Controls.Add(this.label12);
            this.GboxEmpresa.Controls.Add(this.TxtRazonSocial);
            this.GboxEmpresa.Controls.Add(this.label11);
            this.GboxEmpresa.Controls.Add(this.TxtNombreComercial);
            this.GboxEmpresa.Controls.Add(this.label6);
            this.GboxEmpresa.Controls.Add(this.TxtNroIDEmpresa);
            this.GboxEmpresa.Controls.Add(this.label5);
            this.GboxEmpresa.Controls.Add(this.CmbTipoIDEmpresa);
            this.GboxEmpresa.Controls.Add(this.label4);
            this.GboxEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GboxEmpresa.Location = new System.Drawing.Point(16, 57);
            this.GboxEmpresa.Name = "GboxEmpresa";
            this.GboxEmpresa.Size = new System.Drawing.Size(598, 199);
            this.GboxEmpresa.TabIndex = 0;
            this.GboxEmpresa.TabStop = false;
            this.GboxEmpresa.Text = "Empresa";
            // 
            // CmbDistrito
            // 
            this.CmbDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDistrito.DropDownWidth = 326;
            this.CmbDistrito.FormattingEnabled = true;
            this.CmbDistrito.Location = new System.Drawing.Point(268, 156);
            this.CmbDistrito.Name = "CmbDistrito";
            this.CmbDistrito.Size = new System.Drawing.Size(317, 28);
            this.CmbDistrito.TabIndex = 11;
            this.CmbDistrito.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDistrito_Format);
            this.CmbDistrito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbProvincia
            // 
            this.CmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProvincia.DropDownWidth = 300;
            this.CmbProvincia.FormattingEnabled = true;
            this.CmbProvincia.Location = new System.Drawing.Point(222, 156);
            this.CmbProvincia.Name = "CmbProvincia";
            this.CmbProvincia.Size = new System.Drawing.Size(40, 28);
            this.CmbProvincia.TabIndex = 10;
            this.CmbProvincia.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbProvincia_Format);
            this.CmbProvincia.SelectedValueChanged += new System.EventHandler(this.CmbProvincia_SelectedValueChanged);
            this.CmbProvincia.Enter += new System.EventHandler(this.CmbProvincia_Enter);
            this.CmbProvincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            this.CmbProvincia.Leave += new System.EventHandler(this.CmbDepartamento_Leave);
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDepartamento.DropDownWidth = 200;
            this.CmbDepartamento.FormattingEnabled = true;
            this.CmbDepartamento.Location = new System.Drawing.Point(176, 156);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(40, 28);
            this.CmbDepartamento.TabIndex = 9;
            this.CmbDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboDepartamento_Format);
            this.CmbDepartamento.SelectedValueChanged += new System.EventHandler(this.CmbDepartamento_SelectedValueChanged);
            this.CmbDepartamento.Enter += new System.EventHandler(this.CmbDepartamento_Enter);
            this.CmbDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            this.CmbDepartamento.Leave += new System.EventHandler(this.CmbDepartamento_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ubicación:";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(176, 124);
            this.TxtRazonSocial.MaxLength = 255;
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(409, 26);
            this.TxtRazonSocial.TabIndex = 7;
            this.TxtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Razón Social:";
            // 
            // TxtNombreComercial
            // 
            this.TxtNombreComercial.Location = new System.Drawing.Point(176, 92);
            this.TxtNombreComercial.MaxLength = 255;
            this.TxtNombreComercial.Name = "TxtNombreComercial";
            this.TxtNombreComercial.Size = new System.Drawing.Size(409, 26);
            this.TxtNombreComercial.TabIndex = 5;
            this.TxtNombreComercial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre Comercial:";
            // 
            // TxtNroIDEmpresa
            // 
            this.TxtNroIDEmpresa.Location = new System.Drawing.Point(176, 60);
            this.TxtNroIDEmpresa.MaxLength = 20;
            this.TxtNroIDEmpresa.Name = "TxtNroIDEmpresa";
            this.TxtNroIDEmpresa.Size = new System.Drawing.Size(190, 26);
            this.TxtNroIDEmpresa.TabIndex = 3;
            this.TxtNroIDEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroIDEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nro de Identificación:";
            // 
            // CmbTipoIDEmpresa
            // 
            this.CmbTipoIDEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoIDEmpresa.FormattingEnabled = true;
            this.CmbTipoIDEmpresa.Location = new System.Drawing.Point(176, 26);
            this.CmbTipoIDEmpresa.Name = "CmbTipoIDEmpresa";
            this.CmbTipoIDEmpresa.Size = new System.Drawing.Size(307, 28);
            this.CmbTipoIDEmpresa.TabIndex = 1;
            this.CmbTipoIDEmpresa.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.ComboID_Format);
            this.CmbTipoIDEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Identificación:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnGuardar,
            this.TsBtnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(626, 54);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // TsBtnGuardar
            // 
            this.TsBtnGuardar.Image = global::EsconPOS.Properties.Resources.Guardar;
            this.TsBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnGuardar.Name = "TsBtnGuardar";
            this.TsBtnGuardar.Size = new System.Drawing.Size(53, 51);
            this.TsBtnGuardar.Text = "&Guardar";
            this.TsBtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnGuardar.Click += new System.EventHandler(this.TsBtnGuardar_Click);
            // 
            // TsBtnSalir
            // 
            this.TsBtnSalir.Image = global::EsconPOS.Properties.Resources.Close;
            this.TsBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnSalir.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TsBtnSalir.Name = "TsBtnSalir";
            this.TsBtnSalir.Size = new System.Drawing.Size(43, 51);
            this.TsBtnSalir.Text = "&Cerrar";
            this.TsBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnSalir.Click += new System.EventHandler(this.TsBtnSalir_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 592);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.GboxEmpresa);
            this.Controls.Add(this.GboxCaja);
            this.Controls.Add(this.GboxAdministrador);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración inicial";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmConfiguracion_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmConfiguracion_FormClosed);
            this.Load += new System.EventHandler(this.FrmConfiguracion_Load);
            this.GboxAdministrador.ResumeLayout(false);
            this.GboxAdministrador.PerformLayout();
            this.GboxCaja.ResumeLayout(false);
            this.GboxCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCajaID)).EndInit();
            this.GboxEmpresa.ResumeLayout(false);
            this.GboxEmpresa.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GboxAdministrador;
        private System.Windows.Forms.CheckBox ChkEsSupervisor;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtNroIDEmpleado;
        private System.Windows.Forms.ComboBox CmbTipoIDEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GboxCaja;
        private System.Windows.Forms.NumericUpDown NumCajaID;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox GboxEmpresa;
        private System.Windows.Forms.TextBox TxtNroIDEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoIDEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNombreComercial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox CmbProvincia;
        private System.Windows.Forms.ComboBox CmbDistrito;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsBtnGuardar;
        private System.Windows.Forms.ToolStripButton TsBtnSalir;
    }
}