using System;

namespace Practica3.EF.Common
{
    public class CustomExceptionCtg : Exception
    {
        public CustomExceptionCtg() : base("No se puede eliminar esta categoria, esta asociada a productos") {
        }
    }
}
