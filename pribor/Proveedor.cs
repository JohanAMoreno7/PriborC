using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pribor
{
    public partial class Proveedor : Form
    {
        Logica.LProveedor ObjPR = new Logica.LProveedor();
        Controlador.CProveedor ObjPRr = new Controlador.CProveedor();



        public Proveedor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void InsertarProve_Click(object sender, EventArgs e)
        {
            ObjPRr.Nit = int.Parse(CampoNit.Text);
            ObjPRr.PersonaJuridica = CampoJuridico.Text;
            ObjPRr.PersonaNatural = CampoNatural.Text;
            ObjPRr.Direccion = CampoDireccion.Text;
            ObjPRr.Telefono = int.Parse(CampoTelefono.Text);
            ObjPRr.Responsable = CampoResponsable.Text;
            ObjPRr.Estado = CampoEstado.Text;
            


            if (ObjPR.insertar(ObjPRr))
            {
                MessageBox.Show("Ha ingresando correctamente");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }

        }

        private void MostrarProve_Click(object sender, EventArgs e)
        {
            dataGridView1Pro.DataSource = (ObjPR.Mostrar_Proveedor());
        }
    }
}
