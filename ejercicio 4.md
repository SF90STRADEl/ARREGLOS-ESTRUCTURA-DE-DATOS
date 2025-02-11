# Comparación de Promedios entre Dos Grupos

Este programa genera una matriz de calificaciones aleatorias para dos grupos (A y B), calcula el mayor promedio de cada fila y luego imprime los resultados. Utiliza `Parallel.For` para optimizar la ejecución cuando el programa se expanda a matrices más grandes.

## ¿Qué hace el programa?

1. **Generación de calificaciones aleatorias**:  
   Se generan calificaciones aleatorias para los grupos A y B en una matriz de 10 filas y 2 columnas (una para cada grupo). Cada calificación se genera entre 0 y 10.

2. **Cálculo del mayor promedio**:  
   Para cada fila, el programa calcula el mayor promedio entre los dos grupos (A y B) y lo guarda en una tercera columna.

3. **Optimización con `Parallel.For`**:  
   Se usa `Parallel.For` para optimizar la asignación de valores en la tercera columna, lo que mejora la eficiencia al trabajar con matrices más grandes.

4. **Impresión de los resultados**:  
   El programa imprime las calificaciones de ambos grupos y el mayor promedio de cada fila.

## Código y Lógica

- **Generación de calificaciones**:  
   La matriz se llena con calificaciones aleatorias entre 0 y 10 para los grupos A y B.

- **Programación paralela**:  
   Usando `Parallel.For`, el programa asigna los valores del mayor promedio en la tercera columna de forma eficiente.

- **Impresión formateada**:  
   Los resultados se imprimen de forma tabulada, mostrando los valores de los dos grupos y el mayor promedio.
