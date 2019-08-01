using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaDatos;

namespace CapaNegocio
{
    public class logicaNegocioUsuarios
    {
        AccesoClaseUsuarios ac = new AccesoClaseUsuarios();

        public int insertarUsuarios(Usuarios u)
        {
            return ac.insertarUsuarios(u);
        }

        public List<Usuarios> listarUsuarios()
        {
            return ac.listarUsuarios();
        }

        public int EliminarUsuarios(int idusuari)
        {
            return ac.EliminarUsuarios(idusuari);
        }

        public int EditarUsuarios(Usuarios re)
        {
            return ac.EditarUsuarios(re);
        }

        public List<Usuarios> BuscarUsuarios(String dato)
        {
            return ac.BuscarUsuarios(dato);
        }
    }
}
