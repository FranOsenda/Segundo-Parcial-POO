using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Fisico : Libro
    {
        public bool disponibilidad { get; set; }

        public Fisico(string ISBN, string titulo, string autor) : base (ISBN, titulo, autor)
        {
            this.ISBN = ISBN;
            this.autor = autor;
            this.titulo = titulo;
            disponibilidad = true; 
            prestamos = 0;
        }
        public static void verificarDisponibilidad(Libro libro)
        {
            if (libro.disponibilidad)
            {
                Console.WriteLine("El libro fue prestado");            
                libro.prestamos++;
                libro.disponibilidad = false;
            }
            else
            {
                Console.WriteLine("El libro no está disponible");
            }
        }
    }
}
