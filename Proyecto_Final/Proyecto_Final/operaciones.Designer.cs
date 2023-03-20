namespace Proyecto_Final
{
    partial class operaciones
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
            this.btn_agrepro = new System.Windows.Forms.Button();
            this.btn_agreclie = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.lab_cerrars = new System.Windows.Forms.Label();
            this.btn_reporte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_agrepro
            // 
            this.btn_agrepro.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_agrepro.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_agrepro.FlatAppearance.BorderSize = 0;
            this.btn_agrepro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agrepro.ForeColor = System.Drawing.Color.Black;
            this.btn_agrepro.Location = new System.Drawing.Point(33, 104);
            this.btn_agrepro.Name = "btn_agrepro";
            this.btn_agrepro.Size = new System.Drawing.Size(267, 40);
            this.btn_agrepro.TabIndex = 3;
            this.btn_agrepro.Text = "Productos";
            this.btn_agrepro.UseVisualStyleBackColor = false;
            this.btn_agrepro.Click += new System.EventHandler(this.btn_agrepro_Click);
            // 
            // btn_agreclie
            // 
            this.btn_agreclie.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_agreclie.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_agreclie.FlatAppearance.BorderSize = 0;
            this.btn_agreclie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agreclie.ForeColor = System.Drawing.Color.Black;
            this.btn_agreclie.Location = new System.Drawing.Point(306, 104);
            this.btn_agreclie.Name = "btn_agreclie";
            this.btn_agreclie.Size = new System.Drawing.Size(267, 40);
            this.btn_agreclie.TabIndex = 4;
            this.btn_agreclie.Text = "Clientes";
            this.btn_agreclie.UseVisualStyleBackColor = false;
            this.btn_agreclie.Click += new System.EventHandler(this.btn_agreclie_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 34);
            this.label2.TabIndex = 11;
            this.label2.Text = "Elija la opción ";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_salir.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(33, 175);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(267, 40);
            this.btn_salir.TabIndex = 12;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lab_cerrars
            // 
            this.lab_cerrars.AutoSize = true;
            this.lab_cerrars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lab_cerrars.Location = new System.Drawing.Point(494, 23);
            this.lab_cerrars.Name = "lab_cerrars";
            this.lab_cerrars.Size = new System.Drawing.Size(104, 18);
            this.lab_cerrars.TabIndex = 13;
            this.lab_cerrars.Text = "Cerrar Sesión";
            this.lab_cerrars.Click += new System.EventHandler(this.lab_cerrars_Click);
            // 
            // btn_reporte
            // 
            this.btn_reporte.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_reporte.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_reporte.FlatAppearance.BorderSize = 0;
            this.btn_reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reporte.ForeColor = System.Drawing.Color.Black;
            this.btn_reporte.Location = new System.Drawing.Point(306, 175);
            this.btn_reporte.Name = "btn_reporte";
            this.btn_reporte.Size = new System.Drawing.Size(267, 40);
            this.btn_reporte.TabIndex = 14;
            this.btn_reporte.Text = "Reporte";
            this.btn_reporte.UseVisualStyleBackColor = false;
            this.btn_reporte.Click += new System.EventHandler(this.btn_reporte_Click);
            // 
            // operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(614, 270);
            this.Controls.Add(this.btn_reporte);
            this.Controls.Add(this.lab_cerrars);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_agreclie);
            this.Controls.Add(this.btn_agrepro);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "operaciones";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agrepro;
        private System.Windows.Forms.Button btn_agreclie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lab_cerrars;
        private System.Windows.Forms.Button btn_reporte;
    }
}