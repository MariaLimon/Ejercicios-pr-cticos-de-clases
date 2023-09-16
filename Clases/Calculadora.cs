using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_de_clases.Clases
{
    internal class Calculadora
    {
        private double _numero1;
        private double _numero2;
        private double _resultado;

        public double Resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }
        

        public double Numero1
        {
            get { return _numero1; }
            set { _numero1 = value; }
        }
        public double Numero2
        {
            get { return _numero2; }
            set { _numero2 = value; }
        }

        //double respuesta;
        public double Sumar(double numero1, double numero2)
        {
            Resultado = (numero1 + numero2);
            return Resultado;
        }
        public double Restar(double numero1, double numero2)
        {
            return Resultado = (numero1 - numero2);
        }
        public double Multiplicar(double numero1, double numero2)
        {
            return Resultado = (numero1 * numero2);
        }
        public double Dividir(double numero1, double numero2)
        {
            
              return Resultado = (numero1 / numero2);
            
            
        }
    }
}
