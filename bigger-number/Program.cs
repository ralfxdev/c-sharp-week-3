double n1, n2, n3;

try
{
    Console.WriteLine("Ingrese el primer número:");
    n1 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Ingrese el segundo número:");
    n2 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Ingrese el tercer número:");
    n3 = Convert.ToDouble(Console.ReadLine()!);

    double mayor = Math.Max(n1, Math.Max(n2, n3));

    Console.WriteLine($"El mayor número ingresado es: {mayor}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}