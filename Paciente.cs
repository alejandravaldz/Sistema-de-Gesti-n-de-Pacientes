using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema_de_Gestión_de_Pacientes
{
    public class Paciente
    {
        public enum sexo
        {
            Masculino,
            Femenino
        }
        public enum Estadop
        {
            Ingresado,
            EnObservacion,
            DeAlta,
            Hospitalizado

        }
      
            public string Cedula { get; set; }
            public string Nombre { get; set; }
            public int Edad { get; set; }
            public sexo Sexo { get; set; }
            public Estadop Estado { get; set; }
            public string Diagnostico { get; set; }
            public DateTime FechaIngreso { get; set; }
            
        }
    }
