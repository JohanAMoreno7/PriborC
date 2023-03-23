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
    public class Marca
    {
        public bool Registrar_Marca(Controlador.CMarca Objmarca)
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
                string strMarca = "[dbo].[RegistrarMarca]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstMarca = new SqlCommand(strMarca, Cn);
                CmInstMarca.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstMarca.Parameters.AddWithValue("@nombre", Objmarca.Descripcion);

                int intRespuesta = CmInstMarca.ExecuteNonQuery();
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

        public DataTable ConsultaM(string nombrE)
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strUnidad = "[dbo].[BuscarM]";

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
        public DataTable MostrarM()
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strUnidad = "[dbo].[MostrarM]";

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

        public bool ModificarM(Controlador.CMarca ObjMarca)
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
                string strUnidad = "[dbo].[ModificarM]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstUnidad = new SqlCommand(strUnidad, Cn);
                CmInstUnidad.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstUnidad.Parameters.AddWithValue("@nombre", ObjMarca.Descripcion);
                CmInstUnidad.Parameters.AddWithValue("@idmarca", ObjMarca.Idmarca);
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
