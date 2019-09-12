using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        static Dolar()
        {
            cotizacionRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizacionRespectoDolar = cotizacion;
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizacionRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad() / Peso.GetCotizacion());
        }

    }
}
