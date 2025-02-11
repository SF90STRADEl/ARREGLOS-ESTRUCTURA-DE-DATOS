class Program
{
    static void Main()
    {
        // Arreglos con los promedios de dos grupos
        double[] grupo1 = { 7.8, 9.1, 6.5, 8.2, 7.4 };
        double[] grupo2 = { 8.5, 6.9, 7.2, 8.7, 7.9 };
        double[] mayores = new double[5];

        // Llamada recursiva para llenar el arreglo de los mayores
        CalcularMayores(grupo1, grupo2, mayores, 0);

        // Imprimir resultados
        Console.WriteLine("Promedios más altos de cada posición:");
        ImprimirArreglo(mayores, 0);
    }

    // Relación de recurrencia para calcular los mayores
    static void CalcularMayores(double[] g1, double[] g2, double[] mayores, int index)
    {
        if (index < g1.Length)
        {
            mayores[index] = EncontrarMayor(g1[index], g2[index]);
            CalcularMayores(g1, g2, mayores, index + 1);
        }
    }

    // Relación de recurrencia para imprimir el arreglo
    static void ImprimirArreglo(double[] arr, int index)
    {
        if (index < arr.Length)
        {
            Console.WriteLine($"Posición {index}: {arr[index]}");
            ImprimirArreglo(arr, index + 1);
        }
    }

    // Función recursiva para encontrar el mayor entre dos números
    static double EncontrarMayor(double a, double b)
    {
        if (EsMayor(a, b))
            return a;
        return b;
    }

    // Función auxiliar recursiva para determinar si un número es mayor que otro
    static bool EsMayor(double a, double b)
    {
        return a > b ? true : false;
    }
}
