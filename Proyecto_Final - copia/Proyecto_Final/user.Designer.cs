namespace Proyecto_Final
{
    partial class user
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
            this.txt_user = new System.Windows.Forms.TextBox();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agre = new System.Windows.Forms.Button();
            this.chek_pass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(50, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Usuario:";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.Location = new System.Drawing.Point(160, 44);
            this.txt_user.Multiline = true;
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(309, 33);
            this.txt_user.TabIndex = 16;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_regresar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_regresar.FlatAppearance.BorderSize = 0;
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.ForeColor = System.Drawing.Color.Black;
            this.btn_regresar.Location = new System.Drawing.Point(369, 190);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(100, 35);
            this.btn_regresar.TabIndex = 19;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(160, 107);
            this.txt_pass.Multiline = true;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(309, 33);
            this.txt_pass.TabIndex = 20;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(50, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password:";
            // 
            // btn_agre
            // 
            this.btn_agre.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_agre.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btn_agre.FlatAppearance.BorderSize = 0;
            this.btn_agre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agre.ForeColor = System.Drawing.Color.Black;
            this.btn_agre.Location = new System.Drawing.Point(160, 190);
            this.btn_agre.Name = "btn_agre";
            this.btn_agre.Size = new System.Drawing.Size(157, 35);
            this.btn_agre.TabIndex = 22;
            this.btn_agre.Text = "Agregar Usuario";
            this.btn_agre.UseVisualStyleBackColor = false;
            this.btn_agre.Click += new System.EventHandler(this.btn_agre_Click_1);
            // 
            // chek_pass
            // 
            this.chek_pass.AutoSize = true;
            this.chek_pass.Location = new System.Drawing.Point(160, 146);
            this.chek_pass.Name = "chek_pass";
            this.chek_pass.Size = new System.Drawing.Size(85, 22);
            this.chek_pass.TabIndex = 23;
            this.chek_pass.Text = "Mostrar";
            this.chek_pass.UseVisualStyleBackColor = true;
            this.chek_pass.CheckedChanged += new System.EventHandler(this.chek_pass_CheckedChanged);
            // 
            // user
            // 
            this.AcceptButton = this.btn_agre;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(571, 252);
            this.Controls.Add(this.chek_pass);
            this.Controls.Add(this.btn_agre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_user);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "user";
            this.Text = "buscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btn_regresar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_agre;
        private System.Windows.Forms.CheckBox chek_pass;
    }
}