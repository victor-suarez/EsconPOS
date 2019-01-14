namespace EsconPOS.forms
{
    partial class FrmFormasPago
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
            this.TabFormaPago = new System.Windows.Forms.TabControl();
            this.PagLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.DgvFormasPago = new System.Windows.Forms.DataGridView();
            this.TxtFiltroFormaPago = new System.Windows.Forms.TextBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.ChkRequiereNumero = new System.Windows.Forms.CheckBox();
            this.ChkRequiereBanco = new System.Windows.Forms.CheckBox();
            this.NumOrden = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkRequiereAutorizacion = new System.Windows.Forms.CheckBox();
            this.ChkActiva = new System.Windows.Forms.CheckBox();
            this.TxtFormaPago = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabFormaPago.SuspendLayout();
            this.PagLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormasPago)).BeginInit();
            this.PagEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrden)).BeginInit();
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
            this.statusStrip.Location = new System.Drawing.Point(0, 315);
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
            // TabFormaPago
            // 
            this.TabFormaPago.Controls.Add(this.PagLista);
            this.TabFormaPago.Controls.Add(this.PagEditar);
            this.TabFormaPago.Location = new System.Drawing.Point(12, 57);
            this.TabFormaPago.Name = "TabFormaPago";
            this.TabFormaPago.SelectedIndex = 0;
            this.TabFormaPago.Size = new System.Drawing.Size(627, 258);
            this.TabFormaPago.TabIndex = 0;
            this.TabFormaPago.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.TxtFiltroCodigo);
            this.PagLista.Controls.Add(this.DgvFormasPago);
            this.PagLista.Controls.Add(this.TxtFiltroFormaPago);
            this.PagLista.Location = new System.Drawing.Point(4, 29);
            this.PagLista.Name = "PagLista";
            this.PagLista.Padding = new System.Windows.Forms.Padding(3);
            this.PagLista.Size = new System.Drawing.Size(619, 225);
            this.PagLista.TabIndex = 0;
            this.PagLista.Text = "Lista";
            this.PagLista.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroCodigo
            // 
            this.TxtFiltroCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtFiltroCodigo.Location = new System.Drawing.Point(3, 6);
            this.TxtFiltroCodigo.MaxLength = 3;
            this.TxtFiltroCodigo.Name = "TxtFiltroCodigo";
            this.TxtFiltroCodigo.Size = new System.Drawing.Size(79, 26);
            this.TxtFiltroCodigo.TabIndex = 0;
            this.TxtFiltroCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // DgvFormasPago
            // 
            this.DgvFormasPago.AllowUserToAddRows = false;
            this.DgvFormasPago.AllowUserToDeleteRows = false;
            this.DgvFormasPago.AllowUserToOrderColumns = true;
            this.DgvFormasPago.AllowUserToResizeRows = false;
            this.DgvFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFormasPago.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvFormasPago.Location = new System.Drawing.Point(3, 40);
            this.DgvFormasPago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvFormasPago.MultiSelect = false;
            this.DgvFormasPago.Name = "DgvFormasPago";
            this.DgvFormasPago.ReadOnly = true;
            this.DgvFormasPago.RowHeadersVisible = false;
            this.DgvFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvFormasPago.Size = new System.Drawing.Size(613, 182);
            this.DgvFormasPago.TabIndex = 2;
            this.DgvFormasPago.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFormasPago_CellContentDoubleClick);
            this.DgvFormasPago.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvFormasPago_ColumnHeaderMouseClick);
            // 
            // TxtFiltroFormaPago
            // 
            this.TxtFiltroFormaPago.Location = new System.Drawing.Point(88, 6);
            this.TxtFiltroFormaPago.MaxLength = 255;
            this.TxtFiltroFormaPago.Name = "TxtFiltroFormaPago";
            this.TxtFiltroFormaPago.Size = new System.Drawing.Size(528, 26);
            this.TxtFiltroFormaPago.TabIndex = 1;
            this.TxtFiltroFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.ChkRequiereNumero);
            this.PagEditar.Controls.Add(this.ChkRequiereBanco);
            this.PagEditar.Controls.Add(this.NumOrden);
            this.PagEditar.Controls.Add(this.label2);
            this.PagEditar.Controls.Add(this.ChkRequiereAutorizacion);
            this.PagEditar.Controls.Add(this.ChkActiva);
            this.PagEditar.Controls.Add(this.TxtFormaPago);
            this.PagEditar.Controls.Add(this.label8);
            this.PagEditar.Controls.Add(this.TxtCodigo);
            this.PagEditar.Controls.Add(this.label1);
            this.PagEditar.Location = new System.Drawing.Point(4, 29);
            this.PagEditar.Name = "PagEditar";
            this.PagEditar.Padding = new System.Windows.Forms.Padding(3);
            this.PagEditar.Size = new System.Drawing.Size(619, 225);
            this.PagEditar.TabIndex = 1;
            this.PagEditar.Text = "Editar";
            this.PagEditar.UseVisualStyleBackColor = true;
            // 
            // ChkRequiereNumero
            // 
            this.ChkRequiereNumero.AutoSize = true;
            this.ChkRequiereNumero.Location = new System.Drawing.Point(126, 132);
            this.ChkRequiereNumero.Name = "ChkRequiereNumero";
            this.ChkRequiereNumero.Size = new System.Drawing.Size(151, 24);
            this.ChkRequiereNumero.TabIndex = 7;
            this.ChkRequiereNumero.Text = "Requiere número";
            this.ChkRequiereNumero.UseVisualStyleBackColor = true;
            this.ChkRequiereNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // ChkRequiereBanco
            // 
            this.ChkRequiereBanco.AutoSize = true;
            this.ChkRequiereBanco.Location = new System.Drawing.Point(126, 102);
            this.ChkRequiereBanco.Name = "ChkRequiereBanco";
            this.ChkRequiereBanco.Size = new System.Drawing.Size(141, 24);
            this.ChkRequiereBanco.TabIndex = 6;
            this.ChkRequiereBanco.Text = "Requiere banco";
            this.ChkRequiereBanco.UseVisualStyleBackColor = true;
            this.ChkRequiereBanco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // NumOrden
            // 
            this.NumOrden.Location = new System.Drawing.Point(126, 70);
            this.NumOrden.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOrden.Name = "NumOrden";
            this.NumOrden.Size = new System.Drawing.Size(50, 26);
            this.NumOrden.TabIndex = 5;
            this.NumOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumOrden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOrden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orden en lista:";
            // 
            // ChkRequiereAutorizacion
            // 
            this.ChkRequiereAutorizacion.AutoSize = true;
            this.ChkRequiereAutorizacion.Location = new System.Drawing.Point(126, 162);
            this.ChkRequiereAutorizacion.Name = "ChkRequiereAutorizacion";
            this.ChkRequiereAutorizacion.Size = new System.Drawing.Size(183, 24);
            this.ChkRequiereAutorizacion.TabIndex = 8;
            this.ChkRequiereAutorizacion.Text = "Requiere autorización";
            this.ChkRequiereAutorizacion.UseVisualStyleBackColor = true;
            this.ChkRequiereAutorizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // ChkActiva
            // 
            this.ChkActiva.AutoSize = true;
            this.ChkActiva.Location = new System.Drawing.Point(126, 192);
            this.ChkActiva.Name = "ChkActiva";
            this.ChkActiva.Size = new System.Drawing.Size(78, 24);
            this.ChkActiva.TabIndex = 9;
            this.ChkActiva.Text = "En uso";
            this.ChkActiva.UseVisualStyleBackColor = true;
            this.ChkActiva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Chk_KeyPress);
            // 
            // TxtFormaPago
            // 
            this.TxtFormaPago.Location = new System.Drawing.Point(126, 38);
            this.TxtFormaPago.MaxLength = 255;
            this.TxtFormaPago.Name = "TxtFormaPago";
            this.TxtFormaPago.Size = new System.Drawing.Size(451, 26);
            this.TxtFormaPago.TabIndex = 3;
            this.TxtFormaPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripción:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCodigo.Location = new System.Drawing.Point(126, 6);
            this.TxtCodigo.MaxLength = 4;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(57, 26);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // FrmFormasPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 337);
            this.Controls.Add(this.TabFormaPago);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmFormasPago";
            this.Text = "Administrar Formas de Pago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFormasPago_FormClosing);
            this.Load += new System.EventHandler(this.FrmFormasPago_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabFormaPago.ResumeLayout(false);
            this.PagLista.ResumeLayout(false);
            this.PagLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFormasPago)).EndInit();
            this.PagEditar.ResumeLayout(false);
            this.PagEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOrden)).EndInit();
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
        private System.Windows.Forms.TabControl TabFormaPago;
        private System.Windows.Forms.TabPage PagLista;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.DataGridView DgvFormasPago;
        private System.Windows.Forms.TextBox TxtFiltroFormaPago;
        private System.Windows.Forms.TabPage PagEditar;
        private System.Windows.Forms.NumericUpDown NumOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ChkRequiereAutorizacion;
        private System.Windows.Forms.CheckBox ChkActiva;
        private System.Windows.Forms.TextBox TxtFormaPago;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkRequiereNumero;
        private System.Windows.Forms.CheckBox ChkRequiereBanco;
    }
}