using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaDatos;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class logicaNegocioRespaldo
    {
        accesoDatosRespaldoBD rbd = new accesoDatosRespaldoBD();

        public int respaldarBD()
        {
            return rbd.respaldarBD();
        }
    }
}
