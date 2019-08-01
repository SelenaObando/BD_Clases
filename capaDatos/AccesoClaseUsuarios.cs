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
    public class AccesoClaseUsuarios
    {
        SqlConnection cnx; //conexion
        Usuarios us = new Usuarios();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Usuarios> listausuarios = null;

        public int insertarUsuarios(Usuarios u)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                cm = new SqlCommand("usuarios", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", u.cedula);
                cm.Parameters.AddWithValue("@nombres", u.nombres);
                cm.Parameters.AddWithValue("@apellidos", u.apellidos);
                cm.Parameters.AddWithValue("@email", u.email);
                cm.Parameters.AddWithValue("@telefono", u.telefono);


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

        public List<Usuarios> listarUsuarios()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("usuarios_pro", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listausuarios = new List<Usuarios>();
                while (dr.Read())
                {
                    Usuarios usi = new Usuarios();
                    usi.idusuario = Convert.ToInt32(dr["Idusuario"].ToString());
                    usi.cedula = dr["Cedula"].ToString();
                    usi.nombres = dr["Nombres"].ToString();
                    usi.apellidos = dr["Apellidos"].ToString();
                    usi.email = dr["Email"].ToString();
                    usi.telefono = dr["Telefono"].ToString();
                    listausuarios.Add(usi);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listausuarios = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return listausuarios;
        }

        public int EliminarUsuarios(int idusuari)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("usuarios_pro", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@idusuario", idusuari);
                cm.Parameters.AddWithValue("cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

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

        public int EditarUsuarios(Usuarios re)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("usuarios_pro", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idusuario", re.idusuario);
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", "");
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

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

        public List<Usuarios> BuscarUsuarios(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("usuarios_pro", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idusuario", "");
                cm.Parameters.AddWithValue("@cedula", "");
                cm.Parameters.AddWithValue("@nombres", dato);
                cm.Parameters.AddWithValue("@apellidos", "");
                cm.Parameters.AddWithValue("@email", "");
                cm.Parameters.AddWithValue("@telefono", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listausuarios = new List<Usuarios>();
                while (dr.Read())
                {
                    Usuarios usi = new Usuarios();
                    usi.idusuario = Convert.ToInt32(dr["Idusuario"].ToString());
                    usi.cedula = dr["Cedula"].ToString();
                    usi.nombres = dr["Codigo"].ToString();
                    usi.apellidos = dr["Descripcion"].ToString();
                    usi.email = dr["Email"].ToString();
                    usi.telefono = dr["Telefono"].ToString();
                    listausuarios.Add(usi);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listausuarios = null;

            }
            finally
            {
                cm.Connection.Close();
            }
            return listausuarios;
        }
    }
}
    
