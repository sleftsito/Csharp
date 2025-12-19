using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Golosinas : Almacen
    {
        List<Producto> _Golosinas;
        public Golosinas()
        {
            _Golosinas = new List<Producto>();
        }
        public override List<Producto> GetProducts()
        {
            return _Golosinas;
        }
        public override void addProduct(Producto producto)
        {
            _Golosinas.Add(producto);
        }
    }
}
