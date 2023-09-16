using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_prácticos_de_clases.Clases
{
    internal class Libro
    {
        private string _autor;
        private string _titulo;

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
    }
}
