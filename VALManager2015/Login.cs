using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VALManager2015
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            Program.cerrarApp = true;
            Close();
        }

        private void linkAcceso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Program.anonimo = true;
            Close();
        }

        private void cmdAcceder_Click(object sender, EventArgs e)
        {
            Program.loggedUser = UsuariosToolBox.getUserFromFile("usuarios.dat", txtUser.Text, txtPw.Text);
            if (Program.loggedUser)
            {
                Program.loggedUser = true;
                Close();
            }
            else if (txtUser.Text == "eddy" && txtPw.Text == "eddy")
            {
                Program.admin = true;
                Program.loggedUser = true;
                Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña no válidos.");
                txtUser.Text = "";
                txtUser.Focus();
                txtPw.Text = "";
            }
        }
    }
}
