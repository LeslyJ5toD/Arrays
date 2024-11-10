using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("¿Cuántos números deseas ingresar? ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        int[] numeros = new int[cantidad];
        int sumatoria = 0;

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Introduce el número {i + 1}: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
            sumatoria += numeros[i]; 

            if (sumatoria >= 100)
            {
                Console.WriteLine($"La sumatoria de los números es: {sumatoria}");
                return;
            }
        }

        if (sumatoria < 100)
        {
            Console.WriteLine("La sumatoria de los números ingresados no alcanzó 100.");
        }
    }
}
