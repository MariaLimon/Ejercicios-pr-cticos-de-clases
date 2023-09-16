using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_de_clases.Clases
{
    //clase derivada 
    internal class Auto : Vehiculo
    {
        private string _modelo;

        public string ModeloAuto
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
    }
}
