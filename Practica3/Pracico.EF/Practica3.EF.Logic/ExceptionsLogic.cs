using Practica3.EF.Common;
using System;
using System.Windows.Forms;

namespace Practica3.EF.Logic
{
    public class ExceptionsLogic
    {
        public static void CustomExceptionEliminar()
        {
            try
            {
                Exceptions.ThrowExceptionPersonalizada();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CustomExceptionModificar()
        {
            try
            {
                Exceptions.ThrowExceptionMod();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CustomExceptionDelete()
        {
            try
            {
                Exceptions.ThrowExceptionDelete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
