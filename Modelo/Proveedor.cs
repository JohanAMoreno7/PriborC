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
    public class Proveedor
    {
        public bool Registrar_Proveedor(Controlador.CProveedor Objeproveedor)
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
                string strProveedor = "[dbo].[RegistrarProve]";
                //Establezco el tipo de conexion para el SqlCommand "CmInstCategoria"
                SqlCommand CmInstProveedor = new SqlCommand(strProveedor, Cn);
                CmInstProveedor.CommandType = System.Data.CommandType.StoredProcedure;
                CmInstProveedor.Parameters.AddWithValue("@personaJuridica", Objeproveedor.PersonaJuridica);
                CmInstProveedor.Parameters.AddWithValue("@personaNatural", Objeproveedor.PersonaNatural);
                CmInstProveedor.Parameters.AddWithValue("@nit", Objeproveedor.Nit);
                CmInstProveedor.Parameters.AddWithValue("@direccion", Objeproveedor.Direccion);
                CmInstProveedor.Parameters.AddWithValue("@telefono", Objeproveedor.Telefono);
                CmInstProveedor.Parameters.AddWithValue("@responsable", Objeproveedor.Responsable);
                CmInstProveedor.Parameters.AddWithValue("@estado", Objeproveedor.Estado);

                int intRespuesta = CmInstProveedor.ExecuteNonQuery();
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

        public DataTable MostrarProveedor()
        {
            DataTable dt = new DataTable();
            SqlConnection Cn = new SqlConnection();

            try
            {
                Conexion oMClsConexion = new Conexion();
                Cn = oMClsConexion.Conexionbd();
                Cn.Open();

                //Especifica el nombre del procedimiento almacenado
                string strCliente = "[dbo].[MostrarProveedor]";

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
    }
}
