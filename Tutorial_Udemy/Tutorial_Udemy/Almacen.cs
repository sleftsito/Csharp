using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public abstract class Almacen
    {
        public abstract List<Producto> GetProducts();
        public abstract void addProduct(Producto producto);
    }
}
