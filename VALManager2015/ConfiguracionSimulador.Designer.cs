namespace VALManager2015
{
    partial class ConfiguracionSimulador
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
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFsPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFSUIPC = new System.Windows.Forms.RadioButton();
            this.rbSimConnect = new System.Windows.Forms.RadioButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdGetFolder = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFSX = new System.Windows.Forms.RadioButton();
            this.rbFS2004 = new System.Windows.Forms.RadioButton();
            this.rbP3D = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(362, 170);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 0;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Location = new System.Drawing.Point(281, 170);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 1;
            this.cmdSave.Text = "Salvar";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Camino del Simulador";
            // 
            // txtFsPath
            // 
            this.txtFsPath.Location = new System.Drawing.Point(120, 25);
            this.txtFsPath.Name = "txtFsPath";
            this.txtFsPath.Size = new System.Drawing.Size(264, 20);
            this.txtFsPath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cmdGetFolder);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtFsPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 146);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSimConnect);
            this.groupBox2.Controls.Add(this.rbFSUIPC);
            this.groupBox2.Location = new System.Drawing.Point(215, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Módulo a través del cual conectarse";
            // 
            // rbFSUIPC
            // 
            this.rbFSUIPC.AutoSize = true;
            this.rbFSUIPC.Checked = true;
            this.rbFSUIPC.Location = new System.Drawing.Point(20, 22);
            this.rbFSUIPC.Name = "rbFSUIPC";
            this.rbFSUIPC.Size = new System.Drawing.Size(63, 17);
            this.rbFSUIPC.TabIndex = 0;
            this.rbFSUIPC.TabStop = true;
            this.rbFSUIPC.Text = "FSUIPC";
            this.rbFSUIPC.UseVisualStyleBackColor = true;
            this.rbFSUIPC.CheckedChanged += new System.EventHandler(this.rbFSUIPC_CheckedChanged);
            // 
            // rbSimConnect
            // 
            this.rbSimConnect.AutoSize = true;
            this.rbSimConnect.Location = new System.Drawing.Point(20, 45);
            this.rbSimConnect.Name = "rbSimConnect";
            this.rbSimConnect.Size = new System.Drawing.Size(82, 17);
            this.rbSimConnect.TabIndex = 1;
            this.rbSimConnect.Text = "SimConnect";
            this.rbSimConnect.UseVisualStyleBackColor = true;
            // 
            // cmdGetFolder
            // 
            this.cmdGetFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGetFolder.Location = new System.Drawing.Point(386, 24);
            this.cmdGetFolder.Name = "cmdGetFolder";
            this.cmdGetFolder.Size = new System.Drawing.Size(25, 23);
            this.cmdGetFolder.TabIndex = 5;
            this.cmdGetFolder.Text = "...";
            this.cmdGetFolder.UseVisualStyleBackColor = true;
            this.cmdGetFolder.Click += new System.EventHandler(this.cmdGetFolder_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbP3D);
            this.groupBox3.Controls.Add(this.rbFSX);
            this.groupBox3.Controls.Add(this.rbFS2004);
            this.groupBox3.Location = new System.Drawing.Point(9, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 74);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Versión del Simulador";
            // 
            // rbFSX
            // 
            this.rbFSX.AutoSize = true;
            this.rbFSX.Location = new System.Drawing.Point(20, 34);
            this.rbFSX.Name = "rbFSX";
            this.rbFSX.Size = new System.Drawing.Size(45, 17);
            this.rbFSX.TabIndex = 1;
            this.rbFSX.Text = "FSX";
            this.rbFSX.UseVisualStyleBackColor = true;
            // 
            // rbFS2004
            // 
            this.rbFS2004.AutoSize = true;
            this.rbFS2004.Checked = true;
            this.rbFS2004.Location = new System.Drawing.Point(20, 17);
            this.rbFS2004.Name = "rbFS2004";
            this.rbFS2004.Size = new System.Drawing.Size(62, 17);
            this.rbFS2004.TabIndex = 0;
            this.rbFS2004.TabStop = true;
            this.rbFS2004.Text = "FS2004";
            this.rbFS2004.UseVisualStyleBackColor = true;
            // 
            // rbP3D
            // 
            this.rbP3D.AutoSize = true;
            this.rbP3D.Location = new System.Drawing.Point(20, 51);
            this.rbP3D.Name = "rbP3D";
            this.rbP3D.Size = new System.Drawing.Size(46, 17);
            this.rbP3D.TabIndex = 2;
            this.rbP3D.Text = "P3D";
            this.rbP3D.UseVisualStyleBackColor = true;
            // 
            // ConfiguracionSimulador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(449, 200);
            this.ControlBox = false;
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfiguracionSimulador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración del Simulador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFsPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSimConnect;
        private System.Windows.Forms.RadioButton rbFSUIPC;
        private System.Windows.Forms.Button cmdGetFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbP3D;
        private System.Windows.Forms.RadioButton rbFSX;
        private System.Windows.Forms.RadioButton rbFS2004;
    }
}