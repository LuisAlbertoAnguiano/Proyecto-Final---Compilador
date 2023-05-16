using System;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void Interfaz_Load(object sender, EventArgs e)
          {
            ConexionDB conexionDB = new ConexionDB();
            if(conexionDB.Usuario_Activo == string.Empty)
              {
                conexionDB.Usuario_Activo = Clipboard.GetText();
              }          

            tbx_usuario_activo.Text = conexionDB.Usuario_Activo;
          }
        private void bt_Registrar_MouseClick(object sender, MouseEventArgs e)
          {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Hide();
          }

        private void Interfaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }


    }
}
