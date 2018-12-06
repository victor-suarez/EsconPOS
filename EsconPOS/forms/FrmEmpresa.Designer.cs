namespace EsconPOS.forms
{
    partial class FrmEmpresa
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
            this.TabEmpresas = new System.Windows.Forms.TabControl();
            this.TabLista = new System.Windows.Forms.TabPage();
            this.TxtFiltroNombre = new System.Windows.Forms.TextBox();
            this.TxtFiltroNroID = new System.Windows.Forms.TextBox();
            this.CmbFiltroTipoID = new System.Windows.Forms.ComboBox();
            this.DgvEmpresas = new System.Windows.Forms.DataGridView();
            this.TabEditar = new System.Windows.Forms.TabPage();
            this.TxtUrbanizacion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNroIDEmpresa = new System.Windows.Forms.TextBox();
            this.TxtCorreoElectronicoEmpresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNroTelefonicoEmpresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccionEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDistrito = new System.Windows.Forms.ComboBox();
            this.CmbProvincia = new System.Windows.Forms.ComboBox();
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNombreComercial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoIDEmpresa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabEmpresas.SuspendLayout();
            this.TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).BeginInit();
            this.TabEditar.SuspendLayout();
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
            this.toolStrip.Size = new System.Drawing.Size(747, 54);
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
            this.statusStrip.Location = new System.Drawing.Point(0, 479);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(747, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(419, 17);
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
            // TabEmpresas
            // 
            this.TabEmpresas.Controls.Add(this.TabLista);
            this.TabEmpresas.Controls.Add(this.TabEditar);
            this.TabEmpresas.Location = new System.Drawing.Point(12, 57);
            this.TabEmpresas.Name = "TabEmpresas";
            this.TabEmpresas.SelectedIndex = 0;
            this.TabEmpresas.Size = new System.Drawing.Size(735, 413);
            this.TabEmpresas.TabIndex = 0;
            // 
            // TabLista
            // 
            this.TabLista.Controls.Add(this.TxtFiltroNombre);
            this.TabLista.Controls.Add(this.TxtFiltroNroID);
            this.TabLista.Controls.Add(this.CmbFiltroTipoID);
            this.TabLista.Controls.Add(this.DgvEmpresas);
            this.TabLista.Location = new System.Drawing.Point(4, 29);
            this.TabLista.Name = "TabLista";
            this.TabLista.Padding = new System.Windows.Forms.Padding(3);
            this.TabLista.Size = new System.Drawing.Size(727, 380);
            this.TabLista.TabIndex = 0;
            this.TabLista.Text = "Lista";
            this.TabLista.UseVisualStyleBackColor = true;
            // 
            // TxtFiltroNombre
            // 
            this.TxtFiltroNombre.Location = new System.Drawing.Point(220, 6);
            this.TxtFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFiltroNombre.MaxLength = 255;
            this.TxtFiltroNombre.Name = "TxtFiltroNombre";
            this.TxtFiltroNombre.Size = new System.Drawing.Size(503, 26);
            this.TxtFiltroNombre.TabIndex = 2;
            this.TxtFiltroNombre.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // TxtFiltroNroID
            // 
            this.TxtFiltroNroID.Location = new System.Drawing.Point(70, 6);
            this.TxtFiltroNroID.Name = "TxtFiltroNroID";
            this.TxtFiltroNroID.Size = new System.Drawing.Size(143, 26);
            this.TxtFiltroNroID.TabIndex = 1;
            this.TxtFiltroNroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtFiltroNroID.TextChanged += new System.EventHandler(this.Txt_TextChanged);
            // 
            // CmbFiltroTipoID
            // 
            this.CmbFiltroTipoID.FormattingEnabled = true;
            this.CmbFiltroTipoID.Location = new System.Drawing.Point(6, 6);
            this.CmbFiltroTipoID.Name = "CmbFiltroTipoID";
            this.CmbFiltroTipoID.Size = new System.Drawing.Size(58, 28);
            this.CmbFiltroTipoID.TabIndex = 0;
            this.CmbFiltroTipoID.SelectedIndexChanged += new System.EventHandler(this.Cmb_SelectedIndexChanged);
            // 
            // DgvEmpresas
            // 
            this.DgvEmpresas.AllowUserToAddRows = false;
            this.DgvEmpresas.AllowUserToDeleteRows = false;
            this.DgvEmpresas.AllowUserToOrderColumns = true;
            this.DgvEmpresas.AllowUserToResizeRows = false;
            this.DgvEmpresas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpresas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvEmpresas.Location = new System.Drawing.Point(3, 38);
            this.DgvEmpresas.MultiSelect = false;
            this.DgvEmpresas.Name = "DgvEmpresas";
            this.DgvEmpresas.ReadOnly = true;
            this.DgvEmpresas.RowHeadersVisible = false;
            this.DgvEmpresas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpresas.Size = new System.Drawing.Size(721, 339);
            this.DgvEmpresas.TabIndex = 3;
            this.DgvEmpresas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEmpresas_CellContentDoubleClick);
            // 
            // TabEditar
            // 
            this.TabEditar.Controls.Add(this.TxtUrbanizacion);
            this.TabEditar.Controls.Add(this.label8);
            this.TabEditar.Controls.Add(this.TxtRazonSocial);
            this.TabEditar.Controls.Add(this.label7);
            this.TabEditar.Controls.Add(this.TxtNroIDEmpresa);
            this.TabEditar.Controls.Add(this.TxtCorreoElectronicoEmpresa);
            this.TabEditar.Controls.Add(this.label3);
            this.TabEditar.Controls.Add(this.TxtNroTelefonicoEmpresa);
            this.TabEditar.Controls.Add(this.label2);
            this.TabEditar.Controls.Add(this.TxtDireccionEmpresa);
            this.TabEditar.Controls.Add(this.label1);
            this.TabEditar.Controls.Add(this.CmbDistrito);
            this.TabEditar.Controls.Add(this.CmbProvincia);
            this.TabEditar.Controls.Add(this.CmbDepartamento);
            this.TabEditar.Controls.Add(this.label12);
            this.TabEditar.Controls.Add(this.TxtNombreComercial);
            this.TabEditar.Controls.Add(this.label6);
            this.TabEditar.Controls.Add(this.label5);
            this.TabEditar.Controls.Add(this.CmbTipoIDEmpresa);
            this.TabEditar.Controls.Add(this.label4);
            this.TabEditar.Location = new System.Drawing.Point(4, 29);
            this.TabEditar.Name = "TabEditar";
            this.TabEditar.Padding = new System.Windows.Forms.Padding(3);
            this.TabEditar.Size = new System.Drawing.Size(647, 380);
            this.TabEditar.TabIndex = 1;
            this.TabEditar.Text = "Editar";
            this.TabEditar.UseVisualStyleBackColor = true;
            // 
            // TxtUrbanizacion
            // 
            this.TxtUrbanizacion.Location = new System.Drawing.Point(182, 233);
            this.TxtUrbanizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtUrbanizacion.MaxLength = 255;
            this.TxtUrbanizacion.Name = "TxtUrbanizacion";
            this.TxtUrbanizacion.Size = new System.Drawing.Size(453, 26);
            this.TxtUrbanizacion.TabIndex = 11;
            this.TxtUrbanizacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 236);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Urbanización:";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(182, 118);
            this.TxtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRazonSocial.MaxLength = 255;
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(453, 26);
            this.TxtRazonSocial.TabIndex = 7;
            this.TxtRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Razón Social:";
            // 
            // TxtNroIDEmpresa
            // 
            this.TxtNroIDEmpresa.Location = new System.Drawing.Point(182, 46);
            this.TxtNroIDEmpresa.MaxLength = 15;
            this.TxtNroIDEmpresa.Name = "TxtNroIDEmpresa";
            this.TxtNroIDEmpresa.Size = new System.Drawing.Size(143, 26);
            this.TxtNroIDEmpresa.TabIndex = 3;
            this.TxtNroIDEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroIDEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // TxtCorreoElectronicoEmpresa
            // 
            this.TxtCorreoElectronicoEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtCorreoElectronicoEmpresa.Location = new System.Drawing.Point(182, 342);
            this.TxtCorreoElectronicoEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCorreoElectronicoEmpresa.MaxLength = 255;
            this.TxtCorreoElectronicoEmpresa.Name = "TxtCorreoElectronicoEmpresa";
            this.TxtCorreoElectronicoEmpresa.Size = new System.Drawing.Size(453, 26);
            this.TxtCorreoElectronicoEmpresa.TabIndex = 19;
            this.TxtCorreoElectronicoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 345);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Correo Electrónico:";
            // 
            // TxtNroTelefonicoEmpresa
            // 
            this.TxtNroTelefonicoEmpresa.Location = new System.Drawing.Point(182, 306);
            this.TxtNroTelefonicoEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNroTelefonicoEmpresa.MaxLength = 255;
            this.TxtNroTelefonicoEmpresa.Name = "TxtNroTelefonicoEmpresa";
            this.TxtNroTelefonicoEmpresa.Size = new System.Drawing.Size(453, 26);
            this.TxtNroTelefonicoEmpresa.TabIndex = 17;
            this.TxtNroTelefonicoEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 309);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Teléfonos:";
            // 
            // TxtDireccionEmpresa
            // 
            this.TxtDireccionEmpresa.Location = new System.Drawing.Point(182, 154);
            this.TxtDireccionEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDireccionEmpresa.MaxLength = 255;
            this.TxtDireccionEmpresa.Multiline = true;
            this.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa";
            this.TxtDireccionEmpresa.Size = new System.Drawing.Size(453, 69);
            this.TxtDireccionEmpresa.TabIndex = 9;
            this.TxtDireccionEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dirección:";
            // 
            // CmbDistrito
            // 
            this.CmbDistrito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbDistrito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbDistrito.DropDownWidth = 326;
            this.CmbDistrito.FormattingEnabled = true;
            this.CmbDistrito.Location = new System.Drawing.Point(278, 269);
            this.CmbDistrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDistrito.Name = "CmbDistrito";
            this.CmbDistrito.Size = new System.Drawing.Size(357, 28);
            this.CmbDistrito.TabIndex = 15;
            this.CmbDistrito.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDistrito_Format);
            this.CmbDistrito.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // CmbProvincia
            // 
            this.CmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmbProvincia.DropDownWidth = 300;
            this.CmbProvincia.FormattingEnabled = true;
            this.CmbProvincia.Location = new System.Drawing.Point(230, 268);
            this.CmbProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbProvincia.Name = "CmbProvincia";
            this.CmbProvincia.Size = new System.Drawing.Size(40, 28);
            this.CmbProvincia.TabIndex = 14;
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
            this.CmbDepartamento.Location = new System.Drawing.Point(182, 268);
            this.CmbDepartamento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(40, 28);
            this.CmbDepartamento.TabIndex = 13;
            this.CmbDepartamento.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbDepartamento_Format);
            this.CmbDepartamento.SelectedValueChanged += new System.EventHandler(this.CmbDepartamento_SelectedValueChanged);
            this.CmbDepartamento.Enter += new System.EventHandler(this.CmbDepartamento_Enter);
            this.CmbDepartamento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            this.CmbDepartamento.Leave += new System.EventHandler(this.CmbDepartamento_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 272);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ubicación:";
            // 
            // TxtNombreComercial
            // 
            this.TxtNombreComercial.Location = new System.Drawing.Point(182, 82);
            this.TxtNombreComercial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtNombreComercial.MaxLength = 255;
            this.TxtNombreComercial.Name = "TxtNombreComercial";
            this.TxtNombreComercial.Size = new System.Drawing.Size(453, 26);
            this.TxtNombreComercial.TabIndex = 5;
            this.TxtNombreComercial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre Comercial:";
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
            // CmbTipoIDEmpresa
            // 
            this.CmbTipoIDEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoIDEmpresa.FormattingEnabled = true;
            this.CmbTipoIDEmpresa.Location = new System.Drawing.Point(182, 8);
            this.CmbTipoIDEmpresa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbTipoIDEmpresa.Name = "CmbTipoIDEmpresa";
            this.CmbTipoIDEmpresa.Size = new System.Drawing.Size(340, 28);
            this.CmbTipoIDEmpresa.TabIndex = 1;
            this.CmbTipoIDEmpresa.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbID_Format);
            this.CmbTipoIDEmpresa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
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
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 501);
            this.Controls.Add(this.TabEmpresas);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmpresa";
            this.Text = "Administrar Empresas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpresa_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabEmpresas.ResumeLayout(false);
            this.TabLista.ResumeLayout(false);
            this.TabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpresas)).EndInit();
            this.TabEditar.ResumeLayout(false);
            this.TabEditar.PerformLayout();
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
        private System.Windows.Forms.TabControl TabEmpresas;
        private System.Windows.Forms.TabPage TabLista;
        private System.Windows.Forms.TextBox TxtFiltroNombre;
        private System.Windows.Forms.TextBox TxtFiltroNroID;
        private System.Windows.Forms.ComboBox CmbFiltroTipoID;
        private System.Windows.Forms.DataGridView DgvEmpresas;
        private System.Windows.Forms.TabPage TabEditar;
        private System.Windows.Forms.TextBox TxtUrbanizacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNroIDEmpresa;
        private System.Windows.Forms.TextBox TxtCorreoElectronicoEmpresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNroTelefonicoEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDireccionEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDistrito;
        private System.Windows.Forms.ComboBox CmbProvincia;
        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNombreComercial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoIDEmpresa;
        private System.Windows.Forms.Label label4;
    }
}