using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Controlador;

namespace pribor
{
    public partial class Form1 : Form
    {

        public int valor;
        public int valorp;
        public int valoru;
        public int valorm;


        Controlador.CCategoria objc = new Controlador.CCategoria();
        Logica.LCategoria objLc = new Logica.LCategoria();
      

        Controlador.CPresentacion objclp = new Controlador.CPresentacion();
        Logica.LPresetacion objcLP = new Logica.LPresetacion();

        Controlador.CUnidadMedida Unic = new Controlador.CUnidadMedida();
        Logica.LUnidadMedida Uniq = new Logica.LUnidadMedida();

        Controlador.CMarca Marc = new Controlador.CMarca();
        Logica.LMarca Marq = new Logica.LMarca();



        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            objc.Nombre = text_nombre.Text;
            if (objLc.insertar(objc))
            {
                MessageBox.Show("Ha ingresando correctamente");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void InsertarP_Click(object sender, EventArgs e)
        {
            objclp.Nombre = CampoP.Text;
            if (objcLP.insertarp(objclp))
            {
                MessageBox.Show("Ha ingresando correctamente");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }
        }

        private void BuscarC_Click(object sender, EventArgs e)
        {
            string valor =  text_nombre.Text;
            dataGridView1.DataSource = objLc.Consultar_Categoria(valor);
        }

        private void ListarC_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objLc.Mostrar_Categoria();
        }

        private void ModificarC_Click(object sender, EventArgs e)
        {
            {
                objc.Idcategoria = valor;
                objc.Nombre = text_nombre.Text;
                if (objLc.modicarCategoria(objc))
                {

                    limpiar();
                    dataGridView1.DataSource = objLc.Mostrar_Categoria();
                    MessageBox.Show("Ha modificado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }

          

        }
        public void limpiar()
        {

            text_nombre.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            text_nombre.Text = Convert.ToString(fila.Cells["nombre"].Value);
            valor= Convert.ToInt32(fila.Cells["idcategoria"].Value);

        }

        private void BuscarP_Click(object sender, EventArgs e)
        {

            string valor =CampoP.Text;
            dataGridViewPre.DataSource = objcLP.Consultar_Presentacion(valor);

        }

        private void ListarP_Click(object sender, EventArgs e)
        {

            dataGridViewPre.DataSource = objcLP.Mostrar_Presentacion();

        }


       

        private void dataGridViewPre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridViewPre.Rows[e.RowIndex];
            CampoP.Text = Convert.ToString(fila.Cells["nombre"].Value);
            valorp = Convert.ToInt32(fila.Cells["idpresentaciones"].Value);
        }

        private void ModificarP_Click(object sender, EventArgs e)
        {
            {
                objclp.Idpresentacion = valorp;
                objclp.Nombre = CampoP.Text;
                if (objcLP.ModificarPre(objclp))
                {

                    limpiar();
                    dataGridViewPre.DataSource = objcLP.Mostrar_Presentacion();
                    MessageBox.Show("Ha modificado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al modificar");
                }
            }

        }

        private void InsertarU_Click(object sender, EventArgs e)
        {

            Unic.Nombre = CampoU.Text;
            if (Uniq.insertarU(Unic))
            {
                MessageBox.Show("Ha ingresando correctamente");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }

        }

        private void ListarU_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = Uniq.MostrarUnidadn();
        }

        private void BuscarU_Click(object sender, EventArgs e)
        {

            string valor = CampoU.Text;
            dataGridView5.DataSource = Uniq.ConsultarUnidad(valor);

        }

        private void ModificarU_Click(object sender, EventArgs e)
        {

            Unic.Idunidadmedida = valoru;
            Unic.Nombre = CampoU.Text;
            if (Uniq.ModificarUnidad(Unic))
            {

                limpiar();
                dataGridView5.DataSource = Uniq.MostrarUnidadn();
                MessageBox.Show("Ha modificado correctamente");

            }
            else
            {
                MessageBox.Show("Error al modificar");
            }
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView5.Rows[e.RowIndex];
            CampoU.Text = Convert.ToString(fila.Cells["nombre"].Value);
            valoru = Convert.ToInt32(fila.Cells["idunidaddemedida"].Value);
        }

        private void InsertarMA_Click(object sender, EventArgs e)
        {

            Marc.Descripcion = CampoM.Text;
            if (Marq.insertarM(Marc))
            {
                MessageBox.Show("Ha ingresando correctamente");
            }
            else
            {
                MessageBox.Show("Error al ingresar");
            }

        }

        private void BuscarMA_Click(object sender, EventArgs e)
        {
            string valor = CampoM.Text;
            dataGridView6.DataSource = Marq.ConsultarM(valor);
        }

        private void ModificarMA_Click(object sender, EventArgs e)
        {
            Marc.Idmarca = valorm;
            Marc.Descripcion = CampoM.Text;
            if (Marq.ModificarM(Marc))
            {

                limpiar();
                dataGridView6.DataSource = Marq.MostrarM();
                MessageBox.Show("Ha modificado correctamente");

            }
            else
            {
                MessageBox.Show("Error al modificar");
            }
        }

        private void ListarMA_Click(object sender, EventArgs e)
        {
            dataGridView6.DataSource = Marq.MostrarM();
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView6.Rows[e.RowIndex];
            CampoM.Text = Convert.ToString(fila.Cells["nombre"].Value);
            valorm = Convert.ToInt32(fila.Cells["idmarca"].Value);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
    

