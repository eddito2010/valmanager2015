using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VALManager2015
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdSaveNewUser_Click(object sender, EventArgs e)
        {
            if(txtPw1.Text == txtPw2.Text)
            {
                Program.Piloto.SetUsuario(txtUser.Text);
                Program.Piloto.SetPassword(txtPw1.Text);

                UsuariosToolBox.addUserToFile("usuarios.dat", Program.Piloto.GetUsuario(), Program.Piloto.GetPassword());
                Program.Piloto.SetDataToDB();
                Close();
            }
        }



    }
}
