using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilador.Clases
{
    public class Validar
    {
        public void solonumeros(KeyPressEventArgs e)
          {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
               e.Handled = true; 
          }

        public void sololetras(KeyPressEventArgs e)
        {
            if (e.KeyChar >= 33 && e.KeyChar <= 64 || e.KeyChar >= 91 && e.KeyChar <= 96 || e.KeyChar >= 123 && e.KeyChar <= 255)
                e.Handled = true;
        }
    }
}
