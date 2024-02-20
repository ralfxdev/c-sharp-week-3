// Solicitar el precio original del producto y aplicar un descuento del 10% si el precio es mayor a Q100. Mostrar el precio final.

try
{
    Console.WriteLine("Ingrese el precio del producto:");
    double price = Convert.ToDouble(Console.ReadLine());

    double finalPrice;

    if (price > 100)
    {
        // Aplicar un descuento del 10%
        double discount = price * 0.10;
        finalPrice = price - discount;
        Console.WriteLine("Se aplicó un descuento del 10%.");
        Console.WriteLine($"Total del descuento Q{discount}");
    }
    else
    {
        finalPrice = price;
        Console.WriteLine("El precio no supera los Q100. No aplica descuento.");
    }

    Console.WriteLine($"El precio final del producto es: Q{finalPrice}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}