using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaDatos;

namespace CapaNegocio
{
    public class logicaNegocioSolicitud
    {
        AccesoClaseSolicitud ac = new AccesoClaseSolicitud();

        public int insertarSolicitud(Solicitud so)
        {
            return ac.insertarSolicitud(so);
        }

        public List<Solicitud> ListarSolicitud()
        {
            return ac.ListarSolicitud();
        }

        public int EliminarSolicitud(int idsolicit)
        {
            return ac.EliminarSolicitud(idsolicit);
        }

        public int EditarSolicitud(Solicitud solic)
        {
            return ac.EditarSolicitud(solic);
        }

        public List<Solicitud> BuscarSolicitud(String dato)
        {
            return ac.BuscarSolicitud(dato);
        }
    }
}
