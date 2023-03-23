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
    public class Presentacion
    {
        public bool Registrar_Presentacion(Controlador.CPresentacion Objepresentacion)
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
                string strPresentacion = "[dbo].[Registrar_presentacion]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstPresentacion = new SqlCommand(strPresentacion, Cn);
                CmInstPresentacion.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstPresentacion.Parameters.AddWithValue("@nombre", Objepresentacion.Nombre);

                int intRespuesta = CmInstPresentacion.ExecuteNonQuery();
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
        public DataTable Consultar_Presentacion(string nombrE)
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strPresentacion = "[dbo].[BuscarPre]";

                SqlDataAdapter CmInstPresentacion = new SqlDataAdapter(strPresentacion, Cn);
                CmInstPresentacion.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstPresentacion.SelectCommand.Parameters.AddWithValue("@nombre", nombrE);
                CmInstPresentacion.Fill(dt);
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


        public DataTable Mostrar_Presentacion()
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strPresentacion = "[dbo].[MostrarPre]";

                SqlDataAdapter CmInstPresentacion = new SqlDataAdapter(strPresentacion, Cn);
                CmInstPresentacion.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstPresentacion.Fill(dt);
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
        public bool MofificarPre(Controlador.CPresentacion ObjPresentacion)
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
                string strPresentacion = "[dbo].[ModificarPre]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstPresentacion = new SqlCommand(strPresentacion, Cn);
                CmInstPresentacion.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstPresentacion.Parameters.AddWithValue("@nombre", ObjPresentacion.Nombre);
                CmInstPresentacion.Parameters.AddWithValue("@idpresentacion", ObjPresentacion.Idpresentacion);
                int intRespuesta = CmInstPresentacion.ExecuteNonQuery();
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
