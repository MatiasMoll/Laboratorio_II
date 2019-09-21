using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
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

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        public new string Mostrar()
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
        : base(llamada.Duracion,llamada.NroDestino,llamada.NroDestino)
        {
            this.franja = mifranja;
        }
        public Provincial(string origen,Franja mifranja, float duracion,string destino)
            :this(mifranja, new Llamada(duracion, destino, origen))
        {

        }
    }
}
