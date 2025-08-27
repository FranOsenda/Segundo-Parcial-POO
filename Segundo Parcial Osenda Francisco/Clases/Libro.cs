using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class Libro
    {
        public string ISBN { get; set; }    
        public string titulo { get; set; }  
        public string autor { get; set; }
        public int prestamos { get; set; }
        public bool disponibilidad { get; set; }

        public Libro(string ISBN, string titulo, string autor) 
        {
            this.ISBN = ISBN;
            this.autor = autor;
            this.titulo = titulo;
            prestamos = 0; 
        }

        public static List<Libro> Libros = new List<Libro>();
        public static bool verificarExistencia(string ISBN)
        {
            bool existe;
            return existe = Libros.Exists(l => l.ISBN == ISBN);
        }

        public static void mostrarInformacion(Libro l)
        {
            Console.WriteLine($"ISBN: {l.ISBN}");
            Console.WriteLine($"Título: {l.titulo}");
            Console.WriteLine($"Autor: {l.autor}");
            Console.WriteLine($"Cantidad de préstamos: {l.prestamos}");
            if (l.GetType().Name == "Fisico")
            {
                if (l.disponibilidad)
                    Console.WriteLine($"El libro esta disponible");
                else  
                    Console.WriteLine($"El libro no esta disponible");  
                
            }
        }
        public static void mostrarLibros()
        {
            int fisicos = 0;
            int digitales = 0;
            foreach (Libro l in Libros)
            {
                Console.WriteLine($"ISBN: {l.ISBN}");
                Console.WriteLine($"Título: {l.titulo}");
                Console.WriteLine($"Autor: {l.autor}");
                Console.WriteLine($"Cantidad de préstamos: {l.prestamos}");
                if (l.GetType().Name == "Fisico") fisicos++;
                else digitales++;          
            }
            Console.WriteLine($"Cantidad de libros físicos: {fisicos}");    
            Console.WriteLine($"Cantidad de libros digitales: {digitales}");    
        }
    }
}
