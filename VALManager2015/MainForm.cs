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

            initInterface();
            initConfigurationGlobalVars();
            initConfigurationRibbonTab();

            this.Show();
            ClockLT.Enabled = true;
        }

        private void initConfigurationGlobalVars()
        {
            Program.Config.ReadCfgFileXml(Program.Caminos.systemCfgFileXml);
            loadAerolineaInConfig();
        }

        private void loadAerolineaInConfig()
        {
            if(File.Exists(Path.Combine(Program.Caminos.airlineProfileDirectory, Program.Config.Aerolinea + ".xml")))
            {
                Program.Aerolinea.LoadFromFileXml(Path.Combine(Program.Caminos.airlineProfileDirectory, Program.Config.Aerolinea + ".xml"));
            }
        }

        private void initConfigurationRibbonTab()
        {
            var i = 0;
            fillVAList();
            refreshRibbonCBAirlineList();
            foreach(RibbonItem item in ribbonCBAirLineList.DropDownItems)
            {
                if(ribbonCBAirLineList.DropDownItems[i].Text == Program.Config.Aerolinea)
                {
                    ribbonCBAirLineList.SelectedItem = ribbonCBAirLineList.DropDownItems[i];
                }
                i++;
            }
            
        }

        private void initInterface()
        {
            if (Program.cerrarApp)
                Application.ExitThread();

            if (Program.loggedUser)
            {

                if (Program.admin)
                {
                    //Tab Asignaciones
                    ribbonTabAsignaciones.Visible = true;

                    //Tab Reportes
                    ribbonTabReportes.Visible = true;

                    //Tab Tools
                    ribbonTabTools.Visible = true;

                    //Tab ImportExport
                    ribbonTabImportExport.Visible = true;

                    //Tab Admin
                    ribbonTabAdmin.Visible = true;

                    //Tab Vuelos
                    ribbonTabVuelos.Visible = true;

                    //Tab Config
                    ribbonButtonEditAerolinea.Enabled = true;
                    ribbonButtonNewAerolinea.Enabled = true;

                    //Status Bar
                    lblUser.Text = "Administrador";
                }

                if (!Program.anonimo)
                {
                    //Tab Asignaciones
                    ribbonTabAsignaciones.Visible = true;

                    //Tab Reportes
                    ribbonTabReportes.Visible = true;

                    //Tab Tools
                    ribbonTabTools.Visible = true;

                    //Tab ImportExport
                    ribbonTabImportExport.Visible = true;

                    //Tab Vuelos
                    ribbonTabVuelos.Visible = true;

                    //Tab Config
                    ribbonButtonEditAerolinea.Enabled = true;
                    ribbonButtonNewAerolinea.Enabled = true;

                    //Status Bar
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

        private void fillVAList()
        {
            DirectoryInfo di = new DirectoryInfo(Program.Caminos.airlineProfileDirectory);
            var files = di.GetFiles();

            foreach (var file in files)
            {
                Aerolinea _tempAirline = new Aerolinea();
                _tempAirline.LoadFromFileXml(file.FullName);
                Program.AerolineaList.Add(_tempAirline);
            }
        }

        private void refreshRibbonCBAirlineList()
        {
            var i = 0;

            foreach (Aerolinea _airlineTemp in Program.AerolineaList)
            {
                ribbonCBAirLineList.DropDownItems.Add(new RibbonButton());
                ribbonCBAirLineList.DropDownItems[i].Text = Program.AerolineaList[i].Nombre;
            }
        }

        private void ribbonButtonFs_Click(object sender, EventArgs e)
        {
            ConfiguracionSimulador configuracionSimulador = new ConfiguracionSimulador();
            configuracionSimulador.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Config.SaveDataToXml(Program.Caminos.systemCfgFileXml);
        }

        private void ribbonCBAirLineList_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            Program.Config.Aerolinea = ribbonCBAirLineList.SelectedItem.Text;
        }

        private void ribbonButtonNewAerolinea_Click(object sender, EventArgs e)
        {
            NewAirline frmNewAirline = new NewAirline();
            frmNewAirline.ShowDialog();
        }

        private void ribbonButtonEditAirline_Click(object sender, EventArgs e)
        {
            NewAirline frmNewAirline = new NewAirline(Program.Aerolinea);
            frmNewAirline.ShowDialog();
        }

    }
}
