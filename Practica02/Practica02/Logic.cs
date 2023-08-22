using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class Logic : ExceptionMat
    {
        public static void MayorMenor()
        {
            Logic comparar = new Logic();
            Console.WriteLine("Introduzca valor a comparar");
            int valor1;
            valor1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca valor menor al anterior");
            int valor2;
            valor2 = Int32.Parse(Console.ReadLine());
            comparar.ComparaMayorMenor(valor1, valor2, true);

        }
        public int ComparaMayorMenor(int valor1, int valor2, bool compara)
        {

            try
            {
                if (valor1 > valor2)
                {
                    Console.WriteLine($"{valor1} es mayor que {valor2}");
                    return 0;
                }
                else
                {
                    ComparacionMayorMenorException();
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
                return -1;
            }
        }
        public static void CustomException()
        {
            try
            {
                ThrowExceptionPersonalizada();
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.Message + "\n");
            }
        }
    }
}
