using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaDatos;

namespace CapaNegocio
{
    public class logicaNegocioRecursos
    {
        AccesoClaseRecursos ac = new AccesoClaseRecursos();

        public int insertarRecursos(Recursos r)
        {
            return ac.insertarRecursos(r);
        }

        public List<Recursos> listarRecursos()
        {
            return ac.listarRecursos();
        }

        public int EliminarRecursos(int idrecurs)
        {
            return ac.EliminarRecursos(idrecurs);
        }

        public int EditarRecursos(Recursos re)
        {
            return ac.EditarRecursos(re);
        }

        public List<Recursos> BuscarRecursos(String dato)
        {
            return ac.BuscarRecursos(dato);
        }

    }
}
