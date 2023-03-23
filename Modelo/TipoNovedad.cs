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
    class TipoNovedad
    {
        public bool Registrar_TipoNovedad(Controlador.CTipoNovedad ObjetipoNovedad)
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
                string strTipoNovedad = "[dbo].[Registrar_tipoNovedad]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstTipoNovedad = new SqlCommand(strTipoNovedad, Cn);
                CmInstTipoNovedad.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstTipoNovedad.Parameters.AddWithValue("@idtiponovedad", ObjetipoNovedad.IdtipoNovedad);
                CmInstTipoNovedad.Parameters.AddWithValue("@descricion", ObjetipoNovedad.Descripcion);
                


                int intRespuesta = CmInstTipoNovedad.ExecuteNonQuery();
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
