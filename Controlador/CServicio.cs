using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CServicio
    {
        private int idservicio;
        private string descripcion;
        private string estado;

        public int Idservicio { get => idservicio; set => idservicio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
