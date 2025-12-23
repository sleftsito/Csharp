using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class claseGenerica<T> where T : Books// sino tiene el where entonces acepta objetos de cualquier clase
    {   
        private Nodo2<T> primero;
        private int size;
        
        public void Add(T obj)
        {
            var nuevo = new Nodo2<T>(obj);
            Nodo2<T> valor;
            if( primero == null)
            {
                primero = nuevo;
            }
            else
            {
                valor = primero;
                while(valor != null)
                {
                    nuevo.next = primero;
                    primero = nuevo;
                    break;
                }
            }
            size++;
        }
        public T Get(int index)
        {
            var actual = primero;
            T obj = null;
            int count = size - 1;
            for(int i = count; i >= 0 ; i--)
            {
                if(index == 1)
                {   
                    obj = actual.obj;   
                    break;
                }
                actual = actual.next;
                count--;
            }
            return obj;
        }
    }
}
