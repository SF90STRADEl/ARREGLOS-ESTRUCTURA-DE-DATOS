# Comparación de Promedios Aleatorios entre dos Grupos

Este programa genera promedios aleatorios para dos grupos de estudiantes y luego muestra el mayor promedio de cada posición. Utiliza un enfoque simple con `Random` para crear números aleatorios y los compara usando `Math.Max`.

## ¿Qué hace el programa?

1. **Generación de promedios aleatorios**:  
   Se crean dos arreglos (`grupo1` y `grupo2`), cada uno con 5 promedios generados aleatoriamente entre 0 y 100.

2. **Comparación de promedios**:  
   El programa compara los promedios de ambos grupos en cada posición y guarda el mayor de cada par en el arreglo `promediosAltos`.

3. **Impresión de los resultados**:  
   El programa muestra:
   - Los promedios de cada grupo.
   - El mayor promedio de cada posición entre ambos grupos.

## Código y Lógica

- **Generación aleatoria**:  
   Usando `Random`, el programa genera promedios aleatorios con dos decimales para simular calificaciones de estudiantes.

- **Comparación con `Math.Max`**:  
   La función `Math.Max(grupo1[i], grupo2[i])` compara los promedios correspondientes de ambos grupos y guarda el mayor en el arreglo `promediosAltos`.

- **Impresión de resultados**:  
   El código imprime los promedios de ambos grupos y luego los promedios más altos en cada posición.
