using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Logica
{
    public class LProducto
    {
        Modelo.Producto objproducto = new Modelo.Producto();

        public bool insertarProducto(Controlador.CProducto objc)
        {
            return objproducto.RegistrarProducto(objc);
        }

        public DataTable MostrarProducto()
        {
            return objproducto.MostrarProducto();
        }
    }
}
