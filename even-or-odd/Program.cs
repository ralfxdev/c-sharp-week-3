// Solicitar un número al usuario e indicar si es par o impar.

try
{
    Console.WriteLine("Ingrese un número:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} es un número par.");
    }
    else
    {
        Console.WriteLine($"{number} es un número impar.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}