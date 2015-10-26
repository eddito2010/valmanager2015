using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace VALManager2015
{

    public class Piloto
    {

        private string nombreCompleto;
        private string licencia;
        private CategoriaPiloto categoria;
        private string usuario;
        private Sexo sexo;
        private PilotoAvion[] pilotoAvion;
        private PilotoSimulador[] pilotoSimulador;
        private PilotoCurso[] pilotoCurso;
        private PilotoHabilitacion[] pilotoHabilitacion;
        private PilotoExamen[] examenPiloto;

        public string NombreCompleto 
        {   
            get; 
            set; 
        }

        public string Licencia 
        {   
            get; 
            set; 
        }

        public CategoriaPiloto Categoria 
        { 
            get; 
            set; 
        }

        public string Usuario 
        { 
            get; 
            set; 
        }

        public Sexo Sexo 
        { 
            get; 
            set; 
        }

        public PilotoAvion[] PilotoAvion 
        { 
            get; 
            set; 
        }

        public PilotoSimulador[] PilotoSimulador 
        { 
            get; 
            set; 
        }

        public PilotoCurso[] PilotoCurso 
        { 
            get; 
            set; 
        }

        public PilotoHabilitacion[] PilotoHabilitacion 
        { 
            get; 
            set; 
        }

        public PilotoExamen[] ExamenPiloto 
        { 
            get; 
            set; 
        }

    }
}

