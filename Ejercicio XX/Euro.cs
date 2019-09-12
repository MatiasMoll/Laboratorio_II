using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        static Euro()
        {
            cotizacionRespectoDolar = 0.86;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizacionRespectoDolar = cotizacion;
        }
        public static implicit operator Euro(double p)
        {
            return new Euro(p);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizacionRespectoDolar;
        }
    }
}
