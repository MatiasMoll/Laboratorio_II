using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private int valorHora;

        private Moto()
        {
            valorHora = 30;
        }
        public Moto(string patente, int cilindrada):this():base(patente)
        {
            
            this.cilindrada = cilindrada;
        }
    }
}
