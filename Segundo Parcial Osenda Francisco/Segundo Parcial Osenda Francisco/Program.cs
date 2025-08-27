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
            while (true)
            {
                Console.Clear();   
                Console.WriteLine("--- MENÚ PRINCIPAL ---");
                Console.WriteLine("1 - ");
                Console.WriteLine("2 - ");
                Console.WriteLine("3 - ");
                Console.WriteLine("4 - ");
                Console.WriteLine("5 - ");
                Console.WriteLine("6 - Salir");
                Console.WriteLine("Seleccione una opción: ");
                string opcion = Console.ReadLine();                          
                switch (opcion.Trim())
                {
                    case "1":
                        Console.Clear();
                        // Codigo 
                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                        
                        break;
                    case "2":
                        Console.Clear();
                        // Codigo 
                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                        
                        break;


                    case "3":
                        Console.Clear();
                        // Codigo 
                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                        
                        break;

                    case "4":
                        Console.Clear();
                        // Codigo 

                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                            
                        break;

                    case "5":
                        Console.Clear();
                        // Codigo 
                        Console.WriteLine("Para volver al menu principal presione una tecla");
                        Console.ReadKey();
                        
                        break;

                    case "6":
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


