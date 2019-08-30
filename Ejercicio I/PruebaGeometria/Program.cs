using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Geomatria.Rectangulo rec = new Geomatria.Rectangulo();
            Punto punto1 = new Punto();
            Punto punto3 = new Punto();
            punto1.Mpunto(1, 3);
            punto3.Mpunto(3, 5);
            rec.rectangulo(punto1,punto3);
            float area = rec.GetArea();
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
