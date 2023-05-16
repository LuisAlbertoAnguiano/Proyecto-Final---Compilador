using System.Data.SqlClient;

namespace Compilador
  {
    public class ConexionDB
    {
        public SqlConnection conectar = new SqlConnection("server=ASREN-PC\\SQLSERVER ; database = DB_Compilador ; INTEGRATED SECURITY = true");

        public string Usuario_Activo = string.Empty;
    }
              
  }
