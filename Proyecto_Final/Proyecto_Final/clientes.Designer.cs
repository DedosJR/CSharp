namespace Proyecto_Final
{
    partial class clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_limcre = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_dir = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_numclie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry3 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkGray;
            this.dataGridView1.Location = new System.Drawing.Point(12, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(860, 424);
            this.dataGridView1.TabIndex = 15;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(780, 88);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(100, 35);
            this.btn_salir.TabIndex = 32;
            this.btn_salir.Text = "Regresar";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar.Location = new System.Drawing.Point(662, 88);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(100, 35);
            this.btn_eliminar.TabIndex = 31;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.ForeColor = System.Drawing.Color.Black;
            this.btn_actualizar.Location = new System.Drawing.Point(137, 88);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(100, 35);
            this.btn_actualizar.TabIndex = 30;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Location = new System.Drawing.Point(15, 88);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(100, 35);
            this.btn_agregar.TabIndex = 29;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(515, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Limite de crédito :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(387, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Teléfono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(257, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(143, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Num de cliente:";
            // 
            // txt_limcre
            // 
            this.txt_limcre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_limcre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_limcre.ForeColor = System.Drawing.Color.Black;
            this.txt_limcre.Location = new System.Drawing.Point(506, 42);
            this.txt_limcre.Multiline = true;
            this.txt_limcre.Name = "txt_limcre";
            this.txt_limcre.Size = new System.Drawing.Size(150, 25);
            this.txt_limcre.TabIndex = 23;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_tel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tel.ForeColor = System.Drawing.Color.Black;
            this.txt_tel.Location = new System.Drawing.Point(380, 42);
            this.txt_tel.Multiline = true;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(120, 25);
            this.txt_tel.TabIndex = 22;
            // 
            // txt_dir
            // 
            this.txt_dir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_dir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dir.ForeColor = System.Drawing.Color.Black;
            this.txt_dir.Location = new System.Drawing.Point(250, 42);
            this.txt_dir.Multiline = true;
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.Size = new System.Drawing.Size(124, 25);
            this.txt_dir.TabIndex = 21;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nombre.ForeColor = System.Drawing.Color.Black;
            this.txt_nombre.Location = new System.Drawing.Point(137, 42);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(107, 25);
            this.txt_nombre.TabIndex = 20;
            // 
            // txt_numclie
            // 
            this.txt_numclie.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_numclie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_numclie.ForeColor = System.Drawing.Color.Black;
            this.txt_numclie.Location = new System.Drawing.Point(12, 42);
            this.txt_numclie.Multiline = true;
            this.txt_numclie.Name = "txt_numclie";
            this.txt_numclie.Size = new System.Drawing.Size(119, 25);
            this.txt_numclie.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(668, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Correo :";
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.Location = new System.Drawing.Point(662, 42);
            this.txt_correo.Multiline = true;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(107, 25);
            this.txt_correo.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(781, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 37;
            this.label7.Text = "RFC:";
            // 
            // txt_rfc
            // 
            this.txt_rfc.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_rfc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_rfc.ForeColor = System.Drawing.Color.Black;
            this.txt_rfc.Location = new System.Drawing.Point(773, 42);
            this.txt_rfc.Multiline = true;
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.Size = new System.Drawing.Size(107, 25);
            this.txt_rfc.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(184, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 18);
            this.label8.TabIndex = 39;
            this.label8.Text = "Buscar:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_buscar.ForeColor = System.Drawing.Color.Black;
            this.txt_buscar.Location = new System.Drawing.Point(260, 131);
            this.txt_buscar.Multiline = true;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(375, 29);
            this.txt_buscar.TabIndex = 38;
            this.txt_buscar.TextChanged += new System.EventHandler(this.txt_buscar_TextChanged);
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rfc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_limcre);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_numclie);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "clientes";
            this.Load += new System.EventHandler(this.clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_limcre;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_dir;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_numclie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.DirectoryServices.DirectoryEntry directoryEntry3;
    }
}