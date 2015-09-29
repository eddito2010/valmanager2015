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
using Ini;

namespace VALManager2015
{
    public partial class MainForm : Form
    {
        Splash splash;
        public System.Timers.Timer ClockLT;

        //Classes Initialization

        public MainForm()
        {
            InitializeComponent();

            ClockLT = new System.Timers.Timer();
            ClockLT.Interval = 1000;
            ClockLT.Elapsed += updateClock;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            splash = new Splash();
            splash.ShowDialog();

            if (File.Exists("usuarios.dat"))
            {
                Login login = new Login();
                login.ShowDialog();
            }

            InitInterface();

            this.Show();
            ClockLT.Enabled = true;
            getVAList();
        }

        private void InitInterface()
        {
            if (Program.cerrarApp)
                Application.ExitThread();

            if (Program.loggedUser)
            {

                if (Program.admin)
                {
                    ribbonTabAsignaciones.Visible = true;
                    ribbonTabReportes.Visible = true;
                    ribbonTabTools.Visible = true;
                    ribbonTabImportExport.Visible = true;
                    ribbonTabAdmin.Visible = true;
                    lblUser.Text = "Administrador";
                }

                if (!Program.anonimo)
                {
                    ribbonTabAsignaciones.Visible = true;
                    ribbonTabReportes.Visible = true;
                    ribbonTabTools.Visible = true;
                    ribbonTabImportExport.Visible = true;
                    lblUser.Text = "";
                }

            }
        }

        private void updateClock(object state, System.Timers.ElapsedEventArgs e)
        {
            ClockUpdate();
        }

        private delegate void UpdateClockDelegate();
        private void ClockUpdate()
        {
            Invoke(new UpdateClockDelegate(
                delegate
                {
                    lblClockLT.Text = "LT: " + DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");
                    lblClockUTC.Text = "UTC: " + DateTime.UtcNow.Hour.ToString("00") + ":" + DateTime.UtcNow.Minute.ToString("00") + ":" + DateTime.UtcNow.Second.ToString("00");
                })
            );
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdNewUser_Click(object sender, EventArgs e)
        {
            NewUser newUser = new NewUser();
            newUser.ShowDialog();
        }

        private void getVAList()
        {
            DirectoryInfo di = new DirectoryInfo(Program.Caminos.airlineProfileDirectory);
            var files = di.GetFiles();
            var i = 0;

            foreach (var file in files)
            {
                ribbonCBAirLineList.DropDownItems.Add(new RibbonButton());
                ribbonCBAirLineList.DropDownItems[i].Text = Path.GetFileNameWithoutExtension(file.Name);
            }
        }

        private void ribbonButtonFs_Click(object sender, EventArgs e)
        {
            ConfiguracionSimulador configuracionSimulador = new ConfiguracionSimulador();
            configuracionSimulador.ShowDialog();
        }

    }
}
