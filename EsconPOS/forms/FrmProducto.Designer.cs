namespace EsconPOS.forms
{
    partial class FrmProducto
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
            this.TabProductos = new System.Windows.Forms.TabControl();
            this.PagLista = new System.Windows.Forms.TabPage();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAgregarCliente = new System.Windows.Forms.Button();
            this.NumPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.NumCostoUnitario = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbImpuestos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbUnidades = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPresentacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CmbMarcas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgragarUnidad = new System.Windows.Forms.Button();
            this.BtnAgregarImpuesto = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabProductos.SuspendLayout();
            this.PagLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.PagEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCostoUnitario)).BeginInit();
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
            this.toolStrip.Size = new System.Drawing.Size(795, 54);
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
            this.TsBtnGuardar.Text = "Guardar";
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
            this.TsBtnDeshacer.Text = "Deshacer";
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
            this.TsBtnEliminar.Text = "Eliminar";
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
            this.TsBtnSalir.Size = new System.Drawing.Size(36, 51);
            this.TsBtnSalir.Text = "Salir";
            this.TsBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnSalir.Click += new System.EventHandler(this.TsBtnSalir_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 439);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(467, 17);
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
            // TabProductos
            // 
            this.TabProductos.Controls.Add(this.PagLista);
            this.TabProductos.Controls.Add(this.PagEditar);
            this.TabProductos.Location = new System.Drawing.Point(12, 57);
            this.TabProductos.Name = "TabProductos";
            this.TabProductos.SelectedIndex = 0;
            this.TabProductos.Size = new System.Drawing.Size(771, 378);
            this.TabProductos.TabIndex = 0;
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.DgvProductos);
            this.PagLista.Controls.Add(this.comboBox6);
            this.PagLista.Controls.Add(this.textBox5);
            this.PagLista.Controls.Add(this.comboBox5);
            this.PagLista.Location = new System.Drawing.Point(4, 29);
            this.PagLista.Name = "PagLista";
            this.PagLista.Padding = new System.Windows.Forms.Padding(3);
            this.PagLista.Size = new System.Drawing.Size(763, 345);
            this.PagLista.TabIndex = 0;
            this.PagLista.Text = "Lista";
            this.PagLista.UseVisualStyleBackColor = true;
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.AllowUserToOrderColumns = true;
            this.DgvProductos.AllowUserToResizeRows = false;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Location = new System.Drawing.Point(9, 42);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvProductos.MultiSelect = false;
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersVisible = false;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(747, 295);
            this.DgvProductos.TabIndex = 0;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(133, 6);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 28);
            this.comboBox6.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(260, 8);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(496, 26);
            this.textBox5.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(6, 6);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 28);
            this.comboBox5.TabIndex = 1;
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.BtnAgregarImpuesto);
            this.PagEditar.Controls.Add(this.BtnAgragarUnidad);
            this.PagEditar.Controls.Add(this.button1);
            this.PagEditar.Controls.Add(this.BtnAgregarCliente);
            this.PagEditar.Controls.Add(this.NumPrecioUnitario);
            this.PagEditar.Controls.Add(this.label10);
            this.PagEditar.Controls.Add(this.NumCostoUnitario);
            this.PagEditar.Controls.Add(this.label9);
            this.PagEditar.Controls.Add(this.TxtProducto);
            this.PagEditar.Controls.Add(this.label8);
            this.PagEditar.Controls.Add(this.CmbImpuestos);
            this.PagEditar.Controls.Add(this.label7);
            this.PagEditar.Controls.Add(this.CmbUnidades);
            this.PagEditar.Controls.Add(this.label6);
            this.PagEditar.Controls.Add(this.TxtPresentacion);
            this.PagEditar.Controls.Add(this.label5);
            this.PagEditar.Controls.Add(this.CmbTipos);
            this.PagEditar.Controls.Add(this.label4);
            this.PagEditar.Controls.Add(this.CmbMarcas);
            this.PagEditar.Controls.Add(this.label3);
            this.PagEditar.Controls.Add(this.TxtCodigoBarra);
            this.PagEditar.Controls.Add(this.label2);
            this.PagEditar.Controls.Add(this.TxtCodigo);
            this.PagEditar.Controls.Add(this.label1);
            this.PagEditar.Location = new System.Drawing.Point(4, 29);
            this.PagEditar.Name = "PagEditar";
            this.PagEditar.Padding = new System.Windows.Forms.Padding(3);
            this.PagEditar.Size = new System.Drawing.Size(763, 345);
            this.PagEditar.TabIndex = 1;
            this.PagEditar.Text = "Editar";
            this.PagEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.button1.Location = new System.Drawing.Point(609, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(609, 75);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(28, 28);
            this.BtnAgregarCliente.TabIndex = 6;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // NumPrecioUnitario
            // 
            this.NumPrecioUnitario.DecimalPlaces = 2;
            this.NumPrecioUnitario.Location = new System.Drawing.Point(200, 308);
            this.NumPrecioUnitario.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumPrecioUnitario.Name = "NumPrecioUnitario";
            this.NumPrecioUnitario.Size = new System.Drawing.Size(143, 26);
            this.NumPrecioUnitario.TabIndex = 21;
            this.NumPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumPrecioUnitario.ThousandsSeparator = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 310);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Precio unitario:";
            // 
            // NumCostoUnitario
            // 
            this.NumCostoUnitario.DecimalPlaces = 2;
            this.NumCostoUnitario.Location = new System.Drawing.Point(200, 276);
            this.NumCostoUnitario.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumCostoUnitario.Name = "NumCostoUnitario";
            this.NumCostoUnitario.Size = new System.Drawing.Size(143, 26);
            this.NumCostoUnitario.TabIndex = 19;
            this.NumCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCostoUnitario.ThousandsSeparator = true;
            this.NumCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Num_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 278);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Costo unitario:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(200, 144);
            this.TxtProducto.MaxLength = 255;
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(403, 26);
            this.TxtProducto.TabIndex = 11;
            this.TxtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 147);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Descripción:";
            // 
            // CmbImpuestos
            // 
            this.CmbImpuestos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbImpuestos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbImpuestos.FormattingEnabled = true;
            this.CmbImpuestos.Location = new System.Drawing.Point(200, 242);
            this.CmbImpuestos.Name = "CmbImpuestos";
            this.CmbImpuestos.Size = new System.Drawing.Size(318, 28);
            this.CmbImpuestos.TabIndex = 17;
            this.CmbImpuestos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Impuesto:";
            // 
            // CmbUnidades
            // 
            this.CmbUnidades.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbUnidades.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbUnidades.FormattingEnabled = true;
            this.CmbUnidades.Location = new System.Drawing.Point(200, 208);
            this.CmbUnidades.Name = "CmbUnidades";
            this.CmbUnidades.Size = new System.Drawing.Size(318, 28);
            this.CmbUnidades.TabIndex = 15;
            this.CmbUnidades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unidad de medida:";
            // 
            // TxtPresentacion
            // 
            this.TxtPresentacion.Location = new System.Drawing.Point(200, 176);
            this.TxtPresentacion.MaxLength = 255;
            this.TxtPresentacion.Name = "TxtPresentacion";
            this.TxtPresentacion.Size = new System.Drawing.Size(403, 26);
            this.TxtPresentacion.TabIndex = 13;
            this.TxtPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Presentación:";
            // 
            // CmbTipos
            // 
            this.CmbTipos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbTipos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbTipos.FormattingEnabled = true;
            this.CmbTipos.Location = new System.Drawing.Point(200, 110);
            this.CmbTipos.Name = "CmbTipos";
            this.CmbTipos.Size = new System.Drawing.Size(403, 28);
            this.CmbTipos.TabIndex = 8;
            this.CmbTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Clase:";
            // 
            // CmbMarcas
            // 
            this.CmbMarcas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbMarcas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbMarcas.FormattingEnabled = true;
            this.CmbMarcas.Location = new System.Drawing.Point(200, 76);
            this.CmbMarcas.Name = "CmbMarcas";
            this.CmbMarcas.Size = new System.Drawing.Size(403, 28);
            this.CmbMarcas.TabIndex = 5;
            this.CmbMarcas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca:";
            // 
            // TxtCodigoBarra
            // 
            this.TxtCodigoBarra.Location = new System.Drawing.Point(200, 44);
            this.TxtCodigoBarra.MaxLength = 15;
            this.TxtCodigoBarra.Name = "TxtCodigoBarra";
            this.TxtCodigoBarra.Size = new System.Drawing.Size(156, 26);
            this.TxtCodigoBarra.TabIndex = 3;
            this.TxtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de barras:";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(200, 12);
            this.TxtCodigo.MaxLength = 15;
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(156, 26);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código interno:";
            // 
            // BtnAgragarUnidad
            // 
            this.BtnAgragarUnidad.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgragarUnidad.Location = new System.Drawing.Point(524, 208);
            this.BtnAgragarUnidad.Name = "BtnAgragarUnidad";
            this.BtnAgragarUnidad.Size = new System.Drawing.Size(28, 28);
            this.BtnAgragarUnidad.TabIndex = 22;
            this.BtnAgragarUnidad.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarImpuesto
            // 
            this.BtnAgregarImpuesto.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarImpuesto.Location = new System.Drawing.Point(524, 242);
            this.BtnAgregarImpuesto.Name = "BtnAgregarImpuesto";
            this.BtnAgregarImpuesto.Size = new System.Drawing.Size(28, 28);
            this.BtnAgregarImpuesto.TabIndex = 23;
            this.BtnAgregarImpuesto.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 461);
            this.Controls.Add(this.TabProductos);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmProducto";
            this.Text = "Administrar productos/servicios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProducto_FormClosing);
            this.Load += new System.EventHandler(this.FrmProducto_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabProductos.ResumeLayout(false);
            this.PagLista.ResumeLayout(false);
            this.PagLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.PagEditar.ResumeLayout(false);
            this.PagEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCostoUnitario)).EndInit();
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
        private System.Windows.Forms.TabControl TabProductos;
        private System.Windows.Forms.TabPage PagLista;
        private System.Windows.Forms.TabPage PagEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAgregarCliente;
        private System.Windows.Forms.NumericUpDown NumPrecioUnitario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumCostoUnitario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CmbImpuestos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbUnidades;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPresentacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CmbMarcas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigoBarra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnAgregarImpuesto;
        private System.Windows.Forms.Button BtnAgragarUnidad;
    }
}