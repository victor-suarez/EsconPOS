namespace EsconPOS.forms
{
    partial class FrmEmpleado
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TssLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblAgregado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TssLblModificado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsBtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnDeshacer = new System.Windows.Forms.ToolStripButton();
            this.TsBtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.TsBtnSalir = new System.Windows.Forms.ToolStripButton();
            this.TabClientes = new System.Windows.Forms.TabControl();
            this.TabLista = new System.Windows.Forms.TabPage();
            this.TxtFilterNroTelefonico = new System.Windows.Forms.TextBox();
            this.TxtFilterNombre = new System.Windows.Forms.TextBox();
            this.CmbFilterTipoID = new System.Windows.Forms.ComboBox();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.TabEditar = new System.Windows.Forms.TabPage();
            this.TxtCorreoElectronicoEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbDistrito = new System.Windows.Forms.ComboBox();
            this.CmbProvincia = new System.Windows.Forms.ComboBox();
            this.CmbDepartamento = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNroIDEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbTipoIDEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkEsSupervisor = new System.Windows.Forms.CheckBox();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.TabClientes.SuspendLayout();
            this.TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
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
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(669, 54);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssLblStatus,
            this.TssLblAgregado,
            this.TssLblModificado});
            this.statusStrip.Location = new System.Drawing.Point(0, 504);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(669, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // TssLblStatus
            // 
            this.TssLblStatus.Name = "TssLblStatus";
            this.TssLblStatus.Size = new System.Drawing.Size(341, 17);
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
            // TabClientes
            // 
            this.TabClientes.Controls.Add(this.TabLista);
            this.TabClientes.Controls.Add(this.TabEditar);
            this.TabClientes.Location = new System.Drawing.Point(6, 66);
            this.TabClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.SelectedIndex = 0;
            this.TabClientes.Size = new System.Drawing.Size(655, 435);
            this.TabClientes.TabIndex = 0;
            // 
            // TabLista
            // 
            this.TabLista.Controls.Add(this.TxtFilterNroTelefonico);
            this.TabLista.Controls.Add(this.TxtFilterNombre);
            this.TabLista.Controls.Add(this.CmbFilterTipoID);
            this.TabLista.Controls.Add(this.DgvEmpleados);
            this.TabLista.Location = new System.Drawing.Point(4, 29);
            this.TabLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabLista.Name = "TabLista";
            this.TabLista.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabLista.Size = new System.Drawing.Size(647, 402);
            this.TabLista.TabIndex = 0;
            this.TabLista.Text = "Lista";
            this.TabLista.UseVisualStyleBackColor = true;
            // 
            // TxtFilterNroTelefonico
            // 
            this.TxtFilterNroTelefonico.Location = new System.Drawing.Point(736, 9);
            this.TxtFilterNroTelefonico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFilterNroTelefonico.Name = "TxtFilterNroTelefonico";
            this.TxtFilterNroTelefonico.Size = new System.Drawing.Size(223, 26);
            this.TxtFilterNroTelefonico.TabIndex = 3;
            // 
            // TxtFilterNombre
            // 
            this.TxtFilterNombre.Location = new System.Drawing.Point(9, 9);
            this.TxtFilterNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFilterNombre.Name = "TxtFilterNombre";
            this.TxtFilterNombre.Size = new System.Drawing.Size(344, 26);
            this.TxtFilterNombre.TabIndex = 2;
            // 
            // CmbFilterTipoID
            // 
            this.CmbFilterTipoID.FormattingEnabled = true;
            this.CmbFilterTipoID.Location = new System.Drawing.Point(364, 9);
            this.CmbFilterTipoID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbFilterTipoID.Name = "CmbFilterTipoID";
            this.CmbFilterTipoID.Size = new System.Drawing.Size(85, 28);
            this.CmbFilterTipoID.TabIndex = 1;
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.AllowUserToAddRows = false;
            this.DgvEmpleados.AllowUserToDeleteRows = false;
            this.DgvEmpleados.AllowUserToOrderColumns = true;
            this.DgvEmpleados.AllowUserToResizeRows = false;
            this.DgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Location = new System.Drawing.Point(8, 47);
            this.DgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DgvEmpleados.MultiSelect = false;
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.ReadOnly = true;
            this.DgvEmpleados.RowHeadersVisible = false;
            this.DgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvEmpleados.Size = new System.Drawing.Size(631, 345);
            this.DgvEmpleados.TabIndex = 0;
            // 
            // TabEditar
            // 
            this.TabEditar.Controls.Add(this.ChkEsSupervisor);
            this.TabEditar.Controls.Add(this.TxtCorreoElectronicoEmpleado);
            this.TabEditar.Controls.Add(this.label3);
            this.TabEditar.Controls.Add(this.TxtTelefonoEmpleado);
            this.TabEditar.Controls.Add(this.label2);
            this.TabEditar.Controls.Add(this.TxtDireccionEmpleado);
            this.TabEditar.Controls.Add(this.label1);
            this.TabEditar.Controls.Add(this.CmbDistrito);
            this.TabEditar.Controls.Add(this.CmbProvincia);
            this.TabEditar.Controls.Add(this.CmbDepartamento);
            this.TabEditar.Controls.Add(this.label12);
            this.TabEditar.Controls.Add(this.TxtNombreEmpleado);
            this.TabEditar.Controls.Add(this.label6);
            this.TabEditar.Controls.Add(this.TxtNroIDEmpleado);
            this.TabEditar.Controls.Add(this.label5);
            this.TabEditar.Controls.Add(this.CmbTipoIDEmpleado);
            this.TabEditar.Controls.Add(this.label4);
            this.TabEditar.Location = new System.Drawing.Point(4, 29);
            this.TabEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabEditar.Name = "TabEditar";
            this.TabEditar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabEditar.Size = new System.Drawing.Size(647, 402);
            this.TabEditar.TabIndex = 1;
            this.TabEditar.Text = "Editar";
            this.TabEditar.UseVisualStyleBackColor = true;
            // 
            // TxtCorreoElectronicoEmpleado
            // 
            this.TxtCorreoElectronicoEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.TxtCorreoElectronicoEmpleado.Location = new System.Drawing.Point(185, 331);
            this.TxtCorreoElectronicoEmpleado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtCorreoElectronicoEmpleado.MaxLength = 255;
            this.TxtCorreoElectronicoEmpleado.Name = "TxtCorreoElectronicoEmpleado";
            this.TxtCorreoElectronicoEmpleado.Size = new System.Drawing.Size(453, 26);
            this.TxtCorreoElectronicoEmpleado.TabIndex = 15;
            this.TxtCorreoElectronicoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Correo Electrónico:";
            // 
            // TxtTelefonoEmpleado
            // 
            this.TxtTelefonoEmpleado.Location = new System.Drawing.Point(185, 293);
            this.TxtTelefonoEmpleado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtTelefonoEmpleado.MaxLength = 255;
            this.TxtTelefonoEmpleado.Name = "TxtTelefonoEmpleado";
            this.TxtTelefonoEmpleado.Size = new System.Drawing.Size(453, 26);
            this.TxtTelefonoEmpleado.TabIndex = 13;
            this.TxtTelefonoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 297);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Teléfonos:";
            // 
            // TxtDireccionEmpleado
            // 
            this.TxtDireccionEmpleado.Location = new System.Drawing.Point(185, 137);
            this.TxtDireccionEmpleado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtDireccionEmpleado.MaxLength = 255;
            this.TxtDireccionEmpleado.Multiline = true;
            this.TxtDireccionEmpleado.Name = "TxtDireccionEmpleado";
            this.TxtDireccionEmpleado.Size = new System.Drawing.Size(453, 104);
            this.TxtDireccionEmpleado.TabIndex = 7;
            this.TxtDireccionEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
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
            this.CmbDistrito.Location = new System.Drawing.Point(356, 253);
            this.CmbDistrito.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CmbDistrito.Name = "CmbDistrito";
            this.CmbDistrito.Size = new System.Drawing.Size(176, 28);
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
            this.CmbProvincia.Location = new System.Drawing.Point(271, 253);
            this.CmbProvincia.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CmbProvincia.Name = "CmbProvincia";
            this.CmbProvincia.Size = new System.Drawing.Size(73, 28);
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
            this.CmbDepartamento.Location = new System.Drawing.Point(185, 253);
            this.CmbDepartamento.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CmbDepartamento.Name = "CmbDepartamento";
            this.CmbDepartamento.Size = new System.Drawing.Size(73, 28);
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
            this.label12.Location = new System.Drawing.Point(10, 256);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Ubicación:";
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(185, 99);
            this.TxtNombreEmpleado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtNombreEmpleado.MaxLength = 255;
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(453, 26);
            this.TxtNombreEmpleado.TabIndex = 5;
            this.TxtNombreEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombres:";
            // 
            // TxtNroIDEmpleado
            // 
            this.TxtNroIDEmpleado.Location = new System.Drawing.Point(185, 63);
            this.TxtNroIDEmpleado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.TxtNroIDEmpleado.MaxLength = 20;
            this.TxtNroIDEmpleado.Name = "TxtNroIDEmpleado";
            this.TxtNroIDEmpleado.Size = new System.Drawing.Size(210, 26);
            this.TxtNroIDEmpleado.TabIndex = 3;
            this.TxtNroIDEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroIDEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nro de Identificación:";
            // 
            // CmbTipoIDEmpleado
            // 
            this.CmbTipoIDEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoIDEmpleado.FormattingEnabled = true;
            this.CmbTipoIDEmpleado.Location = new System.Drawing.Point(185, 25);
            this.CmbTipoIDEmpleado.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.CmbTipoIDEmpleado.Name = "CmbTipoIDEmpleado";
            this.CmbTipoIDEmpleado.Size = new System.Drawing.Size(340, 28);
            this.CmbTipoIDEmpleado.TabIndex = 1;
            this.CmbTipoIDEmpleado.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.CmbID_Format);
            this.CmbTipoIDEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cmb_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo de Identificación:";
            // 
            // ChkEsSupervisor
            // 
            this.ChkEsSupervisor.AutoSize = true;
            this.ChkEsSupervisor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ChkEsSupervisor.Location = new System.Drawing.Point(185, 368);
            this.ChkEsSupervisor.Name = "ChkEsSupervisor";
            this.ChkEsSupervisor.Size = new System.Drawing.Size(132, 24);
            this.ChkEsSupervisor.TabIndex = 16;
            this.ChkEsSupervisor.Text = "Es supervisor?";
            this.ChkEsSupervisor.UseVisualStyleBackColor = true;
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 526);
            this.Controls.Add(this.TabClientes);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEmpleado";
            this.Text = "Administrar empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.TabClientes.ResumeLayout(false);
            this.TabLista.ResumeLayout(false);
            this.TabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
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
        private System.Windows.Forms.TabControl TabClientes;
        private System.Windows.Forms.TabPage TabLista;
        private System.Windows.Forms.TextBox TxtFilterNroTelefonico;
        private System.Windows.Forms.TextBox TxtFilterNombre;
        private System.Windows.Forms.ComboBox CmbFilterTipoID;
        private System.Windows.Forms.DataGridView DgvEmpleados;
        private System.Windows.Forms.TabPage TabEditar;
        private System.Windows.Forms.TextBox TxtCorreoElectronicoEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTelefonoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDireccionEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbDistrito;
        private System.Windows.Forms.ComboBox CmbProvincia;
        private System.Windows.Forms.ComboBox CmbDepartamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNroIDEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbTipoIDEmpleado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkEsSupervisor;
    }
}