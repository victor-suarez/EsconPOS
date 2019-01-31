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
            this.CmbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.CmbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.TxtFiltroCodigo = new System.Windows.Forms.TextBox();
            this.TxtFiltroCodigoBarra = new System.Windows.Forms.TextBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.TxtFiltroProducto = new System.Windows.Forms.TextBox();
            this.PagEditar = new System.Windows.Forms.TabPage();
            this.BtnAgregarImpuesto = new System.Windows.Forms.Button();
            this.BtnAgregarUnidad = new System.Windows.Forms.Button();
            this.BtnAgregarTipo = new System.Windows.Forms.Button();
            this.BtnAgregarMarca = new System.Windows.Forms.Button();
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
            this.ChkPorFraccion = new System.Windows.Forms.CheckBox();
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
            this.toolStrip.Size = new System.Drawing.Size(994, 54);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 467);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(994, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(666, 17);
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
            this.TabProductos.Size = new System.Drawing.Size(970, 407);
            this.TabProductos.TabIndex = 0;
            this.TabProductos.SelectedIndexChanged += new System.EventHandler(this.Tab_SelectedIndexChanged);
            // 
            // PagLista
            // 
            this.PagLista.Controls.Add(this.CmbFiltroTipo);
            this.PagLista.Controls.Add(this.CmbFiltroMarca);
            this.PagLista.Controls.Add(this.TxtFiltroCodigo);
            this.PagLista.Controls.Add(this.TxtFiltroCodigoBarra);
            this.PagLista.Controls.Add(this.DgvProductos);
            this.PagLista.Controls.Add(this.TxtFiltroProducto);
            this.PagLista.Location = new System.Drawing.Point(4, 29);
            this.PagLista.Name = "PagLista";
            this.PagLista.Padding = new System.Windows.Forms.Padding(3);
            this.PagLista.Size = new System.Drawing.Size(962, 374);
            this.PagLista.TabIndex = 0;
            this.PagLista.Text = "Lista";
            this.PagLista.UseVisualStyleBackColor = true;
            // 
            // CmbFiltroTipo
            // 
            this.CmbFiltroTipo.DropDownWidth = 300;
            this.CmbFiltroTipo.FormattingEnabled = true;
            this.CmbFiltroTipo.Location = new System.Drawing.Point(354, 6);
            this.CmbFiltroTipo.Name = "CmbFiltroTipo";
            this.CmbFiltroTipo.Size = new System.Drawing.Size(63, 28);
            this.CmbFiltroTipo.TabIndex = 3;
            this.CmbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            this.CmbFiltroTipo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbFiltroTipo_Format);
            this.CmbFiltroTipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbFiltroMarca
            // 
            this.CmbFiltroMarca.DropDownWidth = 300;
            this.CmbFiltroMarca.FormattingEnabled = true;
            this.CmbFiltroMarca.Location = new System.Drawing.Point(285, 6);
            this.CmbFiltroMarca.Name = "CmbFiltroMarca";
            this.CmbFiltroMarca.Size = new System.Drawing.Size(63, 28);
            this.CmbFiltroMarca.TabIndex = 2;
            this.CmbFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            this.CmbFiltroMarca.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbFiltroMarca_Format);
            this.CmbFiltroMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // TxtFiltroCodigo
            // 
            this.TxtFiltroCodigo.Location = new System.Drawing.Point(144, 6);
            this.TxtFiltroCodigo.Name = "TxtFiltroCodigo";
            this.TxtFiltroCodigo.Size = new System.Drawing.Size(135, 26);
            this.TxtFiltroCodigo.TabIndex = 1;
            this.TxtFiltroCodigo.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtFiltroCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtFiltroCodigoBarra
            // 
            this.TxtFiltroCodigoBarra.Location = new System.Drawing.Point(3, 6);
            this.TxtFiltroCodigoBarra.Name = "TxtFiltroCodigoBarra";
            this.TxtFiltroCodigoBarra.Size = new System.Drawing.Size(135, 26);
            this.TxtFiltroCodigoBarra.TabIndex = 0;
            this.TxtFiltroCodigoBarra.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtFiltroCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // DgvProductos
            // 
            this.DgvProductos.AllowUserToAddRows = false;
            this.DgvProductos.AllowUserToDeleteRows = false;
            this.DgvProductos.AllowUserToOrderColumns = true;
            this.DgvProductos.AllowUserToResizeRows = false;
            this.DgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvProductos.Location = new System.Drawing.Point(3, 40);
            this.DgvProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvProductos.MultiSelect = false;
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.ReadOnly = true;
            this.DgvProductos.RowHeadersVisible = false;
            this.DgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProductos.Size = new System.Drawing.Size(956, 331);
            this.DgvProductos.TabIndex = 5;
            this.DgvProductos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvProductos_ColumnHeaderMouseClick);
            // 
            // TxtFiltroProducto
            // 
            this.TxtFiltroProducto.Location = new System.Drawing.Point(423, 6);
            this.TxtFiltroProducto.Name = "TxtFiltroProducto";
            this.TxtFiltroProducto.Size = new System.Drawing.Size(533, 26);
            this.TxtFiltroProducto.TabIndex = 4;
            this.TxtFiltroProducto.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            this.TxtFiltroProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // PagEditar
            // 
            this.PagEditar.Controls.Add(this.ChkPorFraccion);
            this.PagEditar.Controls.Add(this.BtnAgregarImpuesto);
            this.PagEditar.Controls.Add(this.BtnAgregarUnidad);
            this.PagEditar.Controls.Add(this.BtnAgregarTipo);
            this.PagEditar.Controls.Add(this.BtnAgregarMarca);
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
            this.PagEditar.Size = new System.Drawing.Size(962, 374);
            this.PagEditar.TabIndex = 1;
            this.PagEditar.Text = "Editar";
            this.PagEditar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarImpuesto
            // 
            this.BtnAgregarImpuesto.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarImpuesto.Location = new System.Drawing.Point(524, 272);
            this.BtnAgregarImpuesto.Name = "BtnAgregarImpuesto";
            this.BtnAgregarImpuesto.Size = new System.Drawing.Size(28, 28);
            this.BtnAgregarImpuesto.TabIndex = 20;
            this.BtnAgregarImpuesto.UseVisualStyleBackColor = true;
            this.BtnAgregarImpuesto.Click += new System.EventHandler(this.BtnAgregarImpuesto_Click);
            // 
            // BtnAgregarUnidad
            // 
            this.BtnAgregarUnidad.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarUnidad.Location = new System.Drawing.Point(524, 208);
            this.BtnAgregarUnidad.Name = "BtnAgregarUnidad";
            this.BtnAgregarUnidad.Size = new System.Drawing.Size(28, 28);
            this.BtnAgregarUnidad.TabIndex = 16;
            this.BtnAgregarUnidad.UseVisualStyleBackColor = true;
            this.BtnAgregarUnidad.Click += new System.EventHandler(this.BtnAgregarUnidad_Click);
            // 
            // BtnAgregarTipo
            // 
            this.BtnAgregarTipo.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarTipo.Location = new System.Drawing.Point(609, 110);
            this.BtnAgregarTipo.Name = "BtnAgregarTipo";
            this.BtnAgregarTipo.Size = new System.Drawing.Size(28, 28);
            this.BtnAgregarTipo.TabIndex = 9;
            this.BtnAgregarTipo.UseVisualStyleBackColor = true;
            this.BtnAgregarTipo.Click += new System.EventHandler(this.BtnAgregarTipo_Click);
            // 
            // BtnAgregarMarca
            // 
            this.BtnAgregarMarca.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarMarca.Location = new System.Drawing.Point(609, 75);
            this.BtnAgregarMarca.Name = "BtnAgregarMarca";
            this.BtnAgregarMarca.Size = new System.Drawing.Size(28, 28);
            this.BtnAgregarMarca.TabIndex = 6;
            this.BtnAgregarMarca.UseVisualStyleBackColor = true;
            this.BtnAgregarMarca.Click += new System.EventHandler(this.BtnAgregarMarca_Click);
            // 
            // NumPrecioUnitario
            // 
            this.NumPrecioUnitario.DecimalPlaces = 2;
            this.NumPrecioUnitario.Location = new System.Drawing.Point(200, 338);
            this.NumPrecioUnitario.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumPrecioUnitario.Name = "NumPrecioUnitario";
            this.NumPrecioUnitario.Size = new System.Drawing.Size(143, 26);
            this.NumPrecioUnitario.TabIndex = 24;
            this.NumPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumPrecioUnitario.ThousandsSeparator = true;
            this.NumPrecioUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 340);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "Precio unitario:";
            // 
            // NumCostoUnitario
            // 
            this.NumCostoUnitario.DecimalPlaces = 2;
            this.NumCostoUnitario.Location = new System.Drawing.Point(200, 306);
            this.NumCostoUnitario.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.NumCostoUnitario.Name = "NumCostoUnitario";
            this.NumCostoUnitario.Size = new System.Drawing.Size(143, 26);
            this.NumCostoUnitario.TabIndex = 22;
            this.NumCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCostoUnitario.ThousandsSeparator = true;
            this.NumCostoUnitario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Num_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 308);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Costo unitario:";
            // 
            // TxtProducto
            // 
            this.TxtProducto.Location = new System.Drawing.Point(200, 144);
            this.TxtProducto.MaxLength = 255;
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(756, 26);
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
            this.CmbImpuestos.Location = new System.Drawing.Point(200, 272);
            this.CmbImpuestos.Name = "CmbImpuestos";
            this.CmbImpuestos.Size = new System.Drawing.Size(318, 28);
            this.CmbImpuestos.TabIndex = 19;
            this.CmbImpuestos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 275);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 18;
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
            this.TxtPresentacion.Size = new System.Drawing.Size(756, 26);
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
            this.CmbTipos.SelectedIndexChanged += new System.EventHandler(this.CmbTipos_SelectedIndexChanged);
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
            this.CmbMarcas.SelectedIndexChanged += new System.EventHandler(this.CmbMarcas_SelectedIndexChanged);
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
            // ChkPorFraccion
            // 
            this.ChkPorFraccion.AutoSize = true;
            this.ChkPorFraccion.Location = new System.Drawing.Point(200, 242);
            this.ChkPorFraccion.Name = "ChkPorFraccion";
            this.ChkPorFraccion.Size = new System.Drawing.Size(129, 24);
            this.ChkPorFraccion.TabIndex = 17;
            this.ChkPorFraccion.Text = "Por fracciones";
            this.ChkPorFraccion.UseVisualStyleBackColor = true;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 489);
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
        private System.Windows.Forms.Button BtnAgregarTipo;
        private System.Windows.Forms.Button BtnAgregarMarca;
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
        private System.Windows.Forms.TextBox TxtFiltroProducto;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnAgregarImpuesto;
        private System.Windows.Forms.Button BtnAgregarUnidad;
        private System.Windows.Forms.TextBox TxtFiltroCodigo;
        private System.Windows.Forms.TextBox TxtFiltroCodigoBarra;
        private System.Windows.Forms.ComboBox CmbFiltroTipo;
        private System.Windows.Forms.ComboBox CmbFiltroMarca;
        private System.Windows.Forms.CheckBox ChkPorFraccion;
    }
}