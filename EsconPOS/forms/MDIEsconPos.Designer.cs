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
            this.TsslCaja = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslEmpleado = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.TsslHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Ribbon = new System.Windows.Forms.Ribbon();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.RibTabInicio = new System.Windows.Forms.RibbonTab();
            this.RibPnlAcciones = new System.Windows.Forms.RibbonPanel();
            this.RibBtnAbrirCaja = new System.Windows.Forms.RibbonButton();
            this.RibBtnEmpresas = new System.Windows.Forms.RibbonButton();
            this.RibBtnEmpleados = new System.Windows.Forms.RibbonButton();
            this.RibBtnClientes = new System.Windows.Forms.RibbonButton();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsslStatus,
            this.TsslCaja,
            this.TsslEmpleado,
            this.TsslFecha,
            this.TsslHora});
            this.statusStrip.Location = new System.Drawing.Point(0, 382);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip.Size = new System.Drawing.Size(948, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // TsslStatus
            // 
            this.TsslStatus.Name = "TsslStatus";
            this.TsslStatus.Size = new System.Drawing.Size(383, 21);
            this.TsslStatus.Spring = true;
            this.TsslStatus.Text = "Status";
            this.TsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TsslCaja
            // 
            this.TsslCaja.Name = "TsslCaja";
            this.TsslCaja.Size = new System.Drawing.Size(62, 21);
            this.TsslCaja.Text = "Caja #1";
            // 
            // TsslEmpleado
            // 
            this.TsslEmpleado.Name = "TsslEmpleado";
            this.TsslEmpleado.Size = new System.Drawing.Size(173, 21);
            this.TsslEmpleado.Text = "Nombres del empleado";
            // 
            // TsslFecha
            // 
            this.TsslFecha.Name = "TsslFecha";
            this.TsslFecha.Size = new System.Drawing.Size(226, 21);
            this.TsslFecha.Text = "Sábado, 27 de octubre de 2018";
            // 
            // TsslHora
            // 
            this.TsslHora.Name = "TsslHora";
            this.TsslHora.Size = new System.Drawing.Size(81, 21);
            this.TsslHora.Text = "10:36 a.m.";
            // 
            // Ribbon
            // 
            this.Ribbon.CaptionBarVisible = false;
            this.Ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.Minimized = false;
            this.Ribbon.Name = "Ribbon";
            // 
            // 
            // 
            this.Ribbon.OrbDropDown.BorderRoundness = 8;
            this.Ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.OrbDropDown.Name = "";
            this.Ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.Ribbon.OrbDropDown.TabIndex = 0;
            this.Ribbon.OrbDropDown.Visible = false;
            this.Ribbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            // 
            // 
            // 
            this.Ribbon.QuickAccessToolbar.Items.Add(this.ribbonButton1);
            this.Ribbon.QuickAccessToolbar.Items.Add(this.ribbonButton2);
            this.Ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.Ribbon.Size = new System.Drawing.Size(948, 131);
            this.Ribbon.TabIndex = 4;
            this.Ribbon.Tabs.Add(this.RibTabInicio);
            this.Ribbon.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.Ribbon.TabSpacing = 4;
            this.Ribbon.Text = "Herramientas";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // RibTabInicio
            // 
            this.RibTabInicio.Name = "RibTabInicio";
            this.RibTabInicio.Panels.Add(this.RibPnlAcciones);
            this.RibTabInicio.Text = "Inicio";
            // 
            // RibPnlAcciones
            // 
            this.RibPnlAcciones.ButtonMoreEnabled = false;
            this.RibPnlAcciones.Items.Add(this.RibBtnAbrirCaja);
            this.RibPnlAcciones.Items.Add(this.RibBtnEmpresas);
            this.RibPnlAcciones.Items.Add(this.RibBtnEmpleados);
            this.RibPnlAcciones.Items.Add(this.RibBtnClientes);
            this.RibPnlAcciones.Name = "RibPnlAcciones";
            this.RibPnlAcciones.Text = "Acciones";
            // 
            // RibBtnAbrirCaja
            // 
            this.RibBtnAbrirCaja.CheckOnClick = true;
            this.RibBtnAbrirCaja.Image = global::EsconPOS.Properties.Resources.CajaCerrada;
            this.RibBtnAbrirCaja.LargeImage = global::EsconPOS.Properties.Resources.CajaCerrada;
            this.RibBtnAbrirCaja.Name = "RibBtnAbrirCaja";
            this.RibBtnAbrirCaja.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnAbrirCaja.SmallImage")));
            this.RibBtnAbrirCaja.Text = "Abrir Caja";
            // 
            // RibBtnEmpresas
            // 
            this.RibBtnEmpresas.Image = global::EsconPOS.Properties.Resources.Empresas;
            this.RibBtnEmpresas.LargeImage = global::EsconPOS.Properties.Resources.Empresas;
            this.RibBtnEmpresas.Name = "RibBtnEmpresas";
            this.RibBtnEmpresas.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnEmpresas.SmallImage")));
            this.RibBtnEmpresas.Text = "Empresas";
            // 
            // RibBtnEmpleados
            // 
            this.RibBtnEmpleados.Image = global::EsconPOS.Properties.Resources.Empleados;
            this.RibBtnEmpleados.LargeImage = global::EsconPOS.Properties.Resources.Empleados;
            this.RibBtnEmpleados.Name = "RibBtnEmpleados";
            this.RibBtnEmpleados.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnEmpleados.SmallImage")));
            this.RibBtnEmpleados.Text = "Empleados";
            // 
            // RibBtnClientes
            // 
            this.RibBtnClientes.Image = global::EsconPOS.Properties.Resources.Clientes;
            this.RibBtnClientes.LargeImage = global::EsconPOS.Properties.Resources.Clientes;
            this.RibBtnClientes.Name = "RibBtnClientes";
            this.RibBtnClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnClientes.SmallImage")));
            this.RibBtnClientes.Text = "Clientes";
            // 
            // MDIEsconPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 408);
            this.Controls.Add(this.Ribbon);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIEsconPos";
            this.Text = "EsconPOS";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private System.Windows.Forms.Ribbon Ribbon;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonTab RibTabInicio;
        private System.Windows.Forms.RibbonPanel RibPnlAcciones;
        private System.Windows.Forms.RibbonButton RibBtnAbrirCaja;
        private System.Windows.Forms.RibbonButton RibBtnEmpresas;
        private System.Windows.Forms.RibbonButton RibBtnEmpleados;
        private System.Windows.Forms.RibbonButton RibBtnClientes;
    }
}



