using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franja;

        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        protected new string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.Append(base.Mostrar() + " Costo Llamada: " + CostoLlamada + " Franja " + this.franja);
            return cadena.ToString();
        }
        private float CalcularCosto()
        {
            double costo = duracion;
            if(this.franja == Franja.Franja_1)
            {
                costo *= 0.99;
            }else if(this.franja == Franja.Franja_2)
            {
                costo *= 1.25;
            }else
            {
                costo *= 0.66;
            }
            return (float)costo;
        }
        public Provincial(Franja mifranja,Llamada llamada)
        : this(llamada.NroOrigen,mifranja,llamada.Duracion,llamada.NroDestino)
        {
            this.franja = mifranja;
        }
        public Provincial(string origen,Franja mifranja, float duracion,string destino)
            :base(duracion,destino,origen)
        {
            this.franja = mifranja;
        }
        public  override bool Equals(object obj)
        {
            bool retorno = false;
            if(!(obj is null))
            {
                if (obj is Provincial)
                {
                    retorno = true;
                }

            }
            return retorno;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
