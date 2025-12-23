// See https://aka.ms/new-console-template for more information


using Exceptions;

try
{
    int[] arr = { };
    int data = arr[0];
}
catch(FormatException ex) // como esta es la clase padre de todas las excepciones, puedes usar polimorfismo para poder llamar a todas. Sirve cuando no conoces el tipo de excepcion
{
    string msg = ex.Message;

}
catch(IndexOutOfRangeException ex)
{
    //string msg = ex.Message;
    //Console.WriteLine(msg);
    throw new ExcepcionPersonalizada("Hubo un error manin");
}
catch(Exception ex) // Si colocaste una excepcion que cubre ya la escepcion que cubres, no te deja colocarla
{
    string msg = ex.Message;
    Console.WriteLine(msg);
}
finally //Siempre se ejecuta sin importar si hubo o no una excepcion
{
    Console.WriteLine("Siempre me ejecuto");
}

