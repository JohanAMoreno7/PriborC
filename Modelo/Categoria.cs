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
    public class Categoria
    {
        public bool Registrar_Categoria(Controlador.CCategoria Objcategoria)
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
                string strCategoria = "[dbo].[InsertarCat]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstCategoria = new SqlCommand(strCategoria, Cn);
                CmInstCategoria.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstCategoria.Parameters.AddWithValue("@nombre", Objcategoria.Nombre);

                int intRespuesta = CmInstCategoria.ExecuteNonQuery();
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

        public DataTable Consultar_Categoria(string nombrE)
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strCategoria = "[dbo].[buscarCat]";

                SqlDataAdapter CmInstCategoria = new SqlDataAdapter(strCategoria, Cn);
                CmInstCategoria.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstCategoria.SelectCommand.Parameters.AddWithValue("@nombre", nombrE);
                CmInstCategoria.Fill(dt);
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

        public DataTable Mostrar_Categoria()
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strCliente = "[dbo].[MostrarCat]";

                SqlDataAdapter CmInstCategoria = new SqlDataAdapter(strCliente, Cn);
                CmInstCategoria.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstCategoria.Fill(dt);
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

        public bool Mofificar_Categoria(Controlador.CCategoria Objcategoria)
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
                string strCategoria = "[dbo].[ModificarCat]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstCategoria = new SqlCommand(strCategoria, Cn);
                CmInstCategoria.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstCategoria.Parameters.AddWithValue("@nombre", Objcategoria.Nombre);
                CmInstCategoria.Parameters.AddWithValue("@idcategoria", Objcategoria.Idcategoria);
                int intRespuesta = CmInstCategoria.ExecuteNonQuery();
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
