namespace Practica3.EF.Common
{
    public class Exceptions
    {
        public static void ThrowExceptionPersonalizada()
        {
            throw new CustomExceptionCtg();
        }
        public static void ThrowExceptionMod()
        {
            throw new CustomExceptionMod();
        }
        public static void ThrowExceptionDelete()
        {
            throw new CustomExceptionDelete();
        }
    }
}
