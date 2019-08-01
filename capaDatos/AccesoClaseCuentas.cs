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
   public class AccesoClaseCuentas
    {
        SqlConnection cnx; //conexion
        Cuentas cnt = new Cuentas();
        Conexion cn = new Conexion();
        SqlCommand cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Cuentas> listacuentas = null;

        public int insertarcuentas(Cuentas ct)
        {
            try
            {
                SqlConnection cnx = cn.conectar(); //conexion
                cm = new SqlCommand("cuenta", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", ct.nombreuser);
                cm.Parameters.AddWithValue("@clave", ct.clave);
                cm.Parameters.AddWithValue("@rol", ct.rol);


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

        public List<Cuentas> listarCuentas()
{
try
{
SqlConnection cnx= cn.conectar();
cm= new SqlCommand("cuenta", cnx);
cm.Parameters.AddWithValue("@b", 3);
cm.Parameters.AddWithValue("@idcuenta", "");
cm.Parameters.AddWithValue("@nombreuser", "");
cm.Parameters.AddWithValue("@clave", "");
cm.Parameters.AddWithValue("@rol", "");

cm.CommandType= CommandType.StoredProcedure;
cnx.Open();
dr= cm.ExecuteReader();
listacuentas = new List<Cuentas>();
while (dr.Read())
{
Cuentas c= new Cuentas();
c.idcuenta= Convert.ToInt32(dr["Idcomentario"].ToString());
c.nombreuser=dr["Nombre"].ToString();
c.clave= dr["Correo"].ToString();
c.rol= dr["Rol"].ToString();
listacuentas.Add(c);
}
}
catch (Exception e)
{
e.Message.ToString();
listacuentas= null;
}
finally
{
    cm.Connection.Close();
}
return listacuentas;
}

        public int EliminarCuentas(int idcuent)
{
try
{
SqlConnection cnx=cn.conectar();
cm=new SqlCommand("cuenta", cnx);
cm.Parameters.AddWithValue("@b", 2);
cm.Parameters.AddWithValue("@idcuenta", idcuent);
cm.Parameters.AddWithValue("nombreuser", "");
cm.Parameters.AddWithValue("@clave", "");
cm.Parameters.AddWithValue("@rol", "");

cm.CommandType=CommandType.StoredProcedure;
cnx.Open();
cm.ExecuteNonQuery();
indicador=1;
}
catch(Exception e)
{
e.Message.ToString();
indicador=0;
}
finally
{
cm.Connection.Close();
}
return indicador;
}

        public int EditarCuentas(Cuentas ct)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("cuenta", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@idcuenta", ct.idcuenta);
                cm.Parameters.AddWithValue("@nombreuser", "");
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");

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

        public List<Cuentas> BuscarCuentas(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("cuenta", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@idcuenta", "");
                cm.Parameters.AddWithValue("@nombreuser", dato);
                cm.Parameters.AddWithValue("@clave", "");
                cm.Parameters.AddWithValue("@rol", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listacuentas = new List<Cuentas>();
                while (dr.Read())
                {
                    Cuentas c = new Cuentas();
                    c.idcuenta = Convert.ToInt32(dr["Idcuenta"].ToString());
                    c.nombreuser = dr["Nombreuser"].ToString();
                    c.clave = dr["Clave"].ToString();
                    c.rol = dr["Rol"].ToString();
                    listacuentas.Add(c);
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listacuentas = null;

            }
            finally
            {
                cm.Connection.Close();
            }
            return listacuentas;
        }

    }
}
