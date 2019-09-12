using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
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

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            return new Peso(e.GetCantidad() / Peso.GetCotizacion() * GetCotizacion());
        }

    }
}
