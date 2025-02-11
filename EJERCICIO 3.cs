using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Lista para almacenar calificaciones y promedios
        List<(double Parcial1, double Parcial2, double Parcial3, double Promedio)> calificaciones = new();
        Random rand = new();

        // Llenar la lista con datos aleatorios y calcular promedios
        Parallel.For(0, 5, i =>
        {
            var parciales = Enumerable.Range(0, 3).Select(_ => rand.Next(60, 100) / 10.0).ToArray();
            double promedio = parciales.Average();
            lock (calificaciones)
            {
                calificaciones.Add((parciales[0], parciales[1], parciales[2], promedio));
            }
        });

        // Imprimir resultados con LINQ
        Console.WriteLine("Calificaciones y promedios:");
        calificaciones.Select((alumno, index) => $"Alumno {index + 1}: {alumno.Parcial1:F2} {alumno.Parcial2:F2} {alumno.Parcial3:F2} Promedio: {alumno.Promedio:F2}")
                      .ToList()
                      .ForEach(Console.WriteLine);
    }
}
