using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CentralTelefonica
{
    public class Centralita
    {
        private List<Llamada> listaLlamadas;
        protected string razonSocial;

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> ListaLlamadas
        {
            get
            {
                return this.listaLlamadas;
            }
            
        }


        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;
            foreach (Llamada call in listaLlamadas)
            {
                if (tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas && call is Local)
                {
                    ganancia += ((Local)call).CostoLlamada;

                } else if (tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas && call is Provincial)
                {
                    ganancia += ((Provincial)call).CostoLlamada;
                }
            }
            return ganancia;
        }
        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();
            string aux;
            cadena.AppendLine("Razon social: " + this.razonSocial);
            cadena.AppendLine("Ganancia Total: " + GananciasPorTotal);
            cadena.AppendLine("------------------------------------------");
            cadena.AppendLine("------------------------------------------");
            foreach (Llamada call in listaLlamadas)
            {
                if (call is Local)
                {
                    aux = ((Local)call).Mostrar();
                } else
                {
                    aux = ((Provincial)call).Mostrar();
                }
                cadena.AppendLine(aux);
                cadena.AppendLine("----------------------------------------");

            }
            return cadena.ToString();
        }
        public Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public void OrdenarLlamada()
        {

            this.listaLlamadas.Sort(Llamada.OrdenarLlamada);
            
        }

    }
}
