namespace EsconPOS.forms
{
    partial class MDIEsconPos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIEsconPos));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslCaja = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TssPpalFiller1 = new System.Windows.Forms.ToolStripSeparator();
            this.TssPpalFiller2 = new System.Windows.Forms.ToolStripSeparator();
            this.TssPpalFiller3 = new System.Windows.Forms.ToolStripSeparator();
            this.TssbPpalCaja = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiCajaIncluirFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCajaAbrirCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbPpalAdministrar = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiAdminEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAdminEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAdminClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAdminFormasPago = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAdminMiContrasenia = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbPpalUbicacion = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiUbigeoPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiUbigeoDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiUbigeoProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiUbigeoDistritos = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbPpalSunat = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiSunatBancos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSunatImpuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSunatMonedas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSunatTiposDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSunatUnidadesMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbPpalProductos = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiProdMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiProdClases = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiProdServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbPpalWindow = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiWindowCascada = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWindowVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWindowHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWindowMinimizarTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWindowCierraTodas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiWindowFiller = new System.Windows.Forms.ToolStripSeparator();
            this.TssbPpalSalir = new System.Windows.Forms.ToolStripButton();
            this.statusStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslStatus,
            this.TsslEmpleado,
            this.TsslCaja,
            this.TsslFecha,
            this.TsslHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 386);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // TsslStatus
            // 
            this.TsslStatus.Name = "TsslStatus";
            this.TsslStatus.Size = new System.Drawing.Size(925, 17);
            this.TsslStatus.Spring = true;
            this.TsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TsslEmpleado
            // 
            this.TsslEmpleado.Name = "TsslEmpleado";
            this.TsslEmpleado.Size = new System.Drawing.Size(0, 17);
            // 
            // TsslCaja
            // 
            this.TsslCaja.Name = "TsslCaja";
            this.TsslCaja.Size = new System.Drawing.Size(0, 17);
            // 
            // TsslFecha
            // 
            this.TsslFecha.Name = "TsslFecha";
            this.TsslFecha.Size = new System.Drawing.Size(0, 17);
            // 
            // TsslHora
            // 
            this.TsslHora.Name = "TsslHora";
            this.TsslHora.Size = new System.Drawing.Size(0, 17);
            // 
            // TmrHora
            // 
            this.TmrHora.Interval = 60000;
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TssbPpalCaja,
            this.TssPpalFiller1,
            this.TssbPpalAdministrar,
            this.TssbPpalUbicacion,
            this.TssbPpalSunat,
            this.TssbPpalProductos,
            this.TssPpalFiller2,
            this.TssbPpalWindow,
            this.TssbPpalSalir,
            this.TssPpalFiller3});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(948, 54);
            this.toolStrip.TabIndex = 4;
            // 
            // TssPpalFiller1
            // 
            this.TssPpalFiller1.Name = "TssPpalFiller1";
            this.TssPpalFiller1.Size = new System.Drawing.Size(6, 54);
            // 
            // TssPpalFiller2
            // 
            this.TssPpalFiller2.Name = "TssPpalFiller2";
            this.TssPpalFiller2.Size = new System.Drawing.Size(6, 54);
            // 
            // TssPpalFiller3
            // 
            this.TssPpalFiller3.Name = "TssPpalFiller3";
            this.TssPpalFiller3.Size = new System.Drawing.Size(6, 54);
            // 
            // TssbPpalCaja
            // 
            this.TssbPpalCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiCajaIncluirFactura,
            this.TsmiCajaAbrirCuenta});
            this.TssbPpalCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TssbPpalCaja.Name = "TssbPpalCaja";
            this.TssbPpalCaja.Size = new System.Drawing.Size(75, 51);
            this.TssbPpalCaja.Text = "Abrir &Caja";
            this.TssbPpalCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbPpalCaja.Visible = false;
            this.TssbPpalCaja.ButtonClick += new System.EventHandler(this.Tssb_ButtonClick);
            // 
            // TsmiCajaIncluirFactura
            // 
            this.TsmiCajaIncluirFactura.Name = "TsmiCajaIncluirFactura";
            this.TsmiCajaIncluirFactura.Size = new System.Drawing.Size(149, 22);
            this.TsmiCajaIncluirFactura.Text = "Incluir &Factura";
            this.TsmiCajaIncluirFactura.Visible = false;
            this.TsmiCajaIncluirFactura.Click += new System.EventHandler(this.TsmiCajaIncluirFactura_Click);
            // 
            // TsmiCajaAbrirCuenta
            // 
            this.TsmiCajaAbrirCuenta.Name = "TsmiCajaAbrirCuenta";
            this.TsmiCajaAbrirCuenta.Size = new System.Drawing.Size(149, 22);
            this.TsmiCajaAbrirCuenta.Text = "Abrir &Cuenta";
            this.TsmiCajaAbrirCuenta.Visible = false;
            // 
            // TssbPpalAdministrar
            // 
            this.TssbPpalAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiAdminEmpresas,
            this.TsmiAdminEmpleados,
            this.TsmiAdminClientes,
            this.TsmiAdminFormasPago,
            this.TsmiAdminMiContrasenia});
            this.TssbPpalAdministrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalAdministrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TssbPpalAdministrar.Name = "TssbPpalAdministrar";
            this.TssbPpalAdministrar.Size = new System.Drawing.Size(85, 51);
            this.TssbPpalAdministrar.Text = "&Administrar";
            this.TssbPpalAdministrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbPpalAdministrar.Visible = false;
            this.TssbPpalAdministrar.ButtonClick += new System.EventHandler(this.Tssb_ButtonClick);
            // 
            // TsmiAdminEmpresas
            // 
            this.TsmiAdminEmpresas.Name = "TsmiAdminEmpresas";
            this.TsmiAdminEmpresas.Size = new System.Drawing.Size(159, 22);
            this.TsmiAdminEmpresas.Text = "&Empresas";
            this.TsmiAdminEmpresas.Click += new System.EventHandler(this.TsmiAdminEmpresas_Click);
            // 
            // TsmiAdminEmpleados
            // 
            this.TsmiAdminEmpleados.Name = "TsmiAdminEmpleados";
            this.TsmiAdminEmpleados.Size = new System.Drawing.Size(159, 22);
            this.TsmiAdminEmpleados.Text = "E&mpleados";
            this.TsmiAdminEmpleados.Click += new System.EventHandler(this.TsmiAdminEmpleados_Click);
            // 
            // TsmiAdminClientes
            // 
            this.TsmiAdminClientes.Name = "TsmiAdminClientes";
            this.TsmiAdminClientes.Size = new System.Drawing.Size(159, 22);
            this.TsmiAdminClientes.Text = "&Clientes";
            this.TsmiAdminClientes.Click += new System.EventHandler(this.TsmiAdminClientes_Click);
            // 
            // TsmiAdminFormasPago
            // 
            this.TsmiAdminFormasPago.Name = "TsmiAdminFormasPago";
            this.TsmiAdminFormasPago.Size = new System.Drawing.Size(159, 22);
            this.TsmiAdminFormasPago.Text = "&Formas de pago";
            this.TsmiAdminFormasPago.Click += new System.EventHandler(this.TsmiAdminFormasPago_Click);
            // 
            // TsmiAdminMiContrasenia
            // 
            this.TsmiAdminMiContrasenia.Name = "TsmiAdminMiContrasenia";
            this.TsmiAdminMiContrasenia.Size = new System.Drawing.Size(159, 22);
            this.TsmiAdminMiContrasenia.Text = "M&i contraseña";
            this.TsmiAdminMiContrasenia.Click += new System.EventHandler(this.TsmiAdminMiContrasenia_Click);
            // 
            // TssbPpalUbicacion
            // 
            this.TssbPpalUbicacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiUbigeoPaises,
            this.TsmiUbigeoDepartamentos,
            this.TsmiUbigeoProvincias,
            this.TsmiUbigeoDistritos});
            this.TssbPpalUbicacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalUbicacion.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbPpalUbicacion.Name = "TssbPpalUbicacion";
            this.TssbPpalUbicacion.Size = new System.Drawing.Size(76, 51);
            this.TssbPpalUbicacion.Text = "&Ubicación";
            this.TssbPpalUbicacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbPpalUbicacion.Visible = false;
            this.TssbPpalUbicacion.ButtonClick += new System.EventHandler(this.Tssb_ButtonClick);
            // 
            // TsmiUbigeoPaises
            // 
            this.TsmiUbigeoPaises.Name = "TsmiUbigeoPaises";
            this.TsmiUbigeoPaises.Size = new System.Drawing.Size(155, 22);
            this.TsmiUbigeoPaises.Text = "&Paises";
            // 
            // TsmiUbigeoDepartamentos
            // 
            this.TsmiUbigeoDepartamentos.Name = "TsmiUbigeoDepartamentos";
            this.TsmiUbigeoDepartamentos.Size = new System.Drawing.Size(155, 22);
            this.TsmiUbigeoDepartamentos.Text = "&Departamentos";
            // 
            // TsmiUbigeoProvincias
            // 
            this.TsmiUbigeoProvincias.Name = "TsmiUbigeoProvincias";
            this.TsmiUbigeoProvincias.Size = new System.Drawing.Size(155, 22);
            this.TsmiUbigeoProvincias.Text = "P&rovincias";
            // 
            // TsmiUbigeoDistritos
            // 
            this.TsmiUbigeoDistritos.Name = "TsmiUbigeoDistritos";
            this.TsmiUbigeoDistritos.Size = new System.Drawing.Size(155, 22);
            this.TsmiUbigeoDistritos.Text = "D&istritos";
            // 
            // TssbPpalSunat
            // 
            this.TssbPpalSunat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSunatBancos,
            this.TsmiSunatImpuestos,
            this.TsmiSunatMonedas,
            this.TsmiSunatTiposDocumentos,
            this.TsmiSunatUnidadesMedida});
            this.TssbPpalSunat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalSunat.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbPpalSunat.Name = "TssbPpalSunat";
            this.TssbPpalSunat.Size = new System.Drawing.Size(60, 51);
            this.TssbPpalSunat.Text = "SU&NAT";
            this.TssbPpalSunat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbPpalSunat.Visible = false;
            this.TssbPpalSunat.ButtonClick += new System.EventHandler(this.Tssb_ButtonClick);
            // 
            // TsmiSunatBancos
            // 
            this.TsmiSunatBancos.Name = "TsmiSunatBancos";
            this.TsmiSunatBancos.Size = new System.Drawing.Size(189, 22);
            this.TsmiSunatBancos.Text = "&Bancos";
            this.TsmiSunatBancos.Click += new System.EventHandler(this.TsmiSunatBancos_Click);
            // 
            // TsmiSunatImpuestos
            // 
            this.TsmiSunatImpuestos.Name = "TsmiSunatImpuestos";
            this.TsmiSunatImpuestos.Size = new System.Drawing.Size(189, 22);
            this.TsmiSunatImpuestos.Text = "&Impuestos";
            this.TsmiSunatImpuestos.Click += new System.EventHandler(this.TsmiSunatImpuestos_Click);
            // 
            // TsmiSunatMonedas
            // 
            this.TsmiSunatMonedas.Name = "TsmiSunatMonedas";
            this.TsmiSunatMonedas.Size = new System.Drawing.Size(189, 22);
            this.TsmiSunatMonedas.Text = "&Monedas";
            this.TsmiSunatMonedas.Click += new System.EventHandler(this.TsmiSunatMonedas_Click);
            // 
            // TsmiSunatTiposDocumentos
            // 
            this.TsmiSunatTiposDocumentos.Name = "TsmiSunatTiposDocumentos";
            this.TsmiSunatTiposDocumentos.Size = new System.Drawing.Size(189, 22);
            this.TsmiSunatTiposDocumentos.Text = "&Tipos de documentos";
            // 
            // TsmiSunatUnidadesMedida
            // 
            this.TsmiSunatUnidadesMedida.Name = "TsmiSunatUnidadesMedida";
            this.TsmiSunatUnidadesMedida.Size = new System.Drawing.Size(189, 22);
            this.TsmiSunatUnidadesMedida.Text = "&Unidades de medida";
            this.TsmiSunatUnidadesMedida.Click += new System.EventHandler(this.TsmiSunatUnidadesMedida_Click);
            // 
            // TssbPpalProductos
            // 
            this.TssbPpalProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiProdMarcas,
            this.TsmiProdClases,
            this.TsmiProdServicios});
            this.TssbPpalProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalProductos.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbPpalProductos.Name = "TssbPpalProductos";
            this.TssbPpalProductos.Size = new System.Drawing.Size(85, 51);
            this.TssbPpalProductos.Text = "&Prods/Servs";
            this.TssbPpalProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbPpalProductos.ToolTipText = "Productos/Servicios";
            this.TssbPpalProductos.Visible = false;
            this.TssbPpalProductos.ButtonClick += new System.EventHandler(this.Tssb_ButtonClick);
            // 
            // TsmiProdMarcas
            // 
            this.TsmiProdMarcas.Name = "TsmiProdMarcas";
            this.TsmiProdMarcas.Size = new System.Drawing.Size(179, 22);
            this.TsmiProdMarcas.Text = "&Marcas";
            this.TsmiProdMarcas.Click += new System.EventHandler(this.TsmiProdMarcas_Click);
            // 
            // TsmiProdClases
            // 
            this.TsmiProdClases.Name = "TsmiProdClases";
            this.TsmiProdClases.Size = new System.Drawing.Size(179, 22);
            this.TsmiProdClases.Text = "&Clases";
            this.TsmiProdClases.Click += new System.EventHandler(this.TsmiProdClases_Click);
            // 
            // TsmiProdServicios
            // 
            this.TsmiProdServicios.Name = "TsmiProdServicios";
            this.TsmiProdServicios.Size = new System.Drawing.Size(179, 22);
            this.TsmiProdServicios.Text = "&Productos/Servicios";
            this.TsmiProdServicios.Click += new System.EventHandler(this.TsmiProdServicios_Click);
            // 
            // TssbPpalWindow
            // 
            this.TssbPpalWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiWindowCascada,
            this.TsmiWindowVertical,
            this.TsmiWindowHorizontal,
            this.TsmiWindowMinimizarTodas,
            this.TsmiWindowCierraTodas,
            this.TsmiWindowFiller});
            this.TssbPpalWindow.Image = ((System.Drawing.Image)(resources.GetObject("TssbPpalWindow.Image")));
            this.TssbPpalWindow.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalWindow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TssbPpalWindow.Name = "TssbPpalWindow";
            this.TssbPpalWindow.Size = new System.Drawing.Size(67, 51);
            this.TssbPpalWindow.Text = "&Window";
            this.TssbPpalWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // TsmiWindowCascada
            // 
            this.TsmiWindowCascada.Name = "TsmiWindowCascada";
            this.TsmiWindowCascada.Size = new System.Drawing.Size(161, 22);
            this.TsmiWindowCascada.Text = "&Cascada";
            this.TsmiWindowCascada.Click += new System.EventHandler(this.TssbWindowCascada_Click);
            // 
            // TsmiWindowVertical
            // 
            this.TsmiWindowVertical.Name = "TsmiWindowVertical";
            this.TsmiWindowVertical.Size = new System.Drawing.Size(161, 22);
            this.TsmiWindowVertical.Text = "&Vertical";
            this.TsmiWindowVertical.Click += new System.EventHandler(this.TsmiWindowVertical_Click);
            // 
            // TsmiWindowHorizontal
            // 
            this.TsmiWindowHorizontal.Name = "TsmiWindowHorizontal";
            this.TsmiWindowHorizontal.Size = new System.Drawing.Size(161, 22);
            this.TsmiWindowHorizontal.Text = "&Horizontal";
            this.TsmiWindowHorizontal.Click += new System.EventHandler(this.TsmiWindowHorizontal_Click);
            // 
            // TsmiWindowMinimizarTodas
            // 
            this.TsmiWindowMinimizarTodas.Name = "TsmiWindowMinimizarTodas";
            this.TsmiWindowMinimizarTodas.Size = new System.Drawing.Size(161, 22);
            this.TsmiWindowMinimizarTodas.Text = "&Minimizar Todas";
            this.TsmiWindowMinimizarTodas.Click += new System.EventHandler(this.TsmiWindowMinimizarTodas_Click);
            // 
            // TsmiWindowCierraTodas
            // 
            this.TsmiWindowCierraTodas.Name = "TsmiWindowCierraTodas";
            this.TsmiWindowCierraTodas.Size = new System.Drawing.Size(161, 22);
            this.TsmiWindowCierraTodas.Text = "Cerrar &Todas";
            this.TsmiWindowCierraTodas.Click += new System.EventHandler(this.TsmiWindowCierraTodas_Click);
            // 
            // TsmiWindowFiller
            // 
            this.TsmiWindowFiller.Name = "TsmiWindowFiller";
            this.TsmiWindowFiller.Size = new System.Drawing.Size(158, 6);
            // 
            // TssbPpalSalir
            // 
            this.TssbPpalSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbPpalSalir.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbPpalSalir.Name = "TssbPpalSalir";
            this.TssbPpalSalir.Size = new System.Drawing.Size(36, 51);
            this.TssbPpalSalir.Text = "&Salir";
            this.TssbPpalSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbPpalSalir.Click += new System.EventHandler(this.TssbSalir_Click);
            // 
            // MDIEsconPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 408);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIEsconPos";
            this.Text = "EsconPOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIEsconPos_FormClosing);
            this.Load += new System.EventHandler(this.MDIEsconPos_Load);
            this.MdiChildActivate += new System.EventHandler(this.MDIEsconPos_MdiChildActivate);
            this.Shown += new System.EventHandler(this.MDIEsconPos_Shown);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel TsslStatus;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel TsslCaja;
        private System.Windows.Forms.ToolStripStatusLabel TsslEmpleado;
        private System.Windows.Forms.ToolStripStatusLabel TsslFecha;
        private System.Windows.Forms.ToolStripStatusLabel TsslHora;
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.ToolStripSplitButton TssbPpalUbicacion;
        private System.Windows.Forms.ToolStripMenuItem TsmiUbigeoPaises;
        private System.Windows.Forms.ToolStripMenuItem TsmiUbigeoDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem TsmiUbigeoProvincias;
        private System.Windows.Forms.ToolStripMenuItem TsmiUbigeoDistritos;
        private System.Windows.Forms.ToolStripSplitButton TssbPpalSunat;
        private System.Windows.Forms.ToolStripMenuItem TsmiSunatImpuestos;
        private System.Windows.Forms.ToolStripMenuItem TsmiSunatMonedas;
        private System.Windows.Forms.ToolStripMenuItem TsmiSunatTiposDocumentos;
        private System.Windows.Forms.ToolStripMenuItem TsmiSunatUnidadesMedida;
        private System.Windows.Forms.ToolStripSplitButton TssbPpalProductos;
        private System.Windows.Forms.ToolStripMenuItem TsmiProdMarcas;
        private System.Windows.Forms.ToolStripMenuItem TsmiProdClases;
        private System.Windows.Forms.ToolStripMenuItem TsmiProdServicios;
        private System.Windows.Forms.ToolStripSeparator TssPpalFiller1;
        private System.Windows.Forms.ToolStripSeparator TssPpalFiller2;
        private System.Windows.Forms.ToolStripButton TssbPpalSalir;
        private System.Windows.Forms.ToolStripSeparator TssPpalFiller3;
        private System.Windows.Forms.ToolStripSplitButton TssbPpalAdministrar;
        private System.Windows.Forms.ToolStripMenuItem TsmiAdminEmpresas;
        private System.Windows.Forms.ToolStripMenuItem TsmiAdminEmpleados;
        private System.Windows.Forms.ToolStripMenuItem TsmiAdminClientes;
        private System.Windows.Forms.ToolStripMenuItem TsmiAdminFormasPago;
        private System.Windows.Forms.ToolStripSplitButton TssbPpalCaja;
        private System.Windows.Forms.ToolStripMenuItem TsmiCajaIncluirFactura;
        private System.Windows.Forms.ToolStripMenuItem TsmiCajaAbrirCuenta;
        public System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem TsmiAdminMiContrasenia;
        private System.Windows.Forms.ToolStripMenuItem TsmiSunatBancos;
        private System.Windows.Forms.ToolStripSplitButton TssbPpalWindow;
        private System.Windows.Forms.ToolStripMenuItem TsmiWindowCascada;
        private System.Windows.Forms.ToolStripMenuItem TsmiWindowVertical;
        private System.Windows.Forms.ToolStripMenuItem TsmiWindowHorizontal;
        private System.Windows.Forms.ToolStripMenuItem TsmiWindowMinimizarTodas;
        private System.Windows.Forms.ToolStripMenuItem TsmiWindowCierraTodas;
        private System.Windows.Forms.ToolStripSeparator TsmiWindowFiller;
    }
}



