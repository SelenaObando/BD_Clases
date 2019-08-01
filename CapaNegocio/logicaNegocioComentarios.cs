using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using capaDatos;

namespace CapaNegocio
{
    public class logicaNegocioComentarios
    {
        AccesoClaseComentario ac= new AccesoClaseComentario();

        public int insertarcomentarios(Comentarios co)
        {
            return ac.insertarcomentarios(co);
        }

        public List<Comentarios> ListarComentarios()
        {
            return ac.ListarComentarios();
        }

        public int EliminarComentarios(int idcoment)
        {
            return ac.EliminarComentarios(idcoment);
        }

        public int EditarComentarios(Comentarios co)
        {
            return ac.EditarComentarios(co);
        }

        public List<Comentarios> BuscarComentarios(String dato)
        {
            return ac.BuscarComentarios(dato);
        }
    }
}
