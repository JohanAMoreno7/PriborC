using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class CTipoNovedad
    {
        private int idtipoNovedad;
        private string descripcion;

        public int IdtipoNovedad { get => idtipoNovedad; set => idtipoNovedad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
