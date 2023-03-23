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
    public class LUnidadMedida
    {
        Modelo.UnidadMedida objunidadmedida = new Modelo.UnidadMedida();

        public bool insertarU(Controlador.CUnidadMedida Unic)
        {
            return objunidadmedida.Registrar_UnidadMedida(Unic);
        }
        public DataTable MostrarUnidadn()
        {
            return objunidadmedida.MostrarUnidad();
        }
        public DataTable ConsultarUnidad(string nombrE)
        {
            return objunidadmedida.ConsultarUnidad(nombrE);

        }

        public bool ModificarUnidad(Controlador.CUnidadMedida Unic)
        {
            return objunidadmedida.MofificarUnidad(Unic);
        }




    }
}
