// Solicitar la edad del usuario y permitir el ingreso al club solo si es mayor o igual a 18 años.

try
{
    Console.WriteLine("Ingrese su edad:");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age >= 18)
    {
        Console.WriteLine("Bienvenido al club");
    }
    else
    {
        Console.WriteLine("Lo siento, no cumples con la edad requerida para ingresar al club.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}