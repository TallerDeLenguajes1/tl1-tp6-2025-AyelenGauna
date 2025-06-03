string texto1, texto2, cadenaTextos, subcadena1, subcadena2;
int longitud1;

Console.WriteLine("Ingrese el primer texto");
texto1 = Console.ReadLine();
longitud1 = texto1.Length;
Console.WriteLine($"\nLongitud del primer texto: {longitud1}\n");

Console.WriteLine("Ingrese el segundo texto");
texto2 = Console.ReadLine();
cadenaTextos = string.Concat(texto1, texto2);
Console.WriteLine($"\nConcatenación del primer y segundo texto: {cadenaTextos}\n");

subcadena1 = texto1.Substring(5);
Console.WriteLine($"\nSubcadena del primer texto: {subcadena1}\n");

subcadena2 = texto2.Substring(5);
Console.WriteLine($"\nSubcadena del segundo texto: {subcadena2}\n");
