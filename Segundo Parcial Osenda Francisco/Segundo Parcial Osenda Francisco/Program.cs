using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segundo_Parcial_Osenda_Francisco
{
    public class Program
    {
        static void Main(string[] args)
        {

            Libro libro1 = null; 
            while (true)
            {                
                Console.Clear();   
                Console.WriteLine("--- MENÚ PRINCIPAL ---");
                Console.WriteLine("1 - Registrar libro");
                Console.WriteLine("2 - Registrar prestamo de un libro");
                Console.WriteLine("3 - Mostrar informacion de un libro");
                Console.WriteLine("4 - Mostar todos los libros y estadisticas generales");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("Seleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion.Trim())
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("Elija que tipo de libro quiere registrar (fisco o digital) ");
                        string tipo = Console.ReadLine().ToLower().Trim();
                        if (tipo != "fisico" && tipo != "digital")
                        {
                            Console.WriteLine("Tipo de libro incorrecto. Ingrese nuevamente el tipo");
                            Console.WriteLine("Para volver al menu principal presione una tecla");
                            Console.ReadKey();
                            continue;
                        }
                        else if (tipo == "fisico")
                        {

                            Console.WriteLine("Ingrese el ISBN del libro que desea cargar");
                            string ISBN = Console.ReadLine().ToLower();
                            if (Libro.verificarExistencia(ISBN))
                            {
                                Console.WriteLine($"El libro ya existe en la biblioteca.");
                                Console.WriteLine("Para volver al menu principal presione una tecla");
                                Console.ReadKey();
                                continue;
                            }
                            Console.WriteLine("Ingrese el titulo del libro");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el autor del libro ");
                            string autor = Console.ReadLine();
                            Fisico fisico = new Fisico(ISBN, titulo, autor);
                            Libro.Libros.Add(fisico);
                            Console.WriteLine("El libro se registro correctamente");
                        }
                        else if (tipo == "digital")
                        {

                            Console.WriteLine("Ingrese el ISBN del libro que desea cargar");
                            string ISBN = Console.ReadLine().ToLower();
                            if (Libro.verificarExistencia(ISBN))
                            {
                                Console.WriteLine($"El libro ya existe en la biblioteca.");
                                Console.WriteLine("Para volver al menu principal presione una tecla");
                                Console.ReadKey();
                                continue;
                            }
                            Console.WriteLine("Ingrese el titulo del libro");
                            string titulo = Console.ReadLine();
                            Console.WriteLine("Ingrese el autor del libro ");
                            string autor = Console.ReadLine();
                            Fisico digital = new Fisico(ISBN, titulo, autor);
                            Libro.Libros.Add(digital);
                            Console.WriteLine("El libro se registro correctamente");
                        }
                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        if (Libro.Libros.Count < 1)
                        {
                            Console.WriteLine("No hay libros registrados. Por favor registro uno ");
                            Console.WriteLine("Para volver al menu principal presione una tecla");
                            Console.ReadKey();
                            continue;
                        }

                        Console.WriteLine("Ingrese el ISBN del libro que desea prestar");
                        string isbn = Console.ReadLine().ToLower();
                        if (Libro.verificarExistencia(isbn))
                        {
                            Libro libro = Libro.Libros.Find(l => l.ISBN == isbn);

                            Console.WriteLine("Ingrese el nombre del socio");
                            string socio = Console.ReadLine();
                            Console.WriteLine("Ingrese la fecha del prestamo");
                            string f = Console.ReadLine();
                            DateTime fecha;
                            if (DateTime.TryParse(f, out fecha))
                            {
                                Console.WriteLine("Ingrese la duración del préstamo en días");
                                string d = Console.ReadLine();
                                int duracion;
                                if (int.TryParse(d, out duracion) || duracion <= 0)
                                {
                                    Prestamo prestamo = new Prestamo(socio, fecha, duracion, libro);
                                    prestamo.registrarPrestamo(isbn);
                                }
                                else
                                {
                                    Console.WriteLine("Duración inválida. Intente nuevamente.");
                                    Console.ReadKey();
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Fecha inválida. Intente nuevamente.");
                                Console.ReadKey();
                                continue;
                            }                              
                        }
                        else
                        {
                        Console.WriteLine($"El libro no existe en la biblioteca.");                       
                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                        }

                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();                        
                        break;


                    case "3":
                        Console.Clear();
                        
                        Console.WriteLine("Ingrese el ISBN del libro que desea consultar");
                        string isbnConsulta = Console.ReadLine().ToLower();   
                        if (Libro.verificarExistencia(isbnConsulta))
                            {
                            int indice = Libro.Libros.FindIndex(l => l.ISBN == isbnConsulta);
                            Libro.mostrarInformacion(Libro.Libros[indice]);
                        }
                        else
                        {
                            Console.WriteLine($"El libro no existe en la biblioteca.");
                            continue;
                        }

                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();                        
                        break;

                    case "4":
                        Console.Clear();

                        Libro.mostrarLibros(); 

                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();                            
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Volviendo al menu principal ");                       
                        break;
                        
                    default:
                        Console.WriteLine("Opción inválida. Ingrese un valor entre 1 y 6.");
                        Console.ReadKey();  
                        break;
                }
            }              
        }
    }
}


