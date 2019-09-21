using System;

namespace Sistema
{
    public class Cliente
    {
        private string nombre;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        private int numero;

        public int Numero
        {
            get
            {
                return numero;
            }
  
        }

        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre) : this(numero)
        {
            Nombre = nombre;
        }
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if (c1.numero == c2.numero)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }
}
