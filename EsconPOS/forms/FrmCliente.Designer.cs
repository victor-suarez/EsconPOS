namespace EsconPOS.forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.TabClientes = new System.Windows.Forms.TabControl();
            this.TabLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroNroID = new System.Windows.Forms.TextBox();
            this.CmbFiltroTipoID = new System.Windows.Forms.ComboBox();
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
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoIDCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TsLblAccion = new System.Windows.Forms.ToolStripLabel();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblAgregado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblModificado = new System.Windows.Forms.ToolStripStatusLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.NumDiaNac = new System.Windows.Forms.NumericUpDown();
            this.NumMesNac = new System.Windows.Forms.NumericUpDown();
            this.NumAñoNac = new System.Windows.Forms.NumericUpDown();
            this.TxtNroIDCliente = new System.Windows.Forms.TextBox();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.TabClientes.SuspendLayout();
            this.TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.TabEditar.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDiaNac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMesNac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAñoNac)).BeginInit();
            this.SuspendLayout();
            // 
            // TabClientes
            // 
            this.TabClientes.Controls.Add(this.TabLista);
            this.TabClientes.Controls.Add(this.TabEditar);
            this.TabClientes.Location = new System.Drawing.Point(6, 66);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.SelectedIndex = 0;
            this.TabClientes.Size = new System.Drawing.Size(655, 377);
            this.TabClientes.TabIndex = 0;
            // 
            // TabLista
            // 
            this.TabLista.Controls.Add(this.TxtFiltroNombre);
            this.TabLista.Controls.Add(this.TxtFiltroNroID);
            this.TabLista.Controls.Add(this.CmbFiltroTipoID);
            this.TabLista.Controls.Add(this.DgvClientes);
            this.TabLista.Location = new System.Drawing.Point(4, 29);
            this.TabLista.Name = "TabLista";
            this.TabLista.Padding = new System.Windows.Forms.Padding(3);
            this.TabLista.Size = new System.Drawing.Size(647, 344);
            this.TabLista.TabIndex = 0;
            this.TabLista.Text = "Lista";
            this.TabLista.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroNroID
            // 
            this.TxtFiltroNroID.Location = new System.Drawing.Point(70, 6);
            this.TxtFiltroNroID.Name = "TxtFiltroNroID";
            this.TxtFiltroNroID.Size = new System.Drawing.Size(143, 26);
            this.TxtFiltroNroID.TabIndex = 1;
            this.TxtFiltroNroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CmbFiltroTipoID
            // 
            this.CmbFiltroTipoID.FormattingEnabled = true;
            this.CmbFiltroTipoID.Location = new System.Drawing.Point(6, 6);
            this.CmbFiltroTipoID.Name = "CmbFiltroTipoID";
            this.CmbFiltroTipoID.Size = new System.Drawing.Size(58, 28);
            this.CmbFiltroTipoID.TabIndex = 0;
            // 
            // DgvClientes
            // 
            this.DgvClientes.AllowUserToAddRows = false;
            this.DgvClientes.AllowUserToDeleteRows = false;
            this.DgvClientes.AllowUserToOrderColumns = true;
            this.DgvClientes.AllowUserToResizeRows = false;
            this.DgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Location = new System.Drawing.Point(6, 38);
            this.DgvClientes.MultiSelect = false;
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.ReadOnly = true;
            this.DgvClientes.RowHeadersVisible = false;
            this.DgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvClientes.Size = new System.Drawing.Size(635, 295);
            this.DgvClientes.TabIndex = 3;
            this.DgvClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellContentDoubleClick);
            // 
            // TabEditar
            // 
            this.TabEditar.Controls.Add(this.TxtNroIDCliente);
            this.TabEditar.Controls.Add(this.NumAñoNac);
            this.TabEditar.Controls.Add(this.NumMesNac);
            this.TabEditar.Controls.Add(this.NumDiaNac);
            this.TabEditar.Controls.Add(this.label7);
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
            this.TabEditar.Controls.Add(this.label5);
            this.TabEditar.Controls.Add(this.CmbTipoIDCliente);
            this.TabEditar.Controls.Add(this.label4);
            this.TabEditar.Location = new System.Drawing.Point(4, 29);
            this.TabEditar.Name = "TabEditar";
            this.TabEditar.Padding = new System.Windows.Forms.Padding(3);
            this.TabEditar.Size = new System.Drawing.Size(647, 344);
            this.TabEditar.TabIndex = 1;
            this.TabEditar.Text = "Editar";
            this.TabEditar.UseVisualStyleBackColor = true;
            // 
            // TxtCorreoElectronicoCliente
            // 
            this.TxtCorreoElectronicoCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtCorreoElectronicoCliente.Location = new System.Drawing.Point(182, 271);
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
            this.label3.Location = new System.Drawing.Point(10, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo Electrónico:";
            // 
            // TxtNroTelefonicoCliente
            // 
            this.TxtNroTelefonicoCliente.Location = new System.Drawing.Point(182, 235);
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
            this.label2.Location = new System.Drawing.Point(10, 238);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teléfonos:";
            // 
            // TxtDireccionCliente
            // 
            this.TxtDireccionCliente.Location = new System.Drawing.Point(182, 118);
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
            this.label1.Location = new System.Drawing.Point(10, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dirección:";
            // 
            // CmbDistrito
            // 
            this.CmbDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDistrito.DropDownWidth = 326;
            this.CmbDistrito.FormattingEnabled = true;
            this.CmbDistrito.Location = new System.Drawing.Point(278, 198);
            this.CmbDistrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDistrito.Name = "CmbDistrito";
            this.CmbDistrito.Size = new System.Drawing.Size(357, 28);
            this.CmbDistrito.TabIndex = 11;
            this.CmbDistrito.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDistrito_Format);
            this.CmbDistrito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbProvincia
            // 
            this.CmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProvincia.DropDownWidth = 300;
            this.CmbProvincia.FormattingEnabled = true;
            this.CmbProvincia.Location = new System.Drawing.Point(230, 197);
            this.CmbProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbProvincia.Name = "CmbProvincia";
            this.CmbProvincia.Size = new System.Drawing.Size(40, 28);
            this.CmbProvincia.TabIndex = 10;
            this.CmbProvincia.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbProvincia_Format);
            this.CmbProvincia.SelectedValueChanged += new System.EventHandler(this.CmbProvincia_SelectedValueChanged);
            this.CmbProvincia.Enter += new System.EventHandler(this.CmbProvincia_Enter);
            this.CmbProvincia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            this.CmbProvincia.Leave += new System.EventHandler(this.CmbProvincia_Leave);
            // 
            // CmbDepartamento
            // 
            this.CmbDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDepartamento.DropDownWidth = 200;
            this.CmbDepartamento.FormattingEnabled = true;
            this.CmbDepartamento.Location = new System.Drawing.Point(182, 197);
            this.CmbDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(40, 28);
            this.CmbDepartamento.TabIndex = 9;
            this.CmbDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDepartamento_Format);
            this.CmbDepartamento.SelectedValueChanged += new System.EventHandler(this.CmbDepartamento_SelectedValueChanged);
            this.CmbDepartamento.Enter += new System.EventHandler(this.CmbDepartamento_Enter);
            this.CmbDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            this.CmbDepartamento.Leave += new System.EventHandler(this.CmbDepartamento_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 201);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ubicación:";
            // 
            // TxtNombreCliente
            // 
            this.TxtNombreCliente.Location = new System.Drawing.Point(182, 82);
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
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 49);
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
            this.CmbTipoIDCliente.Location = new System.Drawing.Point(182, 8);
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
            this.label4.Location = new System.Drawing.Point(10, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Identificación:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLblAccion,
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
            // TsLblAccion
            // 
            this.TsLblAccion.ForeColor = System.Drawing.Color.Green;
            this.TsLblAccion.Name = "TsLblAccion";
            this.TsLblAccion.Size = new System.Drawing.Size(66, 51);
            this.TsLblAccion.Text = "Agregando";
            this.TsLblAccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 444);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(673, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(353, 17);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Fecha Nacimiento:";
            // 
            // NumDiaNac
            // 
            this.NumDiaNac.Location = new System.Drawing.Point(182, 308);
            this.NumDiaNac.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.NumDiaNac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumDiaNac.Name = "NumDiaNac";
            this.NumDiaNac.Size = new System.Drawing.Size(40, 26);
            this.NumDiaNac.TabIndex = 17;
            this.NumDiaNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumDiaNac.Value = new decimal(new int[] {
            31,
            0,
            0,
            0});
            // 
            // NumMesNac
            // 
            this.NumMesNac.Location = new System.Drawing.Point(228, 308);
            this.NumMesNac.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumMesNac.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumMesNac.Name = "NumMesNac";
            this.NumMesNac.Size = new System.Drawing.Size(40, 26);
            this.NumMesNac.TabIndex = 18;
            this.NumMesNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumMesNac.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // NumAñoNac
            // 
            this.NumAñoNac.Location = new System.Drawing.Point(274, 308);
            this.NumAñoNac.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.NumAñoNac.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.NumAñoNac.Name = "NumAñoNac";
            this.NumAñoNac.Size = new System.Drawing.Size(63, 26);
            this.NumAñoNac.TabIndex = 19;
            this.NumAñoNac.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumAñoNac.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // TxtNroIDCliente
            // 
            this.TxtNroIDCliente.Location = new System.Drawing.Point(182, 46);
            this.TxtNroIDCliente.MaxLength = 15;
            this.TxtNroIDCliente.Name = "TxtNroIDCliente";
            this.TxtNroIDCliente.Size = new System.Drawing.Size(143, 26);
            this.TxtNroIDCliente.TabIndex = 3;
            this.TxtNroIDCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Location = new System.Drawing.Point(220, 6);
            this.TxtFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltroNombre.MaxLength = 255;
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(420, 26);
            this.TxtFiltroNombre.TabIndex = 2;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 466);
            this.Controls.Add(this.statusStrip);
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
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDiaNac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMesNac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAñoNac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoIDCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFiltroNroID;
        private System.Windows.Forms.ComboBox CmbFiltroTipoID;
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
        private System.Windows.Forms.ToolStripLabel TsLblAccion;
        private System.Windows.Forms.NumericUpDown NumAñoNac;
        private System.Windows.Forms.NumericUpDown NumMesNac;
        private System.Windows.Forms.NumericUpDown NumDiaNac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNroIDCliente;
        private System.Windows.Forms.TextBox TxtFiltroNombre;
    }
}