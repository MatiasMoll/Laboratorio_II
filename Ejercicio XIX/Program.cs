using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XIX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Sobrecarga de Operadores";
            Sumador prueba = new Sumador();
            Sumador pruebaDos = new Sumador();
            long numero;
            string palabra;
            pruebaDos.Add(15);
            prueba.Add(15);
            Console.WriteLine(prueba + pruebaDos);
            Console.WriteLine(prueba | pruebaDos);
            Console.ReadKey();
        }
    }
}
