using System;

namespace Practica3.EF.Common
{
    public class CustomExceptionDelete : Exception
    {
        public CustomExceptionDelete() : base("No se puede eliminar un ID que no existe.") { 
        }
    }
}
