using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CMarca
    {
        private int idmarca;
        private string descripcion;

        public int Idmarca { get => idmarca; set => idmarca = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
