using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Frutas : Almacen
    {
        List<Producto> _Frutas;
        public Frutas()
        {
            _Frutas = new List<Producto>();
        }
        public override List<Producto> GetProducts(string producto)
        {
            var frutas = new List<Producto>();
            if (producto.Equals(""))
                frutas = _Frutas;
            else
                frutas = _Frutas.Where(g => g.Name.Equals(producto)).ToList();
            return frutas;
        }
        public override void addProduct(Producto producto)
        {
            _Frutas.Add(producto);
        }
    }
}
