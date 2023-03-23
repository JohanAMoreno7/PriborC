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
    public class LMarca
    {

        Modelo.Marca objmarca = new Modelo.Marca();

        public bool insertarM(Controlador.CMarca Marc)
        {
            return objmarca.Registrar_Marca(Marc);
        }
        public DataTable ConsultarM(string nombrE)
        {
            return objmarca.ConsultaM(nombrE);

        }

        public DataTable MostrarM()
        {
            return objmarca.MostrarM();
        }

        public bool ModificarM(Controlador.CMarca Marc)
        {
            return objmarca.ModificarM(Marc);
        }


    }
}
