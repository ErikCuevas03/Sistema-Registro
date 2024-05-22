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

        public Persona(string nombre, DateTime horaRegistro, string tipoRegistro)
        {
            Nombre = nombre;
            HoraRegistro = horaRegistro;
            TipoRegistro = tipoRegistro;
        }
    }
}
