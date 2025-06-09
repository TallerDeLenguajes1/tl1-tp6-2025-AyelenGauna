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

// ----------------------------------------------------------------------------------

string opcion;
int numero;
Console.WriteLine("*** CALCULADORA SIMPLE ***");

    do
    {
        Console.WriteLine("\nOpciones:\n1)Suma  2)Resta  3)Multiplicación  4)División");
        opcion = Console.ReadLine();

    if (int.TryParse(opcion, out numero) && (numero > 0 && 5 > numero))
    {
        string mensaje = "";
        int num1N, num2N, resultado;

        Console.WriteLine("\nNúmero 1: ");
        num1N = int.Parse(Console.ReadLine());

        Console.WriteLine("\nNúmero 2: ");
        num2N = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                resultado = num1N + num2N;
                mensaje = $"La suma de {num1N} y {num2N} es igual a: {resultado}";
                break;
            case 2:
                resultado = num1N - num2N;
                mensaje = $"La resta de {num1N} y {num2N} es igual a: {resultado}";
                break;
            case 3:
                resultado = num1N * num2N;
                mensaje = $"La multiplicación de {num1N} y {num2N} es igual a: {resultado}";
                break;
            case 4:
                if (num2N == 0)
                {
                    Console.WriteLine("No se puede dividir sobre 0");
                }
                else
                {
                    resultado = num1N / num2N;
                    mensaje = $"La división de {num1N} y {num2N} es igual a: {resultado}";
                }
                break;
        }

        if (mensaje != "")
        {
            Console.WriteLine($"\n{mensaje}\n");
            Console.WriteLine($"*** MENSAJE DEL RESULTADO DE LA OPERACIÓN MATEMÁTICA IMPRESO CARACTER POR CARACTER ***\n");

            foreach (var letra in mensaje)
            {
                Console.WriteLine(letra);
            }
        }   

    }
    else
    {
        Console.WriteLine("El dato ingresado no es un número o no es una opción válida\n");
    }

    } while (!(int.TryParse(opcion, out numero)) || (numero < 1 || 4 < numero));

    Console.WriteLine("\n*** OCURRENCIAS DE UNA PALABRA ***\n");
    Console.Write("Ingresá la palabra que querés buscar del primer texto: ");
    string palabra = Console.ReadLine();
    int ocurrencia = 0, posicion = 0;

    while ((posicion = texto1.IndexOf(palabra, posicion, StringComparison.OrdinalIgnoreCase)) != -1)
    {
        ocurrencia++;
        posicion += palabra.Length;
    }

    if (ocurrencia != 0)
    {
        Console.WriteLine($"\n'{palabra}' aparece {ocurrencia} vez/veces\n");
    }
    else
    {
        Console.WriteLine($"\n'{palabra}' no aparece en el primer texto\n");
    }

    Console.WriteLine("\n*** CONVERSIÓN ***\n");
    Console.WriteLine($"Conversión a MAYÚSCULAS del primer texto: {texto1.ToUpper()}\n");
    Console.WriteLine($"Conversión a MINÚSCULAS del primer texto: {texto1.ToLower()}\n");

    Console.WriteLine("\n*** SEPARANDO POR CARACTERES ***\n");
    string cadena, cadenaLimpia;
    Console.Write("Ingresá palabras separadas por guiones (-): ");
    cadena = Console.ReadLine();
    cadenaLimpia = cadena.Trim();
    string[] palabras = cadenaLimpia.Split('-');

    Console.WriteLine("\nPalabras separadas\n");
    foreach (string palabraSeparada in palabras)
    {
        Console.WriteLine($"{palabraSeparada}");
    }

Console.WriteLine("\nIngrese en formato de cadena la una operación matemática simple que quiere resolver\nPor ej: 24+56");
string ecuacion;
char operador = ' ';
ecuacion = Console.ReadLine();

foreach (char c in ecuacion)
{
    if (c == '+' || c == '-' || c == '*' || c == '/')
    {
        operador = c;
        posicion = ecuacion.IndexOf(c);
        break;
    }
}

if (posicion == -1)
{
    Console.WriteLine("\nNo se encontró un operador válido.");
}else
{
    string izquierda = ecuacion.Substring(0, posicion).Trim();
    string derecha = ecuacion.Substring(posicion + 1).Trim();

    int num1 = int.Parse(izquierda);
    int num2 = int.Parse(derecha);

    int resultado = 0;
    bool valido = true;

    switch (operador)
    {
        case '+':
            resultado = num1 + num2;
            break;
        case '-':
            resultado = num1 - num2;
            break;
        case '*':
            resultado = num1 * num2;
            break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("\nNo se puede dividir por cero.");
                valido = false;
            }
            else
            {
                resultado = num1 / num2;
            }
            break;
        }

        if (valido)
        {
            Console.WriteLine($"\nResultado: {num1} {operador} {num2} = {resultado}");
        }
}
