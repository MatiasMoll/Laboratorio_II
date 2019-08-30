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

        private float GetBase()
        {
            int x1;
            int x2;
            x1 = this.vertice1.GetX();
            x2 = this.vertice4.GetX();
            return x2 - x1;
        }
        private float GetAlt()
        {
            int y1;
            int y2;
            y1 = this.vertice1.GetY();
            y2 = this.vertice2.GetY();
            return y2 - y1;
        }
        public float GetArea()
        {
            float bas = this.GetBase();
            float alt = this.GetAlt();
            return bas * alt;    
        
        }

        public float GetPerimetro()
        {
            float bas = this.GetBase();
            float alt = this.GetAlt();
            return (bas + alt) * 2;
        }

    }
}
