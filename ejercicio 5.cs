using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[20];

        // Pedir al usuario que ingrese los 20 números
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Dame tu número #{i + 1}: ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        // Contar los números pares e impares
        int pares = 0;
        foreach (var num in nums)
        {
            if (num % 2 == 0) // Si el número es par
            {
                pares++;
            }
        }

        int impares = 20 - pares; // El resto serán impares

        // Mostrar los resultados
        Console.WriteLine($"Pares: {pares} 😎 | Impares: {impares} 🧙♂️");
    }
}
