# Cálculo de Promedios de Estudiantes con Datos Aleatorios

Este programa genera calificaciones aleatorias para 5 estudiantes en 3 parciales, calcula el promedio de cada estudiante y luego imprime los resultados. Utiliza programación paralela con `Parallel.For` para mejorar la eficiencia al generar los datos.

## ¿Qué hace el programa?

1. **Generación de calificaciones aleatorias**:  
   Se crean calificaciones aleatorias para tres parciales (entre 60 y 100) para cada uno de los 5 estudiantes.

2. **Cálculo del promedio**:  
   El promedio de los tres parciales se calcula utilizando `Average()`.

3. **Programación paralela**:  
   El programa usa `Parallel.For` para llenar la lista de calificaciones de forma concurrente. Esto puede mejorar el rendimiento cuando se trabaja con más datos.

4. **Impresión de los resultados**:  
   El programa imprime las calificaciones de cada parcial y el promedio usando LINQ para formatear y mostrar los resultados.

## Código y Lógica

- **Generación de calificaciones**:  
   Para cada estudiante, se generan 3 calificaciones aleatorias entre 60 y 100. Luego se calcula el promedio de estas calificaciones.

- **Programación paralela con `Parallel.For`**:  
   En lugar de usar un bucle `for` tradicional, se usa `Parallel.For` para procesar los cálculos en paralelo, lo que mejora el rendimiento si se aumenta la cantidad de estudiantes.

- **Uso de LINQ**:  
   El programa usa LINQ para formatear y mostrar los resultados de una manera más eficiente y concisa.
