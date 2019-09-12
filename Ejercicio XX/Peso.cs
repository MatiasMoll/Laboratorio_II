using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotizacionRespectoDolar;

        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return cotizacionRespectoDolar;
        }
        private Peso()
        {
            cotizacionRespectoDolar = 38.33;
        }
        public Peso(double cantidad) : this()
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizacionRespectoDolar = cotizacion;
        }

        public static explicit operator Dolar(Peso p)
        {
            return (p.GetCantidad() / cotizacionRespectoDolar);
        }

        public static explicit operator Euro(Peso p)
        {
            return (p.GetCantidad() / Euro.GetCotizacion());
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            bool retorno = false;
            if ((Dolar)p == d)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            bool retorno = false;
            if ((Euro)p == e)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            bool retorno = false;
            if (p1.GetCantidad() == p2.GetCantidad())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static Peso operator +(Peso p, Dolar d)
        {

            return new Peso((p.GetCantidad() + (d.GetCantidad() * cotizacionRespectoDolar)));
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return (p.GetCantidad() + (e.GetCantidad() * GetCotizacion() * 1.16));
        }
    }
}
