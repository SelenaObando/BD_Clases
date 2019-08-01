using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Solicitud
    {
        public int Idsolicitud { get; set;}
        public string aula { get; set; }
        public string nivel { get; set; }
        public DateTime fechasolicitud { get; set; }
        public DateTime fechauso { get; set; }
        public DateTime horainicio { get; set; }
        public DateTime horafinal { get; set; }
        public string carrera { get; set; }
        public string asignatura { get; set; }
        public int idrecursos { get; set; }
        public int idusuario { get; set; }
    }
}
