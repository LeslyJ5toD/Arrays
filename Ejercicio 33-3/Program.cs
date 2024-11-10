using System;

class Program
{
    static void MostrarEstudiantesYCalificaciones(string[] estudiantes, int[] calificaciones)
    {

        for (int i = 0; i < estudiantes.Length; i++)
        {
            Console.WriteLine($"Estudiante: {estudiantes[i]}, Calificación: {calificaciones[i]}");
        }
    }

    static void Main(string[] args)
    {

        Console.Write("¿Cuántos estudiantes deseas ingresar? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        string[] estudiantes = new string[cantidad];
        int[] calificaciones = new int[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Introduce el nombre del estudiante {i + 1}: ");
            estudiantes[i] = Console.ReadLine();

            Console.Write($"Introduce la calificación de {estudiantes[i]}: ");
            calificaciones[i] = Convert.ToInt32(Console.ReadLine());
        }

        MostrarEstudiantesYCalificaciones(estudiantes, calificaciones);
    }
}
