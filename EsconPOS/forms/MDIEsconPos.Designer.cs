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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.TsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslCaja = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.TssbCaja = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiIncluirFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiAbrirCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.TssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TssbAdministrar = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiEmpresas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFormasPago = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiMiContrasenia = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbUbicacion = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiPaises = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDepartamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDistritos = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbSunat = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiImpuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiMonedas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiTiposDocumentos = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiUnidadesMedida = new System.Windows.Forms.ToolStripMenuItem();
            this.TssbProductos = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmiMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClases = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiProductosServicios = new System.Windows.Forms.ToolStripMenuItem();
            this.TssSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TssbSalir = new System.Windows.Forms.ToolStripButton();
            this.TssSeparator3 = new System.Windows.Forms.ToolStripSeparator();
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
            this.TssbCaja,
            this.TssSeparator1,
            this.TssbAdministrar,
            this.TssbUbicacion,
            this.TssbSunat,
            this.TssbProductos,
            this.TssSeparator2,
            this.TssbSalir,
            this.TssSeparator3});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(948, 54);
            this.toolStrip.TabIndex = 4;
            // 
            // TssbCaja
            // 
            this.TssbCaja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiIncluirFactura,
            this.TsmiAbrirCuenta});
            this.TssbCaja.Image = global::EsconPOS.Properties.Resources.CajaCerrada;
            this.TssbCaja.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TssbCaja.Name = "TssbCaja";
            this.TssbCaja.Size = new System.Drawing.Size(75, 51);
            this.TssbCaja.Text = "Abrir &Caja";
            this.TssbCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbCaja.Visible = false;
            this.TssbCaja.ButtonClick += new System.EventHandler(this.TssbCaja_ButtonClick);
            // 
            // TsmiIncluirFactura
            // 
            this.TsmiIncluirFactura.Name = "TsmiIncluirFactura";
            this.TsmiIncluirFactura.Size = new System.Drawing.Size(149, 22);
            this.TsmiIncluirFactura.Text = "Incluir &Factura";
            this.TsmiIncluirFactura.Visible = false;
            this.TsmiIncluirFactura.Click += new System.EventHandler(this.TsmiIncluirFactura_Click);
            // 
            // TsmiAbrirCuenta
            // 
            this.TsmiAbrirCuenta.Name = "TsmiAbrirCuenta";
            this.TsmiAbrirCuenta.Size = new System.Drawing.Size(149, 22);
            this.TsmiAbrirCuenta.Text = "Abrir &Cuenta";
            this.TsmiAbrirCuenta.Visible = false;
            // 
            // TssSeparator1
            // 
            this.TssSeparator1.Name = "TssSeparator1";
            this.TssSeparator1.Size = new System.Drawing.Size(6, 54);
            // 
            // TssbAdministrar
            // 
            this.TssbAdministrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiEmpresas,
            this.TsmiEmpleados,
            this.TsmiClientes,
            this.TsmiFormasPago,
            this.TsmiMiContrasenia});
            this.TssbAdministrar.Image = global::EsconPOS.Properties.Resources.Administrar;
            this.TssbAdministrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbAdministrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TssbAdministrar.Name = "TssbAdministrar";
            this.TssbAdministrar.Size = new System.Drawing.Size(85, 51);
            this.TssbAdministrar.Text = "&Administrar";
            this.TssbAdministrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbAdministrar.Visible = false;
            // 
            // TsmiEmpresas
            // 
            this.TsmiEmpresas.Image = global::EsconPOS.Properties.Resources.Empresas;
            this.TsmiEmpresas.Name = "TsmiEmpresas";
            this.TsmiEmpresas.Size = new System.Drawing.Size(159, 22);
            this.TsmiEmpresas.Text = "&Empresas";
            this.TsmiEmpresas.Click += new System.EventHandler(this.TsmiEmpresas_Click);
            // 
            // TsmiEmpleados
            // 
            this.TsmiEmpleados.Image = global::EsconPOS.Properties.Resources.Empleados;
            this.TsmiEmpleados.Name = "TsmiEmpleados";
            this.TsmiEmpleados.Size = new System.Drawing.Size(159, 22);
            this.TsmiEmpleados.Text = "E&mpleados";
            this.TsmiEmpleados.Click += new System.EventHandler(this.TsmiEmpleados_Click);
            // 
            // TsmiClientes
            // 
            this.TsmiClientes.Image = global::EsconPOS.Properties.Resources.Clientes;
            this.TsmiClientes.Name = "TsmiClientes";
            this.TsmiClientes.Size = new System.Drawing.Size(159, 22);
            this.TsmiClientes.Text = "&Clientes";
            this.TsmiClientes.Click += new System.EventHandler(this.TsmiClientes_Click);
            // 
            // TsmiFormasPago
            // 
            this.TsmiFormasPago.Image = global::EsconPOS.Properties.Resources.FormasPagos;
            this.TsmiFormasPago.Name = "TsmiFormasPago";
            this.TsmiFormasPago.Size = new System.Drawing.Size(159, 22);
            this.TsmiFormasPago.Text = "&Formas de pago";
            this.TsmiFormasPago.Click += new System.EventHandler(this.TsmiFormasPago_Click);
            // 
            // TsmiMiContrasenia
            // 
            this.TsmiMiContrasenia.Image = global::EsconPOS.Properties.Resources.Contraseña1;
            this.TsmiMiContrasenia.Name = "TsmiMiContrasenia";
            this.TsmiMiContrasenia.Size = new System.Drawing.Size(159, 22);
            this.TsmiMiContrasenia.Text = "M&i contraseña";
            this.TsmiMiContrasenia.Click += new System.EventHandler(this.TsmiMiContrasenia_Click);
            // 
            // TssbUbicacion
            // 
            this.TssbUbicacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiPaises,
            this.TsmiDepartamentos,
            this.TsmiProvincias,
            this.TsmiDistritos});
            this.TssbUbicacion.Image = global::EsconPOS.Properties.Resources.Ubigeo;
            this.TssbUbicacion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbUbicacion.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbUbicacion.Name = "TssbUbicacion";
            this.TssbUbicacion.Size = new System.Drawing.Size(76, 51);
            this.TssbUbicacion.Text = "&Ubicación";
            this.TssbUbicacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbUbicacion.Visible = false;
            // 
            // TsmiPaises
            // 
            this.TsmiPaises.Image = global::EsconPOS.Properties.Resources.Paises;
            this.TsmiPaises.Name = "TsmiPaises";
            this.TsmiPaises.Size = new System.Drawing.Size(155, 22);
            this.TsmiPaises.Text = "&Paises";
            // 
            // TsmiDepartamentos
            // 
            this.TsmiDepartamentos.Image = global::EsconPOS.Properties.Resources.Departamentos;
            this.TsmiDepartamentos.Name = "TsmiDepartamentos";
            this.TsmiDepartamentos.Size = new System.Drawing.Size(155, 22);
            this.TsmiDepartamentos.Text = "&Departamentos";
            // 
            // TsmiProvincias
            // 
            this.TsmiProvincias.Image = global::EsconPOS.Properties.Resources.Provincias;
            this.TsmiProvincias.Name = "TsmiProvincias";
            this.TsmiProvincias.Size = new System.Drawing.Size(155, 22);
            this.TsmiProvincias.Text = "P&rovincias";
            // 
            // TsmiDistritos
            // 
            this.TsmiDistritos.Image = global::EsconPOS.Properties.Resources.Ubicacion;
            this.TsmiDistritos.Name = "TsmiDistritos";
            this.TsmiDistritos.Size = new System.Drawing.Size(155, 22);
            this.TsmiDistritos.Text = "D&istritos";
            // 
            // TssbSunat
            // 
            this.TssbSunat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiImpuestos,
            this.TsmiMonedas,
            this.TsmiTiposDocumentos,
            this.TsmiUnidadesMedida});
            this.TssbSunat.Image = global::EsconPOS.Properties.Resources.SUNAT;
            this.TssbSunat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbSunat.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbSunat.Name = "TssbSunat";
            this.TssbSunat.Size = new System.Drawing.Size(60, 51);
            this.TssbSunat.Text = "SU&NAT";
            this.TssbSunat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbSunat.Visible = false;
            // 
            // TsmiImpuestos
            // 
            this.TsmiImpuestos.Image = global::EsconPOS.Properties.Resources.Impuestos;
            this.TsmiImpuestos.Name = "TsmiImpuestos";
            this.TsmiImpuestos.Size = new System.Drawing.Size(189, 22);
            this.TsmiImpuestos.Text = "&Impuestos";
            // 
            // TsmiMonedas
            // 
            this.TsmiMonedas.Image = global::EsconPOS.Properties.Resources.Monedas;
            this.TsmiMonedas.Name = "TsmiMonedas";
            this.TsmiMonedas.Size = new System.Drawing.Size(189, 22);
            this.TsmiMonedas.Text = "&Monedas";
            this.TsmiMonedas.Click += new System.EventHandler(this.TsmiMonedas_Click);
            // 
            // TsmiTiposDocumentos
            // 
            this.TsmiTiposDocumentos.Name = "TsmiTiposDocumentos";
            this.TsmiTiposDocumentos.Size = new System.Drawing.Size(189, 22);
            this.TsmiTiposDocumentos.Text = "&Tipos de documentos";
            // 
            // TsmiUnidadesMedida
            // 
            this.TsmiUnidadesMedida.Image = global::EsconPOS.Properties.Resources.Unidades;
            this.TsmiUnidadesMedida.Name = "TsmiUnidadesMedida";
            this.TsmiUnidadesMedida.Size = new System.Drawing.Size(189, 22);
            this.TsmiUnidadesMedida.Text = "&Unidades de medida";
            this.TsmiUnidadesMedida.Click += new System.EventHandler(this.TsmiUnidadesMedida_Click);
            // 
            // TssbProductos
            // 
            this.TssbProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiMarcas,
            this.TsmiClases,
            this.TsmiProductosServicios});
            this.TssbProductos.Image = global::EsconPOS.Properties.Resources.Productos;
            this.TssbProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbProductos.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbProductos.Name = "TssbProductos";
            this.TssbProductos.Size = new System.Drawing.Size(85, 51);
            this.TssbProductos.Text = "&Prods/Servs";
            this.TssbProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbProductos.Visible = false;
            // 
            // TsmiMarcas
            // 
            this.TsmiMarcas.Name = "TsmiMarcas";
            this.TsmiMarcas.Size = new System.Drawing.Size(179, 22);
            this.TsmiMarcas.Text = "&Marcas";
            this.TsmiMarcas.Click += new System.EventHandler(this.TsmiMarcas_Click);
            // 
            // TsmiClases
            // 
            this.TsmiClases.Name = "TsmiClases";
            this.TsmiClases.Size = new System.Drawing.Size(179, 22);
            this.TsmiClases.Text = "&Clases";
            this.TsmiClases.Click += new System.EventHandler(this.TsmiClases_Click);
            // 
            // TsmiProductosServicios
            // 
            this.TsmiProductosServicios.Name = "TsmiProductosServicios";
            this.TsmiProductosServicios.Size = new System.Drawing.Size(179, 22);
            this.TsmiProductosServicios.Text = "&Productos/Servicios";
            this.TsmiProductosServicios.Click += new System.EventHandler(this.TsmiProductosServicios_Click);
            // 
            // TssSeparator2
            // 
            this.TssSeparator2.Name = "TssSeparator2";
            this.TssSeparator2.Size = new System.Drawing.Size(6, 54);
            // 
            // TssbSalir
            // 
            this.TssbSalir.Image = global::EsconPOS.Properties.Resources.Logout;
            this.TssbSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TssbSalir.ImageTransparentColor = System.Drawing.Color.White;
            this.TssbSalir.Name = "TssbSalir";
            this.TssbSalir.Size = new System.Drawing.Size(36, 51);
            this.TssbSalir.Text = "&Salir";
            this.TssbSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TssbSalir.Click += new System.EventHandler(this.TssbSalir_Click);
            // 
            // TssSeparator3
            // 
            this.TssSeparator3.Name = "TssSeparator3";
            this.TssSeparator3.Size = new System.Drawing.Size(6, 54);
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
        private System.Windows.Forms.ToolStripSplitButton TssbUbicacion;
        private System.Windows.Forms.ToolStripMenuItem TsmiPaises;
        private System.Windows.Forms.ToolStripMenuItem TsmiDepartamentos;
        private System.Windows.Forms.ToolStripMenuItem TsmiProvincias;
        private System.Windows.Forms.ToolStripMenuItem TsmiDistritos;
        private System.Windows.Forms.ToolStripSplitButton TssbSunat;
        private System.Windows.Forms.ToolStripMenuItem TsmiImpuestos;
        private System.Windows.Forms.ToolStripMenuItem TsmiMonedas;
        private System.Windows.Forms.ToolStripMenuItem TsmiTiposDocumentos;
        private System.Windows.Forms.ToolStripMenuItem TsmiUnidadesMedida;
        private System.Windows.Forms.ToolStripSplitButton TssbProductos;
        private System.Windows.Forms.ToolStripMenuItem TsmiMarcas;
        private System.Windows.Forms.ToolStripMenuItem TsmiClases;
        private System.Windows.Forms.ToolStripMenuItem TsmiProductosServicios;
        private System.Windows.Forms.ToolStripSeparator TssSeparator1;
        private System.Windows.Forms.ToolStripSeparator TssSeparator2;
        private System.Windows.Forms.ToolStripButton TssbSalir;
        private System.Windows.Forms.ToolStripSeparator TssSeparator3;
        private System.Windows.Forms.ToolStripSplitButton TssbAdministrar;
        private System.Windows.Forms.ToolStripMenuItem TsmiEmpresas;
        private System.Windows.Forms.ToolStripMenuItem TsmiEmpleados;
        private System.Windows.Forms.ToolStripMenuItem TsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem TsmiFormasPago;
        private System.Windows.Forms.ToolStripSplitButton TssbCaja;
        private System.Windows.Forms.ToolStripMenuItem TsmiIncluirFactura;
        private System.Windows.Forms.ToolStripMenuItem TsmiAbrirCuenta;
        public System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripMenuItem TsmiMiContrasenia;
    }
}



