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
    public class Producto
    {
        public bool RegistrarProducto(Controlador.CProducto obj)
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
                string strAtleta = "[dbo].[insertarProducto]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstP = new SqlCommand(strAtleta, Cn);
                CmInstP.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstP.Parameters.AddWithValue("@nombre", obj.Nombrep);
                CmInstP.Parameters.AddWithValue("@preciosugerido", obj.Preciosugerido);
                CmInstP.Parameters.AddWithValue("@stock", obj.Stock);
                CmInstP.Parameters.AddWithValue("@medida", obj.Medida);
                CmInstP.Parameters.AddWithValue("@estado", obj.Estado);
                CmInstP.Parameters.AddWithValue("@cantidadmedida", obj.Cantidadmedida);
                CmInstP.Parameters.AddWithValue("@idmarca", obj.Idmarca);
                CmInstP.Parameters.AddWithValue("@idpresentaciones", obj.Idpresentacion);
                CmInstP.Parameters.AddWithValue("@idcategoria", obj.Idcategoria);
                CmInstP.Parameters.AddWithValue("@idunidaddemedida", obj.IdunidadMedida);



                int intRespuesta = CmInstP.ExecuteNonQuery();
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

        public DataTable MostrarProducto()
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strCliente = "[dbo].[mostrarProductos]";

                SqlDataAdapter CmInstProducto= new SqlDataAdapter(strCliente, Cn);
                CmInstProducto.SelectCommand.CommandType = CommandType.StoredProcedure;
                CmInstProducto.Fill(dt);
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
    }
}
