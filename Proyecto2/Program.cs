string opcion;
int numero;
Console.WriteLine("*** CALCULADORA SIMPLE ***\nOpciones:\n1)Suma  2)Resta  3)Multiplicación  4)División");
opcion = Console.ReadLine();

if (int.TryParse(opcion, out numero) && (numero > 0 && 5 > numero))
{
    Console.WriteLine("El dato ingresado es un número");
    
}else
{
    Console.WriteLine("El dato ingresado no es un número o no es una opción válida");
}
