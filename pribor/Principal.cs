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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            producto producto = new producto();
            producto.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proveedor proveedorr = new Proveedor();
            proveedorr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Compra compraa = new Compra();
            compraa.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
