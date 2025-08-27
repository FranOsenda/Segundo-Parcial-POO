using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Digital : Libro
    {        
        public Digital(string ISBN, string titulo, string autor) : base (ISBN, titulo, autor)  
        {
            this.ISBN = ISBN;
            this.autor = autor;
            this.titulo = titulo;
            prestamos = 0;
            disponibilidad = true;
        }
    }
}
