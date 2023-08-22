using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02
{
    public class ExceptionMat
    {
        public int SimpleException(int a, int b)
        {
            try
            {
                int x = a / b;
                Console.WriteLine($"El resultado es {x}");
                return x;
                
                
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message + "\n¡Solo Chuck Norris divide por cero!");
                return -1;
            }
        }
        public static void DivisionException(){
            throw new Exception();
        }

        public static void ComparacionMayorMenorException(){
            throw new Exception();
        }
        public static void ThrowExceptionPersonalizada(){
            throw new ExceptionPersonalizada();
        }
    }
}
