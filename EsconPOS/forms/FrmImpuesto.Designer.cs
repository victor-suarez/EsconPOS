namespace EsconPOS.forms
{
    partial class FrmImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpuesto));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblAgregado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblModificado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabImpuestos = new System.Windows.Forms.TabControl();
            this.PagLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroIniciales = new System.Windows.Forms.TextBox();
            this.TxtFiltroTipo = new System.Windows.Forms.TextBox();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.DgvImpuestos = new System.Windows.Forms.DataGridView();
            this.TxtFiltroImpuesto = new System.Windows.Forms.TextBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.DtpValidoDesde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.NumTasa = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtIniciales = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCategoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtImpuesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabImpuestos.SuspendLayout();
            this.PagLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImpuestos)).BeginInit();
            this.PagEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTasa)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnGuardar,
            this.TsBtnDeshacer,
            this.TsBtnEliminar,
            this.toolStripSeparator1,
            this.TsBtnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(803, 54);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 416);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(803, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(475, 17);
            this.TssLblStatus.Spring = true;
            this.TssLblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TssLblAgregado
            // 
            this.TssLblAgregado.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TssLblAgregado.Name = "TssLblAgregado";
            this.TssLblAgregado.Size = new System.Drawing.Size(150, 17);
            this.TssLblAgregado.Text = "Agregado por 99-99-9999 99:99:99";
            // 
            // TssLblModificado
            // 
            this.TssLblModificado.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TssLblModificado.Name = "TssLblModificado";
            this.TssLblModificado.Size = new System.Drawing.Size(155, 17);
            this.TssLblModificado.Text = "Modificado por 99-99-9999 99:99:99";
            // 
            // TabImpuestos
            // 
            this.TabImpuestos.Controls.Add(this.PagLista);
            this.TabImpuestos.Controls.Add(this.PagEditar);
            this.TabImpuestos.Location = new System.Drawing.Point(12, 57);
            this.TabImpuestos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabImpuestos.Name = "TabImpuestos";
            this.TabImpuestos.SelectedIndex = 0;
            this.TabImpuestos.Size = new System.Drawing.Size(778, 349);
            this.TabImpuestos.TabIndex = 0;
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.TxtFiltroIniciales);
            this.PagLista.Controls.Add(this.TxtFiltroTipo);
            this.PagLista.Controls.Add(this.TxtFiltroCodigo);
            this.PagLista.Controls.Add(this.DgvImpuestos);
            this.PagLista.Controls.Add(this.TxtFiltroImpuesto);
            this.PagLista.Location = new System.Drawing.Point(4, 29);
            this.PagLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PagLista.Name = "PagLista";
            this.PagLista.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PagLista.Size = new System.Drawing.Size(770, 316);
            this.PagLista.TabIndex = 0;
            this.PagLista.Text = "Lista";
            this.PagLista.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroIniciales
            // 
            this.TxtFiltroIniciales.Location = new System.Drawing.Point(659, 5);
            this.TxtFiltroIniciales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltroIniciales.MaxLength = 3;
            this.TxtFiltroIniciales.Name = "TxtFiltroIniciales";
            this.TxtFiltroIniciales.Size = new System.Drawing.Size(84, 26);
            this.TxtFiltroIniciales.TabIndex = 3;
            // 
            // TxtFiltroTipo
            // 
            this.TxtFiltroTipo.Location = new System.Drawing.Point(567, 5);
            this.TxtFiltroTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltroTipo.MaxLength = 3;
            this.TxtFiltroTipo.Name = "TxtFiltroTipo";
            this.TxtFiltroTipo.Size = new System.Drawing.Size(84, 26);
            this.TxtFiltroTipo.TabIndex = 2;
            // 
            // TxtFiltroCodigo
            // 
            this.TxtFiltroCodigo.Location = new System.Drawing.Point(6, 6);
            this.TxtFiltroCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltroCodigo.MaxLength = 3;
            this.TxtFiltroCodigo.Name = "TxtFiltroCodigo";
            this.TxtFiltroCodigo.Size = new System.Drawing.Size(84, 26);
            this.TxtFiltroCodigo.TabIndex = 0;
            // 
            // DgvImpuestos
            // 
            this.DgvImpuestos.AllowUserToAddRows = false;
            this.DgvImpuestos.AllowUserToDeleteRows = false;
            this.DgvImpuestos.AllowUserToOrderColumns = true;
            this.DgvImpuestos.AllowUserToResizeRows = false;
            this.DgvImpuestos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvImpuestos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvImpuestos.Location = new System.Drawing.Point(4, 36);
            this.DgvImpuestos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DgvImpuestos.MultiSelect = false;
            this.DgvImpuestos.Name = "DgvImpuestos";
            this.DgvImpuestos.ReadOnly = true;
            this.DgvImpuestos.RowHeadersVisible = false;
            this.DgvImpuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvImpuestos.Size = new System.Drawing.Size(762, 275);
            this.DgvImpuestos.TabIndex = 4;
            this.DgvImpuestos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvImpuestos_CellContentDoubleClick);
            this.DgvImpuestos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvImpuestos_ColumnHeaderMouseClick);
            // 
            // TxtFiltroImpuesto
            // 
            this.TxtFiltroImpuesto.Location = new System.Drawing.Point(98, 6);
            this.TxtFiltroImpuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltroImpuesto.MaxLength = 255;
            this.TxtFiltroImpuesto.Name = "TxtFiltroImpuesto";
            this.TxtFiltroImpuesto.Size = new System.Drawing.Size(461, 26);
            this.TxtFiltroImpuesto.TabIndex = 1;
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.DtpValidoDesde);
            this.PagEditar.Controls.Add(this.label6);
            this.PagEditar.Controls.Add(this.NumTasa);
            this.PagEditar.Controls.Add(this.label5);
            this.PagEditar.Controls.Add(this.TxtIniciales);
            this.PagEditar.Controls.Add(this.label4);
            this.PagEditar.Controls.Add(this.TxtCategoria);
            this.PagEditar.Controls.Add(this.label3);
            this.PagEditar.Controls.Add(this.TxtTipo);
            this.PagEditar.Controls.Add(this.label2);
            this.PagEditar.Controls.Add(this.ChkActivo);
            this.PagEditar.Controls.Add(this.TxtImpuesto);
            this.PagEditar.Controls.Add(this.label8);
            this.PagEditar.Controls.Add(this.TxtCodigo);
            this.PagEditar.Controls.Add(this.label1);
            this.PagEditar.Location = new System.Drawing.Point(4, 29);
            this.PagEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PagEditar.Name = "PagEditar";
            this.PagEditar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PagEditar.Size = new System.Drawing.Size(770, 316);
            this.PagEditar.TabIndex = 1;
            this.PagEditar.Text = "Editar";
            this.PagEditar.UseVisualStyleBackColor = true;
            // 
            // DtpValidoDesde
            // 
            this.DtpValidoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpValidoDesde.Location = new System.Drawing.Point(225, 228);
            this.DtpValidoDesde.Name = "DtpValidoDesde";
            this.DtpValidoDesde.Size = new System.Drawing.Size(126, 26);
            this.DtpValidoDesde.TabIndex = 13;
            this.DtpValidoDesde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtp_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Válido desde:";
            // 
            // NumTasa
            // 
            this.NumTasa.DecimalPlaces = 2;
            this.NumTasa.Location = new System.Drawing.Point(225, 196);
            this.NumTasa.Name = "NumTasa";
            this.NumTasa.Size = new System.Drawing.Size(84, 26);
            this.NumTasa.TabIndex = 11;
            this.NumTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumTasa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tasa:";
            // 
            // TxtIniciales
            // 
            this.TxtIniciales.Location = new System.Drawing.Point(225, 162);
            this.TxtIniciales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtIniciales.MaxLength = 3;
            this.TxtIniciales.Name = "TxtIniciales";
            this.TxtIniciales.Size = new System.Drawing.Size(84, 26);
            this.TxtIniciales.TabIndex = 9;
            this.TxtIniciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iniciales:";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Location = new System.Drawing.Point(225, 126);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCategoria.MaxLength = 1;
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.Size = new System.Drawing.Size(32, 26);
            this.TxtCategoria.TabIndex = 7;
            this.TxtCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Categoría:";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(225, 90);
            this.TxtTipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTipo.MaxLength = 3;
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(84, 26);
            this.TxtTipo.TabIndex = 5;
            this.TxtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Location = new System.Drawing.Point(225, 262);
            this.ChkActivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(78, 24);
            this.ChkActivo.TabIndex = 14;
            this.ChkActivo.Text = "En uso";
            this.ChkActivo.UseVisualStyleBackColor = true;
            this.ChkActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // TxtImpuesto
            // 
            this.TxtImpuesto.Location = new System.Drawing.Point(225, 54);
            this.TxtImpuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtImpuesto.MaxLength = 255;
            this.TxtImpuesto.Name = "TxtImpuesto";
            this.TxtImpuesto.Size = new System.Drawing.Size(527, 26);
            this.TxtImpuesto.TabIndex = 3;
            this.TxtImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 58);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(225, 18);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCodigo.MaxLength = 5;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(84, 26);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
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
            // TsBtnDeshacer
            // 
            this.TsBtnDeshacer.Image = global::EsconPOS.Properties.Resources.Limpiar;
            this.TsBtnDeshacer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnDeshacer.Name = "TsBtnDeshacer";
            this.TsBtnDeshacer.Size = new System.Drawing.Size(59, 51);
            this.TsBtnDeshacer.Text = "&Deshacer";
            this.TsBtnDeshacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnDeshacer.Click += new System.EventHandler(this.TsBtnDeshacer_Click);
            // 
            // TsBtnEliminar
            // 
            this.TsBtnEliminar.Image = global::EsconPOS.Properties.Resources.Eliminar;
            this.TsBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnEliminar.Name = "TsBtnEliminar";
            this.TsBtnEliminar.Size = new System.Drawing.Size(54, 51);
            this.TsBtnEliminar.Text = "&Eliminar";
            this.TsBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnEliminar.Click += new System.EventHandler(this.TsBtnEliminar_Click);
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
            // FrmImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 438);
            this.Controls.Add(this.TabImpuestos);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmImpuesto";
            this.Text = "Administrar Impuestos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmImpuesto_FormClosing);
            this.Load += new System.EventHandler(this.FrmImpuesto_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabImpuestos.ResumeLayout(false);
            this.PagLista.ResumeLayout(false);
            this.PagLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvImpuestos)).EndInit();
            this.PagEditar.ResumeLayout(false);
            this.PagEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTasa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsBtnGuardar;
        private System.Windows.Forms.ToolStripButton TsBtnDeshacer;
        private System.Windows.Forms.ToolStripButton TsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsBtnSalir;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TssLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel TssLblAgregado;
        private System.Windows.Forms.ToolStripStatusLabel TssLblModificado;
        private System.Windows.Forms.TabControl TabImpuestos;
        private System.Windows.Forms.TabPage PagLista;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.DataGridView DgvImpuestos;
        private System.Windows.Forms.TextBox TxtFiltroImpuesto;
        private System.Windows.Forms.TabPage PagEditar;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtImpuesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtFiltroIniciales;
        private System.Windows.Forms.TextBox TxtFiltroTipo;
        private System.Windows.Forms.DateTimePicker DtpValidoDesde;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumTasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtIniciales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label label2;
    }
}