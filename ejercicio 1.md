# Comparación de Promedios de Dos Grupos

Este programa compara los promedios de dos grupos de estudiantes, eligiendo el mayor en cada posición y luego imprimiéndolos. Utiliza recursión en lugar de bucles, lo que le da un toque interesante si estás aprendiendo cómo funciona la recursión en C#.

## ¿Qué hace el programa?

1. **Entrada de datos**:  
   Hay dos arreglos: `grupo1` y `grupo2`, donde guardamos las calificaciones promedio de dos grupos de estudiantes.

   Ejemplo:
   - `grupo1`: 7.8, 9.1, 6.5, 8.2, 7.4  
   - `grupo2`: 8.5, 6.9, 7.2, 8.7, 7.9

2. **Cálculo de los mayores**:  
   El programa compara los promedios de los dos grupos y guarda el mayor en un nuevo arreglo llamado `mayores`.

3. **Impresión de los resultados**:  
   Después de calcular los promedios mayores, el programa imprime los resultados de cada posición.

## ¿Cómo funciona?

- **Recursión**:  
   En lugar de usar un bucle `for`, el código usa funciones recursivas. Es decir, las funciones llaman a sí mismas hasta llegar al final del arreglo.

   Las funciones principales son:
   - `CalcularMayores`: Compara los promedios de ambos grupos y guarda el mayor.
   - `ImprimirArreglo`: Imprime los valores del arreglo de los mayores, uno por uno, de forma recursiva.
   - `EncontrarMayor`: Toma dos números y devuelve el mayor.
   - `EsMayor`: Compara dos números y devuelve si el primero es mayor que el segundo.

## Ejemplo práctico

Imagina que tienes dos grupos de estudiantes con sus promedios de varias materias:

- **Grupo 1**:  
  Matemáticas: 7.8, Ciencias: 9.1, Historia: 6.5, Inglés: 8.2, Geografía: 7.4

- **Grupo 2**:  
  Matemáticas: 8.5, Ciencias: 6.9, Historia: 7.2, Inglés: 8.7, Geografía: 7.9

El programa imprimirá el mayor promedio de cada materia entre los dos grupos.

## ¿Por qué usar este código?

Este código es útil si:
- Necesitas comparar dos listas de números y encontrar el mayor valor en cada posición.
- Estás aprendiendo recursión y quieres ver cómo funciona.
- Quieres un ejemplo simple y directo de cómo comparar arreglos con recursión.

## ¿Cómo usarlo?

1. Clona o descarga este repositorio.
2. Abre el código en tu editor de C# favorito (como Visual Studio).
3. Ejecuta el programa y verás el resultado en la consola.

## Ejemplo de salida:

