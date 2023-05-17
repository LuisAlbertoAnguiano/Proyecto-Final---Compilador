using System;
using System.IO;
using System.Windows.Forms;

namespace Compilador
{
    public partial class Interfaz : Form
    {
        int Estado, Posicion, columna, direccion;
        string wpalabra, wlinea,  Token, Caracter, wSalida;
        string Identificador, ConsInt, ConsString;
        bool palabrareservada, Encontro;
        string [,] Matriz = new string[40,40];
        string[] VectorPalabrasReservadas;
        OpenFileDialog dialogoAbrirArchivo;
        public Interfaz()
        {
            InitializeComponent();

            dialogoAbrirArchivo = new OpenFileDialog();
            //picCargarArchivo.Image = Image.FromFile(@"..\..\img\upload.png");
            //picCompilar.Image = Image.FromFile(@"..\..\img\compile.png");
            LeerMatrizEstados("matrizEstados.csv");
            LeerPalabrasReservadas("palabrasReservadas.csv");
            for (var i = 0; i <= VectorPalabrasReservadas.Length - 1; i++)
                P_reservadas.Items.Add(VectorPalabrasReservadas[i] + "");
        }

        public void LeerPalabrasReservadas(string archivo)
        {
            string renglon;
            StreamReader lector = new StreamReader(archivo);
            renglon = lector.ReadLine();
            
            VectorPalabrasReservadas = renglon.Split();

            lector.Close();
        }

        /// This is equivalent to Mid Function in VB

        /// <param name="s"> String to Check.</param>  

        /// <param name="a">Position of Character</param>  

        /// <param name="b">Length </param>  

        /// <returns></returns>  

        public static string Mid(string s, int a, int b)
          {
            string temp = s.Substring(a - 1, b);

            return temp;
          }

        private void BuscaTokens()
          {
            // Procedimiento para agregar los tokens
            Estado = 0;
            Token = "";
            Posicion = 1;
            // Len regresa la cantidad de caracteres de una variable de texto
            // Mid regresa un caracter de una variable de texto
            while (Posicion <= wlinea.Length)
            {
                Caracter = Mid(wlinea, Posicion, 1);
                CalcularColumna(); // Calcula la columna que le corresponde al caracter
                Estado = Int32.Parse(Matriz[Estado, columna]); // 
                if ((Estado >= 100))
                {
                    if (Token.Length >= 0)
                        ReconocerToken();
                    Estado = 0;
                    Token = "";
                    Salida_txt.Items.Add(Token); // Agregar en el listbox de salida los tokens
                }
                else if ((Estado != 0))
                    Token = Token + Caracter;
                Posicion = Posicion + 1;
            }
            if (Token.Length > 0)
              {
                Caracter = " ";
                CalcularColumna();
                Estado = Int32.Parse(Matriz[Estado, columna]);
                ReconocerToken();
              }
          }

        private void Buscapreservadas()
          {
            int posicion;
            posicion = 0;
            direccion = -1;
            while ((!(palabrareservada)) & (posicion < VectorPalabrasReservadas.Length))
              {
                // P_reservadas.SelectedIndex = posicion

                if (Token.ToUpper() == VectorPalabrasReservadas[posicion].ToUpper())
                  {
                    palabrareservada = true;
                    direccion = posicion;
                  }
                posicion += 1;
               }
          }

        private void LeerMatrizEstados(string archivo)
          {
            string renglon;
            string[] datosRenglon;
            StreamReader lector = new StreamReader(archivo);
            int r = 0;
            while (!lector.EndOfStream)
              {
                renglon = lector.ReadLine();
                datosRenglon = renglon.Split();
                for (int c = 0; c <= datosRenglon.Length - 1; c++)
                    Matriz[r, c] = datosRenglon[c];
                r += 1;
              }
            lector.Close();
          }

        private void BuscaIdentificadores()
          {
            // Procedimiento para encontrar identificadores
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while ((!(Encontro)) & (Renglon2 < IDs_txt.Items.Count))
              {
                IDs_txt.SelectedIndex = Renglon2;
                if (Token.ToUpper() == IDs_txt.Text.ToUpper())
                  {
                    Encontro = true;
                    direccion = Renglon2;
                  }
                Renglon2 = Renglon2 + 1;
              }
            if ((!(Encontro)))
              {
                IDs_txt.Items.Add(Token);
                direccion = IDs_txt.Items.Count - 1;
              }
          }

        private void bt_Registrar_Click(object sender, EventArgs e)
          {
            this.Close();
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
        private void Interfaz_FormClosed(object sender, FormClosedEventArgs e)
          {
            Login login = new Login();
            login.Show();
          }

        private void ReconocerToken()
          {
            // Programamos reconoce token para saber que tipo de token es cada palabra
            if ((Estado == 100))
              {
                palabrareservada = false;
                Buscapreservadas();
                if (palabrareservada)
                    wSalida = Token + " PR " + direccion.ToString();
                else
                  {
                    BuscaIdentificadores();
                    wSalida = Token + " ID " + direccion.ToString();
                  }
                Posicion = Posicion - 1;
              }
            if (Estado == 101)
              {
                ConstantesEnteras();
                wSalida = Token + "Ctes.Enteras" + direccion.ToString();
                Posicion = Posicion - 1;
              }
            if (Estado == 102)
              {
                ConstantesReales();
                wSalida = Token + "Ctes.Reales" + direccion.ToString();
                Posicion = Posicion - 1;
              }
            if (Estado == 103)
              {
                Token = Token + Caracter;
                ConstantesString();
                wSalida = Token + "Ctes.String" + direccion.ToString();
              }
            if (Estado == 105)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 106)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 107)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 108)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 114)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 115)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 116)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 117)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 118)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 119)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 120)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 121)
              {
                Token = Token + Caracter;
                wSalida = Token + "Caracter Esp";
              }
            if (Estado == 104)
              {
                Token = Token + Caracter;
                wSalida = Token + "Commentario";
              }
            Salida_txt.Items.Add(wSalida); // Añadimos el token en el listbox salida con el tipo de token que es
          }

        private void CalcularColumna()
          {
            // Calcula el valor de la columna de cada caracter
            if (Caracter == "A" || Caracter == "B" || Caracter == "C" || Caracter == "D"
                || Caracter == "E" || Caracter == "F" || Caracter == "G" || Caracter == "H" || Caracter == "I"
                || Caracter == "J" || Caracter == "K" || Caracter == "L" || Caracter == "M" || Caracter == "N"
                || Caracter == "Ñ" || Caracter == "O" || Caracter == "P" || Caracter == "Q" || Caracter == "R"
                || Caracter == "S" || Caracter == "T" || Caracter == "U" || Caracter == "V" || Caracter == "W"
                || Caracter == "X" || Caracter == "Y" || Caracter == "Z")
                columna = 0;
            else if (Caracter == "a" || Caracter == "b" || Caracter == "c" || Caracter == "d"
                || Caracter == "e" || Caracter == "f" || Caracter == "g" || Caracter == "h" || Caracter == "i"
                || Caracter == "j" || Caracter == "k" || Caracter == "l" || Caracter == "m" || Caracter == "n"
                || Caracter == "ñ" || Caracter == "o" || Caracter == "p" || Caracter == "q" || Caracter == "r"
                || Caracter == "s" || Caracter == "t" || Caracter == "u" || Caracter == "v" || Caracter == "w"
                || Caracter == "x" || Caracter == "y" || Caracter == "z")
                columna = 0;
            else if (Caracter == "0" || Caracter == "1" || Caracter == "2" || Caracter == "3" 
                || Caracter == "4" || Caracter == "5" || Caracter == "6" || Caracter == "7" 
                || Caracter == "8" || Caracter == "9")
                columna = 1;
            else if (Caracter == ".")
                columna = 2;
            else if (Caracter == "/")
                columna = 4;
            else if (Caracter == "*")
                columna = 5;
            else if (Caracter == "+")
                columna = 6;
            else if (Caracter == "-")
                columna = 7;
            else if (Caracter == "<")
                columna = 8;
            else if (Caracter == ">")
                columna = 9;
            else if (Caracter == "(")
                columna = 10;
            else if (Caracter == ")")
                columna = 11;
            else if (Caracter == "[")
                columna = 12;
            else if (Caracter == "]")
                columna = 13;
            else if (Caracter == "{")
                columna = 14;
            else if (Caracter == "}")
                columna = 15;
            else if (Caracter == ";")
                columna = 16;
            else if (Caracter == " ")
                columna = 17;
            else if (Caracter == "=")
                columna = 18;
            else if (Caracter == "_")
                columna = 19;
            else
                columna = 3;
        }

        private void ConstantesEnteras()
          {
            // Procedimiento para las constantes enteras
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while ((!(Encontro)) & (Renglon2 < C_Enteras.Items.Count)) // Entra al ciclo, si encuentra un token le asigna un numero
              {
                C_Enteras.SelectedIndex = Renglon2;
                if (Token.ToUpper() == C_Enteras.Text.ToUpper())
                  {
                    Encontro = true;
                    direccion = Renglon2;
                  }
                Renglon2 = Renglon2 + 1;
              }
            if ((!(Encontro)))
              {
                C_Enteras.Items.Add(Token);
                direccion = C_Enteras.Items.Count - 1;
              }
          }


        private void ConstantesReales()
          {
            // Procedimiento para las constantes reales
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while ((!(Encontro)) & (Renglon2 < C_Reales.Items.Count))
              {
                C_Reales.SelectedIndex = Renglon2;
                if (Token.ToUpper() == C_Reales.Text.ToUpper())
                  {
                    Encontro = true;
                    direccion = Renglon2;
                  }
                Renglon2 = Renglon2 + 1;
              }
            if ((!(Encontro)))
              {
                C_Reales.Items.Add(Token);
                direccion = C_Reales.Items.Count - 1;
              }
          }
        private void ConstantesString()
          {
            // Procedimiento para las constantes String
            int Renglon2;
            Renglon2 = 0;
            Encontro = false;
            while ((!(Encontro)) & (Renglon2 < String_txt.Items.Count))
              {
                String_txt.SelectedIndex = Renglon2;
                if (Token.ToUpper() == String_txt.Text.ToUpper())
                  {
                    Encontro = true;
                    direccion = Renglon2;
                  }
                Renglon2 = Renglon2 + 1;
              }
            if ((!(Encontro)))
              {
                String_txt.Items.Add(Token);
                direccion = String_txt.Items.Count - 1;
              }
          }

        private void picCargarArchivo_Click(object sender, EventArgs e)
          {
            // Programamos para abrir un archivo y trabajar en el

            if (dialogoAbrirArchivo.ShowDialog() != DialogResult.OK)
                return;
            string archivo = dialogoAbrirArchivo.FileName;
            System.IO.StreamReader fileReader; // Acomodar para leer linea por linea 
            fileReader = new System.IO.StreamReader(archivo); // 
            string stringReader; // Declara la variable 
            while (!(fileReader.EndOfStream)) // Entra al ciclo y sigue hasta que termine de leer el archivo txt 
              {
                stringReader = fileReader.ReadLine(); // Lee las lineas 
                Entrada_txt.Items.Add(stringReader); // Se agrega el archivo en nuestro listbox de entrada
              }
          }

        private void Compilar_txt_Click(object sender, EventArgs e)
          {
            // Se programa el botón de compilar
            var Renglon = 0;
            while ((Renglon < Entrada_txt.Items.Count))
              {
                Entrada_txt.SelectedIndex = Renglon; // Me posiciono en un elemento de la lista
                wlinea = Entrada_txt.Text; // Regresa el valor de donde estoy posicionado
                BuscaTokens(); // Trae todos los tokens agregados en el archivo
                Renglon = Renglon + 1;
              }
          }

        private void btnExportar_Click(object sender, EventArgs e)
          {
            SaveFileDialog dialogoGuardar = new SaveFileDialog();
               
            string archivo = dialogoGuardar.FileName;


            StreamWriter sw = new StreamWriter(archivo);

            foreach (var item in Salida_txt.Items)
              {
                if (item.ToString() != "")
                    sw.WriteLine(item.ToString());
              }
            sw.Close();
          }

    }
}
