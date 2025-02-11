using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int filas = 10, columnas = 3;
        double[,] matriz = new double[filas, columnas];
        Random rnd = new Random();

        // Llenar la matriz 
        for (int i = 0; i < filas; i++)
        {
            matriz[i, 0] = Math.Round(rnd.NextDouble() * 10, 2); // Grupo A
            matriz[i, 1] = Math.Round(rnd.NextDouble() * 10, 2); // Grupo B
        }

        // use Parallel.For por que vi que es la mejor forma de optimizar la ejecución en matrices más grandes si el programa se expande
        Parallel.For(0, filas, i =>
        {
            matriz[i, 2] = Math.Max(matriz[i, 0], matriz[i, 1]);
        });

        // Mostrar la matriz en este caso
        Console.WriteLine("Grupo A  |  Grupo B  |  Mayor Promedio");
        for (int i = 0; i < filas; i++)
        {
            Console.WriteLine($"{matriz[i, 0],7}  |  {matriz[i, 1],7}  |  {matriz[i, 2],7}");
        }
    }
}
