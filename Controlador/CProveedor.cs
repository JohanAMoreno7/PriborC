using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CProveedor
    {
        private int idproveedor;
        private string personaJuridica;
        private string personaNatural;
        private int nit;
        private string direccion;
        private int telefono;
        private string responsable;
        private string estado;

        public int Idproveedor { get => idproveedor; set => idproveedor = value; }
        public string PersonaJuridica { get => personaJuridica; set => personaJuridica = value; }
        public int Nit { get => nit; set => nit = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Responsable { get => responsable; set => responsable = value; }
        public string Estado { get => estado; set => estado = value; }
        public string PersonaNatural { get => personaNatural; set => personaNatural = value; }
    }
}
