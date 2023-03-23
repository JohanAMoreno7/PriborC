using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using Modelo;


namespace Logica
{
    public class LProveedor
    {
        Modelo.Proveedor objproveedor = new Modelo.Proveedor();

        public bool insertar(Controlador.CProveedor objc)
        {
            return objproveedor.Registrar_Proveedor(objc);
        }

        public DataTable Mostrar_Proveedor()
        {
            return objproveedor.MostrarProveedor();
        }



    }
}
