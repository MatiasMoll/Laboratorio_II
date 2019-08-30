using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace Geomatria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public void rectangulo(Punto vertice1, Punto vertice3)
        {
            Punto punto2 = new Punto();
            Punto punto4 = new Punto();
            punto2.Mpunto(vertice1.GetX(), vertice3.GetY());
            punto4.Mpunto(vertice3.GetX(), vertice1.GetY());
        }

        public float GetArea()
        {
            
            return this.area;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

    }
}
