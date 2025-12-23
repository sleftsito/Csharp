using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Padre 
    {
        private string mensaje;
        public Padre(string mensaje) 
        { 
            this.mensaje = mensaje;
        }
        protected void Hola() //Solo deja que esta clase y sus subclases accedan al metodo
        {
            Console.WriteLine(mensaje);
        }
        public virtual void Adios()
        {
            Console.WriteLine(mensaje);
        }
        private void nada() //Las clases abstractas no se heredan
        {
            Console.WriteLine(mensaje);
        }
    }
}
