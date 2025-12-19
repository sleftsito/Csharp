using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public abstract class Abstracto
    {
        public abstract void mensaje();
        public void Adios()
        {
            Console.WriteLine("Adios");
        }
    }
}
