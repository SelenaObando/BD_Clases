using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    public class accesoDatosRespaldoBD
    {
        SqlConnection cnx;
        Conexion cn=new Conexion();
        SqlCommand cm=null;
        int indicador = 0;

        public int respaldarBD()
        {
            try
            {
                SqlConnection cnx=cn.conectar();

                cm=new SqlCommand("RespaldoBD_GER", cnx);
                cm.CommandType = CommandType.StoredProcedure;
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

    



    }
}
