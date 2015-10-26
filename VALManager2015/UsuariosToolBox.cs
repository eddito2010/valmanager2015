using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VALManager2015
{
    public static class UsuariosToolBox
    {
        /// <summary>
        /// encripta el fichero que se le pase
        /// </summary>
        /// <param name="path"></param>
        public static void encriptaFile(string path)
        {
            var tempFile = Path.GetFileNameWithoutExtension(path) + "_temp";
            var content = "";
            string tempContent = "";
            string fileName = path;

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                content = reader.ReadToEnd();
            }

            reader.Close();

            tempContent = CryptoTools.Encrypt(content, Program.PASSPHRASE, Program.SALTVALUE, Program.HASHALGORITHM, Program.PASSWORDITERATIONS, Program.INITVECTOR, Program.KEYSIZE);

            FileStream streamW = new FileStream(tempFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(streamW);

            writer.Write(tempContent);
            writer.Close();

            File.Delete(fileName);
            File.Move(tempFile, fileName);
        }

        /// <summary>
        /// decripta un fichero dado
        /// </summary>
        /// <param name="path"></param>
        /// <returns>
        /// retorna el camino del fichero decriptado
        /// </returns>
        public static string decriptaFile(string path)
        {
            var tempFile = Path.GetTempFileName();
            var content = "";
            string tempContent = "";
            string fileName = path;

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                content = reader.ReadToEnd();
            }

            reader.Close();

            tempContent = CryptoTools.Decrypt(content, Program.PASSPHRASE, Program.SALTVALUE, Program.HASHALGORITHM, Program.PASSWORDITERATIONS, Program.INITVECTOR, Program.KEYSIZE);

            FileStream streamW = new FileStream(tempFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(streamW);

            writer.Write(tempContent);
            writer.Close();

            return tempFile;
        }

        /// <summary>
        /// adiciona un usuario dado al fichero usuarios.dat
        /// </summary>
        /// <param name="path"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public static void addUserToFile(string path, string userName, string password)
        {
            var decriptedFile = "";

            if (File.Exists(path))
            {
                decriptedFile = UsuariosToolBox.decriptaFile(path);
                using (StreamWriter sw = File.AppendText(decriptedFile))
                {
                    sw.WriteLine(userName);
                    sw.WriteLine(password);
                    sw.WriteLine("");
                }
                File.Delete(path);
                File.Move(decriptedFile, path);
            }
            else
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(userName);
                    sw.WriteLine(password);
                    sw.WriteLine("");
                }
            }
            UsuariosToolBox.encriptaFile(path);
        }

        /// <summary>
        /// busca si el usuario y el password son salidos
        /// </summary>
        /// <param name="path"></param>
        /// <param name="user"></param>
        /// <param name="psw"></param>
        /// <returns>
        /// retorna true si existe, de lo contrario retorna false
        /// </returns>
        public static bool getUserFromFile(string path, string user, string psw)
        {
            var _return = false;
            var content = "";
            var tempContent = "";
            var usuario = "";
            var password = "";


            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                content = reader.ReadLine();
                tempContent = CryptoTools.Decrypt(content, Program.PASSPHRASE, Program.SALTVALUE, Program.HASHALGORITHM, Program.PASSWORDITERATIONS, Program.INITVECTOR, Program.KEYSIZE);
                var cadena = tempContent.Replace("\r\n", "@");
                var cadenas = cadena.Split('@');
                for (int i = 0; i < cadenas.Count(); i+=3)
                {
                    usuario = cadenas[i];
                    password = cadenas[i+1];
                    if (usuario == user && password == psw)
                    {
                        _return = true;
                        Program.anonimo = false;
                        break;
                    }
                }
            }

            reader.Close();


            return _return;
        }

    }
}
