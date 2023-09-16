using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_de_clases.Clases
{
    internal class Rectangulo
    {
        private double _ancho;
        private double _alto;

        public double Ancho { get; set; }
        public double Alto { get; set; }
        public double respuestaArea { get; set; }
        public double respuestaPerimetro { get; set; }

        public double CalculaArea(double Ancho, double Alto)
        {
            return Alto * Ancho;
        }
        public double CalcularPerimetro(double Ancho, double Alto)
        {
            return 2*(Alto + Ancho); 
            
        }
    }
}
