using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Validaciones
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            if (min < max)
            {
                if(valor<=max && valor >=min)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
    }
}
