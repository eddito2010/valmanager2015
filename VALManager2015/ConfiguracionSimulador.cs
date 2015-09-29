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
    public partial class ConfiguracionSimulador : Form
    {
        public ConfiguracionSimulador()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbFSUIPC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmdGetFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.Caminos.fsPath = folderBrowserDialog1.SelectedPath;
                txtFsPath.Text = Program.Caminos.fsPath;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if(txtFsPath.Text != "")
            {
                if(rbFS2004.Checked)
                    Program.Fs.SetNombre(rbFS2004.Text);
                else if(rbFSX.Checked)
                    Program.Fs.SetNombre(rbFSX.Text);
                else if (rbP3D.Checked)
                    Program.Fs.SetNombre(rbP3D.Text);

                Program.Fs.SetPath(txtFsPath.Text);
                Program.Caminos.fsPath = txtFsPath.Text;

                if(rbFSUIPC.Checked)
                {
                    Program.ConnectionModule.SetModuleName("FSUIPC");
                    Program.ConnectionModule.SetPathModule(Path.Combine(Program.Caminos.fsPath, "\\Modules"));
                }
                else if (rbSimConnect.Checked)
                {
                    Program.ConnectionModule.SetModuleName("SimConnect");
                    Program.ConnectionModule.SetPathModule(Path.Combine(Program.Caminos.fsPath, "\\Modules"));
                }

                Program.Fs.SetConnectionModule(Program.ConnectionModule);
                //todo: Aqui grabar ambas clases en la BD
                Close();
            }
            else
            {
                MessageBox.Show("Tiene que especificar el camino del simulador");
            }
        }
    }
}
