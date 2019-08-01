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
    public class AccesoClaseSolicitud
    {
        SqlConnection cnx; //conexion
        Solicitud s = new Solicitud();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Solicitud> listasolicitud = null;

        public int insertarSolicitud(Solicitud so)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                cm = new SqlCommand("solicitudes", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@Idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", so.aula);
                cm.Parameters.AddWithValue("@nivel", so.nivel);
                cm.Parameters.AddWithValue("@fechasolicitud", so.fechasolicitud);
                cm.Parameters.AddWithValue("@fechauso", so.fechauso);
                cm.Parameters.AddWithValue("@horainicio", so.horainicio);
                cm.Parameters.AddWithValue("@horafinal", so.horafinal);
                cm.Parameters.AddWithValue("@carrera", so.carrera);
                cm.Parameters.AddWithValue("@asignatura", so.asignatura);


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

        public List<Solicitud> ListarSolicitud()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("solicitudes", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@Idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listasolicitud = new List<Solicitud>();
                while (dr.Read())
                {
                    Solicitud solic = new Solicitud();
                    solic.Idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    solic.aula = dr["Aula"].ToString();
                    solic.nivel = dr["Nievl"].ToString();
                    solic.fechasolicitud = Convert.ToDateTime(dr["Fechasolicitud"]);
                    solic.fechauso = Convert.ToDateTime(dr["Fechauso"]);
                    solic.horainicio = Convert.ToDateTime(dr["Horainicio"]);
                    solic.horafinal = Convert.ToDateTime(dr["Horafinal"]);
                    solic.carrera = dr["Carrera"].ToString();
                    solic.asignatura = dr["Asignatura"].ToString();
                    listasolicitud.Add(solic);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listasolicitud = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listasolicitud;
        }

        public int EliminarSolicitud(int idsolicit)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("solicitudes", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@Idsolicitud", idsolicit);
                cm.Parameters.AddWithValue("aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitudd", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");

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

        public int EditarSolicitud(Solicitud solic)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("solicitudes", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idsolicitud", solic.Idsolicitud);
                cm.Parameters.AddWithValue("@aula", "");
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");

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

        public List<Solicitud> BuscarSolicitud(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("solicitudes", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@Idsolicitud", "");
                cm.Parameters.AddWithValue("@aula", dato);
                cm.Parameters.AddWithValue("@nivel", "");
                cm.Parameters.AddWithValue("@fechasolicitud", "");
                cm.Parameters.AddWithValue("@fechauso", "");
                cm.Parameters.AddWithValue("@horainicio", "");
                cm.Parameters.AddWithValue("@horafinal", "");
                cm.Parameters.AddWithValue("@carrera", "");
                cm.Parameters.AddWithValue("@asignatura", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listasolicitud = new List<Solicitud>();
                while (dr.Read())
                {
                    Solicitud solic = new Solicitud();
                    solic.Idsolicitud = Convert.ToInt32(dr["idsolicitud"].ToString());
                    solic.aula = dr["Aula"].ToString();
                    solic.nivel = dr["Nivel"].ToString();
                    solic.fechasolicitud = Convert.ToDateTime(dr["Fechasolicitud"]);
                    solic.fechauso = Convert.ToDateTime(dr["Fechauso"]);
                    solic.horainicio = Convert.ToDateTime(dr["Horainicio"]);
                    solic.horafinal = Convert.ToDateTime(dr["Horafinal"]);
                    solic.carrera = dr["carrera"].ToString();
                    solic.asignatura = dr["Asignatura"].ToString();
                    listasolicitud.Add(solic);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listasolicitud = null;

            }
            finally
            {
                cm.Connection.Close();
            }
            return listasolicitud;
        }
    }
}
    
