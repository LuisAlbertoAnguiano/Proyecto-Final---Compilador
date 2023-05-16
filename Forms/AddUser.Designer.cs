namespace Compilador
{
    partial class AddUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_usuario = new System.Windows.Forms.TextBox();
            this.bt_Registrar = new System.Windows.Forms.Button();
            this.tbx_Nombre = new System.Windows.Forms.TextBox();
            this.tbx_ApeP = new System.Windows.Forms.TextBox();
            this.tbx_ApeM = new System.Windows.Forms.TextBox();
            this.tbx_Correo = new System.Windows.Forms.TextBox();
            this.tbx_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Regresar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(91, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario";
            // 
            // tbx_password
            // 
            this.tbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_password.Location = new System.Drawing.Point(171, 216);
            this.tbx_password.MaxLength = 256;
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(162, 29);
            this.tbx_password.TabIndex = 7;
            // 
            // tbx_usuario
            // 
            this.tbx_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_usuario.Location = new System.Drawing.Point(171, 183);
            this.tbx_usuario.MaxLength = 30;
            this.tbx_usuario.Name = "tbx_usuario";
            this.tbx_usuario.Size = new System.Drawing.Size(162, 29);
            this.tbx_usuario.TabIndex = 6;
            // 
            // bt_Registrar
            // 
            this.bt_Registrar.BackColor = System.Drawing.Color.Lime;
            this.bt_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Registrar.ForeColor = System.Drawing.Color.Black;
            this.bt_Registrar.Location = new System.Drawing.Point(130, 328);
            this.bt_Registrar.Name = "bt_Registrar";
            this.bt_Registrar.Size = new System.Drawing.Size(203, 41);
            this.bt_Registrar.TabIndex = 5;
            this.bt_Registrar.Text = "Registrar";
            this.bt_Registrar.UseVisualStyleBackColor = false;
            this.bt_Registrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_Registrar_MouseClick);
            // 
            // tbx_Nombre
            // 
            this.tbx_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Nombre.Location = new System.Drawing.Point(171, 78);
            this.tbx_Nombre.MaxLength = 30;
            this.tbx_Nombre.Name = "tbx_Nombre";
            this.tbx_Nombre.Size = new System.Drawing.Size(162, 29);
            this.tbx_Nombre.TabIndex = 10;
            this.tbx_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sololetras_KeyPress);
            // 
            // tbx_ApeP
            // 
            this.tbx_ApeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ApeP.Location = new System.Drawing.Point(171, 113);
            this.tbx_ApeP.MaxLength = 15;
            this.tbx_ApeP.Name = "tbx_ApeP";
            this.tbx_ApeP.Size = new System.Drawing.Size(162, 29);
            this.tbx_ApeP.TabIndex = 11;
            this.tbx_ApeP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sololetras_KeyPress);
            // 
            // tbx_ApeM
            // 
            this.tbx_ApeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ApeM.Location = new System.Drawing.Point(171, 148);
            this.tbx_ApeM.MaxLength = 15;
            this.tbx_ApeM.Name = "tbx_ApeM";
            this.tbx_ApeM.Size = new System.Drawing.Size(162, 29);
            this.tbx_ApeM.TabIndex = 12;
            this.tbx_ApeM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sololetras_KeyPress);
            // 
            // tbx_Correo
            // 
            this.tbx_Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Correo.Location = new System.Drawing.Point(171, 251);
            this.tbx_Correo.MaxLength = 50;
            this.tbx_Correo.Name = "tbx_Correo";
            this.tbx_Correo.Size = new System.Drawing.Size(162, 29);
            this.tbx_Correo.TabIndex = 13;
            // 
            // tbx_telefono
            // 
            this.tbx_telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_telefono.Location = new System.Drawing.Point(171, 286);
            this.tbx_telefono.MaxLength = 10;
            this.tbx_telefono.Name = "tbx_telefono";
            this.tbx_telefono.Size = new System.Drawing.Size(162, 29);
            this.tbx_telefono.TabIndex = 14;
            this.tbx_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.solonumeros_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apellido Paterno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(97, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 19;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Blue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(86, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Nombre";
            // 
            // btn_Regresar
            // 
            this.btn_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.btn_Regresar.Location = new System.Drawing.Point(12, 4);
            this.btn_Regresar.Name = "btn_Regresar";
            this.btn_Regresar.Size = new System.Drawing.Size(117, 35);
            this.btn_Regresar.TabIndex = 22;
            this.btn_Regresar.Text = "Regresar";
            this.btn_Regresar.UseVisualStyleBackColor = false;
            this.btn_Regresar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Regresar_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(138, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID";
            // 
            // tbx_ID
            // 
            this.tbx_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_ID.Location = new System.Drawing.Point(171, 43);
            this.tbx_ID.MaxLength = 3;
            this.tbx_ID.Name = "tbx_ID";
            this.tbx_ID.Size = new System.Drawing.Size(39, 29);
            this.tbx_ID.TabIndex = 23;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(444, 381);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_ID);
            this.Controls.Add(this.btn_Regresar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_telefono);
            this.Controls.Add(this.tbx_Correo);
            this.Controls.Add(this.tbx_ApeM);
            this.Controls.Add(this.tbx_ApeP);
            this.Controls.Add(this.tbx_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_usuario);
            this.Controls.Add(this.bt_Registrar);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddUser_FormClosed);
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_usuario;
        private System.Windows.Forms.Button bt_Registrar;
        private System.Windows.Forms.TextBox tbx_Nombre;
        private System.Windows.Forms.TextBox tbx_ApeP;
        private System.Windows.Forms.TextBox tbx_ApeM;
        private System.Windows.Forms.TextBox tbx_Correo;
        private System.Windows.Forms.TextBox tbx_telefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Regresar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_ID;
    }
}