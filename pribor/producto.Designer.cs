namespace pribor
{
    partial class producto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombrePr = new System.Windows.Forms.MaskedTextBox();
            this.PrecioSug = new System.Windows.Forms.MaskedTextBox();
            this.Stock = new System.Windows.Forms.MaskedTextBox();
            this.Medida = new System.Windows.Forms.MaskedTextBox();
            this.EstadoProd = new System.Windows.Forms.ComboBox();
            this.Marca = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CampoMarcaa = new System.Windows.Forms.ComboBox();
            this.CampoPresentacion = new System.Windows.Forms.ComboBox();
            this.CampoUnidadM = new System.Windows.Forms.ComboBox();
            this.CampoCategoria = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CampoCM = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertarProducto = new System.Windows.Forms.Button();
            this.ListarProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ModificarProductoo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio sugerido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estado";
            // 
            // NombrePr
            // 
            this.NombrePr.Location = new System.Drawing.Point(132, 25);
            this.NombrePr.Name = "NombrePr";
            this.NombrePr.Size = new System.Drawing.Size(100, 20);
            this.NombrePr.TabIndex = 5;
            // 
            // PrecioSug
            // 
            this.PrecioSug.Location = new System.Drawing.Point(132, 71);
            this.PrecioSug.Name = "PrecioSug";
            this.PrecioSug.Size = new System.Drawing.Size(100, 20);
            this.PrecioSug.TabIndex = 6;
            // 
            // Stock
            // 
            this.Stock.Location = new System.Drawing.Point(443, 34);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(100, 20);
            this.Stock.TabIndex = 7;
            this.Stock.Text = "0";
            // 
            // Medida
            // 
            this.Medida.Location = new System.Drawing.Point(443, 76);
            this.Medida.Name = "Medida";
            this.Medida.Size = new System.Drawing.Size(100, 20);
            this.Medida.TabIndex = 8;
            // 
            // EstadoProd
            // 
            this.EstadoProd.FormattingEnabled = true;
            this.EstadoProd.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.EstadoProd.Location = new System.Drawing.Point(123, 309);
            this.EstadoProd.Name = "EstadoProd";
            this.EstadoProd.Size = new System.Drawing.Size(121, 21);
            this.EstadoProd.TabIndex = 9;
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(5, 27);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(37, 13);
            this.Marca.TabIndex = 10;
            this.Marca.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Presentacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Unidad de medida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Categoria";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // CampoMarcaa
            // 
            this.CampoMarcaa.FormattingEnabled = true;
            this.CampoMarcaa.Location = new System.Drawing.Point(111, 24);
            this.CampoMarcaa.Name = "CampoMarcaa";
            this.CampoMarcaa.Size = new System.Drawing.Size(121, 21);
            this.CampoMarcaa.TabIndex = 18;
            // 
            // CampoPresentacion
            // 
            this.CampoPresentacion.FormattingEnabled = true;
            this.CampoPresentacion.Location = new System.Drawing.Point(123, 233);
            this.CampoPresentacion.Name = "CampoPresentacion";
            this.CampoPresentacion.Size = new System.Drawing.Size(121, 21);
            this.CampoPresentacion.TabIndex = 19;
            // 
            // CampoUnidadM
            // 
            this.CampoUnidadM.FormattingEnabled = true;
            this.CampoUnidadM.Location = new System.Drawing.Point(422, 27);
            this.CampoUnidadM.Name = "CampoUnidadM";
            this.CampoUnidadM.Size = new System.Drawing.Size(121, 21);
            this.CampoUnidadM.TabIndex = 20;
            // 
            // CampoCategoria
            // 
            this.CampoCategoria.FormattingEnabled = true;
            this.CampoCategoria.Location = new System.Drawing.Point(434, 236);
            this.CampoCategoria.Name = "CampoCategoria";
            this.CampoCategoria.Size = new System.Drawing.Size(121, 21);
            this.CampoCategoria.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 150);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CampoCM);
            this.groupBox1.Controls.Add(this.PrecioSug);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NombrePr);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 154);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // CampoCM
            // 
            this.CampoCM.Location = new System.Drawing.Point(132, 122);
            this.CampoCM.Name = "CampoCM";
            this.CampoCM.Size = new System.Drawing.Size(100, 20);
            this.CampoCM.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.CampoUnidadM);
            this.groupBox2.Controls.Add(this.CampoMarcaa);
            this.groupBox2.Controls.Add(this.Marca);
            this.groupBox2.Location = new System.Drawing.Point(12, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 121);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // InsertarProducto
            // 
            this.InsertarProducto.Location = new System.Drawing.Point(596, 183);
            this.InsertarProducto.Name = "InsertarProducto";
            this.InsertarProducto.Size = new System.Drawing.Size(75, 23);
            this.InsertarProducto.TabIndex = 25;
            this.InsertarProducto.Text = "Insertar";
            this.InsertarProducto.UseVisualStyleBackColor = true;
            this.InsertarProducto.Click += new System.EventHandler(this.InsertarProducto_Click);
            // 
            // ListarProducto
            // 
            this.ListarProducto.Location = new System.Drawing.Point(596, 212);
            this.ListarProducto.Name = "ListarProducto";
            this.ListarProducto.Size = new System.Drawing.Size(75, 23);
            this.ListarProducto.TabIndex = 26;
            this.ListarProducto.Text = "Listar";
            this.ListarProducto.UseVisualStyleBackColor = true;
            this.ListarProducto.Click += new System.EventHandler(this.ListarProducto_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Cantidad de medida";
            // 
            // ModificarProductoo
            // 
            this.ModificarProductoo.Location = new System.Drawing.Point(596, 241);
            this.ModificarProductoo.Name = "ModificarProductoo";
            this.ModificarProductoo.Size = new System.Drawing.Size(75, 23);
            this.ModificarProductoo.TabIndex = 27;
            this.ModificarProductoo.Text = "Modificar";
            this.ModificarProductoo.UseVisualStyleBackColor = true;
            this.ModificarProductoo.Click += new System.EventHandler(this.ModificarProductoo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "Nuevos registros";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ModificarProductoo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ListarProducto);
            this.Controls.Add(this.InsertarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CampoCategoria);
            this.Controls.Add(this.CampoPresentacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EstadoProd);
            this.Controls.Add(this.Medida);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "producto";
            this.Text = "producto";
            this.Load += new System.EventHandler(this.producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox NombrePr;
        private System.Windows.Forms.MaskedTextBox PrecioSug;
        private System.Windows.Forms.MaskedTextBox Stock;
        private System.Windows.Forms.MaskedTextBox Medida;
        private System.Windows.Forms.ComboBox EstadoProd;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CampoMarcaa;
        private System.Windows.Forms.ComboBox CampoPresentacion;
        private System.Windows.Forms.ComboBox CampoUnidadM;
        private System.Windows.Forms.ComboBox CampoCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button InsertarProducto;
        private System.Windows.Forms.Button ListarProducto;
        private System.Windows.Forms.MaskedTextBox CampoCM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ModificarProductoo;
        private System.Windows.Forms.Button button1;
    }
}