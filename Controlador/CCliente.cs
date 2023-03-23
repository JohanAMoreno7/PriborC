using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CCliente
    {
        private int idcliente;
        private string nombre;
        private string apellido;
        private int telefono;

        public int Idcliente { get => idcliente; set => idcliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
