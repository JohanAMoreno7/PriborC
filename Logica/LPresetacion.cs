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
    public class LPresetacion
    {
        Modelo.Presentacion objpresentacion = new Modelo.Presentacion();

        public bool insertarp(Controlador.CPresentacion objclp)
        {
            return objpresentacion.Registrar_Presentacion(objclp);
        }
        public DataTable Consultar_Presentacion(string nombrE)
        {
            return objpresentacion.Consultar_Presentacion(nombrE);
        }
        public DataTable Mostrar_Presentacion()
        {
            return objpresentacion.Mostrar_Presentacion();
        }
        public bool ModificarPre(Controlador.CPresentacion objclp)
        {
            return objpresentacion.MofificarPre(objclp);
        }
    }
}
