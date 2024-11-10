using System;

class Programa
{
    static void Main()
    {
        int[] arreglo1 = new int[10];
        int[] arreglo2 = new int[10];
        int[] sumaArreglos = new int[10];

        Console.WriteLine("Introduce 10 números enteros para el primer arreglo:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            arreglo1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nIntroduce 10 números enteros para el segundo arreglo:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Número {i + 1}: ");
            arreglo2[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
        {
            sumaArreglos[i] = arreglo1[i] + arreglo2[i];
        }

        Console.WriteLine("\nLa suma de los dos arreglos es:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{arreglo1[i]} + {arreglo2[i]} = {sumaArreglos[i]}");
        }
    }
}
