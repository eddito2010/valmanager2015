using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VALManager2015
{
    static class InitialDataCreator
    {
        public static void CreateAirlineFile(string airlineName)
        {
            IniFile airlineIni = new IniFile(Path.Combine(Program.Caminos.airlineProfileDirectory, airlineName));
            airlineIni.IniWriteValue("GENERAL", "NAME", airlineName + ".ini");
            airlineIni.IniWriteValue("GENERAL", "CALLSIGN", "");
            airlineIni.IniWriteValue("GENERAL", "CODE", "");
            airlineIni.IniWriteValue("GENERAL", "PATHLOGOFILE", "");
            airlineIni.IniWriteValue("GENERAL", "PATHCFGFILE", "");
            airlineIni.IniWriteValue("GENERAL", "HASHCODE", "");
            airlineIni.IniWriteValue("FAIL", "MARGIN", "5");
        }

        public static void CreateConfigFileIni()
        {
            var iniFile = Program.Caminos.systemCfgDirectory + @"\config.ini";
            File.Create(iniFile);
            IniFile airlineIni = new IniFile(iniFile);
            airlineIni.IniWriteValue("PATH", "FSPATH", "");            
            airlineIni.IniWriteValue("AIRLINE", "NAME", "");
        }


    }
}

