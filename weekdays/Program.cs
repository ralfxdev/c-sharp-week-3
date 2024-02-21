// Solicitar al usuario un número del 1 al 7 y mostrar el día de la semana correspondiente.

try
{
    Console.WriteLine("Ingrese un número del 1 al 7:");
    int nDay = Convert.ToInt32(Console.ReadLine());

    string dayWeek;

    switch (nDay)
    {
        case 1:
            dayWeek = "Lunes";
            break;

        case 2:
            dayWeek = "Martes";
            break;

        case 3:
            dayWeek = "Miércoles";
            break;

        case 4:
            dayWeek = "Jueves";
            break;

        case 5:
            dayWeek = "Viernes";
            break;

        case 6:
            dayWeek = "Sábado";
            break;

        case 7:
            dayWeek = "Domingo";
            break;

        default:
            Console.WriteLine("Número no válido.");
            return;
    }

    Console.WriteLine($"El número {nDay} corresponde al día de la semana: {dayWeek}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
