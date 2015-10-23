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
    public partial class NewAirline : Form
    {
        private bool _edit = false;

        public NewAirline()
        {
            InitializeComponent();
        }

        public NewAirline(Aerolinea _airline)
        {
            InitializeComponent();
            txtNombre.Text = _airline.Nombre;
            txtCodigo.Text = _airline.Codigo;
            txtCallSign.Text = _airline.CallSign;
            txtLogoPath.Text = _airline.LogoFilePath;
            txtFallo.Text = _airline.FailPercent.ToString();
            txtInitialMoney.Text = _airline.InitialMoney.ToString();
            _edit = true;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdGetFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Program.Config.Fs.Path = folderBrowserDialog1.SelectedPath;
                txtLogoPath.Text = Program.Config.Fs.Path;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            Aerolinea _airline = new Aerolinea();
            _airline.Nombre = txtNombre.Text;
            _airline.Codigo = txtCodigo.Text;
            _airline.CallSign = txtCallSign.Text;
            _airline.LogoFilePath = txtLogoPath.Text;
            _airline.FailPercent = Convert.ToInt16(txtFallo.Text);
            _airline.InitialMoney = Convert.ToDouble(txtInitialMoney.Text);
            _airline.SaveDataToXml(Path.Combine(Program.Caminos.airlineProfileDirectory, _airline.Nombre + ".xml"));
            if(!_edit)
            {
                Program.AerolineaList.Add(_airline);
                Program.Aerolinea = _airline;
                List<Aerolinea> _tempList = new List<Aerolinea>();
                foreach (Aerolinea _airlineTemp in Program.AerolineaList)
                {
                    if (_airlineTemp != Program.Aerolinea)
                    {
                        _tempList.Add(_airlineTemp);
                    }
                    else
                    {
                        _tempList.Add(Program.Aerolinea);
                    }
                }
                Program.AerolineaList = _tempList;
            }
            Close();
        }
    }
}
