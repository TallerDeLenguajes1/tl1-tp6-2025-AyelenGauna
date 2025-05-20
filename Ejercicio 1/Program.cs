// See https://aka.ms/new-console-template for more information

int numero;
string textoNumero;
bool resultado;

do
{
    Console.WriteLine("Ingrese un número mayor a 0");
    textoNumero = Console.ReadLine();

    resultado = int.TryParse(textoNumero, out numero);

    if (resultado)
    {
        Console.WriteLine("\nEl texto ingresado es un numero");
    }else
    {
        Console.WriteLine("\nEl texto ingresado NO es un numero\n");
    }

} while (!resultado);
 
if (numero > 0)
{
    Console.WriteLine("El numero ingresado es mayor a 0");
}else
{
    Console.WriteLine("El numero ingresado es menor o igual 0");
    
}