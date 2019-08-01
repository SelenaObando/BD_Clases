using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient;

namespace capaDatos
{
    public class AccesoClaseComentario
    {
        SqlConnection cnx; //conexion
        Comentarios s = new Comentarios();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Comentarios> listacomentarios = null;

        public int insertarcomentarios(Comentarios co)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", co.Nombres);
                cm.Parameters.AddWithValue("@correo", co.Correo);
                cm.Parameters.AddWithValue("@telefono", co.Telefono);
                cm.Parameters.AddWithValue("@mensaje", co.Mensaje);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;

        }

        public List<Comentarios> ListarComentarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listacomentarios = new List<Comentarios>();
                while (dr.Read())
                {
                    Comentarios c = new Comentarios();
                    c.Idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.Nombres = dr["nombre"].ToString();
                    c.Correo = dr["correo"].ToString();
                    c.Telefono = dr["telefono"].ToString();
                    c.Correo = dr["mensaje"].ToString();
                    listacomentarios.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listacomentarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listacomentarios;
        }

        public int EliminarComentarios(int idcoment)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("Comentar", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idcomentario", idcoment);
                cm.Parameters.AddWithValue("nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;
            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public int EditarComentarios(Comentarios co)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcomentario", co.Idcomentario);
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", co.Mensaje);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }

        public List<Comentarios> BuscarComentarios(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("comentar", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcomentario", "");
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@correo", "");
                cm.Parameters.AddWithValue("@telefono", "");
                cm.Parameters.AddWithValue("@mensaje", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listacomentarios = new List<Comentarios>();
                while (dr.Read())
                {
                    Comentarios c = new Comentarios();
                    c.Idcomentario = Convert.ToInt32(dr["idcomentario"].ToString());
                    c.Nombres = dr["nombre"].ToString();
                    c.Correo = dr["correo"].ToString();
                    c.Telefono = dr["telefono"].ToString();
                    c.Mensaje = dr["mensaje"].ToString();
                    listacomentarios.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listacomentarios = null;

            }
            finally
            {
                cm.Connection.Close();
            }
            return listacomentarios;
        }
    }
}
