using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace VALManager2015
{
    public class Examen
    {
        enum CalificacionExamen
        {
            Exelente,
            Bien,
            Regular,
            Mal,
        }

        public string NombreExamen
        {
            get;
            set;
        }

        public string Calificacion
        {
            get;
            set;
        }

        public void SaveDataToXml(string xmlFileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Examen));
            TextWriter writer = new StreamWriter(xmlFileName);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public void LoadDataFromXml(string xmlFileName)
        {
            if (File.Exists(xmlFileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Examen));
                using (FileStream fs = new FileStream(xmlFileName, FileMode.Open))
                {
                    Examen _examen;
                    _examen = (Examen)serializer.Deserialize(fs);
                    NombreExamen = _examen.NombreExamen;
                    Calificacion = _examen.Calificacion;

                }
            }
        }

    }
}
