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
    public class Cliente
    {
        
        public bool Registrar_Cliente(Controlador.CCliente Objcliente)
        {
            //Variable de retorno
            bool bolRespuesta = false;
            //Declaracion de la variable conexion
            SqlConnection Cn = new SqlConnection();
            //Validacion
            try
            {
                //creacion de una variable objeto para llamar ak string de conexion
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();
                //Especifica el nombre del procedimiento almacenado 
                string strCliente = "[dbo].[Registrar_cliente]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCliente"
                SqlCommand CmInstCliente = new SqlCommand(strCliente, Cn);
                CmInstCliente.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstCliente.Parameters.AddWithValue("@idcliente",Objcliente.Idcliente);
                CmInstCliente.Parameters.AddWithValue("@nombre",Objcliente.Nombre);
                CmInstCliente.Parameters.AddWithValue("@apellido", Objcliente.Apellido);
                CmInstCliente.Parameters.AddWithValue("@telefono", Objcliente.Telefono);

                int intRespuesta = CmInstCliente.ExecuteNonQuery();
                if (intRespuesta > 0)
                {
                    bolRespuesta = true;
                }
            }
            catch (Exception)
            {

            }
            finally
            {
                //Cierro la conexion
                Cn.Close();
                //Libero recursos no administrados, esto me garantiza
                Cn.Dispose();
            }
            return bolRespuesta;
        }
    }
}
