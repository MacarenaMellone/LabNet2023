using System;

namespace Practica3.EF.Common
{
    public class CustomExceptionMod : Exception
    {
        public CustomExceptionMod() : base("No se puede modificar un ID que no existe.") { 
        }
    }
}
