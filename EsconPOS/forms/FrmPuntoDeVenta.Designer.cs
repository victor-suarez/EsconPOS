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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("No Header", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Total X",
            "9.999,99"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.CmbTipoIDCli = new System.Windows.Forms.ComboBox();
            this.TxtNroIDCli = new System.Windows.Forms.TextBox();
            this.DgvProdServ = new System.Windows.Forms.DataGridView();
            this.TxtProdCodigo = new System.Windows.Forms.TextBox();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.CmbClase = new System.Windows.Forms.ComboBox();
            this.CmbDescripcion = new System.Windows.Forms.ComboBox();
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
            this.CmbNombreCli = new System.Windows.Forms.ComboBox();
            this.CmbNombreEmp = new System.Windows.Forms.ComboBox();
            this.NumValorUnit = new System.Windows.Forms.NumericUpDown();
            this.NumDcto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdServ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).BeginInit();
            this.GbxTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumValorUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDcto)).BeginInit();
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
            this.CmbTipoIDCli.FormattingEnabled = true;
            this.CmbTipoIDCli.Location = new System.Drawing.Point(172, 12);
            this.CmbTipoIDCli.Name = "CmbTipoIDCli";
            this.CmbTipoIDCli.Size = new System.Drawing.Size(48, 28);
            this.CmbTipoIDCli.TabIndex = 1;
            // 
            // TxtNroIDCli
            // 
            this.TxtNroIDCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroIDCli.Location = new System.Drawing.Point(223, 13);
            this.TxtNroIDCli.Name = "TxtNroIDCli";
            this.TxtNroIDCli.Size = new System.Drawing.Size(151, 26);
            this.TxtNroIDCli.TabIndex = 2;
            // 
            // DgvProdServ
            // 
            this.DgvProdServ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProdServ.Location = new System.Drawing.Point(11, 112);
            this.DgvProdServ.Name = "DgvProdServ";
            this.DgvProdServ.Size = new System.Drawing.Size(1144, 281);
            this.DgvProdServ.TabIndex = 3;
            // 
            // TxtProdCodigo
            // 
            this.TxtProdCodigo.Location = new System.Drawing.Point(11, 78);
            this.TxtProdCodigo.Name = "TxtProdCodigo";
            this.TxtProdCodigo.Size = new System.Drawing.Size(125, 26);
            this.TxtProdCodigo.TabIndex = 10;
            this.TxtProdCodigo.Text = "1234567890123";
            // 
            // CmbMarca
            // 
            this.CmbMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbMarca.DropDownWidth = 200;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(142, 77);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(78, 28);
            this.CmbMarca.TabIndex = 11;
            this.CmbMarca.Text = "WWW";
            // 
            // CmbClase
            // 
            this.CmbClase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbClase.DropDownWidth = 200;
            this.CmbClase.FormattingEnabled = true;
            this.CmbClase.Location = new System.Drawing.Point(226, 77);
            this.CmbClase.Name = "CmbClase";
            this.CmbClase.Size = new System.Drawing.Size(78, 28);
            this.CmbClase.TabIndex = 12;
            // 
            // CmbDescripcion
            // 
            this.CmbDescripcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbDescripcion.DropDownWidth = 500;
            this.CmbDescripcion.FormattingEnabled = true;
            this.CmbDescripcion.Location = new System.Drawing.Point(310, 77);
            this.CmbDescripcion.Name = "CmbDescripcion";
            this.CmbDescripcion.Size = new System.Drawing.Size(435, 28);
            this.CmbDescripcion.TabIndex = 13;
            // 
            // NumCantidad
            // 
            this.NumCantidad.DecimalPlaces = 2;
            this.NumCantidad.Location = new System.Drawing.Point(751, 78);
            this.NumCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumCantidad.Name = "NumCantidad";
            this.NumCantidad.Size = new System.Drawing.Size(78, 26);
            this.NumCantidad.TabIndex = 14;
            this.NumCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumCantidad.Value = new decimal(new int[] {
            10001,
            0,
            0,
            131072});
            // 
            // BtnAgregarCliente
            // 
            this.BtnAgregarCliente.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarCliente.Location = new System.Drawing.Point(928, 13);
            this.BtnAgregarCliente.Name = "BtnAgregarCliente";
            this.BtnAgregarCliente.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarCliente.TabIndex = 15;
            this.BtnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Image = global::EsconPOS.Properties.Resources.Agregar;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1124, 78);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(31, 26);
            this.BtnAgregarProducto.TabIndex = 16;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            // 
            // GbxTotales
            // 
            this.GbxTotales.Controls.Add(this.listView);
            this.GbxTotales.Location = new System.Drawing.Point(677, 399);
            this.GbxTotales.Name = "GbxTotales";
            this.GbxTotales.Size = new System.Drawing.Size(478, 166);
            this.GbxTotales.TabIndex = 17;
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
            listViewGroup1.Header = "No Header";
            listViewGroup1.Name = "Dummy";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
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
            this.BtnAgregarEmpleado.TabIndex = 21;
            this.BtnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // TxtNroIDEmp
            // 
            this.TxtNroIDEmp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNroIDEmp.Location = new System.Drawing.Point(223, 45);
            this.TxtNroIDEmp.Name = "TxtNroIDEmp";
            this.TxtNroIDEmp.Size = new System.Drawing.Size(151, 26);
            this.TxtNroIDEmp.TabIndex = 20;
            // 
            // CmbTipoIDEmp
            // 
            this.CmbTipoIDEmp.FormattingEnabled = true;
            this.CmbTipoIDEmp.Location = new System.Drawing.Point(172, 44);
            this.CmbTipoIDEmp.Name = "CmbTipoIDEmp";
            this.CmbTipoIDEmp.Size = new System.Drawing.Size(48, 28);
            this.CmbTipoIDEmp.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Empleado/Vendedor";
            // 
            // CmbNombreCli
            // 
            this.CmbNombreCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbNombreCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbNombreCli.FormattingEnabled = true;
            this.CmbNombreCli.Location = new System.Drawing.Point(380, 12);
            this.CmbNombreCli.Name = "CmbNombreCli";
            this.CmbNombreCli.Size = new System.Drawing.Size(407, 28);
            this.CmbNombreCli.TabIndex = 22;
            // 
            // CmbNombreEmp
            // 
            this.CmbNombreEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbNombreEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbNombreEmp.FormattingEnabled = true;
            this.CmbNombreEmp.Location = new System.Drawing.Point(380, 44);
            this.CmbNombreEmp.Name = "CmbNombreEmp";
            this.CmbNombreEmp.Size = new System.Drawing.Size(407, 28);
            this.CmbNombreEmp.TabIndex = 23;
            // 
            // NumValorUnit
            // 
            this.NumValorUnit.DecimalPlaces = 2;
            this.NumValorUnit.Location = new System.Drawing.Point(835, 79);
            this.NumValorUnit.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumValorUnit.Name = "NumValorUnit";
            this.NumValorUnit.Size = new System.Drawing.Size(127, 26);
            this.NumValorUnit.TabIndex = 24;
            this.NumValorUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumValorUnit.ThousandsSeparator = true;
            this.NumValorUnit.Value = new decimal(new int[] {
            1000001,
            0,
            0,
            131072});
            // 
            // NumDcto
            // 
            this.NumDcto.DecimalPlaces = 2;
            this.NumDcto.Location = new System.Drawing.Point(968, 78);
            this.NumDcto.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumDcto.Name = "NumDcto";
            this.NumDcto.Size = new System.Drawing.Size(127, 26);
            this.NumDcto.TabIndex = 25;
            this.NumDcto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumDcto.ThousandsSeparator = true;
            this.NumDcto.Value = new decimal(new int[] {
            1000001,
            0,
            0,
            131072});
            // 
            // FrmPuntoDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 579);
            this.Controls.Add(this.NumDcto);
            this.Controls.Add(this.NumValorUnit);
            this.Controls.Add(this.CmbNombreEmp);
            this.Controls.Add(this.CmbNombreCli);
            this.Controls.Add(this.BtnAgregarEmpleado);
            this.Controls.Add(this.TxtNroIDEmp);
            this.Controls.Add(this.CmbTipoIDEmp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GbxTotales);
            this.Controls.Add(this.BtnAgregarProducto);
            this.Controls.Add(this.BtnAgregarCliente);
            this.Controls.Add(this.NumCantidad);
            this.Controls.Add(this.CmbDescripcion);
            this.Controls.Add(this.CmbClase);
            this.Controls.Add(this.CmbMarca);
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
            this.Load += new System.EventHandler(this.FrmPuntoDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProdServ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidad)).EndInit();
            this.GbxTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumValorUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDcto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbTipoIDCli;
        private System.Windows.Forms.TextBox TxtNroIDCli;
        private System.Windows.Forms.DataGridView DgvProdServ;
        private System.Windows.Forms.TextBox TxtProdCodigo;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.ComboBox CmbClase;
        private System.Windows.Forms.ComboBox CmbDescripcion;
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
        private System.Windows.Forms.ComboBox CmbNombreCli;
        private System.Windows.Forms.ComboBox CmbNombreEmp;
        private System.Windows.Forms.NumericUpDown NumValorUnit;
        private System.Windows.Forms.NumericUpDown NumDcto;
    }
}