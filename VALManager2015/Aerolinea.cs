
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace VALManager2015
{

    public class Aerolinea
    {
        private string _nombre;
        private string _codigo;
        private string _callSign;
        private string _logoFilePath;
        private int _failPercent;
        private double _initialMoney;
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string CallSign
        {
            get { return _callSign; }
            set { _callSign = value; }
        }

        public string LogoFilePath
        {
            get { return _logoFilePath; }
            set { _logoFilePath = value; }
        }

        public int FailPercent
        {
            get { return _failPercent; }
            set { _failPercent = value; }
        }

        public double InitialMoney
        {
            get { return _initialMoney; }
            set { _initialMoney = value; }
        }

        public void SaveDataToXml(string xmlFileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Aerolinea));
            TextWriter writer = new StreamWriter(xmlFileName);
            serializer.Serialize(writer, this);
            writer.Close();
        }


        public void LoadFromFileXml(string xmlFileName)
        {
            if (File.Exists(xmlFileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Aerolinea));
                using (FileStream fs = new FileStream(xmlFileName, FileMode.Open))
                {
                    Aerolinea _airline;
                    _airline = (Aerolinea)serializer.Deserialize(fs);
                    _nombre = _airline.Nombre;
                    _codigo = _airline.Codigo;
                    _callSign = _airline.CallSign;
                    _logoFilePath = _airline.LogoFilePath;
                    _failPercent = _airline.FailPercent;
                    _initialMoney = _airline.InitialMoney;
                }
            }
        }


    }
}

