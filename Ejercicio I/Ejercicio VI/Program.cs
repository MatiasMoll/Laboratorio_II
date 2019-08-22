using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 6";
            bool flag = false;
            int i, añoMin,añoMax;
            string minYear, maxYear;
            do {
                Console.Write("Ingrese un año de inicio: ");
                minYear = Console.ReadLine();
                Console.Write("Ingrese el año de final: ");
                maxYear = Console.ReadLine();
                if (int.TryParse(minYear,out añoMin)&&int.TryParse(maxYear,out añoMax) && añoMin<añoMax)
                {
                    for(;añoMin<=añoMax;añoMin++)
                    {
                        if(añoMin % 4 == 0 || añoMin % 400 == 0)
                        {
                            Console.WriteLine(añoMin);
                        }
                    }
                    flag = true;
                }else
                {
                    Console.WriteLine("ERROR! Reintente");

                }
            } while (!flag);
            Console.ReadKey();
        }
    }
}
