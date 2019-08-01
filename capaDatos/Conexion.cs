using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace capaDatos
{
    public class Conexion
    {
        public SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=FAREM_B4_16-PC\\SQLEXPRESS;Initial Catalog=bd_ger;Integrated Security=True";
            return cn;
        }
        
    }
}
