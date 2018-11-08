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
            this.RibTabAdministrar = new System.Windows.Forms.RibbonTab();
            this.RibPanelAcciones = new System.Windows.Forms.RibbonPanel();
            this.RibBtnNuevo = new System.Windows.Forms.RibbonButton();
            this.RibBtnGuardar = new System.Windows.Forms.RibbonButton();
            this.RibBtnEliminar = new System.Windows.Forms.RibbonButton();
            this.RibBtnSalir = new System.Windows.Forms.RibbonButton();
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
            this.RibbonMenu.Tabs.Add(this.RibTabAdministrar);
            this.RibbonMenu.TabsMargin = new System.Windows.Forms.Padding(5, 2, 20, 0);
            this.RibbonMenu.TabSpacing = 4;
            this.RibbonMenu.Text = "Acciones";
            // 
            // RibTabAdministrar
            // 
            this.RibTabAdministrar.Name = "RibTabAdministrar";
            this.RibTabAdministrar.Panels.Add(this.RibPanelAcciones);
            this.RibTabAdministrar.Text = "Administrar";
            // 
            // RibPanelAcciones
            // 
            this.RibPanelAcciones.ButtonMoreVisible = false;
            this.RibPanelAcciones.Items.Add(this.RibBtnNuevo);
            this.RibPanelAcciones.Items.Add(this.RibBtnGuardar);
            this.RibPanelAcciones.Items.Add(this.RibBtnEliminar);
            this.RibPanelAcciones.Items.Add(this.RibBtnSalir);
            this.RibPanelAcciones.Name = "RibPanelAcciones";
            this.RibPanelAcciones.Text = "Acciones";
            // 
            // RibBtnNuevo
            // 
            this.RibBtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("RibBtnNuevo.Image")));
            this.RibBtnNuevo.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibBtnNuevo.LargeImage")));
            this.RibBtnNuevo.Name = "RibBtnNuevo";
            this.RibBtnNuevo.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnNuevo.SmallImage")));
            // 
            // RibBtnGuardar
            // 
            this.RibBtnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("RibBtnGuardar.Image")));
            this.RibBtnGuardar.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibBtnGuardar.LargeImage")));
            this.RibBtnGuardar.Name = "RibBtnGuardar";
            this.RibBtnGuardar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnGuardar.SmallImage")));
            this.RibBtnGuardar.Text = "Guardar";
            // 
            // RibBtnEliminar
            // 
            this.RibBtnEliminar.CheckOnClick = true;
            this.RibBtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("RibBtnEliminar.Image")));
            this.RibBtnEliminar.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibBtnEliminar.LargeImage")));
            this.RibBtnEliminar.Name = "RibBtnEliminar";
            this.RibBtnEliminar.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnEliminar.SmallImage")));
            this.RibBtnEliminar.Text = "Eliminar";
            // 
            // RibBtnSalir
            // 
            this.RibBtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("RibBtnSalir.Image")));
            this.RibBtnSalir.LargeImage = ((System.Drawing.Image)(resources.GetObject("RibBtnSalir.LargeImage")));
            this.RibBtnSalir.Name = "RibBtnSalir";
            this.RibBtnSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("RibBtnSalir.SmallImage")));
            this.RibBtnSalir.Text = "Salir";
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
        private System.Windows.Forms.RibbonTab RibTabAdministrar;
        private System.Windows.Forms.RibbonPanel RibPanelAcciones;
        private System.Windows.Forms.RibbonButton RibBtnNuevo;
        private System.Windows.Forms.RibbonButton RibBtnGuardar;
        private System.Windows.Forms.RibbonButton RibBtnEliminar;
        private System.Windows.Forms.RibbonButton RibBtnSalir;
    }
}