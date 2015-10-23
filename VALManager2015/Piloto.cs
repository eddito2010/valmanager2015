﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace VALManager2015
{

    public class Piloto
    {
        private int id { get; set; }

        private string nombreCompleto { get; set; }

        private string licencia { get; set; }

        private CategoriaPiloto categoria { get; set; }

        private string usuario { get; set; }

        private string password { get; set; }

        private Sexo sexo { get; set; }

        private PilotoAvion[] pilotoAvion { get; set; }

        private PilotoSimulador[] pilotoSimulador { get; set; }

        private PilotoCurso[] pilotoCurso { get; set; }

        private PilotoHabilitacion[] pilotoHabilitacion { get; set; }

        private ExamenPiloto[] examenPiloto { get; set; }

        //Seteo de propiedades
        public void SetNombreCompleto(string nombre)
        {
            nombreCompleto = nombre;
        }

        public void SetLicencia(string lic)
        {
            licencia = lic;
        }

        public void SetUsuario(string user)
        {
            usuario = user;
        }

        public void SetPassword(string passwrd)
        {
            password = passwrd;
        }

        //Obtencion del valor de las propiedades
        public string GetNombreCompleto()
        {
            return nombreCompleto;
        }

        public string GetLicencia()
        {
            return licencia;
        }

        public string GetUsuario()
        {
            return usuario;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetDataToDB()
        {
            string insercion;  // Orden de insercion, en SQL
            SQLiteCommand cmd; // Comando de SQLite
            int cantidad;      // Resultado: cantidad de datos

            // Creamos la conexion a la BD. 

            // El Data Source contiene la ruta del archivo de la BD 
            Program.coneccion = new SQLiteConnection("Data Source=" + Program.Caminos.databaseFile + ";Version=3;New=False;Compress=True;");
            Program.coneccion.Open();


            try
            {
                insercion = "INSERT INTO Piloto (idAerolinea, idCategoria, idExpediente, licencia, nombreCompleto, usuario, password, idPilotoAvion, idPilotoCurso, idPilotoExamen, idPilotoHabilitacion, idPilotoSimulador, idSexo) VALUES(0, 0, 0, '', '', " + GetUsuario() + ", " + GetPassword() + ", 0, 0, 0, 0, 0, 0);";
                cmd = new SQLiteCommand(insercion, Program.coneccion);

                cantidad = cmd.ExecuteNonQuery();
                if (cantidad < 1)
                    Console.WriteLine("No se ha podido insertar");
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido insertar");

                Console.WriteLine("Posiblemente un código está repetido");
                Console.WriteLine("Error encontrado: {0} ", e.Message);
            }
            finally
            {
                Program.coneccion.Close();
            }

        }
    }
}

