using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    public class Menu : IMenu // Los metodos tienen que ser public en la clase hija
    {
        Almacen g = new Golosinas();
        Almacen f = new Golosinas();
        public void golosinas()
        {
            var input = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de golosinas");
                if (g.GetProducts("").Count.Equals(0))
                {
                    Console.WriteLine("No hay golosinas");
                    Console.WriteLine("Deseas agregrar golosinas?. s/n");
                    input = Console.ReadLine();
                    if (input.Equals("s"))
                    {
                        Console.WriteLine("Cuantas golosinas quiere agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva golosina: ");
                            Console.WriteLine("Ingrese la ID");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            g.addProduct(new Producto
                            {
                                ID = id,
                                Name = nombre,
                                Price = precio

                            });
                        }
                        Console.WriteLine("Deseas ir al inicio? s/n");
                        input = Console.ReadLine();
                        if (input.Equals("s"))
                            valor = true;
                        else
                            valor = false;
                    }
                    else
                    {
                        Console.WriteLine("Deseas ir al inicio? s/n");
                        input = Console.ReadLine();
                        if (input.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de frutas y golosinas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de golosinas");
                    foreach (var item in g.GetProducts(""))
                    {
                        Console.WriteLine($"Codigo {item.ID} Golosina {item.Name} Precio {item.Price}");
                    }
                    Console.WriteLine("Desea realizar ventas de golosinas? s/n");
                    input = Console.ReadLine();
                    if (input.Equals("s"))
                        ventas();
                    else
                        valor = false;
                }
            } while (valor);
        }
        public void frutas()
        {
            var input = "";
            var valor = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Venta de frutas");
                if (f.GetProducts("").Count.Equals(0))
                {
                    Console.WriteLine("No hay frutas");
                    Console.WriteLine("Deseas agregrar frutas?. s/n");
                    input = Console.ReadLine();
                    if (input.Equals("s"))
                    {
                        Console.WriteLine("Cuantas frutas quiere agregar?");
                        int cant = Convert.ToInt16(Console.ReadLine());
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Nueva fruta: ");
                            Console.WriteLine("Ingrese la ID");
                            var id = Console.ReadLine();
                            Console.WriteLine("Ingrese nombre");
                            var nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese precio");
                            var precio = Convert.ToDouble(Console.ReadLine());
                            g.addProduct(new Producto
                            {
                                ID = id,
                                Name = nombre,
                                Price = precio

                            });
                        }
                        Console.WriteLine("Deseas ir al inicio? s/n");
                        input = Console.ReadLine();
                        if (input.Equals("s"))
                            valor = true;
                        else
                            valor = false;
                    }
                    else
                    {
                        Console.WriteLine("Deseas ir al inicio? s/n");
                        input = Console.ReadLine();
                        if (input.Equals("s"))
                        {
                            Console.Clear();
                            Console.WriteLine("Venta de frutas y golosinas");
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Lista de frutas\n");
                    foreach (var item in f.GetProducts(""))
                    {
                        Console.WriteLine($"Codigo => {item.ID}\nNombre => {item.Name}\nPrecio => {item.Price}\n");
                    }
                    Console.WriteLine("Deseas realizar alguna venta de frutas? s/n");
                    input = Console.ReadLine();
                    if (input.Equals("s"))
                        ventas();

                }

            } while (valor);
        }
        public double solicitarPago()
        {
            bool PagoCorrecto = false;
            double Pago = 0;
            while (!PagoCorrecto)
            {
                Console.WriteLine("Quisieras pagar con?: 2, 5, 10");
                Pago = Double.Parse(Console.ReadLine());
                if (Pago != 2 && Pago != 5 && Pago != 10)
                    Console.WriteLine("Pago no valido");
                else
                    PagoCorrecto = true;
            }
            return Pago;
        }
        public void ventas()
        {
            double total = 0;
            string input = "";
            do
            {
                Console.WriteLine("Ingresa el producto a comprar");
                string producto = Console.ReadLine();
                var productos = g.GetProducts(producto);
                while (productos.Count.Equals(0))
                {
                    Console.WriteLine("No existe la golosina, por favor ingrese otro nombre");
                    producto = Console.ReadLine();
                    productos = g.GetProducts(producto);
                }
                Console.WriteLine($"Tu precio a pagar es {productos[0].Price} $Dollars");
                double pago = solicitarPago();
                while (pago < productos[0].Price)
                {
                    Console.WriteLine($"Faltan {productos[0].Price - pago} $Dollars");
                    pago += solicitarPago();
                }
                Console.WriteLine($"Su devuelta es {pago - productos[0].Price}$Dollars");
                total += productos[0].Price;
                Console.WriteLine($"El total pagado ha sido: {total}$Dollars");
                Console.WriteLine("Deseas realizar otro pago? s/n");
                input = Console.ReadLine();
            } while (input.Equals("s"));
        }
    }
}
