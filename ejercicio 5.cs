# Aquí vamos, ¡20 numerillos! 🎉
using System;

nums = [int(input(f"Dame tu número #{i+1}: ")) for i in range(20)]

# Cuenta mágica: pares 😎 vs impares 🧙♂️
pares = sum(1 for num in nums if num % 2 == 0)
            impares = 20 - pares  # Trucazo matemático 🔥

print(f"Pares: {pares} 😎 | Impares: {impares} 🧙♂️")