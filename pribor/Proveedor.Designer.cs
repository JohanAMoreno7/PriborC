namespace pribor
{
    partial class Proveedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CampoEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CampoDireccion = new System.Windows.Forms.MaskedTextBox();
            this.CampoTelefono = new System.Windows.Forms.MaskedTextBox();
            this.CampoJuridico = new System.Windows.Forms.MaskedTextBox();
            this.CampoNatural = new System.Windows.Forms.MaskedTextBox();
            this.CampoResponsable = new System.Windows.Forms.MaskedTextBox();
            this.CampoNit = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1Pro = new System.Windows.Forms.DataGridView();
            this.InsertarProve = new System.Windows.Forms.Button();
            this.MostrarProve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Pro)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CampoEstado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.CampoDireccion);
            this.groupBox1.Controls.Add(this.CampoTelefono);
            this.groupBox1.Controls.Add(this.CampoJuridico);
            this.groupBox1.Controls.Add(this.CampoNatural);
            this.groupBox1.Controls.Add(this.CampoResponsable);
            this.groupBox1.Controls.Add(this.CampoNit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CampoEstado
            // 
            this.CampoEstado.FormattingEnabled = true;
            this.CampoEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CampoEstado.Location = new System.Drawing.Point(109, 156);
            this.CampoEstado.Name = "CampoEstado";
            this.CampoEstado.Size = new System.Drawing.Size(100, 21);
            this.CampoEstado.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Estado";
            // 
            // CampoDireccion
            // 
            this.CampoDireccion.Location = new System.Drawing.Point(109, 114);
            this.CampoDireccion.Name = "CampoDireccion";
            this.CampoDireccion.Size = new System.Drawing.Size(100, 20);
            this.CampoDireccion.TabIndex = 10;
            // 
            // CampoTelefono
            // 
            this.CampoTelefono.Location = new System.Drawing.Point(362, 114);
            this.CampoTelefono.Name = "CampoTelefono";
            this.CampoTelefono.Size = new System.Drawing.Size(100, 20);
            this.CampoTelefono.TabIndex = 9;
            // 
            // CampoJuridico
            // 
            this.CampoJuridico.Location = new System.Drawing.Point(362, 71);
            this.CampoJuridico.Name = "CampoJuridico";
            this.CampoJuridico.Size = new System.Drawing.Size(100, 20);
            this.CampoJuridico.TabIndex = 8;
            // 
            // CampoNatural
            // 
            this.CampoNatural.Location = new System.Drawing.Point(362, 30);
            this.CampoNatural.Name = "CampoNatural";
            this.CampoNatural.Size = new System.Drawing.Size(100, 20);
            this.CampoNatural.TabIndex = 7;
            // 
            // CampoResponsable
            // 
            this.CampoResponsable.Location = new System.Drawing.Point(109, 74);
            this.CampoResponsable.Name = "CampoResponsable";
            this.CampoResponsable.Size = new System.Drawing.Size(100, 20);
            this.CampoResponsable.TabIndex = 6;
            // 
            // CampoNit
            // 
            this.CampoNit.Location = new System.Drawing.Point(109, 33);
            this.CampoNit.Name = "CampoNit";
            this.CampoNit.Size = new System.Drawing.Size(100, 20);
            this.CampoNit.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Resonsable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Persona Juridica";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Persona natural";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nit";
            // 
            // dataGridView1Pro
            // 
            this.dataGridView1Pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1Pro.Location = new System.Drawing.Point(21, 238);
            this.dataGridView1Pro.Name = "dataGridView1Pro";
            this.dataGridView1Pro.Size = new System.Drawing.Size(584, 150);
            this.dataGridView1Pro.TabIndex = 11;
            // 
            // InsertarProve
            // 
            this.InsertarProve.Location = new System.Drawing.Point(553, 69);
            this.InsertarProve.Name = "InsertarProve";
            this.InsertarProve.Size = new System.Drawing.Size(75, 23);
            this.InsertarProve.TabIndex = 12;
            this.InsertarProve.Text = "Insertar";
            this.InsertarProve.UseVisualStyleBackColor = true;
            this.InsertarProve.Click += new System.EventHandler(this.InsertarProve_Click);
            // 
            // MostrarProve
            // 
            this.MostrarProve.Location = new System.Drawing.Point(553, 110);
            this.MostrarProve.Name = "MostrarProve";
            this.MostrarProve.Size = new System.Drawing.Size(75, 23);
            this.MostrarProve.TabIndex = 13;
            this.MostrarProve.Text = "Mostrar";
            this.MostrarProve.UseVisualStyleBackColor = true;
            this.MostrarProve.Click += new System.EventHandler(this.MostrarProve_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 424);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MostrarProve);
            this.Controls.Add(this.InsertarProve);
            this.Controls.Add(this.dataGridView1Pro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1Pro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox CampoDireccion;
        private System.Windows.Forms.MaskedTextBox CampoTelefono;
        private System.Windows.Forms.MaskedTextBox CampoJuridico;
        private System.Windows.Forms.MaskedTextBox CampoNatural;
        private System.Windows.Forms.MaskedTextBox CampoResponsable;
        private System.Windows.Forms.MaskedTextBox CampoNit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1Pro;
        private System.Windows.Forms.Button InsertarProve;
        private System.Windows.Forms.Button MostrarProve;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CampoEstado;
        private System.Windows.Forms.Button button1;
    }
}