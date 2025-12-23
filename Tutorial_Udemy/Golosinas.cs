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
        public override List<Producto> GetProducts(string producto)
        {
            var golosinas = new List<Producto>();
            if (producto.Equals(""))
                golosinas = _Golosinas;
            else
                golosinas = _Golosinas.Where(g => g.Name.Equals(producto)).ToList();
            return golosinas;
        }
        public override void addProduct(Producto producto)
        {
            _Golosinas.Add(producto);
        }
    }
}
