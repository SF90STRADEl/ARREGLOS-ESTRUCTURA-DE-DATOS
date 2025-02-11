using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        double[] grupo1 = new double[5];
        double[] grupo2 = new double[5];
        double[] promediosAltos = new double[5];

        for (int i = 0; i < 5; i++)
        {
            grupo1[i] = Math.Round(random.NextDouble() * 100, 2);
            grupo2[i] = Math.Round(random.NextDouble() * 100, 2);
            promediosAltos[i] = Math.Max(grupo1[i], grupo2[i]);
        }

        Console.WriteLine("Promedios del Grupo 1:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Alumno {i + 1}: {grupo1[i]}");
        }

        Console.WriteLine("\nPromedios del Grupo 2:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Alumno {i + 1}: {grupo2[i]}");
        }

        Console.WriteLine("\nLos promedios mas altos son:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Posicion {i + 1}: {promediosAltos[i]}");
        }
    }
}