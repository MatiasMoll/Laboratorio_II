using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 26";
            //Lista
            //List<int> lista = new List<int>();
            List<int> listaPositiva = new List<int>();
            List<int> listaNegativa = new List<int>();
            //Cola
            //Queue<int> colas = new Queue<int>();
            Queue<int> colasPositivas = new Queue<int>();
            Queue<int> colasNegativas = new Queue<int>();
            //Pila
            //Stack<int> pila = new Stack<int>();
            Stack<int> pilaPositiva = new Stack<int>();
            Stack<int> pilaNegativa = new Stack<int>();

            Random numRan = new Random();
            int i;
            for(i = 0;i<20;i++)
            {
                int numRandom = numRan.Next(-100, 100);
                if (numRandom != 0)
                {
                    if (numRandom < 0)
                    {
                        listaNegativa.Add(numRandom);
                        colasNegativas.Enqueue(numRandom);
                        pilaNegativa.Push(numRandom);
                    }
                    else 
                    {
                        listaPositiva.Add(numRandom);
                        colasPositivas.Enqueue(numRandom);
                        pilaPositiva.Push(numRandom);
                    }
                }
                else
                    i--;
            }
            listaPositiva.Sort();
            listaPositiva.Reverse();
            colasPositivas = new Queue<int>(colasPositivas.OrderByDescending(q => q));
            pilaPositiva = new Stack<int>(pilaPositiva.OrderBy(q => q));
            pilaPositiva.Reverse();
            listaNegativa.Sort();
            colasNegativas = new Queue<int>(colasNegativas.OrderBy(q => q));
            pilaNegativa = new Stack<int>(pilaNegativa.OrderByDescending(q => q));
            
            Console.Write("Positivo:\n");
            foreach (int num in listaPositiva)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Cola Positiva: ");
            foreach (int num in colasPositivas)
            {
                Console.WriteLine(num);
            }
            Console.Write("Pila Positiva:\n");
            foreach (int num in pilaPositiva)
            {
                Console.WriteLine(num);
            }

            Console.Write("Negativos:\n");
            foreach (int num in listaNegativa)
            {
                Console.WriteLine(num);
            }
            Console.Write("Negativos Cola:\n");
            foreach (int num in listaNegativa)
            {
                Console.WriteLine(num);
            }
            Console.Write("Negativos Pila:\n");
            foreach (int num in listaNegativa)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
