string texto1, texto2, cadenaTextos;
int longitud1;

Console.WriteLine("Ingrese el primer texto");
texto1 = Console.ReadLine();
longitud1 = texto1.Length;
Console.WriteLine($"\nLongitud del primer texto: {longitud1}\n");

Console.WriteLine("Ingrese el segundo texto");
texto2 = Console.ReadLine();
cadenaTextos = string.Concat(texto1, texto2);
Console.WriteLine($"\nConcatenación del primer y segundo texto: {cadenaTextos}\n");
