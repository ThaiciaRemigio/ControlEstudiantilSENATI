using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ControlEstudiantilSENATI.Entidades

{

    public class Estudiante

    {
        public int IdEstudiante { get; set; }

        // FK
        public int IdDistrito { get; set; }
        public int IdGenero { get; set; }
        public int IdProcedencia { get; set; }
        public int IdCondicion { get; set; }
        public int IdApoderado { get; set; }

        // Datos personales
        public string Dni { get; set; } = "";
        public string Nombres { get; set; } = "";
        public string Apellidos { get; set; } = "";

        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }

        // Contacto
        public string Correo1 { get; set; } = "";
        public string Correo2 { get; set; } = "";

        public string Telefono1 { get; set; } = "";
        public string Telefono2 { get; set; } = "";

        // Extras (importante)
        public bool Estado { get; set; } = true;
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

    }

}