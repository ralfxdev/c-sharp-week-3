// Solicitar al usuario un número del 1 al 5 en letra ("uno", "dos", "tres", "cuatro", "cinco") y mostrar el número en dígito.

try
{
    Console.WriteLine("Ingrese un número del 1 al 5 en letra (uno, dos, tres, cuatro, cinco):");
    string numberInWords = Console.ReadLine()!.ToLower();

    int numberInDigit;

    switch (numberInWords)
    {
        case "uno":
            numberInDigit = 1;
            break;

        case "dos":
            numberInDigit = 2;
            break;

        case "tres":
            numberInDigit = 3;
            break;

        case "cuatro":
            numberInDigit = 4;
            break;

        case "cinco":
            numberInDigit = 5;
            break;

        default:
            Console.WriteLine("Número no válido.");
            return;
    }

    Console.WriteLine($"El número en dígito es: {numberInDigit}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
