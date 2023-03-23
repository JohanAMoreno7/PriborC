using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Modelo
{
    public class Conexion
    {
        public SqlConnection Conexionbd() {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-LML9D40\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=True";
            return cn;
        }
    }
}
