//Solicitar al usuario tres números y mostrar el mayor de ellos.

double n1, n2, n3;

try
{
    Console.WriteLine("Ingrese el primer número:");
    n1 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Ingrese el segundo número:");
    n2 = Convert.ToDouble(Console.ReadLine()!);

    Console.WriteLine("Ingrese el tercer número:");
    n3 = Convert.ToDouble(Console.ReadLine()!);

    double biggerN = Math.Max(n1, Math.Max(n2, n3));

    Console.WriteLine($"El mayor número ingresado es: {biggerN}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}