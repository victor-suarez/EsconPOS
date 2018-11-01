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
            this.RibButNuevo = new System.Windows.Forms.RibbonButton();
            this.RibButGuardar = new System.Windows.Forms.RibbonButton();
            this.RibButEliminar = new System.Windows.Forms.RibbonButton();
            this.RibButSalir = new System.Windows.Forms.RibbonButton();
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
            this.RibbonMenu.Size = new System.Drawing.Size(508, 110);
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
            this.RibTab.Text = "Administrar";
            // 
            // RibPanel
            // 
            this.RibPanel.ButtonMoreVisible = false;
            this.RibPanel.Items.Add(this.RibButNuevo);
            this.RibPanel.Items.Add(this.RibButGuardar);
            this.RibPanel.Items.Add(this.RibButEliminar);
            this.RibPanel.Items.Add(this.RibButSalir);
            this.RibPanel.Name = "RibPanel";
            this.RibPanel.Text = "Acciones";
            // 
            // RibButNuevo
            // 
            this.RibButNuevo.Image = ((System.Drawing.Image)(resources.GetObject("RibButNuevo.Image")));
            this.RibButNuevo.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButNuevo.LargeImage")));
            this.RibButNuevo.Name = "RibButNuevo";
            this.RibButNuevo.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButNuevo.SmallImage")));
            // 
            // RibButGuardar
            // 
            this.RibButGuardar.Image = ((System.Drawing.Image)(resources.GetObject("RibButGuardar.Image")));
            this.RibButGuardar.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButGuardar.LargeImage")));
            this.RibButGuardar.Name = "RibButGuardar";
            this.RibButGuardar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButGuardar.SmallImage")));
            // 
            // RibButEliminar
            // 
            this.RibButEliminar.CheckOnClick = true;
            this.RibButEliminar.Image = ((System.Drawing.Image)(resources.GetObject("RibButEliminar.Image")));
            this.RibButEliminar.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButEliminar.LargeImage")));
            this.RibButEliminar.Name = "RibButEliminar";
            this.RibButEliminar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButEliminar.SmallImage")));
            // 
            // RibButSalir
            // 
            this.RibButSalir.Image = ((System.Drawing.Image)(resources.GetObject("RibButSalir.Image")));
            this.RibButSalir.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibButSalir.LargeImage")));
            this.RibButSalir.Name = "RibButSalir";
            this.RibButSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibButSalir.SmallImage")));
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 523);
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
        private System.Windows.Forms.RibbonButton RibButNuevo;
        private System.Windows.Forms.RibbonButton RibButGuardar;
        private System.Windows.Forms.RibbonButton RibButEliminar;
        private System.Windows.Forms.RibbonButton RibButSalir;
    }
}