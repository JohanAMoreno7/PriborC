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
    public partial class producto : Form
    {
        Controlador.CCategoria objc = new Controlador.CCategoria();
        Logica.LCategoria objLc = new Logica.LCategoria();


        Controlador.CPresentacion objclp = new Controlador.CPresentacion();
        Logica.LPresetacion objcLP = new Logica.LPresetacion();

        Controlador.CUnidadMedida Unic = new Controlador.CUnidadMedida();
        Logica.LUnidadMedida Uniq = new Logica.LUnidadMedida();

        Controlador.CMarca Marc = new Controlador.CMarca();
        Logica.LMarca Marq = new Logica.LMarca();

        Controlador.CProducto objp = new Controlador.CProducto();
        Logica.LProducto objLp = new Logica.LProducto();

        public int valor;

        public producto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void producto_Load(object sender, EventArgs e)
        {
            CampoMarcaa.ValueMember = "idmarca";
            CampoMarcaa.DisplayMember = "nombre";
            CampoMarcaa.DataSource = Marq.MostrarM();

            CampoCategoria.ValueMember = "idcategoria";
            CampoCategoria.DisplayMember = "nombre";
            CampoCategoria.DataSource = objLc.Mostrar_Categoria();

            CampoPresentacion.ValueMember = "idpresentaciones";
            CampoPresentacion.DisplayMember = "nombre";
            CampoPresentacion.DataSource = objcLP.Mostrar_Presentacion();

            CampoUnidadM.ValueMember = "idunidaddemedida";
            CampoUnidadM.DisplayMember = "nombre";
            CampoUnidadM.DataSource = Uniq.MostrarUnidadn();



        }


        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            CampoUnidadM.Text = Convert.ToString(fila.Cells["idunidaddemedida"].Value);
            CampoPresentacion.Text = Convert.ToString(fila.Cells["idpresentaciones"].Value);
            CampoMarcaa.Text = Convert.ToString(fila.Cells["idmarca"].Value);
            CampoCategoria.Text = Convert.ToString(fila.Cells["idcategoria"].Value);
            EstadoProd.Text = Convert.ToString(fila.Cells["estado"].Value);
            PrecioSug.Text = Convert.ToString(fila.Cells["preciosugerido"].Value);
            Medida.Text = Convert.ToString(fila.Cells["medida"].Value);
            Stock.Text = Convert.ToString(fila.Cells["stock"].Value);
            CampoCM.Text = Convert.ToString(fila.Cells["cantidadmedida"].Value);
            NombrePr.Text = Convert.ToString(fila.Cells["nombre"].Value);
            valor = Convert.ToInt32(fila.Cells["idproducto"].Value);
        }

        private void InsertarProducto_Click(object sender, EventArgs e)
        {
           

            
            objp.Nombrep = NombrePr.Text;
            objp.Preciosugerido= int.Parse(PrecioSug.Text);
            objp.Stock = int.Parse(Stock.Text);
            objp.Cantidadmedida = int.Parse(CampoCM.Text);
            objp.Medida= int.Parse(Medida.Text);
            objp.Estado = EstadoProd.Text;
            objp.Idmarca = Convert.ToInt16(CampoMarcaa.SelectedValue);
            objp.Idpresentacion = Convert.ToInt16(CampoPresentacion.SelectedValue);
            objp.Idcategoria = Convert.ToInt16(CampoCategoria.SelectedValue);
            objp.IdunidadMedida = Convert.ToInt16(CampoUnidadM.SelectedValue);



            if (objLp.insertarProducto(objp))
            {
                MessageBox.Show("Ha ingresando correctamente");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }

        }

        private void ListarProducto_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (objLp.MostrarProducto());
        }

        private void ModificarProductoo_Click(object sender, EventArgs e)
        {

        }
    }
    }

