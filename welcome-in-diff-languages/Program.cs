// Solicitar al usuario el idioma de su preferencia ("español", "inglés", "francés") y mostrar un mensaje de bienvenida en el idioma seleccionado.

try
{
    Console.WriteLine("Español => Opción A");
    Console.WriteLine("Inglés => Opción B");
    Console.WriteLine("Francés => Opción C");
    Console.WriteLine("Ingrese su idioma preferido:");
    string languageSelected = Console.ReadLine()!.ToLower();

    string message;

    switch (languageSelected)
    {
        case "a":
            message = "¡Bienvenido!";
            break;

        case "b":
            message = "Welcome!";
            break;

        case "c":
            message = "Bienvenue!";
            break;

        default:
            Console.WriteLine("Idioma no válido.");
            return;
    }

    Console.WriteLine($"{message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
