using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[20]; // Aquí guardamos los números sin modificar
        int[] cuadrados = new int[20]; // Aquí guardamos los cuadrados
        int[] cubos = new int[20]; // Aquí guardamos los cubos

        Console.WriteLine("¡Vamos a capturar 20 numeritos! 📥");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Dame el número #{i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // Llenar los arreglos de cuadrados y cubos magic 
        CalcularPotencias(numeros, cuadrados, cubos, 0, 20);

        // Mostrar los resultados
        Console.WriteLine("\nResultados finales 🚀:");
        Console.WriteLine("Número | Cuadrado | Cubo");
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"{numeros[i],6} | {cuadrados[i],8} | {cubos[i],4}");
        }
    }

    static void CalcularPotencias(int[] nums, int[] cuad, int[] cub, int inicio, int fin)
    {
        if (inicio >= fin) return; // Si ya terminamos, nos vamos de aquí, por que para que mas chamba

        int medio = (inicio + fin) / 2;
        cuad[medio] = nums[medio] * nums[medio]; // Sacamos el cuadrado ✖️
        cub[medio] = cuad[medio] * nums[medio]; // Sacamos el cubo ✖️✖️

        // Llamamos recursivamente para las mitades izquierda y derecha
        CalcularPotencias(nums, cuad, cub, inicio, medio);
        CalcularPotencias(nums, cuad, cub, medio + 1, fin);
    }
}
