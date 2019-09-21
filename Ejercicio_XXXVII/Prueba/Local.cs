using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        protected float costo;

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
            cadena.Append(base.Mostrar()+" Costo de llamada: " + CostoLlamada);
            return cadena.ToString();
        }
        private float CalcularCosto()
        {
            return this.costo * base.Duracion;
        }

        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion,llamada.NroOrigen,llamada.NroDestino)
        {
            this.costo = costo;
        }

        public Local(string origen,float duracion, string destino,float costo)
            :this(new Llamada(duracion,destino,origen),costo)
        {
            //VACIO
        }
    }
}
