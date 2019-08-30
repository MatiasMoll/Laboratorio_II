using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_XVII
{
    public class Boligrafo
    {
        const short cantidadMaximaTinta = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;

        }
        public ConsoleColor GetColor(Boligrafo boligrafo)
        {
            return boligrafo.color;
        }

        public short GetTinta(Boligrafo boligrafo)
        {
            return boligrafo.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta += tinta;
            if(this.tinta<0)
            {
                this.tinta = 0;
            }else if(this.tinta>100)
            {
                this.tinta = 100;
            }
        }
        public void Recargar()
        {
            this.tinta = 100;
        }

        public bool Pintar(short gasto,out string dibujo)
        {
           bool retorno = false;
           string aux = "*";
           dibujo = "";
           if(this.tinta<=gasto)
           {
                for(;this.tinta>0;this.tinta--)
                {
                    dibujo += aux;
                }
                retorno = true;
           }else
           {
                for (; gasto > 0; gasto--)
                {
                    dibujo += aux;
                }
                retorno = true;
           }
           Console.ForegroundColor = this.GetColor(this);
           this.SetTinta((short)-gasto);
           return retorno;
        }
    }

    
    
    
}
