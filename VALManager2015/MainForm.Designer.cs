namespace VALManager2015
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonMenu = new System.Windows.Forms.Ribbon();
            this.mnuSalir = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTabVuelos = new System.Windows.Forms.RibbonTab();
            this.ribbonTabAsignaciones = new System.Windows.Forms.RibbonTab();
            this.ribbonTabReportes = new System.Windows.Forms.RibbonTab();
            this.ribbonTabAdmin = new System.Windows.Forms.RibbonTab();
            this.ribbonTabTools = new System.Windows.Forms.RibbonTab();
            this.ribbonTabImportExport = new System.Windows.Forms.RibbonTab();
            this.ribbonTabConfiguracion = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonFs = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.ribbonCBAirLineList = new System.Windows.Forms.RibbonComboBox();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.cmdNewPilot = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBox1 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonComboBox2 = new System.Windows.Forms.RibbonComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblClockLT = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblClockUTC = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ribbonButtonNewAerolinea = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonEditAerolinea = new System.Windows.Forms.RibbonButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ribbonMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMenu.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.Minimized = false;
            this.ribbonMenu.Name = "ribbonMenu";
            // 
            // 
            // 
            this.ribbonMenu.OrbDropDown.BorderRoundness = 8;
            this.ribbonMenu.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMenu.OrbDropDown.MenuItems.Add(this.mnuSalir);
            this.ribbonMenu.OrbDropDown.Name = "";
            this.ribbonMenu.OrbDropDown.Size = new System.Drawing.Size(527, 116);
            this.ribbonMenu.OrbDropDown.TabIndex = 0;
            this.ribbonMenu.OrbImage = null;
            this.ribbonMenu.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbonMenu.OrbText = "Opciones";
            this.ribbonMenu.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMenu.Size = new System.Drawing.Size(906, 173);
            this.ribbonMenu.TabIndex = 0;
            this.ribbonMenu.Tabs.Add(this.ribbonTabVuelos);
            this.ribbonMenu.Tabs.Add(this.ribbonTabAsignaciones);
            this.ribbonMenu.Tabs.Add(this.ribbonTabReportes);
            this.ribbonMenu.Tabs.Add(this.ribbonTabAdmin);
            this.ribbonMenu.Tabs.Add(this.ribbonTabTools);
            this.ribbonMenu.Tabs.Add(this.ribbonTabImportExport);
            this.ribbonMenu.Tabs.Add(this.ribbonTabConfiguracion);
            this.ribbonMenu.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbonMenu.Text = "ribbon1";
            this.ribbonMenu.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // mnuSalir
            // 
            this.mnuSalir.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.mnuSalir.Image = ((System.Drawing.Image)(resources.GetObject("mnuSalir.Image")));
            this.mnuSalir.SmallImage = ((System.Drawing.Image)(resources.GetObject("mnuSalir.SmallImage")));
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // ribbonTabVuelos
            // 
            this.ribbonTabVuelos.Text = "Vuelos";
            this.ribbonTabVuelos.Visible = false;
            // 
            // ribbonTabAsignaciones
            // 
            this.ribbonTabAsignaciones.Text = "Asignaciones";
            this.ribbonTabAsignaciones.Visible = false;
            // 
            // ribbonTabReportes
            // 
            this.ribbonTabReportes.Text = "Reportes";
            this.ribbonTabReportes.Visible = false;
            // 
            // ribbonTabAdmin
            // 
            this.ribbonTabAdmin.Text = "Administración";
            this.ribbonTabAdmin.Visible = false;
            // 
            // ribbonTabTools
            // 
            this.ribbonTabTools.Text = "Herramientas";
            this.ribbonTabTools.Visible = false;
            // 
            // ribbonTabImportExport
            // 
            this.ribbonTabImportExport.Text = "Importar/Exportar";
            this.ribbonTabImportExport.Visible = false;
            // 
            // ribbonTabConfiguracion
            // 
            this.ribbonTabConfiguracion.Panels.Add(this.ribbonPanel1);
            this.ribbonTabConfiguracion.Panels.Add(this.ribbonPanel3);
            this.ribbonTabConfiguracion.Panels.Add(this.ribbonPanel2);
            this.ribbonTabConfiguracion.Text = "Configuración";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.ribbonButtonFs);
            this.ribbonPanel1.Text = "Sistema";
            // 
            // ribbonButtonFs
            // 
            this.ribbonButtonFs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFs.Image")));
            this.ribbonButtonFs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonFs.SmallImage")));
            this.ribbonButtonFs.Text = "Simulador";
            this.ribbonButtonFs.Click += new System.EventHandler(this.ribbonButtonFs_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.ribbonLabel1);
            this.ribbonPanel3.Items.Add(this.ribbonCBAirLineList);
            this.ribbonPanel3.Items.Add(this.ribbonButtonNewAerolinea);
            this.ribbonPanel3.Items.Add(this.ribbonButtonEditAerolinea);
            this.ribbonPanel3.Text = "Aerolíneas";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Text = "Aerolínea";
            // 
            // ribbonCBAirLineList
            // 
            this.ribbonCBAirLineList.AllowTextEdit = false;
            this.ribbonCBAirLineList.Text = "";
            this.ribbonCBAirLineList.TextBoxText = "";
            this.ribbonCBAirLineList.TextBoxWidth = 200;
            this.ribbonCBAirLineList.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonCBAirLineList_DropDownItemClicked);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.cmdNewPilot);
            this.ribbonPanel2.Text = "Usuarios";
            // 
            // cmdNewPilot
            // 
            this.cmdNewPilot.Image = ((System.Drawing.Image)(resources.GetObject("cmdNewPilot.Image")));
            this.cmdNewPilot.SmallImage = ((System.Drawing.Image)(resources.GetObject("cmdNewPilot.SmallImage")));
            this.cmdNewPilot.Text = "Nuevo  Piloto";
            this.cmdNewPilot.Click += new System.EventHandler(this.cmdNewUser_Click);
            // 
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.TextBoxText = "";
            // 
            // ribbonComboBox2
            // 
            this.ribbonComboBox2.TextBoxText = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser,
            this.toolStripStatusLabel3,
            this.lblClockLT,
            this.toolStripStatusLabel2,
            this.lblClockUTC});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(906, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(50, 17);
            this.lblUser.Text = "Usuario:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // lblClockLT
            // 
            this.lblClockLT.Name = "lblClockLT";
            this.lblClockLT.Size = new System.Drawing.Size(49, 17);
            this.lblClockLT.Text = "00:00:00";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // lblClockUTC
            // 
            this.lblClockUTC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lblClockUTC.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblClockUTC.Name = "lblClockUTC";
            this.lblClockUTC.Size = new System.Drawing.Size(49, 17);
            this.lblClockUTC.Text = "00:00:00";
            // 
            // ribbonButtonNewAerolinea
            // 
            this.ribbonButtonNewAerolinea.Enabled = false;
            this.ribbonButtonNewAerolinea.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewAerolinea.Image")));
            this.ribbonButtonNewAerolinea.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNewAerolinea.SmallImage")));
            this.ribbonButtonNewAerolinea.Text = "Nueva Aerolínea";
            this.ribbonButtonNewAerolinea.Click += new System.EventHandler(this.ribbonButtonNewAerolinea_Click);
            // 
            // ribbonButtonEditAerolinea
            // 
            this.ribbonButtonEditAerolinea.Enabled = false;
            this.ribbonButtonEditAerolinea.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonEditAerolinea.Image")));
            this.ribbonButtonEditAerolinea.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonEditAerolinea.SmallImage")));
            this.ribbonButtonEditAerolinea.Text = "Editar Aerolínea";
            this.ribbonButtonEditAerolinea.Click += new System.EventHandler(this.ribbonButtonEditAirline_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(906, 299);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VALManager2015";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbonMenu;
        private System.Windows.Forms.RibbonTab ribbonTabConfiguracion;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonOrbMenuItem mnuSalir;
        private System.Windows.Forms.RibbonButton ribbonButtonFs;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox1;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox2;
        private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.RibbonComboBox ribbonCBAirLineList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblClockLT;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel lblClockUTC;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton cmdNewPilot;
        private System.Windows.Forms.RibbonTab ribbonTabAsignaciones;
        private System.Windows.Forms.RibbonTab ribbonTabReportes;
        private System.Windows.Forms.RibbonTab ribbonTabAdmin;
        private System.Windows.Forms.RibbonTab ribbonTabTools;
        private System.Windows.Forms.RibbonTab ribbonTabImportExport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RibbonTab ribbonTabVuelos;
        private System.Windows.Forms.RibbonButton ribbonButtonNewAerolinea;
        private System.Windows.Forms.RibbonButton ribbonButtonEditAerolinea;


    }
}

