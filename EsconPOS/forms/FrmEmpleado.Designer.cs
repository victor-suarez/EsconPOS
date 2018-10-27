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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpleado));
            this.RibbonMenu = new System.Windows.Forms.Ribbon();
            this.RibTab = new System.Windows.Forms.RibbonTab();
            this.RibPanel = new System.Windows.Forms.RibbonPanel();
            this.RibButAbrirCaja = new System.Windows.Forms.RibbonButton();
            this.RibButAgregarCliente = new System.Windows.Forms.RibbonButton();
            this.RibButAgregarEmpresa = new System.Windows.Forms.RibbonButton();
            this.RibButCrearCaja = new System.Windows.Forms.RibbonButton();
            this.RibButCrearUsuario = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // RibbonMenu
            // 
            this.RibbonMenu.CaptionBarVisible = false;
            this.RibbonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RibbonMenu.Location = new System.Drawing.Point(0, 0);
            this.RibbonMenu.Minimized = false;
            this.RibbonMenu.Name = "RibbonMenu";
            // 
            // 
            // 
            this.RibbonMenu.OrbDropDown.BorderRoundness = 8;
            this.RibbonMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.RibbonMenu.OrbDropDown.Name = "";
            this.RibbonMenu.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.RibbonMenu.OrbDropDown.TabIndex = 0;
            this.RibbonMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.RibbonMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.RibbonMenu.Size = new System.Drawing.Size(960, 110);
            this.RibbonMenu.TabIndex = 0;
            this.RibbonMenu.Tabs.Add(this.RibTab);
            this.RibbonMenu.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.RibbonMenu.TabSpacing = 4;
            this.RibbonMenu.Text = "Acciones";
            // 
            // RibTab
            // 
            this.RibTab.Name = "RibTab";
            this.RibTab.Panels.Add(this.RibPanel);
            this.RibTab.Text = "ribbonTab1";
            // 
            // RibPanel
            // 
            this.RibPanel.Items.Add(this.RibButCrearUsuario);
            this.RibPanel.Items.Add(this.RibButCrearCaja);
            this.RibPanel.Items.Add(this.RibButAbrirCaja);
            this.RibPanel.Items.Add(this.RibButAgregarCliente);
            this.RibPanel.Items.Add(this.RibButAgregarEmpresa);
            this.RibPanel.Name = "RibPanel";
            this.RibPanel.Text = "Acciones";
            // 
            // RibButAbrirCaja
            // 
            this.RibButAbrirCaja.CheckOnClick = true;
            this.RibButAbrirCaja.Image = ((System.Drawing.Image)(resources.GetObject("RibButAbrirCaja.Image")));
            this.RibButAbrirCaja.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButAbrirCaja.LargeImage")));
            this.RibButAbrirCaja.Name = "RibButAbrirCaja";
            this.RibButAbrirCaja.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButAbrirCaja.SmallImage")));
            // 
            // RibButAgregarCliente
            // 
            this.RibButAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("RibButAgregarCliente.Image")));
            this.RibButAgregarCliente.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButAgregarCliente.LargeImage")));
            this.RibButAgregarCliente.Name = "RibButAgregarCliente";
            this.RibButAgregarCliente.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButAgregarCliente.SmallImage")));
            // 
            // RibButAgregarEmpresa
            // 
            this.RibButAgregarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("RibButAgregarEmpresa.Image")));
            this.RibButAgregarEmpresa.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButAgregarEmpresa.LargeImage")));
            this.RibButAgregarEmpresa.Name = "RibButAgregarEmpresa";
            this.RibButAgregarEmpresa.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButAgregarEmpresa.SmallImage")));
            // 
            // RibButCrearCaja
            // 
            this.RibButCrearCaja.Image = ((System.Drawing.Image)(resources.GetObject("RibButCrearCaja.Image")));
            this.RibButCrearCaja.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButCrearCaja.LargeImage")));
            this.RibButCrearCaja.Name = "RibButCrearCaja";
            this.RibButCrearCaja.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButCrearCaja.SmallImage")));
            // 
            // RibButCrearUsuario
            // 
            this.RibButCrearUsuario.Image = ((System.Drawing.Image)(resources.GetObject("RibButCrearUsuario.Image")));
            this.RibButCrearUsuario.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButCrearUsuario.LargeImage")));
            this.RibButCrearUsuario.Name = "RibButCrearUsuario";
            this.RibButCrearUsuario.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButCrearUsuario.SmallImage")));
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 523);
            this.Controls.Add(this.RibbonMenu);
            this.KeyPreview = true;
            this.Name = "FrmEmpleado";
            this.Text = "Administrar empleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon RibbonMenu;
        private System.Windows.Forms.RibbonTab RibTab;
        private System.Windows.Forms.RibbonPanel RibPanel;
        private System.Windows.Forms.RibbonButton RibButCrearUsuario;
        private System.Windows.Forms.RibbonButton RibButCrearCaja;
        private System.Windows.Forms.RibbonButton RibButAbrirCaja;
        private System.Windows.Forms.RibbonButton RibButAgregarCliente;
        private System.Windows.Forms.RibbonButton RibButAgregarEmpresa;
    }
}