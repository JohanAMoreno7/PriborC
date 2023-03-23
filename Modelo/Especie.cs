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
    class Especie
    {
        public bool Registrar_Especie(Controlador.CEspecie Objespecie)
        {
            //Variable de retorno
            bool bolRespuesta = false;
            //Declaracion de la variable conexion
            SqlConnection Cn = new SqlConnection();
            //Validacion
            try
            {
                //creacion de una variable objeto para llamar a string de conexion
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();
                //Especifica el nombre del procedimiento almacenado 
                string strEspecie = "[dbo].[Registrar_especie]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstEspecie = new SqlCommand(strEspecie, Cn);
                CmInstEspecie.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstEspecie.Parameters.AddWithValue("@idespecie", Objespecie.Idespecie);
                CmInstEspecie.Parameters.AddWithValue("@descripcion", Objespecie.Descripcion);

                int intRespuesta = CmInstEspecie.ExecuteNonQuery();
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
