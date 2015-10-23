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

        private void cmdGetFolder_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.Config.Fs.Path = folderBrowserDialog1.SelectedPath;
                txtFsPath.Text = Program.Config.Fs.Path;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if(txtFsPath.Text != "")
            {
                if(rbFS9.Checked)
                    Program.Config.Fs.Nombre = rbFS9.Text;
                else if(rbFSX.Checked)
                    Program.Config.Fs.Nombre = rbFSX.Text;
                else if (rbP3D.Checked)
                    Program.Config.Fs.Nombre = rbP3D.Text;

                Program.Config.Fs.Path = txtFsPath.Text;

                if(rbFSUIPC.Checked)
                {
                    Program.Config.Fs.ConnectionModule.ModuleName = "FSUIPC";
                    Program.Config.Fs.ConnectionModule.ModulePath = Path.Combine(Program.Config.Fs.Path, @"\Modules");
                }
                else if (rbSimConnect.Checked)
                {
                    Program.Config.Fs.ConnectionModule.ModuleName = "SimConnect";
                    Program.Config.Fs.ConnectionModule.ModulePath = Path.Combine(Program.Config.Fs.Path, @"\Modules");
                }

                Program.Config.Fs.ConnectionModule = Program.Config.Fs.ConnectionModule;
                //todo: Aqui grabar ambas clases en la BD
                Close();
            }
            else
            {
                MessageBox.Show("Tiene que especificar el camino del simulador");
            }
        }

        private void ConfiguracionSimulador_Load(object sender, EventArgs e)
        {
            txtFsPath.Text = Program.Config.Fs.Path;
            switch(Program.Config.Fs.Nombre)
            {
                case "FS9":
                    rbFS9.Checked = true;
                    break;
                case "FSX":
                    rbFSX.Checked = true;
                    break;
                case "P3D":
                    rbP3D.Checked = true;
                    break;
            }
            switch (Program.Config.Fs.ConnectionModule.ModuleName)
            {
                case "FSUIPC":
                    rbFSUIPC.Checked = true;
                    break;
                case "SimConnect":
                    rbSimConnect.Checked = true;
                    break;
            }
        }
    }
}
