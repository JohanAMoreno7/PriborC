using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
   public class CPresentacion
    {
        private int idpresentacion;
        private string nombre;

        public int Idpresentacion { get => idpresentacion; set => idpresentacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
