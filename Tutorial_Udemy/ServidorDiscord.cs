using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    internal class ServidorDiscord
    {
        private List<Peleador> peleadores;

        public ServidorDiscord()
        {
            peleadores = new List<Peleador>();
        }
        public void agregarPeleador(Peleador nuevoPeleador)
        {
            peleadores.Add(nuevoPeleador);
        }
        public bool buscarPeleador(string nombre)
        {
            bool encontrado = false;
            int i = 0;
            while(encontrado == false && i < peleadores.Count)
            {
                if (peleadores[i].Nombre == nombre)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if (encontrado)
            {
                Console.WriteLine($"Nombre: {peleadores[i].Nombre}\n" +
                                  $"Edad: {peleadores[i].Edad}\n" +
                                  $"Peso: {peleadores[i].Peso}\n" +
                                  $"Nivel de amenaza: {peleadores[i].nivelAmenaza}\n");
                return false;
            }
            else
            {
                Console.WriteLine("No se de quien me hablas manin");
                return true;
            }
        }

    }
}
