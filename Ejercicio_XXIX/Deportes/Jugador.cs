using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportes
{
    public class Jugador
    {
        private int dni;
        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                if(value > 0)
                {
                    dni = value;
                }
            }
        }
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
        private int partidosJugados;
        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
            set
            {
                if(value >= 0)
                {
                    partidosJugados = value;
                }
                
            }
        }
        private int promedioGoles;

        public int PromedioGoles
        {
            get
            {
                int promedioGoles = totalGoles / partidosJugados;
                return promedioGoles;
            }

        }

        private int totalGoles; 
        public int TotalGoles
        {
            get
            {
                return totalGoles;
            }
            set
            {
                if(value > 0)
                {
                    totalGoles = value;
                }
               
            }
        }



    }
}
