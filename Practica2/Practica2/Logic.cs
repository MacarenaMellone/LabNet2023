using System;
using System.Windows.Forms;

namespace Practica2
{
    public class Logic : ExceptionMat
    {   
        public static void MayorMenor(int valor1, int valor2, bool calcula)
        {
            try
            {
                if (valor1 > valor2){
                    MessageBox.Show($"{valor1} es mayor que {valor2}", "Correcto!");
                }
                else{
                    ComparacionMayorMenorException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace,"Error");
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
                 MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
