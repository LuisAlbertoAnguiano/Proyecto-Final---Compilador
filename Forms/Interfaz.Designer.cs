namespace Compilador
{
    partial class Interfaz
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
            this.bt_Registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_usuario_activo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_Registrar
            // 
            this.bt_Registrar.BackColor = System.Drawing.Color.Lime;
            this.bt_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Registrar.ForeColor = System.Drawing.Color.Black;
            this.bt_Registrar.Location = new System.Drawing.Point(12, 113);
            this.bt_Registrar.Name = "bt_Registrar";
            this.bt_Registrar.Size = new System.Drawing.Size(203, 41);
            this.bt_Registrar.TabIndex = 6;
            this.bt_Registrar.Text = "Agregar Usuario";
            this.bt_Registrar.UseVisualStyleBackColor = false;
            this.bt_Registrar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_Registrar_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario Activo";
            // 
            // tbx_usuario_activo
            // 
            this.tbx_usuario_activo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_usuario_activo.Location = new System.Drawing.Point(148, 6);
            this.tbx_usuario_activo.Name = "tbx_usuario_activo";
            this.tbx_usuario_activo.ReadOnly = true;
            this.tbx_usuario_activo.Size = new System.Drawing.Size(162, 29);
            this.tbx_usuario_activo.TabIndex = 8;
            // 
            // Interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tbx_usuario_activo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Registrar);
            this.Name = "Interfaz";
            this.Text = "Interfaz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Interfaz_FormClosed);
            this.Load += new System.EventHandler(this.Interfaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Registrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_usuario_activo;
    }
}