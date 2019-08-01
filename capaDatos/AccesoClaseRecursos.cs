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
    public class AccesoClaseRecursos
    {

        SqlConnection cnx; //conexion
        Recursos recu = new Recursos();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Recursos> listarecursos = null;

        public int insertarRecursos(Recursos r)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                cm = new SqlCommand("recurso", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", r.nombrer);
                cm.Parameters.AddWithValue("@codigo", r.codigo);
                cm.Parameters.AddWithValue("@descripcion", r.descripcion);


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

        public List<Recursos> listarRecursos()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recurso", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listarecursos = new List<Recursos>();
                while (dr.Read())
                {
                    Recursos re = new Recursos();
                    re.idrecursos = Convert.ToInt32(dr["Idrecursos"].ToString());
                    re.nombrer = dr["Nombrer"].ToString();
                    re.codigo = dr["Codigo"].ToString();
                    re.descripcion = dr["Descripcion"].ToString();
                    listarecursos.Add(re);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listarecursos = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listarecursos;
        }

        public int EliminarRecursos(int idrecurs)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recurso", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idrecursos", idrecurs);
                cm.Parameters.AddWithValue("nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

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

        public int EditarRecursos(Recursos re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recurso", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idrecursos", re.idrecursos);
                cm.Parameters.AddWithValue("@nombrer", "");
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

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

        public List<Recursos> BuscarRecursos(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("recurso", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idrecursos", "");
                cm.Parameters.AddWithValue("@nombrer", dato);
                cm.Parameters.AddWithValue("@codigo", "");
                cm.Parameters.AddWithValue("@descripcion", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listarecursos = new List<Recursos>();
                while (dr.Read())
                {
                    Recursos re = new Recursos();
                    re.idrecursos = Convert.ToInt32(dr["Idrecursos"].ToString());
                    re.nombrer = dr["Nombrer"].ToString();
                    re.codigo = dr["Codigo"].ToString();
                    re.descripcion = dr["Descripcion"].ToString();
                    listarecursos.Add(re);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listarecursos = null;

            }
            finally
            {
                cm.Connection.Close();
            }
            return listarecursos;
        }
    }
}
    
