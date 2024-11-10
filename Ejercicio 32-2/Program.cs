using System;

class Programa
{
    static void Main()
    {
        Console.Write("Introduce el número de tipos de dispositivos: ");
        int numDispositivos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el número de almacenes: ");
        int numAlmacenes = Convert.ToInt32(Console.ReadLine());

        int[,] inventario = new int[numDispositivos, numAlmacenes];
        string[] dispositivos = new string[numDispositivos];

        for (int i = 0; i < numDispositivos; i++)
        {
            Console.Write($"Introduce el nombre del dispositivo {i + 1}: ");
            dispositivos[i] = Console.ReadLine();
        }

        for (int i = 0; i < numDispositivos; i++)
        {
            for (int j = 0; j < numAlmacenes; j++)
            {
                Console.Write($"Introduce la cantidad de {dispositivos[i]} en el almacén {j + 1}: ");
                inventario[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (int j = 0; j < numAlmacenes; j++)
        {
            int totalAlmacen = 0;
            int maxCantidad = int.MinValue;
            int minCantidad = int.MaxValue;
            string dispositivoMayor = "";
            string dispositivoMenor = "";

            for (int i = 0; i < numDispositivos; i++)
            {
                totalAlmacen += inventario[i, j];

                if (inventario[i, j] > maxCantidad)
                {
                    maxCantidad = inventario[i, j];
                    dispositivoMayor = dispositivos[i];
                }

                if (inventario[i, j] < minCantidad)
                {
                    minCantidad = inventario[i, j];
                    dispositivoMenor = dispositivos[i];
                }
            }

            Console.WriteLine($"\nAlmacén {j + 1}:");
            Console.WriteLine($"- Cantidad total de dispositivos: {totalAlmacen}");
            Console.WriteLine($"- Dispositivo con mayor cantidad: {dispositivoMayor} ({maxCantidad})");
            Console.WriteLine($"- Dispositivo con menor cantidad: {dispositivoMenor} ({minCantidad})");
        }
    }
}
