namespace VALManager2015
{
    partial class NewAirline
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFallo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdGetFolder = new System.Windows.Forms.Button();
            this.txtLogoPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCallSign = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInitialMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtInitialMoney);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFallo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmdGetFolder);
            this.groupBox1.Controls.Add(this.txtLogoPath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCallSign);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 155);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Aerolínea";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "%";
            // 
            // txtFallo
            // 
            this.txtFallo.Location = new System.Drawing.Point(129, 112);
            this.txtFallo.Name = "txtFallo";
            this.txtFallo.Size = new System.Drawing.Size(34, 20);
            this.txtFallo.TabIndex = 12;
            this.txtFallo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Probabilidad de fallos:";
            // 
            // cmdGetFolder
            // 
            this.cmdGetFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGetFolder.Location = new System.Drawing.Point(354, 80);
            this.cmdGetFolder.Name = "cmdGetFolder";
            this.cmdGetFolder.Size = new System.Drawing.Size(25, 23);
            this.cmdGetFolder.TabIndex = 10;
            this.cmdGetFolder.Text = "...";
            this.cmdGetFolder.UseVisualStyleBackColor = true;
            this.cmdGetFolder.Click += new System.EventHandler(this.cmdGetFolder_Click);
            // 
            // txtLogoPath
            // 
            this.txtLogoPath.Location = new System.Drawing.Point(72, 82);
            this.txtLogoPath.Name = "txtLogoPath";
            this.txtLogoPath.Size = new System.Drawing.Size(276, 20);
            this.txtLogoPath.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Logo:";
            // 
            // txtCallSign
            // 
            this.txtCallSign.Location = new System.Drawing.Point(239, 53);
            this.txtCallSign.Name = "txtCallSign";
            this.txtCallSign.Size = new System.Drawing.Size(140, 20);
            this.txtCallSign.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Callsign:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(72, 53);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(96, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(307, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // cmdSave
            // 
            this.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSave.Location = new System.Drawing.Point(254, 185);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 3;
            this.cmdSave.Text = "Salvar";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdClose.Location = new System.Drawing.Point(335, 185);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 2;
            this.cmdClose.Text = "Cerrar";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "USD";
            // 
            // txtInitialMoney
            // 
            this.txtInitialMoney.Location = new System.Drawing.Point(259, 112);
            this.txtInitialMoney.Name = "txtInitialMoney";
            this.txtInitialMoney.Size = new System.Drawing.Size(89, 20);
            this.txtInitialMoney.TabIndex = 15;
            this.txtInitialMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Capital Inicial:";
            // 
            // NewAirline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 220);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAirline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Aerolínea";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLogoPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCallSign;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGetFolder;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFallo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInitialMoney;
        private System.Windows.Forms.Label label8;
    }
}