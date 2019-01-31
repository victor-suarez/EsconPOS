namespace EsconPOS.forms
{
    partial class FrmDocumento
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
            this.TabTiposDocumentos = new System.Windows.Forms.TabControl();
            this.PagLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroIniciales = new System.Windows.Forms.TextBox();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.DgvTiposDocumentos = new System.Windows.Forms.DataGridView();
            this.TxtFiltroTipoDocumento = new System.Windows.Forms.TextBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.NumNroSiguiente = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIniciales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkActivo = new System.Windows.Forms.CheckBox();
            this.TxtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabTiposDocumentos.SuspendLayout();
            this.PagLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposDocumentos)).BeginInit();
            this.PagEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumNroSiguiente)).BeginInit();
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
            this.toolStrip.Size = new System.Drawing.Size(626, 54);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(626, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(298, 17);
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
            // TabTiposDocumentos
            // 
            this.TabTiposDocumentos.Controls.Add(this.PagLista);
            this.TabTiposDocumentos.Controls.Add(this.PagEditar);
            this.TabTiposDocumentos.Location = new System.Drawing.Point(0, 57);
            this.TabTiposDocumentos.Name = "TabTiposDocumentos";
            this.TabTiposDocumentos.SelectedIndex = 0;
            this.TabTiposDocumentos.Size = new System.Drawing.Size(627, 378);
            this.TabTiposDocumentos.TabIndex = 0;
            this.TabTiposDocumentos.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.TxtFiltroIniciales);
            this.PagLista.Controls.Add(this.TxtFiltroCodigo);
            this.PagLista.Controls.Add(this.DgvTiposDocumentos);
            this.PagLista.Controls.Add(this.TxtFiltroTipoDocumento);
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
            this.TxtFiltroIniciales.Location = new System.Drawing.Point(91, 6);
            this.TxtFiltroIniciales.MaxLength = 3;
            this.TxtFiltroIniciales.Name = "TxtFiltroIniciales";
            this.TxtFiltroIniciales.Size = new System.Drawing.Size(82, 26);
            this.TxtFiltroIniciales.TabIndex = 1;
            this.TxtFiltroIniciales.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            this.TxtFiltroIniciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
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
            // DgvTiposDocumentos
            // 
            this.DgvTiposDocumentos.AllowUserToAddRows = false;
            this.DgvTiposDocumentos.AllowUserToDeleteRows = false;
            this.DgvTiposDocumentos.AllowUserToOrderColumns = true;
            this.DgvTiposDocumentos.AllowUserToResizeRows = false;
            this.DgvTiposDocumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvTiposDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTiposDocumentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvTiposDocumentos.Location = new System.Drawing.Point(3, 40);
            this.DgvTiposDocumentos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvTiposDocumentos.MultiSelect = false;
            this.DgvTiposDocumentos.Name = "DgvTiposDocumentos";
            this.DgvTiposDocumentos.ReadOnly = true;
            this.DgvTiposDocumentos.RowHeadersVisible = false;
            this.DgvTiposDocumentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTiposDocumentos.Size = new System.Drawing.Size(613, 302);
            this.DgvTiposDocumentos.TabIndex = 3;
            this.DgvTiposDocumentos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTiposDocumentos_CellContentDoubleClick);
            this.DgvTiposDocumentos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTiposDocumentos_ColumnHeaderMouseClick);
            // 
            // TxtFiltroTipoDocumento
            // 
            this.TxtFiltroTipoDocumento.Location = new System.Drawing.Point(179, 6);
            this.TxtFiltroTipoDocumento.MaxLength = 255;
            this.TxtFiltroTipoDocumento.Name = "TxtFiltroTipoDocumento";
            this.TxtFiltroTipoDocumento.Size = new System.Drawing.Size(437, 26);
            this.TxtFiltroTipoDocumento.TabIndex = 2;
            this.TxtFiltroTipoDocumento.TextChanged += new System.EventHandler(this.TxtFiltro_TextChanged);
            this.TxtFiltroTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.NumNroSiguiente);
            this.PagEditar.Controls.Add(this.label3);
            this.PagEditar.Controls.Add(this.TxtIniciales);
            this.PagEditar.Controls.Add(this.label2);
            this.PagEditar.Controls.Add(this.ChkActivo);
            this.PagEditar.Controls.Add(this.TxtTipoDocumento);
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
            // NumNroSiguiente
            // 
            this.NumNroSiguiente.Location = new System.Drawing.Point(152, 140);
            this.NumNroSiguiente.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.NumNroSiguiente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNroSiguiente.Name = "NumNroSiguiente";
            this.NumNroSiguiente.Size = new System.Drawing.Size(120, 26);
            this.NumNroSiguiente.TabIndex = 7;
            this.NumNroSiguiente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumNroSiguiente.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumNroSiguiente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nro. Siguiente:";
            // 
            // TxtIniciales
            // 
            this.TxtIniciales.Location = new System.Drawing.Point(152, 107);
            this.TxtIniciales.MaxLength = 3;
            this.TxtIniciales.Name = "TxtIniciales";
            this.TxtIniciales.Size = new System.Drawing.Size(57, 26);
            this.TxtIniciales.TabIndex = 5;
            this.TxtIniciales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Iniciales:";
            // 
            // ChkActivo
            // 
            this.ChkActivo.AutoSize = true;
            this.ChkActivo.Location = new System.Drawing.Point(152, 172);
            this.ChkActivo.Name = "ChkActivo";
            this.ChkActivo.Size = new System.Drawing.Size(78, 24);
            this.ChkActivo.TabIndex = 8;
            this.ChkActivo.Text = "En uso";
            this.ChkActivo.UseVisualStyleBackColor = true;
            this.ChkActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // TxtTipoDocumento
            // 
            this.TxtTipoDocumento.Location = new System.Drawing.Point(152, 75);
            this.TxtTipoDocumento.MaxLength = 255;
            this.TxtTipoDocumento.Name = "TxtTipoDocumento";
            this.TxtTipoDocumento.Size = new System.Drawing.Size(451, 26);
            this.TxtTipoDocumento.TabIndex = 3;
            this.TxtTipoDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
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
            this.TxtCodigo.MaxLength = 2;
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
            // FrmDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 457);
            this.Controls.Add(this.TabTiposDocumentos);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDocumento";
            this.Text = "Administrar Tipos de Documento";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDocumento_FormClosing);
            this.Load += new System.EventHandler(this.FrmDocumento_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabTiposDocumentos.ResumeLayout(false);
            this.PagLista.ResumeLayout(false);
            this.PagLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTiposDocumentos)).EndInit();
            this.PagEditar.ResumeLayout(false);
            this.PagEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumNroSiguiente)).EndInit();
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
        private System.Windows.Forms.TabControl TabTiposDocumentos;
        private System.Windows.Forms.TabPage PagLista;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.DataGridView DgvTiposDocumentos;
        private System.Windows.Forms.TextBox TxtFiltroTipoDocumento;
        private System.Windows.Forms.TabPage PagEditar;
        private System.Windows.Forms.CheckBox ChkActivo;
        private System.Windows.Forms.TextBox TxtTipoDocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumNroSiguiente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIniciales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFiltroIniciales;
    }
}