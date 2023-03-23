using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class CProducto
    {
        private int idproducto;
        private string nombrep;
        private int stock;
        private int cantidadmedida;
        private int preciosugerido;
        private int medida;
        private string estado;
        private int idpresentacion;
        private int idunidadMedida;
        private int idmarca;
        private int idcategoria;

        public int Idproducto { get => idproducto; set => idproducto = value; }
        public string Nombrep { get => nombrep; set => nombrep = value; }
        public int Cantidadmedida { get => cantidadmedida; set => cantidadmedida = value; }
        public int Preciosugerido { get => preciosugerido; set => preciosugerido = value; }
        public int Medida { get => medida; set => medida = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Idpresentacion { get => idpresentacion; set => idpresentacion = value; }
        public int IdunidadMedida { get => idunidadMedida; set => idunidadMedida = value; }
        public int Idmarca { get => idmarca; set => idmarca = value; }
        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
