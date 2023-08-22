using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class Program
    {
        static void Main(string[] args)
        {
           ExceptionMat dividir = new ExceptionMat();
           bool salir = false;
            while (!salir)
            {
                try
                {
                    Console.WriteLine("╔═════════════════════════════════════════════════════════════════╗");
                    string textToEnter = "Bienvenidos \n";
                    Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 3) + (textToEnter.Length / 3)) + "}", textToEnter));
                    Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");
                    Console.WriteLine("1. Ejercicio 1");
                    Console.WriteLine("2. Ejercicio 2");
                    Console.WriteLine("3. Ejercicio 3");
                    Console.WriteLine("4. Ejercicio 4");
                    Console.WriteLine("5. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Introduzca valor a dividir");
                            int valor;
                            valor = Int32.Parse(Console.ReadLine());
                            //ExceptionMat.SimpleException(valor, 0, true);
                            Console.WriteLine("\nPresione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.WriteLine("Introduzca dividendo");
                            int valor1;
                            valor1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Introduzca divisor");
                            int valor2;
                            valor2 = Int32.Parse(Console.ReadLine());
                            dividir.SimpleException(valor1, valor2);
                            Console.WriteLine("\nPresione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Logic.MayorMenor();
                            Console.WriteLine("\nPresione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Logic.CustomException();
                            Console.WriteLine("\nPresione cualquier tecla para volver al menu principal");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("Ha salido de la aplicacion");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 5");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}
