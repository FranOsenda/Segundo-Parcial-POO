using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class Prestamo
    {
        public string socio { get; set; }
        public DateTime fecha { get; set; }
        public int duracion { get; set; }
        public Libro libro { get; set; }

        public Prestamo (string socio, DateTime fecha, int duracion, Libro libro)
        {
            this.socio = socio;
            this.fecha = fecha;
            this.duracion = duracion;
            this.libro = libro;
        }

        public void registrarPrestamo(string ISBN)
        {
            if (Libro.verificarExistencia(ISBN))
            {
                Libro libro = Libro.Libros.Find(l => l.ISBN == ISBN);
                if (libro.GetType().Name == "Fisico")
                {
                    Fisico.verificarDisponibilidad(libro);
                    Console.WriteLine($"El libro {libro.titulo} fue prestado");
                    libro.disponibilidad = false; 
                }
                else
                {
                    Console.WriteLine($"El libro {libro.titulo} fue prestado");
                    libro.prestamos++;
                }
            }
            else Console.WriteLine($"El libro no existe en la biblioteca.");
        }    
       
    }
}
