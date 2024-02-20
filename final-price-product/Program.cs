// Solicitar el precio original del producto y aplicar un descuento del 10% si el precio es mayor a Q100. Mostrar el precio final.

try
{
    Console.WriteLine("Ingrese el precio del producto:");
    double precio = Convert.ToDouble(Console.ReadLine());

    double precioFinal;

    if (precio > 100)
    {
        // Aplicar un descuento del 10%
        double descuento = precio * 0.10;
        precioFinal = precio - descuento;
        Console.WriteLine("Se aplicó un descuento del 10%.");
    }
    else
    {
        precioFinal = precio;
        Console.WriteLine("El precio no supera los Q100. No aplica descuento.");
    }

    Console.WriteLine("El precio final del producto es: Q" + precioFinal);
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}