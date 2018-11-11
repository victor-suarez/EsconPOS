﻿namespace EsconPOS.forms
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.RibTabAdministrar = new System.Windows.Forms.RibbonTab();
            this.RibPnlAcciones = new System.Windows.Forms.RibbonPanel();
            this.RibLblAccion = new System.Windows.Forms.RibbonLabel();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.TabClientes = new System.Windows.Forms.TabControl();
            this.TabLista = new System.Windows.Forms.TabPage();
            this.TxtFilterNroTelefonico = new System.Windows.Forms.TextBox();
            this.TxtFilterNombre = new System.Windows.Forms.TextBox();
            this.CmbFilterTipoID = new System.Windows.Forms.ComboBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.TabEditar = new System.Windows.Forms.TabPage();
            this.TxtCorreoElectronicoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNroTelefonicoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDistrito = new System.Windows.Forms.ComboBox();
            this.CmbProvincia = new System.Windows.Forms.ComboBox();
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNombreCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNroIDCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoIDCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.clienteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocIdentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distritoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroTelefonicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregadoElDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregadoPorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distritosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paisesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RibBtnNuevo = new System.Windows.Forms.RibbonButton();
            this.RibBtnGuardar = new System.Windows.Forms.RibbonButton();
            this.RibBtnEliminar = new System.Windows.Forms.RibbonButton();
            this.RibBtnSalir = new System.Windows.Forms.RibbonButton();
            this.TabClientes.SuspendLayout();
            this.TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.TabEditar.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RibTabAdministrar
            // 
            this.RibTabAdministrar.Name = "RibTabAdministrar";
            this.RibTabAdministrar.Panels.Add(this.RibPnlAcciones);
            this.RibTabAdministrar.Panels.Add(this.ribbonPanel1);
            this.RibTabAdministrar.Text = "Administrar";
            this.RibTabAdministrar.Visible = false;
            // 
            // RibPnlAcciones
            // 
            this.RibPnlAcciones.ButtonMoreVisible = false;
            this.RibPnlAcciones.Items.Add(this.RibLblAccion);
            this.RibPnlAcciones.Items.Add(this.RibBtnNuevo);
            this.RibPnlAcciones.Items.Add(this.RibBtnGuardar);
            this.RibPnlAcciones.Items.Add(this.RibBtnEliminar);
            this.RibPnlAcciones.Items.Add(this.RibBtnSalir);
            this.RibPnlAcciones.Name = "RibPnlAcciones";
            this.RibPnlAcciones.Text = "Acciones";
            this.RibPnlAcciones.Visible = false;
            // 
            // RibLblAccion
            // 
            this.RibLblAccion.Name = "RibLblAccion";
            this.RibLblAccion.Text = "Accion";
            this.RibLblAccion.Visible = false;
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
            this.ribbonPanel1.Visible = false;
            // 
            // TabClientes
            // 
            this.TabClientes.Controls.Add(this.TabLista);
            this.TabClientes.Controls.Add(this.TabEditar);
            this.TabClientes.Location = new System.Drawing.Point(6, 66);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.SelectedIndex = 0;
            this.TabClientes.Size = new System.Drawing.Size(655, 372);
            this.TabClientes.TabIndex = 0;
            // 
            // TabLista
            // 
            this.TabLista.Controls.Add(this.TxtFilterNroTelefonico);
            this.TabLista.Controls.Add(this.TxtFilterNombre);
            this.TabLista.Controls.Add(this.CmbFilterTipoID);
            this.TabLista.Controls.Add(this.DgvClientes);
            this.TabLista.Location = new System.Drawing.Point(4, 29);
            this.TabLista.Name = "TabLista";
            this.TabLista.Padding = new System.Windows.Forms.Padding(3);
            this.TabLista.Size = new System.Drawing.Size(647, 339);
            this.TabLista.TabIndex = 0;
            this.TabLista.Text = "Lista";
            this.TabLista.UseVisualStyleBackColor = true;
            // 
            // TxtFilterNroTelefonico
            // 
            this.TxtFilterNroTelefonico.Location = new System.Drawing.Point(188, 16);
            this.TxtFilterNroTelefonico.Name = "TxtFilterNroTelefonico";
            this.TxtFilterNroTelefonico.Size = new System.Drawing.Size(150, 26);
            this.TxtFilterNroTelefonico.TabIndex = 3;
            // 
            // TxtFilterNombre
            // 
            this.TxtFilterNombre.Location = new System.Drawing.Point(65, 16);
            this.TxtFilterNombre.Name = "TxtFilterNombre";
            this.TxtFilterNombre.Size = new System.Drawing.Size(117, 26);
            this.TxtFilterNombre.TabIndex = 2;
            // 
            // CmbFilterTipoID
            // 
            this.CmbFilterTipoID.FormattingEnabled = true;
            this.CmbFilterTipoID.Location = new System.Drawing.Point(6, 14);
            this.CmbFilterTipoID.Name = "CmbFilterTipoID";
            this.CmbFilterTipoID.Size = new System.Drawing.Size(53, 28);
            this.CmbFilterTipoID.TabIndex = 1;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToOrderColumns = true;
            this.DgvClientes.AllowUserToResizeRows = false;
            this.DgvClientes.AutoGenerateColumns = false;
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clienteIDDataGridViewTextBoxColumn,
            this.identificacionIDDataGridViewTextBoxColumn,
            this.nroDocIdentDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.paisIDDataGridViewTextBoxColumn,
            this.distritoIDDataGridViewTextBoxColumn,
            this.nroTelefonicoDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.activoDataGridViewTextBoxColumn,
            this.agregadoElDataGridViewTextBoxColumn,
            this.agregadoPorDataGridViewTextBoxColumn,
            this.distritosDataGridViewTextBoxColumn,
            this.paisesDataGridViewTextBoxColumn});
            this.DgvClientes.DataSource = this.clientesBindingSource;
            this.DgvClientes.Location = new System.Drawing.Point(6, 48);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersVisible = false;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(635, 281);
            this.DgvClientes.TabIndex = 0;
            // 
            // TabEditar
            // 
            this.TabEditar.Controls.Add(this.TxtCorreoElectronicoCliente);
            this.TabEditar.Controls.Add(this.label3);
            this.TabEditar.Controls.Add(this.TxtNroTelefonicoCliente);
            this.TabEditar.Controls.Add(this.label2);
            this.TabEditar.Controls.Add(this.TxtDireccionCliente);
            this.TabEditar.Controls.Add(this.label1);
            this.TabEditar.Controls.Add(this.CmbDistrito);
            this.TabEditar.Controls.Add(this.CmbProvincia);
            this.TabEditar.Controls.Add(this.CmbDepartamento);
            this.TabEditar.Controls.Add(this.label12);
            this.TabEditar.Controls.Add(this.TxtNombreCliente);
            this.TabEditar.Controls.Add(this.label6);
            this.TabEditar.Controls.Add(this.TxtNroIDCliente);
            this.TabEditar.Controls.Add(this.label5);
            this.TabEditar.Controls.Add(this.CmbTipoIDCliente);
            this.TabEditar.Controls.Add(this.label4);
            this.TabEditar.Location = new System.Drawing.Point(4, 29);
            this.TabEditar.Name = "TabEditar";
            this.TabEditar.Padding = new System.Windows.Forms.Padding(3);
            this.TabEditar.Size = new System.Drawing.Size(647, 339);
            this.TabEditar.TabIndex = 1;
            this.TabEditar.Text = "Editar";
            this.TabEditar.UseVisualStyleBackColor = true;
            // 
            // TxtCorreoElectronicoCliente
            // 
            this.TxtCorreoElectronicoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtCorreoElectronicoCliente.Location = new System.Drawing.Point(182, 288);
            this.TxtCorreoElectronicoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCorreoElectronicoCliente.MaxLength = 255;
            this.TxtCorreoElectronicoCliente.Name = "TxtCorreoElectronicoCliente";
            this.TxtCorreoElectronicoCliente.Size = new System.Drawing.Size(453, 26);
            this.TxtCorreoElectronicoCliente.TabIndex = 15;
            this.TxtCorreoElectronicoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo Electrónico:";
            // 
            // TxtNroTelefonicoCliente
            // 
            this.TxtNroTelefonicoCliente.Location = new System.Drawing.Point(182, 252);
            this.TxtNroTelefonicoCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNroTelefonicoCliente.MaxLength = 255;
            this.TxtNroTelefonicoCliente.Name = "TxtNroTelefonicoCliente";
            this.TxtNroTelefonicoCliente.Size = new System.Drawing.Size(453, 26);
            this.TxtNroTelefonicoCliente.TabIndex = 13;
            this.TxtNroTelefonicoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teléfonos:";
            // 
            // TxtDireccionCliente
            // 
            this.TxtDireccionCliente.Location = new System.Drawing.Point(182, 135);
            this.TxtDireccionCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDireccionCliente.MaxLength = 255;
            this.TxtDireccionCliente.Multiline = true;
            this.TxtDireccionCliente.Name = "TxtDireccionCliente";
            this.TxtDireccionCliente.Size = new System.Drawing.Size(453, 69);
            this.TxtDireccionCliente.TabIndex = 7;
            this.TxtDireccionCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dirección:";
            // 
            // CmbDistrito
            // 
            this.CmbDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDistrito.DropDownWidth = 326;
            this.CmbDistrito.FormattingEnabled = true;
            this.CmbDistrito.Location = new System.Drawing.Point(298, 214);
            this.CmbDistrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDistrito.Name = "CmbDistrito";
            this.CmbDistrito.Size = new System.Drawing.Size(337, 28);
            this.CmbDistrito.TabIndex = 11;
            this.CmbDistrito.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDistrito_Format);
            this.CmbDistrito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbProvincia
            // 
            this.CmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProvincia.DropDownWidth = 300;
            this.CmbProvincia.FormattingEnabled = true;
            this.CmbProvincia.Location = new System.Drawing.Point(240, 214);
            this.CmbProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbProvincia.Name = "CmbProvincia";
            this.CmbProvincia.Size = new System.Drawing.Size(50, 28);
            this.CmbProvincia.TabIndex = 10;
            this.CmbProvincia.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbProvincia_Format);
            this.CmbProvincia.SelectedValueChanged += new System.EventHandler(this.CmbProvincia_SelectedValueChanged);
            this.CmbProvincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDepartamento.DropDownWidth = 200;
            this.CmbDepartamento.FormattingEnabled = true;
            this.CmbDepartamento.Location = new System.Drawing.Point(182, 214);
            this.CmbDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(50, 28);
            this.CmbDepartamento.TabIndex = 9;
            this.CmbDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDepartamento_Format);
            this.CmbDepartamento.SelectedValueChanged += new System.EventHandler(this.CmbDepartamento_SelectedValueChanged);
            this.CmbDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 218);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ubicación:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(182, 99);
            this.TxtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreCliente.MaxLength = 255;
            this.TxtNombreCliente.Name = "TxtNombreCliente";
            this.TxtNombreCliente.Size = new System.Drawing.Size(453, 26);
            this.TxtNombreCliente.TabIndex = 5;
            this.TxtNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombres:";
            // 
            // TxtNroIDCliente
            // 
            this.TxtNroIDCliente.Location = new System.Drawing.Point(182, 63);
            this.TxtNroIDCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNroIDCliente.MaxLength = 20;
            this.TxtNroIDCliente.Name = "TxtNroIDCliente";
            this.TxtNroIDCliente.Size = new System.Drawing.Size(210, 26);
            this.TxtNroIDCliente.TabIndex = 3;
            this.TxtNroIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroIDCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nro de Identificación:";
            // 
            // CmbTipoIDCliente
            // 
            this.CmbTipoIDCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoIDCliente.FormattingEnabled = true;
            this.CmbTipoIDCliente.Location = new System.Drawing.Point(182, 25);
            this.CmbTipoIDCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTipoIDCliente.Name = "CmbTipoIDCliente";
            this.CmbTipoIDCliente.Size = new System.Drawing.Size(340, 28);
            this.CmbTipoIDCliente.TabIndex = 1;
            this.CmbTipoIDCliente.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbID_Format);
            this.CmbTipoIDCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Identificación:";
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
            this.toolStrip.Size = new System.Drawing.Size(673, 54);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
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
            // 
            // TsBtnSalir
            // 
            this.TsBtnSalir.Image = global::EsconPOS.Properties.Resources.Close;
            this.TsBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TsBtnSalir.ImageTransparentColor = System.Drawing.Color.Black;
            this.TsBtnSalir.Name = "TsBtnSalir";
            this.TsBtnSalir.Size = new System.Drawing.Size(36, 51);
            this.TsBtnSalir.Text = "Salir";
            this.TsBtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TsBtnSalir.Click += new System.EventHandler(this.TsBtnSalir_Click);
            // 
            // clienteIDDataGridViewTextBoxColumn
            // 
            this.clienteIDDataGridViewTextBoxColumn.DataPropertyName = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.HeaderText = "ClienteID";
            this.clienteIDDataGridViewTextBoxColumn.Name = "clienteIDDataGridViewTextBoxColumn";
            this.clienteIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clienteIDDataGridViewTextBoxColumn.Visible = false;
            this.clienteIDDataGridViewTextBoxColumn.Width = 56;
            // 
            // identificacionIDDataGridViewTextBoxColumn
            // 
            this.identificacionIDDataGridViewTextBoxColumn.DataPropertyName = "IdentificacionID";
            this.identificacionIDDataGridViewTextBoxColumn.HeaderText = "IdentificacionID";
            this.identificacionIDDataGridViewTextBoxColumn.Name = "identificacionIDDataGridViewTextBoxColumn";
            this.identificacionIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.identificacionIDDataGridViewTextBoxColumn.Width = 145;
            // 
            // nroDocIdentDataGridViewTextBoxColumn
            // 
            this.nroDocIdentDataGridViewTextBoxColumn.DataPropertyName = "NroDocIdent";
            this.nroDocIdentDataGridViewTextBoxColumn.HeaderText = "NroDocIdent";
            this.nroDocIdentDataGridViewTextBoxColumn.Name = "nroDocIdentDataGridViewTextBoxColumn";
            this.nroDocIdentDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroDocIdentDataGridViewTextBoxColumn.Width = 125;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 90;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Visible = false;
            this.direccionDataGridViewTextBoxColumn.Width = 77;
            // 
            // paisIDDataGridViewTextBoxColumn
            // 
            this.paisIDDataGridViewTextBoxColumn.DataPropertyName = "PaisID";
            this.paisIDDataGridViewTextBoxColumn.HeaderText = "PaisID";
            this.paisIDDataGridViewTextBoxColumn.Name = "paisIDDataGridViewTextBoxColumn";
            this.paisIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.paisIDDataGridViewTextBoxColumn.Visible = false;
            this.paisIDDataGridViewTextBoxColumn.Width = 63;
            // 
            // distritoIDDataGridViewTextBoxColumn
            // 
            this.distritoIDDataGridViewTextBoxColumn.DataPropertyName = "DistritoID";
            this.distritoIDDataGridViewTextBoxColumn.HeaderText = "DistritoID";
            this.distritoIDDataGridViewTextBoxColumn.Name = "distritoIDDataGridViewTextBoxColumn";
            this.distritoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.distritoIDDataGridViewTextBoxColumn.Visible = false;
            this.distritoIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // nroTelefonicoDataGridViewTextBoxColumn
            // 
            this.nroTelefonicoDataGridViewTextBoxColumn.DataPropertyName = "NroTelefonico";
            this.nroTelefonicoDataGridViewTextBoxColumn.HeaderText = "NroTelefonico";
            this.nroTelefonicoDataGridViewTextBoxColumn.Name = "nroTelefonicoDataGridViewTextBoxColumn";
            this.nroTelefonicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nroTelefonicoDataGridViewTextBoxColumn.Width = 132;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "CorreoElectronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoElectronicoDataGridViewTextBoxColumn.Width = 161;
            // 
            // activoDataGridViewTextBoxColumn
            // 
            this.activoDataGridViewTextBoxColumn.DataPropertyName = "Activo";
            this.activoDataGridViewTextBoxColumn.HeaderText = "Activo";
            this.activoDataGridViewTextBoxColumn.Name = "activoDataGridViewTextBoxColumn";
            this.activoDataGridViewTextBoxColumn.ReadOnly = true;
            this.activoDataGridViewTextBoxColumn.Width = 77;
            // 
            // agregadoElDataGridViewTextBoxColumn
            // 
            this.agregadoElDataGridViewTextBoxColumn.DataPropertyName = "AgregadoEl";
            this.agregadoElDataGridViewTextBoxColumn.HeaderText = "AgregadoEl";
            this.agregadoElDataGridViewTextBoxColumn.Name = "agregadoElDataGridViewTextBoxColumn";
            this.agregadoElDataGridViewTextBoxColumn.ReadOnly = true;
            this.agregadoElDataGridViewTextBoxColumn.Width = 118;
            // 
            // agregadoPorDataGridViewTextBoxColumn
            // 
            this.agregadoPorDataGridViewTextBoxColumn.DataPropertyName = "AgregadoPor";
            this.agregadoPorDataGridViewTextBoxColumn.HeaderText = "AgregadoPor";
            this.agregadoPorDataGridViewTextBoxColumn.Name = "agregadoPorDataGridViewTextBoxColumn";
            this.agregadoPorDataGridViewTextBoxColumn.ReadOnly = true;
            this.agregadoPorDataGridViewTextBoxColumn.Width = 128;
            // 
            // distritosDataGridViewTextBoxColumn
            // 
            this.distritosDataGridViewTextBoxColumn.DataPropertyName = "Distritos";
            this.distritosDataGridViewTextBoxColumn.HeaderText = "Distritos";
            this.distritosDataGridViewTextBoxColumn.Name = "distritosDataGridViewTextBoxColumn";
            this.distritosDataGridViewTextBoxColumn.ReadOnly = true;
            this.distritosDataGridViewTextBoxColumn.Width = 92;
            // 
            // paisesDataGridViewTextBoxColumn
            // 
            this.paisesDataGridViewTextBoxColumn.DataPropertyName = "Paises";
            this.paisesDataGridViewTextBoxColumn.HeaderText = "Paises";
            this.paisesDataGridViewTextBoxColumn.Name = "paisesDataGridViewTextBoxColumn";
            this.paisesDataGridViewTextBoxColumn.ReadOnly = true;
            this.paisesDataGridViewTextBoxColumn.Width = 81;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.AllowNew = false;
            this.clientesBindingSource.DataSource = typeof(EsconPOS.Clientes);
            // 
            // RibBtnNuevo
            // 
            this.RibBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("RibBtnNuevo.Image")));
            this.RibBtnNuevo.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibBtnNuevo.LargeImage")));
            this.RibBtnNuevo.Name = "RibBtnNuevo";
            this.RibBtnNuevo.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnNuevo.SmallImage")));
            this.RibBtnNuevo.Visible = false;
            // 
            // RibBtnGuardar
            // 
            this.RibBtnGuardar.Image = global::EsconPOS.Properties.Resources.Guardar;
            this.RibBtnGuardar.LargeImage = global::EsconPOS.Properties.Resources.Guardar;
            this.RibBtnGuardar.Name = "RibBtnGuardar";
            this.RibBtnGuardar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnGuardar.SmallImage")));
            this.RibBtnGuardar.Text = "Guardar";
            this.RibBtnGuardar.Visible = false;
            // 
            // RibBtnEliminar
            // 
            this.RibBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("RibBtnEliminar.Image")));
            this.RibBtnEliminar.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibBtnEliminar.LargeImage")));
            this.RibBtnEliminar.Name = "RibBtnEliminar";
            this.RibBtnEliminar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnEliminar.SmallImage")));
            this.RibBtnEliminar.Text = "Eliminar";
            this.RibBtnEliminar.Visible = false;
            // 
            // RibBtnSalir
            // 
            this.RibBtnSalir.Image = global::EsconPOS.Properties.Resources.Salir;
            this.RibBtnSalir.LargeImage = global::EsconPOS.Properties.Resources.Salir;
            this.RibBtnSalir.Name = "RibBtnSalir";
            this.RibBtnSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnSalir.SmallImage")));
            this.RibBtnSalir.Text = "Salir";
            this.RibBtnSalir.Visible = false;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 498);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.TabClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCliente";
            this.Text = "Administrar Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.TabClientes.ResumeLayout(false);
            this.TabLista.ResumeLayout(false);
            this.TabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.TabEditar.ResumeLayout(false);
            this.TabEditar.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RibbonTab RibTabAdministrar;
        private System.Windows.Forms.RibbonPanel RibPnlAcciones;
        private System.Windows.Forms.RibbonLabel RibLblAccion;
        private System.Windows.Forms.RibbonButton RibBtnNuevo;
        private System.Windows.Forms.RibbonButton RibBtnGuardar;
        private System.Windows.Forms.RibbonButton RibBtnEliminar;
        private System.Windows.Forms.RibbonButton RibBtnSalir;
        private System.Windows.Forms.TabControl TabClientes;
        private System.Windows.Forms.TabPage TabLista;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.TabPage TabEditar;
        private System.Windows.Forms.TextBox TxtCorreoElectronicoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNroTelefonicoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDireccionCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDistrito;
        private System.Windows.Forms.ComboBox CmbProvincia;
        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNombreCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNroIDCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoIDCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocIdentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distritoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroTelefonicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregadoElDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agregadoPorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distritosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paisesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.TextBox TxtFilterNroTelefonico;
        private System.Windows.Forms.TextBox TxtFilterNombre;
        private System.Windows.Forms.ComboBox CmbFilterTipoID;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton TsBtnGuardar;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.ToolStripButton TsBtnDeshacer;
        private System.Windows.Forms.ToolStripButton TsBtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TsBtnSalir;
    }
}