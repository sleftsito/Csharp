// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel;
using System.Text;
using Tutorial_Udemy;

#region Tipos de variables
//float 7 digitos 32bits
//double 15-16 digitos 64bits
//decimal 28-29 digitos 128bits
/*
int year = Convert.ToInt16("2025");
double balance = 25.6;
string name = "Tomas";
decimal weight = 72.8M;
float balanceSteam = 2.94F;
bool carlosGay = true;

//Aparentemente son muy parecidos, no se que diferencia tiene de los otros
Double Balance = balance; 
String Name = name;
Decimal Weight = weight;
Boolean CarlosGay = carlosGay;

Console.WriteLine("Hello, {0}\n" +
                  "Tienes {1} en tu cuenta bancaria\n" +
                  "Pesas {2}\n" +
                  "En tu cuenta de steam tienes {3}\n" +
                  "En el año {4}" +
                  "Es carlos gay? {5}", name, balance, weight, balanceSteam, year, carlosGay);
*/
#endregion Tipos de variables

#region Tipos de operadores
/*
int iqCarlos = 200;
int iqEmil = 201;
int iqCap = iqCarlos + iqEmil;
var iqTomas = iqCarlos - iqEmil; //Tomara cualquier tipo de dato segun la operacion

iqCarlos -= iqTomas;
iqCap += iqTomas;
iqEmil *= iqTomas;
iqEmil /= iqTomas;
iqCarlos %= iqCap;

var data = iqCarlos == iqTomas;
data = iqCarlos <= iqTomas;
data = iqCarlos >= iqTomas;
data = iqCarlos != iqTomas;

Console.WriteLine("El iq de Carlos es {0}\n" +
                  "El iq de Emil es {1}\n" +
                  "El iq de Cap es {2}\n" +
                  "El iq de TomasGPT es de {3}\n" +
                  "Carlos tiene un iq disntinto y por tanto menor al mio? {4}", iqCarlos, iqEmil, iqCap, iqTomas, data);
*/
#endregion Tipos de operadores

#region estructura condicional
/*
int iqPromedio = 100;
int iqCarlos = 200;
int iqCap = 400;
int iqEmil = 201;
int iqTomas = -1;
var data = iqCarlos < iqCap;
var carlosPendejaso = iqPromedio > iqCarlos;
string theStupiest;

if (carlosPendejaso)
    Console.WriteLine("Carlos es bien pendejaso");
else
    Console.WriteLine("Carlos no es tan pendejaso");

if (data)
{
    if(iqCarlos < iqCap)
        Console.WriteLine("Carlos es pendejo");
    else
        Console.WriteLine("Carlos no es tan pendejo");
}
else
{
    Console.WriteLine("Carlos es gay");
}

theStupiest = iqCarlos < iqCap && iqCarlos < iqEmil ? "Carlos" : "Tambien Carlos Bv";
Console.WriteLine($"El stupiest es {theStupiest}");
*/
#endregion estructura condicional

#region arrays
/*
string[] juegosFavoritos = new string[5];
juegosFavoritos[0] = "VHS";
juegosFavoritos[1] = "FNAF";
juegosFavoritos[2] = "Clair Obscure: expedition 33";
juegosFavoritos[3] = "Crosscode";
juegosFavoritos[4] = "Juego de caballas";
int[] iq = new int[5] { -1, 201, 201, 400, 10};

string[] Bros = { "Tomas", "Emil", "Carlos", "Cap", "Agua"};
int[] Edades = { 19, 20, 18, 17, 15};

//Multi dimensional arrays

int[,] dinero = new int[2, 2];
dinero[0, 0] = 25;
dinero[0, 1] = 200;
dinero[1, 0] = 50;
dinero[1, 1] = 0;

string[,,] Gobiernos = new string[2,2,2]
{
    {
        { "USA", "Puerto Rico" },
        { "Venezuela", "Alemania" }
    },
    {
        { "China", "Rusia" },
        { "Turkia", "Mexico" }
    }
};

Console.WriteLine("El juego favorito de {0} es {1}, su edad es {2}, su iq es {3}, tiene {4} dolares y es buscado por {5}", 
                  Bros[3], juegosFavoritos[3], Edades[3], iq[3], dinero[1,1], Gobiernos[0,0,0]);
Console.WriteLine("El juego favorito de {0} es {1}, su edad es {2}, su iq es {3}, {4} y es buscado por {5}",
                  Bros[4], juegosFavoritos[4], Edades[4], iq[4], "Los menores no tiene dinero", Gobiernos[1, 1, 1]);
*/
#endregion arrays

#region for/foreach
/*
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Carlos es gay");
}

string[] names = { "Tomas", "Emil", "Carlos", "Cap", "Agua" };

for(int i = 0; i < names.Length; i++)
{
    Console.WriteLine("Hola, {0}", names[i]);
}

foreach(string name in names)
{
    Console.WriteLine("Hola, {0}", name);
}
*/
#endregion for/foreach

#region triangulo de pascal
//int pisos = 0;
//int[] arreglo = new int[1];
////Mostramos un mensaje y capturalos el dato ingresado desde la consola
//Console.WriteLine("Ingrese el numeros de pisos");
//pisos = Convert.ToInt16(Console.ReadLine());
///* Declaramos el primer ciclo for que va recorrer dependiendo
//el datos ingresado que está almacenado en la variable pisos */
//for (int i = 1; i <= pisos;  i++)
//{
//    /*Colocamos un arreglo y colocamos la variable i del ciclo for
//   que será el tamaño que tendrá el arreglo cada vez que el ciclo for
//   se ejecute */
//    int[] pascal = new int[i];
//    //Ciclo for que se decrementa para formar el triangulo
//    for (int j = pisos; j < i; j--)
//    {
//        Console.Write(" ");
//    }
//    //Ciclo for que genera la sumas de las cifras
//    for (int k = 0; k < i; k++)
//    {
//        //Condición que evaluá la variable del ciclo for
//        if (k == 0 || k == (i - 1))
//        {
//            pascal[k] = 1;
//        }
//        else
//        {
//            //Sumamos los numero que están en cada poción 
//            //del arreglo para formar el triangulo
//            pascal[k] = arreglo[k] + arreglo[k - 1];
//        }
//        Console.Write("[" + pascal[k] + "]");
//    }
//    arreglo = pascal;
//    Console.WriteLine();
//}
#endregion triangulo de pascal

#region switch
/*
var (dataso, Carlanga) = (1, "Carlos es gay"); //eso se puede, pare que con otros tipos de variables no, al menos no int y string
const int numero = 2;

switch(dataso)
{
    case 1:
        Console.WriteLine("Es uno");
        break;
    case numero:
        Console.WriteLine("Es dos");
        break;
    default:
        Console.WriteLine("No es ni uno ni dos");
        break;
}

var Pendejo = dataso switch //Todas las opciones deben retornar el mismo tipo de dato
{
    1 => "Es uno",
    numero => "Es dos", //los switch solo permiten constantes en sus evaluaciones
    _ => "No es ni uno ni dos"
};
Console.WriteLine(Pendejo);
*/
#endregion switch

#region while y do while
/*
var num = 0;
while (true)
{
    if (num == 10)
        break;
    Console.WriteLine(num);
    num++;
}
num = 0;
Console.WriteLine();
do
{
    if (num == 10)
        break;
    num++;
    Console.WriteLine(num);
} while (true);
*/
#endregion while y do while

#region Strings
/*
var nombres = (Tomas: "Tomas", Emil: "Emil", Carlos: "Carlos", Cap: "Cap",
               TomasEdad: 19, EmilEdad: 20, CarlosEdad: 18, CapEdad: 17);
Console.WriteLine($"Su nombre es {nombres.Tomas} y su edad es {nombres.TomasEdad}");
Console.WriteLine("La edad del mas pendejo es {1} y su nombre es {0}", nombres.CarlosEdad, nombres.Carlos);

var title = "The one who puts out the sword will be crowned king";
Console.WriteLine(title.Substring(7));
Console.WriteLine(title.Substring(7, 13));

var miniTitle = title.Remove(7, 31); //El primero es desde donde borras, el segundo es hasta donde 
Console.WriteLine(miniTitle);

var title2 = title.Replace("The one who", "Carlos");
Console.WriteLine(title2);

var theOne = title.IndexOf("The one"); //Index de donde inicia una palabra
var w = title.IndexOf('w'); //Index de un caracter
Console.WriteLine(nombres.Tomas.ToLower()); //Todo minuscula
Console.WriteLine(nombres.Tomas.ToUpper()); //Todo mayuscula
Console.WriteLine(theOne);
Console.WriteLine(w);


foreach (var item in nombres.Tomas) // Asi como en C, los strings son solo arrays de caracteres(char)
{
    Console.WriteLine(item);
}
*/
#endregion Strings

#region StringBuilder
/*
string Tomas = "Tomas";
var name = new StringBuilder("Tomas");
//name.Capacity = 30; //Te permite asignarle cuantos elementos podra tener el string

name.Append(" ");
name.Append("y Carlos 5").AppendLine(" y");
name.AppendLine("Tu mama"); //Sirve para tras imprimir lo que esta en los parentesis saltar de linea
name.AppendFormat("Edad {0}", 50);
name[15] = 't'; //Te permite lo que haya en ese index del string

Console.WriteLine(name); 
*/
#endregion

#region tipos de metodos
/*
//Console.WriteLine(args[0]); //Siguiendo el link de arriba veras como aun que no se muestre ya se esta utilizando la estructura
                            //Clasica de Csharp, es decir ya existe el String[] args, y por tanto podemos pedirle imprimir uno
                            //De sus elementos, dara error al ejecutarlo desde aqui, pero al ejecutarlo desde la consola,
                            //Colocandole un valor justo despues del [nombre programa].exe podremos agregarlo a la lista de elementos
//var data = new Program();
//data.metodoPrivado(); //Esto no funciona, por que ese metodo no se creo en la clase program por algui

metodoPrivado();
var numero = Numerin();
Console.WriteLine(numero);
Console.WriteLine(Numerin());
Console.WriteLine(Cosa());
void metodoPrivado()
{
    Console.WriteLine("Carlos es pendejo");
}

int Numerin()
{
    return Convert.ToInt16("5");
}
string Cosa()
{
    return $"Cagaste {3} veces";
}

//Esto no ejecuta
namespace Curso_de_net_core
{
    class Program
    {
        private String cadena;
        private String verMayusculas = "";
        private String verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMy;
        private string[] tempMn;

        public Program(String cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMy = new string[n];
            tempMn = new string[n];
        }
        private String maysculas()
        {
            for (int i = 0; i < n; i++)
            {
                //IsUpper Indica si un carácter Unicode está categorizado como una letra mayúscula
                if (Char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]);
                }
            }
            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null)
                {
                    Mayusculas[i] = tempMy[i];
                    verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
                }
            }
            return verMayusculas;
        }
        private string minusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //IsLower Indica si un carácter Unicode está categorizado como una letra minúscula.
                if (Char.IsLower(cadena[i]))
                {
                    tempMn[i] = Convert.ToString(cadena[i]);
                }
            }
            for (int i = 0; i < tempMn.Length; i++)
            {
                if (tempMn[i] != null)
                {
                    Minusculas[i] = tempMn[i];
                    verMinusculas = $"{verMinusculas},{Minusculas[i]}";
                }
            }
            return verMinusculas;
        }
        static void Main()
        {
            var cadena = Console.ReadLine();
            var data = new Program(cadena);
            Console.WriteLine("Las letras mayusculas son: " + data.maysculas() +
                "\n" + "Las letras minusculas son: " + data.minusculas());

            Console.ReadLine();
        }

    }
}
*/

/*
class Program
{
    public Program()
    {

    }
    public Program(string name)
    {

    }
    public Program(int age)
    {

    }
    public Program(string name, int age)
    {

    }
    public Program(int age, string name)
    {

    }

    private void main()
    {
        var data = new Program();
        new Program("Carlanga");
        new Program(52);
        new Program(52, "Carlanga");
        new Program("Carlanga", 52);
    }
}
*/
#endregion tipos de metodos

#region parametros de metodos
/*
class Clase
{
    private void metodo(params Object[] parametros) //el params me deja ponerle los datos sueltos, mientras hago la lista
    {
        string nombre = (string)parametros[0];
        int edad = (int)parametros[1];
        bool esGay = (bool)parametros[2];
    }
    private void numerin(in int num)// el in impide que se pueda modificar el parametro
    {
        //num = 50; no se puede modificar gracias al in
        Console.WriteLine(num);
    }
    private void numerin2(ref int num) //Asocia la direccion de la memoria con el parametro, haciendo que sean iguales
    {
        num = 300;
    }
    private void numerin3(out int num) //el parametro sera lo que se le asigne a lo que le introduzcas
    {
        num = 500;
    }
    static void Main()
    {
        Object[] parametros = { "Carlos", 18, true };
        new Clase().metodo(parametros);
        new Clase().metodo("Tomas", 19, false);

        int edad = 15;
        new Clase().numerin(edad);
        new Clase().numerin2(ref edad); //es un modafukin POINTEEEER!!!
        Console.WriteLine(edad);
        new Clase().numerin3(out edad); //es como asignarle un valor a la variable que entras
        Console.WriteLine(edad);

        Console.ReadLine();

    }
}
*/
#endregion parametros de metodos

#region funciones
/*
class Clase
{
    static void Main()
    {
        int data;
        new Clase().metodo(out data);
        mensaje();
        void mensaje() => Console.WriteLine(data); // uso de lamda, lamda es => esto

    }
    private void metodo(out int valor)
    {
        valor = funcion();
        funcion();
        edad();

        int funcion()
        {
            Console.WriteLine(750);
            return 50 + 500;
        }
        static int edad() => 5; Console.WriteLine(edad());
    }
}
*/

/*
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 2, 3, 6, 4, 4, 4, 9, 5, 6, 5, 9, 2 };
        int[] list = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                    if (numero(array[i]))
                    {
                        list[i] = array[i];
                    }
                }
            }
            if (list[i] != 0)
            {
                Console.WriteLine(list[i] + " se repite: " + count);
            }
        }
        bool numero(int num)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == num)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
*/
#endregion funciones

#region uso de static
/*
var data = new Clase();
data.gravity1 = 8; //para esta instancia de la clase, la gravedad sera 8
data.modificador();

Clase2.gravity2 = 8; // asi se cambian los valores de una variable estatica de una clase
Clase2.modificador();
class Clase
{
    public double gravity1 = 9.8; //puede cambiar segun cada instancia
    public static int cantidad = 5;
    public void modificador() //un metodo no estatico si puede acceder a una variable estatica
    {
        cantidad = 10;
        gravity1 += 10;
        Clase3.hola();
    }
} 
class Clase2
{
    public static double gravity2 = 9.8; //se mantiene siempre entre todas las intancias

    public static void modificador() //un metodo estatico solo puede acceder a variables estaticas
    {
        gravity2 += 20;
        Console.WriteLine(Clase3.adios());
    }
}

static class Clase3 //solo pueden contener variables, metodos, y constructor estaticos
{
    static Clase3() //solo puede ser estatico, no publico ni privado, no parametros
    {

    }

    public static void hola()
    {   
        Console.WriteLine("Dicen que eres pendejo");
    }
    public static string adios()
    {
        return "Adios, y eres pelotudo tambien";
    }
}
*/
/*
//convertidora de km/h a m/s y viceversa
int repetir = 0;
do
{
    Console.WriteLine("Elige 1 para convertir de m/s a km/h");
    Console.WriteLine("Elige 2 para convertir de km/h a m/s");
    int opcion = Convert.ToInt16(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Convertidora.kmTom(Convert.ToInt32(Console.ReadLine()));
            repetir = 1;
            break;
        case 2:
            Convertidora.mToKm(Convert.ToInt32(Console.ReadLine()));
            repetir = 1;
            break;
        default:
            Console.WriteLine("Escribe 1 para repetir, cualquier otra cosa para terminar el programa");
            repetir = Convert.ToInt32(Console.ReadLine());
            break;
    }
} while (repetir == 1);

static class Convertidora
{
    public static void kmTom(int convertido)
    {
        Console.WriteLine($"{convertido} en m/s es: {convertido * 3600 / 1000}km/h");
    }
    static public void mToKm(int convertido)
    {
        Console.WriteLine($"{convertido} en km/h es: {convertido * 1000 / 3600}m/s");
    }
}
*/
#endregion uso de static

#region argumentos opcionales y con nombre
/*
var data = new Clase();
data.metodo("Tomas");
data.metodo2(null, null);

var data2 = new Clase();
data2.metodo("Carlanga", "Unibe", 18); // para agregarle un valor a un parametro opcional,
                                       // tienes que agregarle a todos los argumentos opcionales anteriores

data2.metodo2(sueldo: 15, trabajo: "pendejo master"); //asi puedes colocar los argumentos en el orden que quieras
class Clase
{
    //es como una constante, pero se le puede asignar un valor en el constructor
    readonly int vida; // parace que solo se puede usar en clases
    const int VIDA = 100;
    public Clase()
    {
        vida = 100;
    }
    public void metodo(string nombre, string escuela = "ITLA", int edad = 19) //argumeuntos opcionales, siempre al final
    {
        Console.WriteLine(escuela);
        Console.WriteLine(edad);
    }
    public void metodo2(string trabajo, int? sueldo) //el ? te permite colocarle un valor null las variables que normalante no podrian
    {
        Console.WriteLine(trabajo);
        Console.WriteLine(sueldo);
    }
}
*/
#endregion argumentos opcionales y con nombre

#region propiedades C#
/*
var data = new ClaseExterna();
var name = data.Nombre; //el get te permite usarlo como dato
data.Nombre = "Carlos"; //el set cambiarle el valor
data.Trabajo = "Doctor";
data.Nombre = name;

data.Ciudad = "Mosku";
string mosku = data.Ciudad;

data.Pais = "Rusia";
string pais = data.Pais;

int edad = data.Edad;
*/
/*
var Carlos = new Peleador()
{
    Nombre = "Carlos",
    Edad = 1852,
    Peso = 76.3,
    nivelAmenaza = "Dragon"

};
var Tomas = new Peleador()
{
    Nombre = "Tomas",
    Edad = 19,
    Peso = 75.0,
    nivelAmenaza = "Robot"

};
var Emil = new Peleador()
{
    Nombre = "EmilMaster",
    Edad = 20,
    Peso = 69.9,
    nivelAmenaza = "Demonio"

};
var Cap = new Peleador()
{
    Nombre = "Captokiak",
    Edad = 17,
    Peso = 65.5,
    nivelAmenaza = "Esquizofrenico"

};
var MyLittlePony = new ServidorDiscord();
MyLittlePony.agregarPeleador(Carlos);
MyLittlePony.agregarPeleador(Tomas);
MyLittlePony.agregarPeleador(Emil);
MyLittlePony.agregarPeleador(Cap);

bool encontrado = false;
do
{
    Console.WriteLine("A que peleador buscas?");
    string input = Console.ReadLine();
    encontrado = MyLittlePony.buscarPeleador(input);

}while(encontrado);
*/
#endregion propiedades c#

#region clase generica List
/*
List<Object> list = new List<Object>(); //todos los tipos de variable son considerados Object
list.Add(52);
list.Add("Feo");
list.Add(false);
list.Add("Feo");

list.ForEach(item => 
{
    Console.WriteLine(item);
}); //otra forma de iterar todos los elementos de una lista
list.ForEach(item => Console.WriteLine(item)); //Tambien se puede hacer asi si solo es una linea
Console.WriteLine();
foreach(Object item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine();
for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine(list[i]);
}
Console.WriteLine();
int j = 0; //otra forma de hacer el bucle for
for(; ; )
{
    if (j < list.Count)
    {
        Console.WriteLine(list[j]);
        j++;
    }
    else
        break;
}
Console.WriteLine(list.Count);
list.Remove("Feo"); //si no encuentra el elemento, no lo puede eleminar
Console.WriteLine(list.Count);

list.Insert(2, "Carlangas"); // agrega nuevo elemento y le suma 1 al indece de cada elemento posterior
//list.ForEach(item => Console.WriteLine(item));

Console.WriteLine(list.IndexOf("Carlangas"));
Console.WriteLine(list.IndexOf("Carlangas", 0)); //busca el indice desde ese numero
Console.WriteLine(list.IndexOf("Carlangas", 0, 1)); // este ademas le agrega un hasta, si no lo encuentra te regresa -1

Console.WriteLine(list.LastIndexOf("Feo")); //La ultima aparicion de un elemento
Console.WriteLine(list.LastIndexOf("Feo", 1)); //Busca desde ese numero
Console.WriteLine(list.LastIndexOf("Feo", 0, 1)); //Busca desde y hasta ese numero

list.Reverse(); //invierte el orden de la lista
list.ForEach(item => Console.WriteLine(item));

Console.WriteLine(list.Contains("Carlangas")); //retorna si esta o no esta en la lista
Console.WriteLine(list.Exists(e => e.Equals("Carlangas"))); //uso de la expresion lambda
list.Clear();
*/
#endregion clase generica List

#region Lista Enlazada
/*
var list = new ListaNodo();
list.ListaVacia();
//list.agregarNodo(5);
list.agregarNodo(1);
list.agregarNodo(2);
list.agregarNodo(4);
list.agregarNodo(3);
list.Listar();
list.Sustituir(3, 6);
//list.BorrarUltimo();
//list.BorrarPrimero();
//list.BorrarPosicion(2);
Console.WriteLine();
list.Listar();
Console.WriteLine();
list.ListaVacia();

Console.ReadLine();
*/
#endregion Lista Enlazada

#region Herencia de clases
/*
namespace Tutorial_Udemy
{
    class Program : Padre//cuenta como sub clase, hereda todo lo publico de la clase padre
    {
        public Program(string mensaje) : base(mensaje)
        {

        }
        static void Main()
        {
            new Program("Carlos es pendejo").Hola();
            new Program("Carlos es pendejo").Adios();
        }

        public void Hola() // una forma de sobre escribir un metodo
        {
            Console.WriteLine("Hola");
        }
        public override void Adios() //Forma correcta segun el profesor para sobre escribir un metodo
        {
            Console.WriteLine("Adios");
        }
    }
}
*/
#endregion Herencia de clases

#region clase abstracta e interfaces
/*
namespace Tutorial_Udemy
{
    //no puedes tener varias clases padres, pero si puedes tener cuantas interfaces quieras
    class Program : Abstracto, ICosa //Estas forzado a reescribir todos los metodos abstractos del padre
    {
        public override void mensaje() //necesitas usar el override
        {
            Console.WriteLine("Carlos es puto");
            base.Adios(); // te permite acceder todo lo que no sea abstracto de una clase abstracta
        }

        public void gato()
        {
            Console.WriteLine("Gato");
        }
        static void Main()
        {
            new Program().mensaje();
            new Program().gato();
        }
    }
}
interface ICosa //Se recomienda poner I al principio
{
    public void gato();
}
*/
/*
namespace Tutorial_Udemy
{
    class Program : Menu
    {
        static void Main()
        {
            bool valor = false;
            var programa = new Program();
            do
            {
                Console.WriteLine("Bienvenido a mi tienda\nQuisieras comprar frutas o golosinas? f/g");
                var input = Console.ReadLine().ToLower();
                switch (input)
                {
                    case "f":
                        programa.frutas();
                        valor = false;
                        break;
                    case "g":
                        programa.golosinas();
                        valor = false;
                        break;
                    default:
                        valor = true; break;

                }
            } while (valor);


            Almacen alGolosinas = new Golosinas(); // ESto es polimorfismo te permite crear un objeto del tipo almacen
            Almacen alFrutas = new Frutas(); // pero es una instancia de la clase hija
        }
        private void golosinas() // Como el main es estatico no te deja instanciar la clase menu 
        {
            golosinas(); // por lo que no te deja usar este metodo
        }
        private void frutas()
        {
            frutas();
        }
    }
}
*/
#endregion clases abstractas e interfaces

var Generica = new claseGenerica<Books>();
Generica.Add(new Books
{
    ID = 1,
    Nombre = "Don Quijote de la mancha"
});
Generica.Add(new Books
{
    ID = 1,
    Nombre = "100 años de soledad"
});

Console.WriteLine(Generica.Get(1));

//var juego = new Juego<Categoria>(); 
//juego.Categoria = new Categoria
//{
//    Precio = 50,
//    Nombre = "Clair obscure: Expedition 33",
//    categoria = "Juego por turnos",
//    Tipo ="AA"
//};

//Console.WriteLine("Juego");
//Console.WriteLine($"Precio {juego.Categoria.Precio}$");
//Console.WriteLine($"Nombre : {juego.Categoria.Nombre}");
//Console.WriteLine($"Categoria: {juego.Categoria.categoria}");
//Console.WriteLine($"Tipo: {juego.Categoria.Tipo}");
Console.ReadLine();