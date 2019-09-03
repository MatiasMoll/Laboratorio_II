using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XIX
{
    public class Sumador
    {
        private int cantidadSumas;

        public void Add(int cantSumas)
        {
            this.cantidadSumas = cantSumas;
        }
        public void Add()
        {
            this.Add(0);
        }
        public long Sumar(long a, long b)
        {
            cantidadSumas++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            cantidadSumas++;
            return a + b;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;
            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;
        }
    }

}
