# CSharp Katas

Repositorio de katas de algoritmos clasicos resueltos en C#, con tests unitarios en xUnit.

## Proposito

Practicar y mostrar soluciones limpias a problemas algoritmicos frecuentes (estructuras de datos, busqueda, recursion, programacion dinamica), cada una acompanada de sus tests y una nota sobre su complejidad.

## Estructura del repo

```
csharp-katas/
├── CSharpKatas.slnx
├── Katas/              (biblioteca de clases con las soluciones)
├── Katas.Tests/        (proyecto de tests xUnit)
└── README.md
```

## Como correr los tests

Requisitos: .NET SDK 10.x instalado (verificar con `dotnet --version`).

Desde la raiz del repo:

```
dotnet test
```

Esto compila ambos proyectos y ejecuta todos los tests del proyecto `Katas.Tests`.

## Tabla de katas

| Kata | Descripcion | Complejidad |
|------|-------------|-------------|
| FizzBuzz | Genera Fizz, Buzz, FizzBuzz o el numero segun sus multiplos (3, 5 y 15) | O(n) tiempo, O(n) espacio |
| Palindromo | Determina si una cadena es palindromo ignorando mayusculas, espacios y signos | O(n) tiempo, O(n) espacio |
| Anagramas | Determina si dos cadenas son anagramas entre si usando conteo de letras | O(n) tiempo, O(n) espacio |
| TwoSum | Devuelve los indices de los dos elementos cuya suma es el objetivo | O(n) tiempo, O(n) espacio |
| BusquedaBinaria | Busca un valor en un arreglo ordenado dividiendo el rango a la mitad (iterativa) | O(log n) tiempo, O(1) espacio |
| Pila | Estructura LIFO propia con Push, Pop, Peek y Count | O(1) por operacion, O(n) espacio |
| InvertirListaEnlazada | Invierte una lista simplemente enlazada reacomodando punteros | O(n) tiempo, O(1) espacio adicional |
| Fibonacci | Calcula el n-esimo numero de Fibonacci usando memoizacion | O(n) tiempo, O(n) espacio |
