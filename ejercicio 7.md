# Cálculo de Cuadrados y Cubos de Números

Este programa en C# solicita al usuario ingresar 20 números y luego calcula el cuadrado y el cubo de cada uno de ellos. Los resultados se muestran en una tabla con los números originales, sus cuadrados y cubos correspondientes.

## ¿Qué hace el programa?

1. **Ingreso de números**:  
   El programa solicita al usuario ingresar 20 números, uno por uno.

2. **Cálculo del cuadrado y cubo**:  
   Para cada número ingresado, el programa calcula:
   - **Cuadrado**: El número multiplicado por sí mismo.
   - **Cubo**: El cuadrado del número multiplicado por el número original.

3. **Mostrar los resultados**:  
   Al final, el programa muestra una tabla con los números originales, sus cuadrados y cubos.

## Código y Lógica

- **Ingreso de datos**:  
   Usamos un `for` loop para pedirle al usuario que ingrese 20 números. Los números se guardan en un arreglo `numeros`.

- **Cálculo de potencias**:  
   El programa utiliza la función recursiva `CalcularPotencias` para calcular los cuadrados y cubos de los números en el arreglo.

- **Mostrar los resultados**:  
   Después de calcular los cuadrados y cubos, se muestran en una tabla con la siguiente estructura:
