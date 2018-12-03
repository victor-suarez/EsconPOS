namespace EsconPOS.forms
{
    partial class FrmPuntoDeVenta
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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("No Header", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Total X",
            "9.999,99"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoIDCli = new System.Windows.Forms.ComboBox();
            this.TxtNroIDCli = new System.Windows.Forms.TextBox();
            this.DgvProdServ = new System.Windows.Forms.DataGridView();
            this.TxtProdCodigo = new System.Windows.Forms.TextBox();
            this.CmbMarcas = new System.Windows.Forms.ComboBox();
            this.CmbClases = new System.Windows.Forms.ComboBox();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.GbxTotales = new System.Windows.Forms.GroupBox();
            this.listView = new System.Windows.Forms.ListView();
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnAgregarEmpleado = new System.Windows.Forms.Button();
            this.TxtNroIDEmp = new System.Windows.Forms.TextBox();
            this.CmbTipoIDEmp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbClientes = new System.Windows.Forms.ComboBox();
            this.CmbEmpleados = new System.Windows.Forms.ComboBox();
            this.NumValorUnit = new System.Windows.Forms.NumericUpDown();
            this.NumDescuento = new System.Windows.Forms.NumericUpDown();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblAgregado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblModificado = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.GbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumValorUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDescuento)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // CmbTipoIDCli
            // 
            this.CmbTipoIDCli.DropDownWidth = 200;
            this.CmbTipoIDCli.FormattingEnabled = true;
            this.CmbTipoIDCli.Location = new System.Drawing.Point(172, 11);
            this.CmbTipoIDCli.Name = "CmbTipoIDCli";
            this.CmbTipoIDCli.Size = new System.Drawing.Size(68, 28);
            this.CmbTipoIDCli.TabIndex = 1;
            this.CmbTipoIDCli.SelectedIndexChanged += new System.EventHandler(this.CmbTipoIDCli_SelectedIndexChanged);
            this.CmbTipoIDCli.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbTipoID_Format);
            this.CmbTipoIDCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // TxtNroIDCli
            // 
            this.TxtNroIDCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroIDCli.Location = new System.Drawing.Point(246, 12);
            this.TxtNroIDCli.Name = "TxtNroIDCli";
            this.TxtNroIDCli.Size = new System.Drawing.Size(151, 26);
            this.TxtNroIDCli.TabIndex = 2;
            this.TxtNroIDCli.TextChanged += new System.EventHandler(this.TxtNroIDCli_TextChanged);
            this.TxtNroIDCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // DgvProdServ
            // 
            this.DgvProdServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdServ.Location = new System.Drawing.Point(11, 112);
            this.DgvProdServ.Name = "DgvProdServ";
            this.DgvProdServ.Size = new System.Drawing.Size(1144, 281);
            this.DgvProdServ.TabIndex = 15;
            // 
            // TxtProdCodigo
            // 
            this.TxtProdCodigo.Location = new System.Drawing.Point(11, 78);
            this.TxtProdCodigo.Name = "TxtProdCodigo";
            this.TxtProdCodigo.Size = new System.Drawing.Size(125, 26);
            this.TxtProdCodigo.TabIndex = 8;
            this.TxtProdCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // CmbMarcas
            // 
            this.CmbMarcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbMarcas.DropDownWidth = 200;
            this.CmbMarcas.FormattingEnabled = true;
            this.CmbMarcas.Location = new System.Drawing.Point(142, 77);
            this.CmbMarcas.Name = "CmbMarcas";
            this.CmbMarcas.Size = new System.Drawing.Size(68, 28);
            this.CmbMarcas.TabIndex = 9;
            this.CmbMarcas.SelectedIndexChanged += new System.EventHandler(this.CmbMarcas_SelectedIndexChanged);
            this.CmbMarcas.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbMarcas_Format);
            this.CmbMarcas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbClases
            // 
            this.CmbClases.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClases.DropDownWidth = 200;
            this.CmbClases.FormattingEnabled = true;
            this.CmbClases.Location = new System.Drawing.Point(216, 77);
            this.CmbClases.Name = "CmbClases";
            this.CmbClases.Size = new System.Drawing.Size(68, 28);
            this.CmbClases.TabIndex = 10;
            this.CmbClases.SelectedIndexChanged += new System.EventHandler(this.CmbClases_SelectedIndexChanged);
            this.CmbClases.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbClases_Format);
            this.CmbClases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbProductos
            // 
            this.CmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProductos.DropDownWidth = 500;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(290, 77);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(435, 28);
            this.CmbProductos.TabIndex = 11;
            this.CmbProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // NumCantidad
            // 
            this.NumCantidad.DecimalPlaces = 2;
            this.NumCantidad.Location = new System.Drawing.Point(731, 78);
            this.NumCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(78, 26);
            this.NumCantidad.TabIndex = 12;
            this.NumCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(928, 12);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarCliente.TabIndex = 16;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1081, 78);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarProducto.TabIndex = 18;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // GbxTotales
            // 
            this.GbxTotales.Controls.Add(this.listView);
            this.GbxTotales.Location = new System.Drawing.Point(677, 399);
            this.GbxTotales.Name = "GbxTotales";
            this.GbxTotales.Size = new System.Drawing.Size(478, 166);
            this.GbxTotales.TabIndex = 19;
            this.GbxTotales.TabStop = false;
            this.GbxTotales.Text = "Totales";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescripcion,
            this.colMonto});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            listViewGroup5.Header = "No Header";
            listViewGroup5.Name = "Dummy";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
            this.listView.Location = new System.Drawing.Point(26, 30);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.ShowGroups = false;
            this.listView.Size = new System.Drawing.Size(426, 130);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Text = "Descripción";
            this.colDescripcion.Width = 278;
            // 
            // colMonto
            // 
            this.colMonto.Text = "Monto";
            this.colMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colMonto.Width = 129;
            // 
            // BtnAgregarEmpleado
            // 
            this.BtnAgregarEmpleado.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarEmpleado.Location = new System.Drawing.Point(928, 44);
            this.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado";
            this.BtnAgregarEmpleado.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarEmpleado.TabIndex = 17;
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // TxtNroIDEmp
            // 
            this.TxtNroIDEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroIDEmp.Location = new System.Drawing.Point(246, 44);
            this.TxtNroIDEmp.Name = "TxtNroIDEmp";
            this.TxtNroIDEmp.Size = new System.Drawing.Size(151, 26);
            this.TxtNroIDEmp.TabIndex = 6;
            this.TxtNroIDEmp.TextChanged += new System.EventHandler(this.TxtNroIDEmp_TextChanged);
            this.TxtNroIDEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // CmbTipoIDEmp
            // 
            this.CmbTipoIDEmp.DropDownWidth = 200;
            this.CmbTipoIDEmp.FormattingEnabled = true;
            this.CmbTipoIDEmp.Location = new System.Drawing.Point(172, 43);
            this.CmbTipoIDEmp.Name = "CmbTipoIDEmp";
            this.CmbTipoIDEmp.Size = new System.Drawing.Size(68, 28);
            this.CmbTipoIDEmp.TabIndex = 5;
            this.CmbTipoIDEmp.SelectedIndexChanged += new System.EventHandler(this.CmbTipoIDEmp_SelectedIndexChanged);
            this.CmbTipoIDEmp.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbTipoID_Format);
            this.CmbTipoIDEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Empleado/Vendedor";
            // 
            // CmbClientes
            // 
            this.CmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbClientes.FormattingEnabled = true;
            this.CmbClientes.Location = new System.Drawing.Point(403, 11);
            this.CmbClientes.Name = "CmbClientes";
            this.CmbClientes.Size = new System.Drawing.Size(407, 28);
            this.CmbClientes.TabIndex = 3;
            this.CmbClientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbEmpleados
            // 
            this.CmbEmpleados.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbEmpleados.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbEmpleados.FormattingEnabled = true;
            this.CmbEmpleados.Location = new System.Drawing.Point(403, 43);
            this.CmbEmpleados.Name = "CmbEmpleados";
            this.CmbEmpleados.Size = new System.Drawing.Size(407, 28);
            this.CmbEmpleados.TabIndex = 7;
            this.CmbEmpleados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // NumValorUnit
            // 
            this.NumValorUnit.DecimalPlaces = 2;
            this.NumValorUnit.Location = new System.Drawing.Point(815, 78);
            this.NumValorUnit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumValorUnit.Name = "NumValorUnit";
            this.NumValorUnit.Size = new System.Drawing.Size(127, 26);
            this.NumValorUnit.TabIndex = 13;
            this.NumValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumValorUnit.ThousandsSeparator = true;
            this.NumValorUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // NumDescuento
            // 
            this.NumDescuento.DecimalPlaces = 2;
            this.NumDescuento.Location = new System.Drawing.Point(948, 78);
            this.NumDescuento.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumDescuento.Name = "NumDescuento";
            this.NumDescuento.Size = new System.Drawing.Size(127, 26);
            this.NumDescuento.TabIndex = 14;
            this.NumDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumDescuento.ThousandsSeparator = true;
            this.NumDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 569);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1192, 22);
            this.statusStrip.TabIndex = 20;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(864, 17);
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
            // FrmPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 591);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.NumDescuento);
            this.Controls.Add(this.NumValorUnit);
            this.Controls.Add(this.CmbEmpleados);
            this.Controls.Add(this.CmbClientes);
            this.Controls.Add(this.BtnAgregarEmpleado);
            this.Controls.Add(this.TxtNroIDEmp);
            this.Controls.Add(this.CmbTipoIDEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GbxTotales);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnAgregarCliente);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.CmbProductos);
            this.Controls.Add(this.CmbClases);
            this.Controls.Add(this.CmbMarcas);
            this.Controls.Add(this.TxtProdCodigo);
            this.Controls.Add(this.DgvProdServ);
            this.Controls.Add(this.TxtNroIDCli);
            this.Controls.Add(this.CmbTipoIDCli);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPuntoDeVenta";
            this.Text = "FrmPuntoDeVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPuntoDeVenta_FormClosing);
            this.Load += new System.EventHandler(this.FrmPuntoDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.GbxTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumValorUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDescuento)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoIDCli;
        private System.Windows.Forms.TextBox TxtNroIDCli;
        private System.Windows.Forms.DataGridView DgvProdServ;
        private System.Windows.Forms.TextBox TxtProdCodigo;
        private System.Windows.Forms.ComboBox CmbMarcas;
        private System.Windows.Forms.ComboBox CmbClases;
        private System.Windows.Forms.ComboBox CmbProductos;
        private System.Windows.Forms.NumericUpDown NumCantidad;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.GroupBox GbxTotales;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.ColumnHeader colMonto;
        private System.Windows.Forms.Button BtnAgregarEmpleado;
        private System.Windows.Forms.TextBox TxtNroIDEmp;
        private System.Windows.Forms.ComboBox CmbTipoIDEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbClientes;
        private System.Windows.Forms.ComboBox CmbEmpleados;
        private System.Windows.Forms.NumericUpDown NumValorUnit;
        private System.Windows.Forms.NumericUpDown NumDescuento;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TssLblStatus;
        private System.Windows.Forms.ToolStripStatusLabel TssLblAgregado;
        private System.Windows.Forms.ToolStripStatusLabel TssLblModificado;
    }
}