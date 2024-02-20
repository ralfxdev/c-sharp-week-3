// Solicitar al user un nombre de user y una contraseña. Permitir el acceso solo si las credenciales son correctas ("user" y "contraseña").

try
{
    string user = "admin";
    string password = "password";

    Console.WriteLine("Ingrese su nombre de user:");
    string enteredUser = Console.ReadLine()!;

    Console.WriteLine("Ingrese su contraseña:");
    string enteredPassword = Console.ReadLine()!;

    // Verificar las credenciales
    if (enteredUser == user && enteredPassword == password)
    {
        Console.WriteLine($"Bienvenido, {user}.");
    }
    else
    {
        Console.WriteLine("Credenciales incorrectas. Acceso denegado.");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}