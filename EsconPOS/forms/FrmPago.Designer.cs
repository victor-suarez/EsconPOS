namespace EsconPOS.forms
{
    partial class FrmPago
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbFormaPago = new System.Windows.Forms.ComboBox();
            this.LblBanco = new System.Windows.Forms.Label();
            this.CmbBanco = new System.Windows.Forms.ComboBox();
            this.LblNroDocPago = new System.Windows.Forms.Label();
            this.TxtNroDocPago = new System.Windows.Forms.TextBox();
            this.TxtNroAutPago = new System.Windows.Forms.TextBox();
            this.LblNroAutPago = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumMontoPago = new System.Windows.Forms.NumericUpDown();
            this.GbxDocumento = new System.Windows.Forms.GroupBox();
            this.LblMontoSobrante = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LblMontoFaltante = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LblMontoTotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblCodDocumento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPagos = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsBtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.GbxDatosAdicionales = new System.Windows.Forms.GroupBox();
            this.colFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroDocPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNroAutPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NumMontoPago)).BeginInit();
            this.GbxDocumento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.GbxDatosAdicionales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de pago:";
            // 
            // CmbFormaPago
            // 
            this.CmbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaPago.FormattingEnabled = true;
            this.CmbFormaPago.Location = new System.Drawing.Point(148, 146);
            this.CmbFormaPago.Name = "CmbFormaPago";
            this.CmbFormaPago.Size = new System.Drawing.Size(254, 28);
            this.CmbFormaPago.TabIndex = 1;
            this.CmbFormaPago.SelectedIndexChanged += new System.EventHandler(this.CmbFormaPago_SelectedIndexChanged);
            this.CmbFormaPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // LblBanco
            // 
            this.LblBanco.AutoSize = true;
            this.LblBanco.Location = new System.Drawing.Point(7, 28);
            this.LblBanco.Name = "LblBanco";
            this.LblBanco.Size = new System.Drawing.Size(59, 20);
            this.LblBanco.TabIndex = 2;
            this.LblBanco.Text = "Banco:";
            // 
            // CmbBanco
            // 
            this.CmbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBanco.FormattingEnabled = true;
            this.CmbBanco.Location = new System.Drawing.Point(147, 25);
            this.CmbBanco.Name = "CmbBanco";
            this.CmbBanco.Size = new System.Drawing.Size(254, 28);
            this.CmbBanco.TabIndex = 3;
            this.CmbBanco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // LblNroDocPago
            // 
            this.LblNroDocPago.AutoSize = true;
            this.LblNroDocPago.Location = new System.Drawing.Point(7, 65);
            this.LblNroDocPago.Name = "LblNroDocPago";
            this.LblNroDocPago.Size = new System.Drawing.Size(120, 20);
            this.LblNroDocPago.TabIndex = 4;
            this.LblNroDocPago.Text = "Nro. Doc. Pago:";
            // 
            // TxtNroDocPago
            // 
            this.TxtNroDocPago.Location = new System.Drawing.Point(147, 59);
            this.TxtNroDocPago.Name = "TxtNroDocPago";
            this.TxtNroDocPago.Size = new System.Drawing.Size(208, 26);
            this.TxtNroDocPago.TabIndex = 5;
            // 
            // TxtNroAutPago
            // 
            this.TxtNroAutPago.Location = new System.Drawing.Point(147, 91);
            this.TxtNroAutPago.Name = "TxtNroAutPago";
            this.TxtNroAutPago.Size = new System.Drawing.Size(90, 26);
            this.TxtNroAutPago.TabIndex = 7;
            // 
            // LblNroAutPago
            // 
            this.LblNroAutPago.AutoSize = true;
            this.LblNroAutPago.Location = new System.Drawing.Point(7, 97);
            this.LblNroAutPago.Name = "LblNroAutPago";
            this.LblNroAutPago.Size = new System.Drawing.Size(134, 20);
            this.LblNroAutPago.TabIndex = 6;
            this.LblNroAutPago.Text = "Nro. Autorización:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto:";
            // 
            // NumMontoPago
            // 
            this.NumMontoPago.DecimalPlaces = 2;
            this.NumMontoPago.Location = new System.Drawing.Point(148, 180);
            this.NumMontoPago.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumMontoPago.Name = "NumMontoPago";
            this.NumMontoPago.Size = new System.Drawing.Size(136, 26);
            this.NumMontoPago.TabIndex = 9;
            this.NumMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumMontoPago.ThousandsSeparator = true;
            this.NumMontoPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // GbxDocumento
            // 
            this.GbxDocumento.Controls.Add(this.LblMontoSobrante);
            this.GbxDocumento.Controls.Add(this.label13);
            this.GbxDocumento.Controls.Add(this.LblMontoFaltante);
            this.GbxDocumento.Controls.Add(this.label11);
            this.GbxDocumento.Controls.Add(this.LblMontoTotal);
            this.GbxDocumento.Controls.Add(this.label9);
            this.GbxDocumento.Controls.Add(this.LblCodDocumento);
            this.GbxDocumento.Controls.Add(this.label6);
            this.GbxDocumento.Location = new System.Drawing.Point(12, 57);
            this.GbxDocumento.Name = "GbxDocumento";
            this.GbxDocumento.Size = new System.Drawing.Size(698, 89);
            this.GbxDocumento.TabIndex = 10;
            this.GbxDocumento.TabStop = false;
            this.GbxDocumento.Text = "Documento";
            // 
            // LblMontoSobrante
            // 
            this.LblMontoSobrante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMontoSobrante.Location = new System.Drawing.Point(492, 42);
            this.LblMontoSobrante.Name = "LblMontoSobrante";
            this.LblMontoSobrante.Size = new System.Drawing.Size(156, 23);
            this.LblMontoSobrante.TabIndex = 7;
            this.LblMontoSobrante.Text = "0,00";
            this.LblMontoSobrante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Monto sobrante";
            // 
            // LblMontoFaltante
            // 
            this.LblMontoFaltante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMontoFaltante.Location = new System.Drawing.Point(330, 42);
            this.LblMontoFaltante.Name = "LblMontoFaltante";
            this.LblMontoFaltante.Size = new System.Drawing.Size(156, 23);
            this.LblMontoFaltante.TabIndex = 5;
            this.LblMontoFaltante.Text = "0,00";
            this.LblMontoFaltante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Monto faltante";
            // 
            // LblMontoTotal
            // 
            this.LblMontoTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMontoTotal.Location = new System.Drawing.Point(168, 42);
            this.LblMontoTotal.Name = "LblMontoTotal";
            this.LblMontoTotal.Size = new System.Drawing.Size(156, 23);
            this.LblMontoTotal.TabIndex = 3;
            this.LblMontoTotal.Text = "0,00";
            this.LblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Monto total";
            // 
            // LblCodDocumento
            // 
            this.LblCodDocumento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblCodDocumento.Location = new System.Drawing.Point(6, 42);
            this.LblCodDocumento.Name = "LblCodDocumento";
            this.LblCodDocumento.Size = new System.Drawing.Size(156, 23);
            this.LblCodDocumento.TabIndex = 1;
            this.LblCodDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código documento";
            // 
            // dgvPagos
            // 
            this.dgvPagos.AllowUserToAddRows = false;
            this.dgvPagos.AllowUserToDeleteRows = false;
            this.dgvPagos.AllowUserToResizeRows = false;
            this.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFormaPago,
            this.colMontoPago,
            this.colBanco,
            this.colNroDocPago,
            this.colNroAutPago});
            this.dgvPagos.Location = new System.Drawing.Point(12, 278);
            this.dgvPagos.MultiSelect = false;
            this.dgvPagos.Name = "dgvPagos";
            this.dgvPagos.ReadOnly = true;
            this.dgvPagos.RowHeadersVisible = false;
            this.dgvPagos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPagos.RowTemplate.ReadOnly = true;
            this.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagos.Size = new System.Drawing.Size(803, 130);
            this.dgvPagos.TabIndex = 11;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnAgregar,
            this.TsBtnEliminar,
            this.TsBtnDeshacer,
            this.TsBtnGuardar,
            this.toolStripSeparator1,
            this.TsBtnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(826, 54);
            this.toolStrip.TabIndex = 15;
            this.toolStrip.Text = "toolStrip1";
            // 
            // TsBtnAgregar
            // 
            this.TsBtnAgregar.Image = global::EsconPOS.Properties.Resources.Agregar32;
            this.TsBtnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnAgregar.Name = "TsBtnAgregar";
            this.TsBtnAgregar.Size = new System.Drawing.Size(53, 51);
            this.TsBtnAgregar.Text = "&Agregar";
            this.TsBtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnAgregar.Click += new System.EventHandler(this.TsBtnAgregar_Click);
            // 
            // TsBtnEliminar
            // 
            this.TsBtnEliminar.Image = global::EsconPOS.Properties.Resources.Quitar32;
            this.TsBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnEliminar.Name = "TsBtnEliminar";
            this.TsBtnEliminar.Size = new System.Drawing.Size(44, 51);
            this.TsBtnEliminar.Text = "&Quitar";
            this.TsBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnEliminar.Click += new System.EventHandler(this.TsBtnEliminar_Click);
            // 
            // TsBtnDeshacer
            // 
            this.TsBtnDeshacer.Image = global::EsconPOS.Properties.Resources.Limpiar;
            this.TsBtnDeshacer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnDeshacer.Name = "TsBtnDeshacer";
            this.TsBtnDeshacer.Size = new System.Drawing.Size(59, 51);
            this.TsBtnDeshacer.Text = "&Deshacer";
            this.TsBtnDeshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
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
            // GbxDatosAdicionales
            // 
            this.GbxDatosAdicionales.Controls.Add(this.LblBanco);
            this.GbxDatosAdicionales.Controls.Add(this.CmbBanco);
            this.GbxDatosAdicionales.Controls.Add(this.LblNroDocPago);
            this.GbxDatosAdicionales.Controls.Add(this.TxtNroDocPago);
            this.GbxDatosAdicionales.Controls.Add(this.LblNroAutPago);
            this.GbxDatosAdicionales.Controls.Add(this.TxtNroAutPago);
            this.GbxDatosAdicionales.Location = new System.Drawing.Point(408, 146);
            this.GbxDatosAdicionales.Name = "GbxDatosAdicionales";
            this.GbxDatosAdicionales.Size = new System.Drawing.Size(407, 126);
            this.GbxDatosAdicionales.TabIndex = 16;
            this.GbxDatosAdicionales.TabStop = false;
            this.GbxDatosAdicionales.Text = "Datos adicionales";
            this.GbxDatosAdicionales.Visible = false;
            // 
            // colFormaPago
            // 
            this.colFormaPago.HeaderText = "Forma";
            this.colFormaPago.MinimumWidth = 100;
            this.colFormaPago.Name = "colFormaPago";
            this.colFormaPago.ReadOnly = true;
            // 
            // colMontoPago
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colMontoPago.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMontoPago.HeaderText = "Monto";
            this.colMontoPago.MinimumWidth = 100;
            this.colMontoPago.Name = "colMontoPago";
            this.colMontoPago.ReadOnly = true;
            // 
            // colBanco
            // 
            this.colBanco.HeaderText = "Banco";
            this.colBanco.MinimumWidth = 220;
            this.colBanco.Name = "colBanco";
            this.colBanco.ReadOnly = true;
            this.colBanco.Width = 220;
            // 
            // colNroDocPago
            // 
            this.colNroDocPago.HeaderText = "Nro. Doc. Pago";
            this.colNroDocPago.MinimumWidth = 200;
            this.colNroDocPago.Name = "colNroDocPago";
            this.colNroDocPago.ReadOnly = true;
            this.colNroDocPago.Width = 200;
            // 
            // colNroAutPago
            // 
            this.colNroAutPago.HeaderText = "# Autorización";
            this.colNroAutPago.MinimumWidth = 150;
            this.colNroAutPago.Name = "colNroAutPago";
            this.colNroAutPago.ReadOnly = true;
            this.colNroAutPago.Width = 150;
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 415);
            this.Controls.Add(this.GbxDatosAdicionales);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.dgvPagos);
            this.Controls.Add(this.GbxDocumento);
            this.Controls.Add(this.NumMontoPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CmbFormaPago);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPago";
            this.Text = "Recibir Pago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumMontoPago)).EndInit();
            this.GbxDocumento.ResumeLayout(false);
            this.GbxDocumento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagos)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.GbxDatosAdicionales.ResumeLayout(false);
            this.GbxDatosAdicionales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFormaPago;
        private System.Windows.Forms.Label LblBanco;
        private System.Windows.Forms.ComboBox CmbBanco;
        private System.Windows.Forms.Label LblNroDocPago;
        private System.Windows.Forms.TextBox TxtNroDocPago;
        private System.Windows.Forms.TextBox TxtNroAutPago;
        private System.Windows.Forms.Label LblNroAutPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NumMontoPago;
        private System.Windows.Forms.GroupBox GbxDocumento;
        private System.Windows.Forms.Label LblMontoSobrante;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label LblMontoFaltante;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblMontoTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblCodDocumento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPagos;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsBtnAgregar;
        private System.Windows.Forms.ToolStripButton TsBtnEliminar;
        private System.Windows.Forms.ToolStripButton TsBtnDeshacer;
        private System.Windows.Forms.ToolStripButton TsBtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsBtnSalir;
        private System.Windows.Forms.GroupBox GbxDatosAdicionales;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroDocPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroAutPago;
    }
}