using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[20];
        int pares = 0;

        // Pedir 20 
        Console.WriteLine("# Aquí vamos, ¡20 numerillos! 🎉");
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Dame tu número #{i + 1}: ");
            nums[i] = int.Parse(Console.ReadLine());

            // Contar pares
            if (nums[i] % 2 == 0)
                pares++;
        }

        int impares = 20 - pares; // Trucazo matemático 🔥

        // Mostrar resultados
        Console.WriteLine($"Pares: {pares} 😎 | Impares: {impares} 🧙♂️");
    }
}
