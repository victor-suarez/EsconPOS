namespace EsconPOS.forms
{
    partial class FrmBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBanco));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TabBancos = new System.Windows.Forms.TabControl();
            this.PagLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroIniciales = new System.Windows.Forms.TextBox();
            this.DgvBancos = new System.Windows.Forms.DataGridView();
            this.TxtFiltroBanco = new System.Windows.Forms.TextBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.TxtBIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkActiva = new System.Windows.Forms.CheckBox();
            this.TxtBanco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIniciales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblAgregado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblModificado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.TabBancos.SuspendLayout();
            this.PagLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBancos)).BeginInit();
            this.PagEditar.SuspendLayout();
            this.statusStrip.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(647, 54);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // TabBancos
            // 
            this.TabBancos.Controls.Add(this.PagLista);
            this.TabBancos.Controls.Add(this.PagEditar);
            this.TabBancos.Location = new System.Drawing.Point(12, 57);
            this.TabBancos.Name = "TabBancos";
            this.TabBancos.SelectedIndex = 0;
            this.TabBancos.Size = new System.Drawing.Size(627, 378);
            this.TabBancos.TabIndex = 0;
            this.TabBancos.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.TxtFiltroIniciales);
            this.PagLista.Controls.Add(this.DgvBancos);
            this.PagLista.Controls.Add(this.TxtFiltroBanco);
            this.PagLista.Location = new System.Drawing.Point(4, 29);
            this.PagLista.Name = "PagLista";
            this.PagLista.Padding = new System.Windows.Forms.Padding(3);
            this.PagLista.Size = new System.Drawing.Size(619, 345);
            this.PagLista.TabIndex = 0;
            this.PagLista.Text = "Lista";
            this.PagLista.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroIniciales
            // 
            this.TxtFiltroIniciales.Location = new System.Drawing.Point(3, 6);
            this.TxtFiltroIniciales.MaxLength = 3;
            this.TxtFiltroIniciales.Name = "TxtFiltroIniciales";
            this.TxtFiltroIniciales.Size = new System.Drawing.Size(131, 26);
            this.TxtFiltroIniciales.TabIndex = 0;
            this.TxtFiltroIniciales.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            this.TxtFiltroIniciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // DgvBancos
            // 
            this.DgvBancos.AllowUserToAddRows = false;
            this.DgvBancos.AllowUserToDeleteRows = false;
            this.DgvBancos.AllowUserToOrderColumns = true;
            this.DgvBancos.AllowUserToResizeRows = false;
            this.DgvBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvBancos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvBancos.Location = new System.Drawing.Point(3, 40);
            this.DgvBancos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvBancos.MultiSelect = false;
            this.DgvBancos.Name = "DgvBancos";
            this.DgvBancos.ReadOnly = true;
            this.DgvBancos.RowHeadersVisible = false;
            this.DgvBancos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvBancos.Size = new System.Drawing.Size(613, 302);
            this.DgvBancos.TabIndex = 2;
            this.DgvBancos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBancos_CellContentDoubleClick);
            this.DgvBancos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvBancos_ColumnHeaderMouseClick);
            // 
            // TxtFiltroBanco
            // 
            this.TxtFiltroBanco.Location = new System.Drawing.Point(140, 6);
            this.TxtFiltroBanco.MaxLength = 255;
            this.TxtFiltroBanco.Name = "TxtFiltroBanco";
            this.TxtFiltroBanco.Size = new System.Drawing.Size(476, 26);
            this.TxtFiltroBanco.TabIndex = 1;
            this.TxtFiltroBanco.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            this.TxtFiltroBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.TxtBIN);
            this.PagEditar.Controls.Add(this.label3);
            this.PagEditar.Controls.Add(this.TxtCodigo);
            this.PagEditar.Controls.Add(this.label2);
            this.PagEditar.Controls.Add(this.ChkActiva);
            this.PagEditar.Controls.Add(this.TxtBanco);
            this.PagEditar.Controls.Add(this.label8);
            this.PagEditar.Controls.Add(this.TxtIniciales);
            this.PagEditar.Controls.Add(this.label1);
            this.PagEditar.Location = new System.Drawing.Point(4, 29);
            this.PagEditar.Name = "PagEditar";
            this.PagEditar.Padding = new System.Windows.Forms.Padding(3);
            this.PagEditar.Size = new System.Drawing.Size(619, 345);
            this.PagEditar.TabIndex = 1;
            this.PagEditar.Text = "Editar";
            this.PagEditar.UseVisualStyleBackColor = true;
            // 
            // TxtBIN
            // 
            this.TxtBIN.Location = new System.Drawing.Point(109, 143);
            this.TxtBIN.MaxLength = 8;
            this.TxtBIN.Name = "TxtBIN";
            this.TxtBIN.Size = new System.Drawing.Size(78, 26);
            this.TxtBIN.TabIndex = 7;
            this.TxtBIN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "B.I.N.:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(109, 111);
            this.TxtCodigo.MaxLength = 15;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(78, 26);
            this.TxtCodigo.TabIndex = 5;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // ChkActiva
            // 
            this.ChkActiva.AutoSize = true;
            this.ChkActiva.Location = new System.Drawing.Point(109, 175);
            this.ChkActiva.Name = "ChkActiva";
            this.ChkActiva.Size = new System.Drawing.Size(78, 24);
            this.ChkActiva.TabIndex = 8;
            this.ChkActiva.Text = "En uso";
            this.ChkActiva.UseVisualStyleBackColor = true;
            this.ChkActiva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // TxtBanco
            // 
            this.TxtBanco.Location = new System.Drawing.Point(109, 47);
            this.TxtBanco.MaxLength = 255;
            this.TxtBanco.Name = "TxtBanco";
            this.TxtBanco.Size = new System.Drawing.Size(483, 26);
            this.TxtBanco.TabIndex = 1;
            this.TxtBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre:";
            // 
            // TxtIniciales
            // 
            this.TxtIniciales.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtIniciales.Location = new System.Drawing.Point(109, 79);
            this.TxtIniciales.MaxLength = 50;
            this.TxtIniciales.Name = "TxtIniciales";
            this.TxtIniciales.Size = new System.Drawing.Size(124, 26);
            this.TxtIniciales.TabIndex = 3;
            this.TxtIniciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iniciales:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 444);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(647, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(319, 17);
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
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 466);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.TabBancos);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBanco";
            this.Text = "Administrar Entidades Financieras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanco_FormClosing);
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.TabBancos.ResumeLayout(false);
            this.PagLista.ResumeLayout(false);
            this.PagLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvBancos)).EndInit();
            this.PagEditar.ResumeLayout(false);
            this.PagEditar.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.TabControl TabBancos;
        private System.Windows.Forms.TabPage PagLista;
        private System.Windows.Forms.TextBox TxtFiltroIniciales;
        private System.Windows.Forms.DataGridView DgvBancos;
        private System.Windows.Forms.TextBox TxtFiltroBanco;
        private System.Windows.Forms.TabPage PagEditar;
        private System.Windows.Forms.CheckBox ChkActiva;
        private System.Windows.Forms.TextBox TxtBanco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIniciales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TssLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel TssLblAgregado;
        private System.Windows.Forms.ToolStripStatusLabel TssLblModificado;
        private System.Windows.Forms.TextBox TxtBIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
    }
}