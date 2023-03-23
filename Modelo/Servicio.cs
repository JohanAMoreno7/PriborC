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
    class Servicio
    {
        public bool Registrar_Servicio(Controlador.CServicio Objeservicio)
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
                string strServicio = "[dbo].[Registrar_servicio]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstServicio = new SqlCommand(strServicio, Cn);
                CmInstServicio.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstServicio.Parameters.AddWithValue("@idservicio", Objeservicio.Idservicio);
                CmInstServicio.Parameters.AddWithValue("@descricion", Objeservicio.Descripcion);
                CmInstServicio.Parameters.AddWithValue("@estado", Objeservicio.Estado);


                int intRespuesta = CmInstServicio.ExecuteNonQuery();
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
