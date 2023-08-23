using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01
{
    public abstract class TransportePublico
    {
        public int CantidadP { get; set; }
        public string Coche { get; set; }
        public TransportePublico(int cantidadP, string coche)
        {
            this.CantidadP = cantidadP;
            this.Coche = coche;
        }
        public abstract string Avanzar();
        public abstract string Detenerse();
    }
}
