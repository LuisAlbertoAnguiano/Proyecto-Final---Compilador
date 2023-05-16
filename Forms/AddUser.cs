using Compilador.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Compilador
{
    public partial class AddUser : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        Validar validar = new Validar();
        string password = string.Empty;
        string Enpassword = string.Empty;
        public AddUser()
        {
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Registrar_MouseClick(object sender, MouseEventArgs e)
        {
            password = tbx_password.Text;
            Enpassword = Encriptacion.GetSHA256(password);

            conexionDB.conectar.Close();
            conexionDB.conectar.Open();

            SqlCommand comando = new SqlCommand("INSERT INTO Usuarios (ID_Usuario, Nombre_Empleado, Ape_P, Ape_M, Nombre_Usuario, Contraseña, Correo, Telefono) VALUES(@id, @nombre, @apeP, @apeM, @usuario, @contraseña, @correo, @telefono)", conexionDB.conectar);
            comando.Parameters.AddWithValue("@id", tbx_ID.Text);
            comando.Parameters.AddWithValue("@nombre", tbx_Nombre.Text);
            comando.Parameters.AddWithValue("@apeP", tbx_ApeP.Text);
            comando.Parameters.AddWithValue("@apeM", tbx_ApeM.Text);
            comando.Parameters.AddWithValue("@usuario", tbx_usuario.Text);
            comando.Parameters.AddWithValue("@contraseña", Enpassword);
            comando.Parameters.AddWithValue("@correo", tbx_Correo.Text);
            comando.Parameters.AddWithValue("@telefono", tbx_telefono.Text);

            try 
              { 
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado exitosamente");
              }
            catch 
              {
                MessageBox.Show("Datos no validos");
              }
            
        }

        private void solonumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.solonumeros(e);
        }

        private void sololetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.sololetras(e);
        }

        private void btn_Regresar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Interfaz interfaz = new Interfaz();
            interfaz.Show();
        }
    }
}
