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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuntoDeVenta));
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoIDCli = new System.Windows.Forms.ComboBox();
            this.TxtNroIDCli = new System.Windows.Forms.TextBox();
            this.DgvProdServ = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotalItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtProdCodigo = new System.Windows.Forms.TextBox();
            this.CmbMarcas = new System.Windows.Forms.ComboBox();
            this.CmbClases = new System.Windows.Forms.ComboBox();
            this.CmbProductos = new System.Windows.Forms.ComboBox();
            this.NumCantidad = new System.Windows.Forms.NumericUpDown();
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PnlTotales = new System.Windows.Forms.Panel();
            this.NumDctoGlobal = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMonedas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblMontoNeto = new System.Windows.Forms.Label();
            this.LblImpuestos = new System.Windows.Forms.Label();
            this.LblDescuentos = new System.Windows.Forms.Label();
            this.LblMontoBruto = new System.Windows.Forms.Label();
            this.BtnQuitarItem = new System.Windows.Forms.Button();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.TsBtnImprimir = new System.Windows.Forms.ToolStripButton();
            this.BtnAgregarEmpleado = new System.Windows.Forms.Button();
            this.BtnAgregarItem = new System.Windows.Forms.Button();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumValorUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDescuento)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.PnlTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDctoGlobal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // CmbTipoIDCli
            // 
            this.CmbTipoIDCli.DropDownWidth = 350;
            this.CmbTipoIDCli.FormattingEnabled = true;
            this.CmbTipoIDCli.Location = new System.Drawing.Point(172, 25);
            this.CmbTipoIDCli.Name = "CmbTipoIDCli";
            this.CmbTipoIDCli.Size = new System.Drawing.Size(60, 28);
            this.CmbTipoIDCli.TabIndex = 1;
            this.CmbTipoIDCli.SelectedIndexChanged += new System.EventHandler(this.CmbTipoIDCli_SelectedIndexChanged);
            this.CmbTipoIDCli.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbTipoID_Format);
            this.CmbTipoIDCli.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // TxtNroIDCli
            // 
            this.TxtNroIDCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroIDCli.Location = new System.Drawing.Point(238, 26);
            this.TxtNroIDCli.Name = "TxtNroIDCli";
            this.TxtNroIDCli.Size = new System.Drawing.Size(151, 26);
            this.TxtNroIDCli.TabIndex = 2;
            this.TxtNroIDCli.TextChanged += new System.EventHandler(this.TxtNroIDCli_TextChanged);
            this.TxtNroIDCli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // DgvProdServ
            // 
            this.DgvProdServ.AllowUserToAddRows = false;
            this.DgvProdServ.AllowUserToDeleteRows = false;
            this.DgvProdServ.AllowUserToResizeRows = false;
            this.DgvProdServ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProdServ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvProdServ.ColumnHeadersHeight = 30;
            this.DgvProdServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvProdServ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colProducto,
            this.colValorUnitario,
            this.colCantidad,
            this.colDescuento,
            this.colSubTotalItem,
            this.colImpuestos,
            this.colSubTotal});
            this.DgvProdServ.Location = new System.Drawing.Point(11, 128);
            this.DgvProdServ.MultiSelect = false;
            this.DgvProdServ.Name = "DgvProdServ";
            this.DgvProdServ.RowHeadersVisible = false;
            this.DgvProdServ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProdServ.Size = new System.Drawing.Size(1144, 431);
            this.DgvProdServ.TabIndex = 19;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCodigo.Width = 65;
            // 
            // colProducto
            // 
            this.colProducto.HeaderText = "Producto/Servicio";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;
            this.colProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colProducto.Width = 138;
            // 
            // colValorUnitario
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colValorUnitario.DefaultCellStyle = dataGridViewCellStyle2;
            this.colValorUnitario.HeaderText = "Precio Unit.";
            this.colValorUnitario.Name = "colValorUnitario";
            this.colValorUnitario.ReadOnly = true;
            this.colValorUnitario.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colValorUnitario.Width = 96;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCantidad.Width = 79;
            // 
            // colDescuento
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDescuento.DefaultCellStyle = dataGridViewCellStyle4;
            this.colDescuento.HeaderText = "Descuento";
            this.colDescuento.Name = "colDescuento";
            this.colDescuento.ReadOnly = true;
            this.colDescuento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDescuento.Width = 93;
            // 
            // colSubTotalItem
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubTotalItem.DefaultCellStyle = dataGridViewCellStyle5;
            this.colSubTotalItem.HeaderText = "Sub Total Item";
            this.colSubTotalItem.Name = "colSubTotalItem";
            this.colSubTotalItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSubTotalItem.Width = 119;
            // 
            // colImpuestos
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colImpuestos.DefaultCellStyle = dataGridViewCellStyle6;
            this.colImpuestos.HeaderText = "Impuestos";
            this.colImpuestos.Name = "colImpuestos";
            this.colImpuestos.ReadOnly = true;
            this.colImpuestos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colImpuestos.Width = 90;
            // 
            // colSubTotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.colSubTotal.HeaderText = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            this.colSubTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSubTotal.Width = 79;
            // 
            // TxtProdCodigo
            // 
            this.TxtProdCodigo.Location = new System.Drawing.Point(11, 94);
            this.TxtProdCodigo.Name = "TxtProdCodigo";
            this.TxtProdCodigo.Size = new System.Drawing.Size(125, 26);
            this.TxtProdCodigo.TabIndex = 10;
            this.TxtProdCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // CmbMarcas
            // 
            this.CmbMarcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbMarcas.DropDownWidth = 200;
            this.CmbMarcas.FormattingEnabled = true;
            this.CmbMarcas.Location = new System.Drawing.Point(142, 93);
            this.CmbMarcas.Name = "CmbMarcas";
            this.CmbMarcas.Size = new System.Drawing.Size(68, 28);
            this.CmbMarcas.TabIndex = 11;
            this.CmbMarcas.SelectedIndexChanged += new System.EventHandler(this.CmbMarcas_SelectedIndexChanged);
            this.CmbMarcas.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbMarcas_Format);
            this.CmbMarcas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbClases
            // 
            this.CmbClases.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClases.DropDownWidth = 200;
            this.CmbClases.FormattingEnabled = true;
            this.CmbClases.Location = new System.Drawing.Point(216, 93);
            this.CmbClases.Name = "CmbClases";
            this.CmbClases.Size = new System.Drawing.Size(68, 28);
            this.CmbClases.TabIndex = 12;
            this.CmbClases.SelectedIndexChanged += new System.EventHandler(this.CmbClases_SelectedIndexChanged);
            this.CmbClases.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbClases_Format);
            this.CmbClases.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbProductos
            // 
            this.CmbProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProductos.DropDownWidth = 500;
            this.CmbProductos.FormattingEnabled = true;
            this.CmbProductos.Location = new System.Drawing.Point(290, 93);
            this.CmbProductos.Name = "CmbProductos";
            this.CmbProductos.Size = new System.Drawing.Size(435, 28);
            this.CmbProductos.TabIndex = 13;
            this.CmbProductos.SelectedIndexChanged += new System.EventHandler(this.CmbProductos_SelectedIndexChanged);
            this.CmbProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // NumCantidad
            // 
            this.NumCantidad.DecimalPlaces = 2;
            this.NumCantidad.Location = new System.Drawing.Point(731, 94);
            this.NumCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(78, 26);
            this.NumCantidad.TabIndex = 14;
            this.NumCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCantidad.Enter += new System.EventHandler(this.Num_Enter);
            this.NumCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // TxtNroIDEmp
            // 
            this.TxtNroIDEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroIDEmp.Location = new System.Drawing.Point(238, 60);
            this.TxtNroIDEmp.Name = "TxtNroIDEmp";
            this.TxtNroIDEmp.Size = new System.Drawing.Size(151, 26);
            this.TxtNroIDEmp.TabIndex = 7;
            this.TxtNroIDEmp.TextChanged += new System.EventHandler(this.TxtNroIDEmp_TextChanged);
            this.TxtNroIDEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // CmbTipoIDEmp
            // 
            this.CmbTipoIDEmp.DropDownWidth = 350;
            this.CmbTipoIDEmp.FormattingEnabled = true;
            this.CmbTipoIDEmp.Location = new System.Drawing.Point(172, 59);
            this.CmbTipoIDEmp.Name = "CmbTipoIDEmp";
            this.CmbTipoIDEmp.Size = new System.Drawing.Size(60, 28);
            this.CmbTipoIDEmp.TabIndex = 6;
            this.CmbTipoIDEmp.SelectedIndexChanged += new System.EventHandler(this.CmbTipoIDEmp_SelectedIndexChanged);
            this.CmbTipoIDEmp.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbTipoID_Format);
            this.CmbTipoIDEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Empleado/Vendedor";
            // 
            // CmbClientes
            // 
            this.CmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbClientes.FormattingEnabled = true;
            this.CmbClientes.Location = new System.Drawing.Point(395, 25);
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
            this.CmbEmpleados.Location = new System.Drawing.Point(395, 59);
            this.CmbEmpleados.Name = "CmbEmpleados";
            this.CmbEmpleados.Size = new System.Drawing.Size(407, 28);
            this.CmbEmpleados.TabIndex = 8;
            this.CmbEmpleados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // NumValorUnit
            // 
            this.NumValorUnit.DecimalPlaces = 2;
            this.NumValorUnit.Location = new System.Drawing.Point(815, 94);
            this.NumValorUnit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumValorUnit.Name = "NumValorUnit";
            this.NumValorUnit.Size = new System.Drawing.Size(127, 26);
            this.NumValorUnit.TabIndex = 15;
            this.NumValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumValorUnit.ThousandsSeparator = true;
            this.NumValorUnit.Enter += new System.EventHandler(this.Num_Enter);
            this.NumValorUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // NumDescuento
            // 
            this.NumDescuento.DecimalPlaces = 2;
            this.NumDescuento.Location = new System.Drawing.Point(948, 94);
            this.NumDescuento.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumDescuento.Name = "NumDescuento";
            this.NumDescuento.Size = new System.Drawing.Size(127, 26);
            this.NumDescuento.TabIndex = 16;
            this.NumDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumDescuento.ThousandsSeparator = true;
            this.NumDescuento.Enter += new System.EventHandler(this.Num_Enter);
            this.NumDescuento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 637);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(1192, 22);
            this.statusStrip.TabIndex = 23;
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
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsBtnGuardar,
            this.TsBtnImprimir,
            this.TsBtnDeshacer,
            this.TsBtnEliminar,
            this.toolStripSeparator1,
            this.TsBtnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip.Size = new System.Drawing.Size(1192, 54);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 24;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // PnlTotales
            // 
            this.PnlTotales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlTotales.Controls.Add(this.NumDctoGlobal);
            this.PnlTotales.Controls.Add(this.label8);
            this.PnlTotales.Controls.Add(this.label7);
            this.PnlTotales.Controls.Add(this.cmbMonedas);
            this.PnlTotales.Controls.Add(this.label6);
            this.PnlTotales.Controls.Add(this.label5);
            this.PnlTotales.Controls.Add(this.label4);
            this.PnlTotales.Controls.Add(this.label3);
            this.PnlTotales.Controls.Add(this.LblMontoNeto);
            this.PnlTotales.Controls.Add(this.LblImpuestos);
            this.PnlTotales.Controls.Add(this.LblDescuentos);
            this.PnlTotales.Controls.Add(this.LblMontoBruto);
            this.PnlTotales.Location = new System.Drawing.Point(249, 565);
            this.PnlTotales.Name = "PnlTotales";
            this.PnlTotales.Size = new System.Drawing.Size(906, 53);
            this.PnlTotales.TabIndex = 22;
            // 
            // NumDctoGlobal
            // 
            this.NumDctoGlobal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumDctoGlobal.DecimalPlaces = 2;
            this.NumDctoGlobal.Location = new System.Drawing.Point(629, 22);
            this.NumDctoGlobal.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.NumDctoGlobal.Name = "NumDctoGlobal";
            this.NumDctoGlobal.Size = new System.Drawing.Size(146, 26);
            this.NumDctoGlobal.TabIndex = 9;
            this.NumDctoGlobal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumDctoGlobal.ThousandsSeparator = true;
            this.NumDctoGlobal.ValueChanged += new System.EventHandler(this.NumDctoGlobal_ValueChanged);
            this.NumDctoGlobal.Enter += new System.EventHandler(this.Num_Enter);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(629, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dcto. global";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Moneda";
            // 
            // cmbMonedas
            // 
            this.cmbMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonedas.FormattingEnabled = true;
            this.cmbMonedas.Location = new System.Drawing.Point(77, 15);
            this.cmbMonedas.Name = "cmbMonedas";
            this.cmbMonedas.Size = new System.Drawing.Size(174, 28);
            this.cmbMonedas.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(777, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Monto neto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(501, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Impuestos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(377, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dcto. por items";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(253, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Monto bruto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMontoNeto
            // 
            this.LblMontoNeto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMontoNeto.Location = new System.Drawing.Point(781, 23);
            this.LblMontoNeto.Name = "LblMontoNeto";
            this.LblMontoNeto.Size = new System.Drawing.Size(118, 20);
            this.LblMontoNeto.TabIndex = 11;
            this.LblMontoNeto.Text = "9.999.999,99";
            this.LblMontoNeto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblMontoNeto.UseMnemonic = false;
            // 
            // LblImpuestos
            // 
            this.LblImpuestos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblImpuestos.Location = new System.Drawing.Point(505, 23);
            this.LblImpuestos.Name = "LblImpuestos";
            this.LblImpuestos.Size = new System.Drawing.Size(118, 20);
            this.LblImpuestos.TabIndex = 7;
            this.LblImpuestos.Text = "9.999.999,99";
            this.LblImpuestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblImpuestos.UseMnemonic = false;
            // 
            // LblDescuentos
            // 
            this.LblDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDescuentos.Location = new System.Drawing.Point(381, 23);
            this.LblDescuentos.Name = "LblDescuentos";
            this.LblDescuentos.Size = new System.Drawing.Size(118, 20);
            this.LblDescuentos.TabIndex = 5;
            this.LblDescuentos.Text = "9.999.999,99";
            this.LblDescuentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblDescuentos.UseMnemonic = false;
            // 
            // LblMontoBruto
            // 
            this.LblMontoBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblMontoBruto.Location = new System.Drawing.Point(257, 23);
            this.LblMontoBruto.Name = "LblMontoBruto";
            this.LblMontoBruto.Size = new System.Drawing.Size(118, 20);
            this.LblMontoBruto.TabIndex = 3;
            this.LblMontoBruto.Text = "9.999.999,99";
            this.LblMontoBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LblMontoBruto.UseMnemonic = false;
            // 
            // BtnQuitarItem
            // 
            this.BtnQuitarItem.Image = global::EsconPOS.Properties.Resources.Quitar;
            this.BtnQuitarItem.Location = new System.Drawing.Point(1118, 95);
            this.BtnQuitarItem.Name = "BtnQuitarItem";
            this.BtnQuitarItem.Size = new System.Drawing.Size(31, 26);
            this.BtnQuitarItem.TabIndex = 18;
            this.BtnQuitarItem.UseVisualStyleBackColor = true;
            this.BtnQuitarItem.Click += new System.EventHandler(this.BtnQuitarItem_Click);
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
            // TsBtnImprimir
            // 
            this.TsBtnImprimir.Image = global::EsconPOS.Properties.Resources.Imprimir;
            this.TsBtnImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsBtnImprimir.Name = "TsBtnImprimir";
            this.TsBtnImprimir.Size = new System.Drawing.Size(57, 51);
            this.TsBtnImprimir.Text = "&Imprimir";
            this.TsBtnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // BtnAgregarEmpleado
            // 
            this.BtnAgregarEmpleado.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarEmpleado.Location = new System.Drawing.Point(808, 60);
            this.BtnAgregarEmpleado.Name = "BtnAgregarEmpleado";
            this.BtnAgregarEmpleado.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarEmpleado.TabIndex = 9;
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = true;
            this.BtnAgregarEmpleado.Click += new System.EventHandler(this.BtnAgregarEmpleado_Click);
            // 
            // BtnAgregarItem
            // 
            this.BtnAgregarItem.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarItem.Location = new System.Drawing.Point(1081, 94);
            this.BtnAgregarItem.Name = "BtnAgregarItem";
            this.BtnAgregarItem.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarItem.TabIndex = 17;
            this.BtnAgregarItem.UseVisualStyleBackColor = true;
            this.BtnAgregarItem.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(808, 26);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarCliente.TabIndex = 4;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            this.BtnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarCliente_Click);
            // 
            // FrmPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 659);
            this.Controls.Add(this.PnlTotales);
            this.Controls.Add(this.BtnQuitarItem);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.NumDescuento);
            this.Controls.Add(this.NumValorUnit);
            this.Controls.Add(this.CmbEmpleados);
            this.Controls.Add(this.CmbClientes);
            this.Controls.Add(this.BtnAgregarEmpleado);
            this.Controls.Add(this.TxtNroIDEmp);
            this.Controls.Add(this.CmbTipoIDEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAgregarItem);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPuntoDeVenta";
            this.Text = "Factura Directa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FrmPuntoDeVenta_Activated);
            this.Deactivate += new System.EventHandler(this.FrmPuntoDeVenta_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPuntoDeVenta_FormClosing);
            this.Load += new System.EventHandler(this.FrmPuntoDeVenta_Load);
            this.SizeChanged += new System.EventHandler(this.FrmPuntoDeVenta_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumValorUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDescuento)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.PnlTotales.ResumeLayout(false);
            this.PnlTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDctoGlobal)).EndInit();
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
        private System.Windows.Forms.Button BtnAgregarItem;
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
        private System.Windows.Forms.ToolStripButton TsBtnGuardar;
        private System.Windows.Forms.ToolStripButton TsBtnDeshacer;
        private System.Windows.Forms.ToolStripButton TsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsBtnSalir;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.Button BtnQuitarItem;
        private System.Windows.Forms.Panel PnlTotales;
        private System.Windows.Forms.Label LblMontoNeto;
        private System.Windows.Forms.Label LblImpuestos;
        private System.Windows.Forms.Label LblDescuentos;
        private System.Windows.Forms.Label LblMontoBruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMonedas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotalItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.NumericUpDown NumDctoGlobal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton TsBtnImprimir;
    }
}