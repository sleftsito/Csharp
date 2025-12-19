using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_Udemy
{
    internal class ClaseExterna
    {
        public string Nombre { get; set; } = "Carlingas"; //con get y set puedes ponerle un valor y luego
                                                          //sacarlo para ponerlo en otra variable
        //atributos
        private string trabajo;
        private string ciudad;
        private string pais;
        private int edad;

        //propiedades
        public string Trabajo { set { trabajo = value; } } //Con el set solo puedes darle valor a una variable
        public string Ciudad
        {
            set { ciudad = value; }
            get { return ciudad; }
        }
        public string Pais
        {
            set => pais = value;
            get => pais;
        }
        public int Edad
        {
            get => 52;
        }
    }
}
