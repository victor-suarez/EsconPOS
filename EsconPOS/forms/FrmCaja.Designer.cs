namespace EsconPOS.forms
{
    partial class FrmCaja
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
            this.Tab = new System.Windows.Forms.TabControl();
            this.TabLista = new System.Windows.Forms.TabPage();
            this.TxtFilterNroTelefonico = new System.Windows.Forms.TextBox();
            this.TxtFilterNombre = new System.Windows.Forms.TextBox();
            this.CmbFilterTipoID = new System.Windows.Forms.ComboBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.TabEditar = new System.Windows.Forms.TabPage();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.Tab.SuspendLayout();
            this.TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
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
            this.toolStrip.Size = new System.Drawing.Size(782, 54);
            this.toolStrip.TabIndex = 2;
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
            // TsBtnEliminar
            // 
            this.TsBtnEliminar.Image = global::EsconPOS.Properties.Resources.Eliminar;
            this.TsBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnEliminar.Name = "TsBtnEliminar";
            this.TsBtnEliminar.Size = new System.Drawing.Size(54, 51);
            this.TsBtnEliminar.Text = "&Eliminar";
            this.TsBtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 420);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(782, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(454, 17);
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
            // Tab
            // 
            this.Tab.Controls.Add(this.TabLista);
            this.Tab.Controls.Add(this.TabEditar);
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 54);
            this.Tab.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Tab.Name = "Tab";
            this.Tab.SelectedIndex = 0;
            this.Tab.Size = new System.Drawing.Size(782, 366);
            this.Tab.TabIndex = 4;
            // 
            // TabLista
            // 
            this.TabLista.Controls.Add(this.TxtFilterNroTelefonico);
            this.TabLista.Controls.Add(this.TxtFilterNombre);
            this.TabLista.Controls.Add(this.CmbFilterTipoID);
            this.TabLista.Controls.Add(this.Dgv);
            this.TabLista.Location = new System.Drawing.Point(4, 29);
            this.TabLista.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TabLista.Name = "TabLista";
            this.TabLista.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TabLista.Size = new System.Drawing.Size(774, 333);
            this.TabLista.TabIndex = 0;
            this.TabLista.Text = "Lista";
            this.TabLista.UseVisualStyleBackColor = true;
            // 
            // TxtFilterNroTelefonico
            // 
            this.TxtFilterNroTelefonico.Location = new System.Drawing.Point(1104, 14);
            this.TxtFilterNroTelefonico.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtFilterNroTelefonico.Name = "TxtFilterNroTelefonico";
            this.TxtFilterNroTelefonico.Size = new System.Drawing.Size(332, 26);
            this.TxtFilterNroTelefonico.TabIndex = 3;
            // 
            // TxtFilterNombre
            // 
            this.TxtFilterNombre.Location = new System.Drawing.Point(14, 14);
            this.TxtFilterNombre.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtFilterNombre.Name = "TxtFilterNombre";
            this.TxtFilterNombre.Size = new System.Drawing.Size(514, 26);
            this.TxtFilterNombre.TabIndex = 2;
            // 
            // CmbFilterTipoID
            // 
            this.CmbFilterTipoID.FormattingEnabled = true;
            this.CmbFilterTipoID.Location = new System.Drawing.Point(546, 14);
            this.CmbFilterTipoID.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CmbFilterTipoID.Name = "CmbFilterTipoID";
            this.CmbFilterTipoID.Size = new System.Drawing.Size(126, 28);
            this.CmbFilterTipoID.TabIndex = 1;
            // 
            // Dgv
            // 
            this.Dgv.AllowUserToAddRows = false;
            this.Dgv.AllowUserToDeleteRows = false;
            this.Dgv.AllowUserToOrderColumns = true;
            this.Dgv.AllowUserToResizeRows = false;
            this.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv.Location = new System.Drawing.Point(6, 48);
            this.Dgv.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Dgv.MultiSelect = false;
            this.Dgv.Name = "Dgv";
            this.Dgv.ReadOnly = true;
            this.Dgv.RowHeadersVisible = false;
            this.Dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv.Size = new System.Drawing.Size(762, 277);
            this.Dgv.TabIndex = 0;
            // 
            // TabEditar
            // 
            this.TabEditar.Location = new System.Drawing.Point(4, 29);
            this.TabEditar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TabEditar.Name = "TabEditar";
            this.TabEditar.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TabEditar.Size = new System.Drawing.Size(774, 333);
            this.TabEditar.TabIndex = 1;
            this.TabEditar.Text = "Editar";
            this.TabEditar.UseVisualStyleBackColor = true;
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 442);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCaja";
            this.Text = "Caja";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.Tab.ResumeLayout(false);
            this.TabLista.ResumeLayout(false);
            this.TabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
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
        private System.Windows.Forms.TabControl Tab;
        private System.Windows.Forms.TabPage TabLista;
        private System.Windows.Forms.TextBox TxtFilterNroTelefonico;
        private System.Windows.Forms.TextBox TxtFilterNombre;
        private System.Windows.Forms.ComboBox CmbFilterTipoID;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.TabPage TabEditar;
    }
}