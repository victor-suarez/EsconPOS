﻿namespace EsconPOS.forms
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
            this.TmrHora = new System.Windows.Forms.Timer(this.components);
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbRecentItem2 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonOrbOptionButton2 = new System.Windows.Forms.RibbonOrbOptionButton();
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
            this.TsslStatus.Size = new System.Drawing.Size(894, 17);
            this.TsslStatus.Spring = true;
            this.TsslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TsslCaja
            // 
            this.TsslCaja.Name = "TsslCaja";
            this.TsslCaja.Size = new System.Drawing.Size(0, 17);
            // 
            // TsslEmpleado
            // 
            this.TsslEmpleado.Name = "TsslEmpleado";
            this.TsslEmpleado.Size = new System.Drawing.Size(0, 17);
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
            this.Ribbon.Size = new System.Drawing.Size(948, 120);
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
            // TmrHora
            // 
            this.TmrHora.Interval = 60000;
            this.TmrHora.Tick += new System.EventHandler(this.TmrHora_Tick);
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.LargeImage")));
            this.ribbonOrbMenuItem1.Name = "ribbonOrbMenuItem1";
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "Salir";
            this.ribbonOrbMenuItem1.Click += new System.EventHandler(this.ribbonOrbMenuItem1_Click);
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.LargeImage")));
            this.ribbonOrbMenuItem2.Name = "ribbonOrbMenuItem2";
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "Nose que";
            // 
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.LargeImage")));
            this.ribbonOrbRecentItem1.Name = "ribbonOrbRecentItem1";
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "ribbonOrbRecentItem1";
            // 
            // ribbonOrbRecentItem2
            // 
            this.ribbonOrbRecentItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.Image")));
            this.ribbonOrbRecentItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.LargeImage")));
            this.ribbonOrbRecentItem2.Name = "ribbonOrbRecentItem2";
            this.ribbonOrbRecentItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem2.SmallImage")));
            this.ribbonOrbRecentItem2.Text = "ribbonOrbRecentItem2";
            // 
            // ribbonOrbOptionButton1
            // 
            this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
            this.ribbonOrbOptionButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.LargeImage")));
            this.ribbonOrbOptionButton1.Name = "ribbonOrbOptionButton1";
            this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
            this.ribbonOrbOptionButton1.Text = "ribbonOrbOptionButton1";
            // 
            // ribbonOrbOptionButton2
            // 
            this.ribbonOrbOptionButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.Image")));
            this.ribbonOrbOptionButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.LargeImage")));
            this.ribbonOrbOptionButton2.Name = "ribbonOrbOptionButton2";
            this.ribbonOrbOptionButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.SmallImage")));
            this.ribbonOrbOptionButton2.Text = "ribbonOrbOptionButton2";
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
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIEsconPos_Load);
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
        private System.Windows.Forms.Timer TmrHora;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem2;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton2;
    }
}


