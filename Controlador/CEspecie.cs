using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class CEspecie
    {
        private int idespecie;
        private string descripcion;

        public int Idespecie { get => idespecie; set => idespecie = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
