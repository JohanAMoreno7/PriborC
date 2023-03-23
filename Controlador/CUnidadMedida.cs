using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CUnidadMedida
    {
        private int idunidadmedida;
        private string nombre;

        public int Idunidadmedida { get => idunidadmedida; set => idunidadmedida = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
