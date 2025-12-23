using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Juego<T> where T : Categoria //Solo acepta objetos de la clase categoria
    {
        private T juego;
        public T Categoria
        {
            get {  return juego; }
            set { juego = value; }
        }
    }
}
