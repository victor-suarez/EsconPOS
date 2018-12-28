namespace EsconPOS.forms
{
    partial class FrmMarca
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblAgregado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblModificado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabMarcas = new System.Windows.Forms.TabControl();
            this.PagLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.DgvMarcas = new System.Windows.Forms.DataGridView();
            this.TxtFiltroMarca = new System.Windows.Forms.TextBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.ChkActiva = new System.Windows.Forms.CheckBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabMarcas.SuspendLayout();
            this.PagLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).BeginInit();
            this.PagEditar.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(646, 54);
            this.toolStrip.TabIndex = 1;
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
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 443);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(646, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(318, 17);
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
            // TabMarcas
            // 
            this.TabMarcas.Controls.Add(this.PagLista);
            this.TabMarcas.Controls.Add(this.PagEditar);
            this.TabMarcas.Location = new System.Drawing.Point(12, 57);
            this.TabMarcas.Name = "TabMarcas";
            this.TabMarcas.SelectedIndex = 0;
            this.TabMarcas.Size = new System.Drawing.Size(627, 378);
            this.TabMarcas.TabIndex = 0;
            this.TabMarcas.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.TxtFiltroCodigo);
            this.PagLista.Controls.Add(this.DgvMarcas);
            this.PagLista.Controls.Add(this.TxtFiltroMarca);
            this.PagLista.Location = new System.Drawing.Point(4, 29);
            this.PagLista.Name = "PagLista";
            this.PagLista.Padding = new System.Windows.Forms.Padding(3);
            this.PagLista.Size = new System.Drawing.Size(619, 345);
            this.PagLista.TabIndex = 0;
            this.PagLista.Text = "Lista";
            this.PagLista.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroCodigo
            // 
            this.TxtFiltroCodigo.Location = new System.Drawing.Point(3, 6);
            this.TxtFiltroCodigo.MaxLength = 3;
            this.TxtFiltroCodigo.Name = "TxtFiltroCodigo";
            this.TxtFiltroCodigo.Size = new System.Drawing.Size(82, 26);
            this.TxtFiltroCodigo.TabIndex = 0;
            this.TxtFiltroCodigo.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            this.TxtFiltroCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // DgvMarcas
            // 
            this.DgvMarcas.AllowUserToAddRows = false;
            this.DgvMarcas.AllowUserToDeleteRows = false;
            this.DgvMarcas.AllowUserToOrderColumns = true;
            this.DgvMarcas.AllowUserToResizeRows = false;
            this.DgvMarcas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvMarcas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvMarcas.Location = new System.Drawing.Point(3, 40);
            this.DgvMarcas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvMarcas.MultiSelect = false;
            this.DgvMarcas.Name = "DgvMarcas";
            this.DgvMarcas.ReadOnly = true;
            this.DgvMarcas.RowHeadersVisible = false;
            this.DgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvMarcas.Size = new System.Drawing.Size(613, 302);
            this.DgvMarcas.TabIndex = 2;
            this.DgvMarcas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMarcas_CellContentDoubleClick);
            this.DgvMarcas.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvMarcas_ColumnHeaderMouseClick);
            // 
            // TxtFiltroMarca
            // 
            this.TxtFiltroMarca.Location = new System.Drawing.Point(91, 6);
            this.TxtFiltroMarca.MaxLength = 255;
            this.TxtFiltroMarca.Name = "TxtFiltroMarca";
            this.TxtFiltroMarca.Size = new System.Drawing.Size(525, 26);
            this.TxtFiltroMarca.TabIndex = 1;
            this.TxtFiltroMarca.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            this.TxtFiltroMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.ChkActiva);
            this.PagEditar.Controls.Add(this.TxtMarca);
            this.PagEditar.Controls.Add(this.label8);
            this.PagEditar.Controls.Add(this.TxtCodigo);
            this.PagEditar.Controls.Add(this.label1);
            this.PagEditar.Location = new System.Drawing.Point(4, 29);
            this.PagEditar.Name = "PagEditar";
            this.PagEditar.Padding = new System.Windows.Forms.Padding(3);
            this.PagEditar.Size = new System.Drawing.Size(619, 345);
            this.PagEditar.TabIndex = 1;
            this.PagEditar.Text = "Editar";
            this.PagEditar.UseVisualStyleBackColor = true;
            // 
            // ChkActiva
            // 
            this.ChkActiva.AutoSize = true;
            this.ChkActiva.Location = new System.Drawing.Point(152, 107);
            this.ChkActiva.Name = "ChkActiva";
            this.ChkActiva.Size = new System.Drawing.Size(78, 24);
            this.ChkActiva.TabIndex = 4;
            this.ChkActiva.Text = "En uso";
            this.ChkActiva.UseVisualStyleBackColor = true;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(152, 75);
            this.TxtMarca.MaxLength = 255;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(451, 26);
            this.TxtMarca.TabIndex = 3;
            this.TxtMarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(152, 43);
            this.TxtCodigo.MaxLength = 3;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(57, 26);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 465);
            this.Controls.Add(this.TabMarcas);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMarca";
            this.Text = "Administrar Marcas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMarca_FormClosing);
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabMarcas.ResumeLayout(false);
            this.PagLista.ResumeLayout(false);
            this.PagLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvMarcas)).EndInit();
            this.PagEditar.ResumeLayout(false);
            this.PagEditar.PerformLayout();
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
        private System.Windows.Forms.TabControl TabMarcas;
        private System.Windows.Forms.TabPage PagLista;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.DataGridView DgvMarcas;
        private System.Windows.Forms.TextBox TxtFiltroMarca;
        private System.Windows.Forms.TabPage PagEditar;
        private System.Windows.Forms.CheckBox ChkActiva;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
    }
}