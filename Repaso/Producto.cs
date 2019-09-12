using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string codigo, string marca, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public string MostrarProducto()
        {
           return string.Format("Marca: {0}, Precio: {1}, Codigo de Barra: {2}",this.GetMarca(),this.GetPrecio(),(string)this);
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (p1.GetMarca() == p2.GetMarca() && (string)p1 == (string)p2 && !(p1 is null) && !(p2 is null))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p1,Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca)
        {
            bool retorno = false;
            if(p1.GetMarca() == marca)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}
