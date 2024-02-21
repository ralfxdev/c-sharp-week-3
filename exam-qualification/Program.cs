// Solicitar al usuario la calificación de un examen y mostrar su desempeño, modifica el programa:

/* Explicación:
 * Se solicita al usuario la calificación del examen.
 * La calificación se evalúa con la sentencia switch.
 * Se muestran diferentes mensajes de acuerdo al rango de la calificación:
 * - 90-100: Sobresaliente
 * - 80-89: Notable
 * - 70-79: Aprobatoria
 * - 60-69: No aprobatoria
 * Se muestra un mensaje de error si la calificación no es válida.
 */

/* Haz estas modificaciones:
 * Puedes modificar los rangos de las calificaciones y los mensajes que se muestran.
 * Puedes agregar más casos para evaluar otras calificaciones especiales, como la calificación mínima para aprobar el examen.
 * Puedes usar la sentencia ifpara evaluar si la calificación es un número entero.
 */

try
{
    Console.WriteLine("Ingrese la calificación del examen:");
    double qualification = Convert.ToDouble(Console.ReadLine());

    string message;

    if (qualification < 0 || qualification > 100)
    {
        Console.WriteLine("Error: La calificación debe estar en el rango de 0 a 100.");
        return;
    }

    if (qualification % 1 != 0)
    {
        Console.WriteLine("Error: La calificación debe ser un número entero.");
        return;
    }

    switch (qualification)
    {
        case 100:
            message = "Perfecto";
            break;
        case >= 90 and <= 99:
            message = "Sobresaliente";
            break;
        case >= 80 and <= 89:
            message = "Notable";
            break;
        case >= 71 and <= 79:
            message = "Aprobatoria";
            break;
        case 70:
            message = "Mínimo";
            break;
        case >= 60 and <= 69:
            message = "No Aprobatoria";
            break;
        default:
            message = "Insuficiente";
            break;
    }

    Console.WriteLine($"Tu desempeño en el examen es: {message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ups, hubo un error {ex.Message}");
}
