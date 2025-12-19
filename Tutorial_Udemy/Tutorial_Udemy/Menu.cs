using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Menu : IMenu // Los metodos tienen que ser public en la clase hija
    {
        Almacen g = new Golosinas();
        public void golosinas()
        {
            var input = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de golosinas");
                if (g.GetProducts().Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Deseas agreglar golosinas?. s/n");
                    input = Console.ReadLine();
                    if (input.Equals("s"))
                    {
                        Console.WriteLine("Cuantas golosinas quiere agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());
                    }
                }

            } while (valor);
        }
        public void ventas()
        {

        }
        public double solicitarPago()
        {
            return 0.0;
        }
    }
}
