using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XVII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 17";
            Boligrafo pen1 = new Boligrafo(100, ConsoleColor.Cyan);
            Boligrafo pen2 = new Boligrafo(50, ConsoleColor.Red);
            string aux = "";
            pen1.Pintar(100, out aux);
            Console.WriteLine(aux);
            Console.ReadKey();

            


        }
    }
}
