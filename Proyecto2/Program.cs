string opcion;
int numero;
Console.WriteLine("*** CALCULADORA SIMPLE ***\nOpciones:\n1)Suma  2)Resta  3)Multiplicación  4)División");

do
{
    opcion = Console.ReadLine();
    
    if (int.TryParse(opcion, out numero) && (numero > 0 && 5 > numero))
    {
        string num1S, num2S;
        int num1N, num2N;

        Console.WriteLine("Número 1: ");
        num1S = Console.ReadLine();
        int.TryParse(num1S, out num1N);

        Console.WriteLine("Número 2: ");
        num2S = Console.ReadLine();
        int.TryParse(num2S, out num2N);

        switch (numero)
        {
            case 1:
                int suma = num1N + num2N;
                Console.WriteLine($"** SUMA **\n{num1S} + {num2S} = {suma}");
                break;
            case 2:
                int resta = num1N - num2N;
                Console.WriteLine($"** RESTA **\n{num1S} - {num2S} = {resta}");
                break;
            case 3:
                int multiplicación = num1N * num2N;
                Console.WriteLine($"** MULTIPLICACIÓN **\n{num1S} x {num2S} = {multiplicación}");
                break;
            case 4:
                if (num2N == 0)
                {
                    Console.WriteLine("No se puede dividir sobre 0");
                }
                else
                {
                    double división = (double)num1N / num2N;
                    Console.WriteLine($"** DIVISIÓN **\n{num1S} / {num2S} = {división}");
                }
                break;
        }

    }
    else
    {
        Console.WriteLine("El dato ingresado no es un número o no es una opción válida");
    }

} while (!(int.TryParse(opcion, out numero)) || (numero < 1 || 4 < numero));
