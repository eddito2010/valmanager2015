namespace VALManager2015
{
    partial class Login
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
            this.linkAcceso = new System.Windows.Forms.LinkLabel();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.cmdAcceder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkAcceso);
            this.groupBox1.Controls.Add(this.cmdCerrar);
            this.groupBox1.Controls.Add(this.cmdAcceder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPw);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Location = new System.Drawing.Point(6, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // linkAcceso
            // 
            this.linkAcceso.AutoSize = true;
            this.linkAcceso.Location = new System.Drawing.Point(10, 87);
            this.linkAcceso.Name = "linkAcceso";
            this.linkAcceso.Size = new System.Drawing.Size(88, 13);
            this.linkAcceso.TabIndex = 21;
            this.linkAcceso.TabStop = true;
            this.linkAcceso.Text = "No tengo usuario";
            this.linkAcceso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAcceso_LinkClicked);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCerrar.Location = new System.Drawing.Point(257, 77);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(75, 23);
            this.cmdCerrar.TabIndex = 20;
            this.cmdCerrar.Text = "Cerrar";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // cmdAcceder
            // 
            this.cmdAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAcceder.Location = new System.Drawing.Point(176, 77);
            this.cmdAcceder.Name = "cmdAcceder";
            this.cmdAcceder.Size = new System.Drawing.Size(75, 23);
            this.cmdAcceder.TabIndex = 19;
            this.cmdAcceder.Text = "Acceder";
            this.cmdAcceder.UseVisualStyleBackColor = true;
            this.cmdAcceder.Click += new System.EventHandler(this.cmdAcceder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // txtPw
            // 
            this.txtPw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPw.Location = new System.Drawing.Point(73, 51);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(259, 20);
            this.txtPw.TabIndex = 13;
            this.txtPw.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Location = new System.Drawing.Point(55, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(277, 20);
            this.txtUser.TabIndex = 12;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(361, 126);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al sistema";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Button cmdAcceder;
        private System.Windows.Forms.LinkLabel linkAcceso;
    }
}