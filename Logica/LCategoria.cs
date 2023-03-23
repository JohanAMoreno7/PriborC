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
    public class LCategoria
    {
        Modelo.Categoria objcategoria = new Modelo.Categoria();
        Modelo.Presentacion ObjPresentacion = new Modelo.Presentacion();

        public bool insertar(Controlador.CCategoria objc) {
            return objcategoria.Registrar_Categoria(objc);
        }

        public DataTable Consultar_Categoria(string nombrE)
        {
            return objcategoria.Consultar_Categoria(nombrE);
        }

        public DataTable Mostrar_Categoria()
        {
            return objcategoria.Mostrar_Categoria();
        }

        public bool modicarCategoria(Controlador.CCategoria objc)
        {
            return objcategoria.Mofificar_Categoria(objc);
        }
    }
}
