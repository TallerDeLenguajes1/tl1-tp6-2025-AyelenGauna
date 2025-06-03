string opcion;
int numero;
Console.WriteLine("*** CALCULADORA ***");

do
{
    do
    {
        Console.WriteLine("\nOpciones:\n5)Valor Absoluto  6)Cuadrado de un número  7)Raíz cuadrada de un número mayor/igual a 0  8)Seno  9)Coseno  10)Parte entera de un tipo float");
        opcion = Console.ReadLine();

        if (int.TryParse(opcion, out numero) && (numero > 4 && 11 > numero))
        {
            string numS;
            double numN;

            do
            {
                Console.WriteLine("\nNúmero:");
                numS = Console.ReadLine();

                if (double.TryParse(numS, out numN))
                {
                    switch (numero)
                    {
                        case 5:
                            double vAbs = Math.Abs(numN);
                            Console.WriteLine($"|{numN}| = {vAbs}");
                            break;
                        case 6:
                            double pow = Math.Pow(numN, 2);
                            Console.WriteLine($"{numN}^2 = {pow}");
                            break;
                        case 7:
                            if (numN >= 0)
                            {
                                double raiz = Math.Sqrt(numN);
                                Console.WriteLine($"Sqrt({numN}) = {raiz}");
                            }
                            else
                            {
                                Console.WriteLine("No se puede calcular la raíz de indice par a un número negativo");
                            }
                            break;
                        case 8:
                            double sen = Math.Sin(numN);
                            Console.WriteLine($"Sen({numN}) = {sen}");
                            break;
                        case 9:
                            double cos = Math.Cos(numN);
                            Console.WriteLine($"Cos({numN}) = {cos}");
                            break;
                        case 10:
                            double entero = Math.Truncate(numN);
                            Console.WriteLine($"Parte entera del decimal {numN} = {entero}");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("El dato ingresado no es válido");
                }

            } while (!double.TryParse(numS, out numN));

        }
        else
        {
            Console.WriteLine("El dato ingresado no es un número o no es una opción válida\n");
        }

    } while (!(int.TryParse(opcion, out numero)) || (numero < 5 || 10 < numero));

    do
    {
        Console.WriteLine("\n¿Desea realizar otra operación? SÍ = 1 ó NO = 0");
        opcion = Console.ReadLine();

        if (!int.TryParse(opcion, out numero) || (numero != 0 && numero != 1))
        {
            Console.WriteLine("La opción o el dato ingresado es inválido");
        }

    } while (!int.TryParse(opcion, out numero) || (numero != 0 && numero != 1));

} while (!int.TryParse(opcion, out numero) || numero == 1);


