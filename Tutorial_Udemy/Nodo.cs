using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Nodo
    {
        public int dato;
        public Nodo siguiente = null;
        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}
