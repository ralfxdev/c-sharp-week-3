// Solicitar al usuario el monto del préstamo y su edad. Aprobar el préstamo si el monto es menor a $5000 o si el usuario es mayor de 60 años.

try
{
    Console.WriteLine("Ingrese el monto que quiere solicitar como préstamo:");
    double loanAmount = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese su edad:");
    int age = Convert.ToInt32(Console.ReadLine());

    // Verificar requerimientos
    if (loanAmount < 5000 || age > 60)
    {
        Console.WriteLine($"Préstamo Aprobado. Se te acreditaron ${loanAmount}");
    }
    else
    {
        Console.WriteLine("Préstamo rechazado. No cumples con los requerimientos.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
