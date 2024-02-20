// Solicitar al usuario el tipo de figura geométrica (triángulo, cuadrado o círculo) y sus dimensiones. Calcular y mostrar el área de la figura.

try
{
    Console.WriteLine("Seleccione el tipo de figura geométrica:");
    Console.WriteLine("1. Triángulo");
    Console.WriteLine("2. Cuadrado");
    Console.WriteLine("3. Círculo");

    int option = Convert.ToInt32(Console.ReadLine());

    double area = 0;

    switch (option)
    {
        case 1:
            Console.WriteLine("Ingrese la base del triángulo:");
            double baseTriangle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triángulo:");
            double heightTriangle = Convert.ToDouble(Console.ReadLine());

            area = 0.5 * baseTriangle * heightTriangle;
            break;

        case 2:
            Console.WriteLine("Ingrese el lado del cuadrado:");
            double sideSquare = Convert.ToDouble(Console.ReadLine());

            area = sideSquare * sideSquare;
            break;

        case 3:
            Console.WriteLine("Ingrese el radio del círculo:");
            double radiusCircle = Convert.ToDouble(Console.ReadLine());

            area = Math.PI * radiusCircle * radiusCircle;
            break;

        default:
            Console.WriteLine("Opción no válida. Por favor, seleccione 1, 2 o 3.");
            return;
    }

    Console.WriteLine("El área de la figura es: " + area);
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
