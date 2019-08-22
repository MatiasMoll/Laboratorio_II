using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 4";
            int contadorPerfectos = 0;
            int i, j;
            int acumulador = 0;
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            for(i=1;contadorPerfectos<4 ;i++)
            {
                for (j = 1; j < i-1; j++)
                {
                    if(i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if(acumulador == i)
                {
                    contadorPerfectos++;
                    Console.WriteLine(i);
                }
                acumulador = 0;
            }
            Console.ReadKey();
        }
    }
}
