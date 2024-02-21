// Solicitar al usuario el tipo de servicio ("lavado de auto", "cambio de aceite", "revisión mecánica") y mostrar el importe a pagar.

try
{
    Console.WriteLine("Lavado de auto => Opción A");
    Console.WriteLine("Cambio de aceite => Opción B");
    Console.WriteLine("Revisión mecánica => Opción C");
    Console.WriteLine("Ingrese el tipo de servicio:");
    string serviceSelected = Console.ReadLine()!.ToLower();

    double total;
    string serviceType;

    switch (serviceSelected)
    {
        case "a":
            total = 35.0;
            serviceType = "Lavado de auto";
            break;

        case "b":
            total = 50.0;
            serviceType = "Cambio de aceite";
            break;

        case "c":
            total = 250.0;
            serviceType = "Revisión mecánica";
            break;

        default:
            Console.WriteLine("Servicio no válido.");
            return;
    }

    Console.WriteLine($"El importe a pagar por {serviceType} es: Q{total}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
