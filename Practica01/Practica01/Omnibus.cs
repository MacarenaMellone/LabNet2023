using System;

namespace Practica01
{
    public class Omnibus : TransportePublico
    {
        public Omnibus (int cantidadP, string coche) : base(cantidadP, coche) { }
        public override string Avanzar(){
            return string.Format("{1} Avanza con {0} pasajeros.", CantidadP, Coche);
        }
        public override string Detenerse(){
            throw new NotImplementedException();
        }
    }
}

