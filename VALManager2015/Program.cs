using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;

namespace VALManager2015
{
    static class Program
    {
        //Constantes para el encriptamiento
        public const string PASSPHRASE = "Pas5pr@se";           // can be any string
        public const string SALTVALUE = "s@1tValue";            // can be any string
        public const string HASHALGORITHM = "SHA1";             // can be "MD5"
        public const int PASSWORDITERATIONS = 2;                // can be any number
        public const string INITVECTOR = "@1B2c3D4e5F6g7H8";    // must be 16 bytes
        public const int KEYSIZE = 256;                         // can be 192 or 128
        

        public struct Caminos
        {
            public static string systemCfgDirectory = Path.Combine(Application.StartupPath, "Config");
            public static string systemCfgFileIni = Path.Combine(systemCfgDirectory, "config.ini");
            public static string systemCfgFileXml = Path.Combine(systemCfgDirectory, "config.xml");
            public static string databaseFile = Path.Combine(Application.StartupPath, @"BaseDatos\simucubamanager2015.db");
            public static string airlineCfg;
            public static string airlineProfileDirectory = Path.Combine(Application.StartupPath, "VA_Profiles");
        }

        public static bool cerrarApp = false;
        public static bool anonimo = true;
        public static bool admin = false;
        public static bool loggedUser = false;

        public static string activeAirline = "";
        public static List<Aerolinea> AerolineaList = new List<Aerolinea>();

        //Declaracion de clases
        public static Configuracion Config = new Configuracion();
        public static Aerolinea Aerolinea = new Aerolinea();
        public static Piloto Piloto = new Piloto();

        //Coneccion con la BD
        public static SQLiteConnection coneccion;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
