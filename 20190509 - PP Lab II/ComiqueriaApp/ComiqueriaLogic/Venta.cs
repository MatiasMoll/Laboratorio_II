using System;
using System.Collections.Generic;
using System.Text;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Atributos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        #endregion

        #region Propiedades
        internal DateTime Fecha
        {
            get
            {
                return fecha;
            }
        }
        #endregion

        #region Constructor / Metodos
        static Venta()
        {
            porcentajeIva = 21;
        }
        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);    
        }
        private void Vender(int cantidad)
        {
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(producto.Precio, cantidad);
            this.producto.Stock -= cantidad;
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            double precioBruto = precioUnidad * cantidad;
            double iva= (precioBruto * porcentajeIva) / 100;

            return precioBruto + iva;
        }
        public string ObtenerDescripcionBreve()
        {
            return "Fecha: " + Fecha + " Descripcion: " + this.producto.Descripcion + " Precio Final: " + this.precioFinal;
        }
        #endregion
    }
}
