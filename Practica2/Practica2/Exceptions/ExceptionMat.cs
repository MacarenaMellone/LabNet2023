using System;
using System.Windows.Forms;

namespace Practica2
{
    public class ExceptionMat
    {
        public static void SimpleException(int a, int b)
        {
            try
            {
                int x = a / b;
                MessageBox.Show($"El resultado es {x}");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message + " ¡Solo Chuck Norris divide por cero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("¡Seguro Ingreso una letra o no ingreso nada!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
