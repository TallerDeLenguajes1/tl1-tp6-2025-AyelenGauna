int numero = 0, longitudNumero;
string textoNumero;
bool resultado;

do
{
    Console.WriteLine("Ingrese un número mayor a 0");
    textoNumero = Console.ReadLine();

    resultado = int.TryParse(textoNumero, out numero);

    if (resultado && numero > 0)
    {
        longitudNumero = textoNumero.Length;
        string numeroInvertido = "";
        for (int i = 0; i < longitudNumero; i++)
        {
            numeroInvertido = numeroInvertido + textoNumero[(longitudNumero-1)-i];
        }
        Console.WriteLine("\nEl texto ingresado es un numero y es mayor a 0");
        Console.WriteLine($"\nEl número invertido es: {numeroInvertido}");
    }else
    {
        Console.WriteLine("\nEl texto ingresado NO es un numero o es menor o igual 0\n");
    }

} while (!resultado || numero <= 0);