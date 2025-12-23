using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Nodo2<T> 
    {
        public T obj;
        public Nodo2<T> next;
        public Nodo2(T obj)
        {
            this.obj = obj;
            this.next = null;
        }
    }
}
