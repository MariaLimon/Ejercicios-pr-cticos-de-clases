using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_de_clases.Clases
{
    internal class Persona
    {
        private string _nombre;
        private int _edad;

        public string NombrePersona
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int EdadPesona
        {
            get { return _edad; }
            set { _edad = value; }
        }
    }
}
