namespace Katas;

/// <summary>
/// Kata FizzBuzz: por cada numero del 1 al N, devuelve "Fizz" si es multiplo de 3,
/// "Buzz" si es multiplo de 5, "FizzBuzz" si es multiplo de ambos, o el numero como texto.
/// Complejidad: O(n) en tiempo, O(n) en espacio por la lista resultante.
/// </summary>
public static class FizzBuzz
{
    public static List<string> Generar(int n)
    {
        var resultado = new List<string>(n);

        for (int i = 1; i <= n; i++)
        {
            if (i % 15 == 0)
            {
                resultado.Add("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                resultado.Add("Fizz");
            }
            else if (i % 5 == 0)
            {
                resultado.Add("Buzz");
            }
            else
            {
                resultado.Add(i.ToString());
            }
        }

        return resultado;
    }
}
