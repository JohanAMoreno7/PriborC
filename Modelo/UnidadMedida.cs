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
    public class UnidadMedida
    {
        public bool Registrar_UnidadMedida(Controlador.CUnidadMedida ObjeunidadMedida)
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
                string strUnidadMedida = "[dbo].[RegistrarUni]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstUnidadMedida = new SqlCommand(strUnidadMedida, Cn);
                CmInstUnidadMedida.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstUnidadMedida.Parameters.AddWithValue("@nombre", ObjeunidadMedida.Nombre);



                int intRespuesta = CmInstUnidadMedida.ExecuteNonQuery();
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

        public DataTable MostrarUnidad()
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strUnidad = "[dbo].[MostrarUnidad]";

                SqlDataAdapter CmInstUnidad = new SqlDataAdapter(strUnidad, Cn);
                CmInstUnidad.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstUnidad.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                Cn.Close();
                Cn.Dispose();
            }
            return dt;
        }

        public DataTable ConsultarUnidad(string nombrE)
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strUnidad = "[dbo].[BuscarUnidad]";

                SqlDataAdapter CmInstUnidad = new SqlDataAdapter(strUnidad, Cn);
                CmInstUnidad.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstUnidad.SelectCommand.Parameters.AddWithValue("@nombre", nombrE);
                CmInstUnidad.Fill(dt);
            }
            catch (Exception)
            {

            }
            finally
            {
                Cn.Close();
                Cn.Dispose();
            }
            return dt;
        }

        public bool MofificarUnidad(Controlador.CUnidadMedida ObjUnidad)
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
                string strUnidad = "[dbo].[ModificarUnidad]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstUnidad = new SqlCommand(strUnidad, Cn);
                CmInstUnidad.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstUnidad.Parameters.AddWithValue("@nombre", ObjUnidad.Nombre);
                CmInstUnidad.Parameters.AddWithValue("@idunidaddemedida", ObjUnidad.Idunidadmedida);
                int intRespuesta = CmInstUnidad.ExecuteNonQuery();
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
