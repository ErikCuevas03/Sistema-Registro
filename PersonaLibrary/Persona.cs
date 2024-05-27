using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaLibrary
{
    class Persona
    {

        public string Nombre { get; set; }
        public DateTime HoraRegistro { get; set; }
        public string TipoRegistro { get; set; }
        public string NumeroControl { get; set; }
        public string Carrera { get; set; }
        public string Semestre { get; set; }

        public Persona(string nombre, DateTime horaRegistro, string tipoRegistro ,string numeroControl, string carrera, string semestre)
        {
            Nombre = nombre;
            HoraRegistro = horaRegistro;
            TipoRegistro = tipoRegistro;
            NumeroControl = numeroControl;
            Carrera = carrera;
            Semestre = semestre;
        }
    }
}
