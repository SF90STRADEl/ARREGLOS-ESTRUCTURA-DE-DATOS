# Contador de Pares e Impares

Este programa en C# permite contar cuántos números ingresados por el usuario son pares y cuántos son impares. El programa solicita al usuario que ingrese 20 números y luego realiza los cálculos y muestra los resultados.

## ¿Qué hace el programa?

1. **Ingreso de números**:  
   El programa solicita al usuario ingresar 20 números, uno por uno.

2. **Contar los números pares e impares**:  
   El programa cuenta cuántos de esos números son pares y cuántos son impares.

3. **Mostrar los resultados**:  
   Al final, el programa muestra cuántos números son pares y cuántos son impares, con algunos emojis para darle un toque divertido.

## Código y Lógica

- **Ingreso de datos**:  
   Usamos un `for` loop para pedirle al usuario que ingrese 20 números. Los números ingresados se guardan en un arreglo `nums`.

- **Contar pares**:  
   Cada número es evaluado en un ciclo `for`. Si es divisible por 2 (`num % 2 == 0`), se cuenta como par. Si no lo es, automáticamente se considera impar.

- **Validación de entrada**:  
   Usamos `int.TryParse()` para asegurar que solo se ingresen números válidos. Si el usuario ingresa algo que no es un número, se le solicita nuevamente el valor.

- **Cálculo de impares**:  
   Los impares se calculan restando el número de pares de 20, que es el total de números solicitados.

- **Mostrar los resultados**:  
   Finalmente, el programa imprime cuántos números fueron pares y cuántos impares, con un mensaje amigable para el usuario.
