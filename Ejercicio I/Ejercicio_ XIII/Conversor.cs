using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio__XIII
{
    public class Conversor
    {
        public static string DecimalABinario(double x)
        {
            string binario = "";
            double resto = 0;
            if (x > 0)
            {
                while (x != 1 || x != 2)
                {
                    resto = x % 2;
                    binario += resto.ToString();
                    x = x / 2;
                }
            }
            else if (x == 0)
            {
                binario = "0";
            }else
            {
                binario = "No se pueden convertir numeros negativos";
            }
            return binario;
        }

    }
}
