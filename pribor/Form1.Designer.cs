namespace pribor
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ListarC = new System.Windows.Forms.Button();
            this.ModificarC = new System.Windows.Forms.Button();
            this.BuscarC = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewPre = new System.Windows.Forms.DataGridView();
            this.ListarP = new System.Windows.Forms.Button();
            this.ModificarP = new System.Windows.Forms.Button();
            this.BuscarP = new System.Windows.Forms.Button();
            this.InsertarP = new System.Windows.Forms.Button();
            this.CampoP = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ListarU = new System.Windows.Forms.Button();
            this.ModificarU = new System.Windows.Forms.Button();
            this.BuscarU = new System.Windows.Forms.Button();
            this.CampoU = new System.Windows.Forms.MaskedTextBox();
            this.InsertarU = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ListarMA = new System.Windows.Forms.Button();
            this.ModificarMA = new System.Windows.Forms.Button();
            this.BuscarMA = new System.Windows.Forms.Button();
            this.InsertarMA = new System.Windows.Forms.Button();
            this.CampoM = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPre)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(522, 449);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListarC);
            this.tabPage1.Controls.Add(this.ModificarC);
            this.tabPage1.Controls.Add(this.BuscarC);
            this.tabPage1.Controls.Add(this.btn_registrar);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.text_nombre);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(514, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categoria";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ListarC
            // 
            this.ListarC.Location = new System.Drawing.Point(417, 168);
            this.ListarC.Name = "ListarC";
            this.ListarC.Size = new System.Drawing.Size(91, 23);
            this.ListarC.TabIndex = 8;
            this.ListarC.Text = "Listar";
            this.ListarC.UseVisualStyleBackColor = true;
            this.ListarC.Click += new System.EventHandler(this.ListarC_Click);
            // 
            // ModificarC
            // 
            this.ModificarC.Location = new System.Drawing.Point(417, 139);
            this.ModificarC.Name = "ModificarC";
            this.ModificarC.Size = new System.Drawing.Size(91, 23);
            this.ModificarC.TabIndex = 7;
            this.ModificarC.Text = "Modificar";
            this.ModificarC.UseVisualStyleBackColor = true;
            this.ModificarC.Click += new System.EventHandler(this.ModificarC_Click);
            // 
            // BuscarC
            // 
            this.BuscarC.Location = new System.Drawing.Point(417, 109);
            this.BuscarC.Name = "BuscarC";
            this.BuscarC.Size = new System.Drawing.Size(91, 23);
            this.BuscarC.TabIndex = 6;
            this.BuscarC.Text = "Buscar";
            this.BuscarC.UseVisualStyleBackColor = true;
            this.BuscarC.Click += new System.EventHandler(this.BuscarC_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(417, 80);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(91, 23);
            this.btn_registrar.TabIndex = 5;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(376, 187);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(214, 28);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(137, 20);
            this.text_nombre.TabIndex = 3;
            this.text_nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion de la categoria";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewPre);
            this.tabPage2.Controls.Add(this.ListarP);
            this.tabPage2.Controls.Add(this.ModificarP);
            this.tabPage2.Controls.Add(this.BuscarP);
            this.tabPage2.Controls.Add(this.InsertarP);
            this.tabPage2.Controls.Add(this.CampoP);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Presetacion";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPre
            // 
            this.dataGridViewPre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPre.Location = new System.Drawing.Point(20, 84);
            this.dataGridViewPre.Name = "dataGridViewPre";
            this.dataGridViewPre.Size = new System.Drawing.Size(376, 211);
            this.dataGridViewPre.TabIndex = 7;
            this.dataGridViewPre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPre_CellContentClick);
            // 
            // ListarP
            // 
            this.ListarP.Location = new System.Drawing.Point(416, 183);
            this.ListarP.Name = "ListarP";
            this.ListarP.Size = new System.Drawing.Size(86, 23);
            this.ListarP.TabIndex = 6;
            this.ListarP.Text = "Listar";
            this.ListarP.UseVisualStyleBackColor = true;
            this.ListarP.Click += new System.EventHandler(this.ListarP_Click);
            // 
            // ModificarP
            // 
            this.ModificarP.Location = new System.Drawing.Point(416, 154);
            this.ModificarP.Name = "ModificarP";
            this.ModificarP.Size = new System.Drawing.Size(86, 23);
            this.ModificarP.TabIndex = 5;
            this.ModificarP.Text = "Modificar";
            this.ModificarP.UseVisualStyleBackColor = true;
            this.ModificarP.Click += new System.EventHandler(this.ModificarP_Click);
            // 
            // BuscarP
            // 
            this.BuscarP.Location = new System.Drawing.Point(416, 125);
            this.BuscarP.Name = "BuscarP";
            this.BuscarP.Size = new System.Drawing.Size(86, 23);
            this.BuscarP.TabIndex = 4;
            this.BuscarP.Text = "Buscar";
            this.BuscarP.UseVisualStyleBackColor = true;
            this.BuscarP.Click += new System.EventHandler(this.BuscarP_Click);
            // 
            // InsertarP
            // 
            this.InsertarP.Location = new System.Drawing.Point(416, 96);
            this.InsertarP.Name = "InsertarP";
            this.InsertarP.Size = new System.Drawing.Size(86, 23);
            this.InsertarP.TabIndex = 3;
            this.InsertarP.Text = "Registrar";
            this.InsertarP.UseVisualStyleBackColor = true;
            this.InsertarP.Click += new System.EventHandler(this.InsertarP_Click);
            // 
            // CampoP
            // 
            this.CampoP.Location = new System.Drawing.Point(228, 41);
            this.CampoP.Name = "CampoP";
            this.CampoP.Size = new System.Drawing.Size(130, 20);
            this.CampoP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion de la pesentacion";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ListarU);
            this.tabPage5.Controls.Add(this.ModificarU);
            this.tabPage5.Controls.Add(this.BuscarU);
            this.tabPage5.Controls.Add(this.CampoU);
            this.tabPage5.Controls.Add(this.InsertarU);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(514, 423);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "UnidadMedida";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ListarU
            // 
            this.ListarU.Location = new System.Drawing.Point(415, 174);
            this.ListarU.Name = "ListarU";
            this.ListarU.Size = new System.Drawing.Size(75, 23);
            this.ListarU.TabIndex = 6;
            this.ListarU.Text = "Listar";
            this.ListarU.UseVisualStyleBackColor = true;
            this.ListarU.Click += new System.EventHandler(this.ListarU_Click);
            // 
            // ModificarU
            // 
            this.ModificarU.Location = new System.Drawing.Point(415, 145);
            this.ModificarU.Name = "ModificarU";
            this.ModificarU.Size = new System.Drawing.Size(75, 23);
            this.ModificarU.TabIndex = 5;
            this.ModificarU.Text = "Modificar";
            this.ModificarU.UseVisualStyleBackColor = true;
            this.ModificarU.Click += new System.EventHandler(this.ModificarU_Click);
            // 
            // BuscarU
            // 
            this.BuscarU.Location = new System.Drawing.Point(415, 116);
            this.BuscarU.Name = "BuscarU";
            this.BuscarU.Size = new System.Drawing.Size(75, 23);
            this.BuscarU.TabIndex = 4;
            this.BuscarU.Text = "Buscar";
            this.BuscarU.UseVisualStyleBackColor = true;
            this.BuscarU.Click += new System.EventHandler(this.BuscarU_Click);
            // 
            // CampoU
            // 
            this.CampoU.Location = new System.Drawing.Point(233, 28);
            this.CampoU.Name = "CampoU";
            this.CampoU.Size = new System.Drawing.Size(136, 20);
            this.CampoU.TabIndex = 3;
            // 
            // InsertarU
            // 
            this.InsertarU.Location = new System.Drawing.Point(415, 87);
            this.InsertarU.Name = "InsertarU";
            this.InsertarU.Size = new System.Drawing.Size(75, 23);
            this.InsertarU.TabIndex = 2;
            this.InsertarU.Text = "Registrar";
            this.InsertarU.UseVisualStyleBackColor = true;
            this.InsertarU.Click += new System.EventHandler(this.InsertarU_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Descripciom de la unidad de medida";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(28, 87);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(360, 169);
            this.dataGridView5.TabIndex = 0;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ListarMA);
            this.tabPage6.Controls.Add(this.ModificarMA);
            this.tabPage6.Controls.Add(this.BuscarMA);
            this.tabPage6.Controls.Add(this.InsertarMA);
            this.tabPage6.Controls.Add(this.CampoM);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(514, 423);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Marca";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ListarMA
            // 
            this.ListarMA.Location = new System.Drawing.Point(413, 192);
            this.ListarMA.Name = "ListarMA";
            this.ListarMA.Size = new System.Drawing.Size(75, 23);
            this.ListarMA.TabIndex = 6;
            this.ListarMA.Text = "Listar";
            this.ListarMA.UseVisualStyleBackColor = true;
            this.ListarMA.Click += new System.EventHandler(this.ListarMA_Click);
            // 
            // ModificarMA
            // 
            this.ModificarMA.Location = new System.Drawing.Point(413, 163);
            this.ModificarMA.Name = "ModificarMA";
            this.ModificarMA.Size = new System.Drawing.Size(75, 23);
            this.ModificarMA.TabIndex = 5;
            this.ModificarMA.Text = "Modificar";
            this.ModificarMA.UseVisualStyleBackColor = true;
            this.ModificarMA.Click += new System.EventHandler(this.ModificarMA_Click);
            // 
            // BuscarMA
            // 
            this.BuscarMA.Location = new System.Drawing.Point(413, 134);
            this.BuscarMA.Name = "BuscarMA";
            this.BuscarMA.Size = new System.Drawing.Size(75, 23);
            this.BuscarMA.TabIndex = 4;
            this.BuscarMA.Text = "Buscar";
            this.BuscarMA.UseVisualStyleBackColor = true;
            this.BuscarMA.Click += new System.EventHandler(this.BuscarMA_Click);
            // 
            // InsertarMA
            // 
            this.InsertarMA.Location = new System.Drawing.Point(413, 105);
            this.InsertarMA.Name = "InsertarMA";
            this.InsertarMA.Size = new System.Drawing.Size(75, 23);
            this.InsertarMA.TabIndex = 3;
            this.InsertarMA.Text = "Registrar";
            this.InsertarMA.UseVisualStyleBackColor = true;
            this.InsertarMA.Click += new System.EventHandler(this.InsertarMA_Click);
            // 
            // CampoM
            // 
            this.CampoM.Location = new System.Drawing.Point(205, 41);
            this.CampoM.Name = "CampoM";
            this.CampoM.Size = new System.Drawing.Size(139, 20);
            this.CampoM.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripcion de la marca";
            // 
            // dataGridView6
            // 
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(19, 105);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(369, 145);
            this.dataGridView6.TabIndex = 0;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 329);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPre)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InsertarP;
        private System.Windows.Forms.MaskedTextBox CampoP;
        private System.Windows.Forms.MaskedTextBox CampoU;
        private System.Windows.Forms.Button InsertarU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button InsertarMA;
        private System.Windows.Forms.MaskedTextBox CampoM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Button ListarC;
        private System.Windows.Forms.Button ModificarC;
        private System.Windows.Forms.Button BuscarC;
        private System.Windows.Forms.Button ListarP;
        private System.Windows.Forms.Button ModificarP;
        private System.Windows.Forms.Button BuscarP;
        private System.Windows.Forms.Button ListarU;
        private System.Windows.Forms.Button ModificarU;
        private System.Windows.Forms.Button BuscarU;
        private System.Windows.Forms.Button ListarMA;
        private System.Windows.Forms.Button ModificarMA;
        private System.Windows.Forms.Button BuscarMA;
        private System.Windows.Forms.DataGridView dataGridViewPre;
    }
}

