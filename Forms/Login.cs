using Compilador.Clases;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Login : Form
    {
        ConexionDB conexionDB = new ConexionDB();
        string password = string.Empty;
        string Enpassword = string.Empty;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_Registrar_MouseClick(object sender, MouseEventArgs e)
          {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
          }

        private void bt_login_MouseClick(object sender, MouseEventArgs e)
        {
            if(tbx_usuario.Text != "" && tbx_password.Text != "")
              {
                Clipboard.SetText(tbx_usuario.Text);
                conexionDB.Usuario_Activo = Clipboard.GetText();

                password = tbx_password.Text;
                Enpassword = Encriptacion.GetSHA256(password);

                conexionDB.conectar.Close();
                conexionDB.conectar.Open();

                SqlCommand comando = new SqlCommand("SELECT Nombre_Usuario, Contraseña FROM Usuarios WHERE Nombre_Usuario = @Nombre_Usuario AND Contraseña = @Contraseña", conexionDB.conectar);
                comando.Parameters.AddWithValue("@Nombre_Usuario", tbx_usuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", Enpassword);

                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    conexionDB.conectar.Close();
                    Interfaz interfaz = new Interfaz();
                    interfaz.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no validos");
                }
            }
            else { MessageBox.Show("Por favor ingresa tu usuario y contraseña"); }           
        }
    }
}
