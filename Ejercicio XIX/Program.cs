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
            Sumador prueba = new Sumador(22);
            Sumador pruebaDos = new Sumador();
            prueba.Sumar(15, 23);
            Console.WriteLine(prueba);
            Console.WriteLine(pruebaDos);
            Console.ReadKey();
        }
    }
}
