namespace Katas;

/// <summary>
/// Kata Fibonacci con memoizacion: calcula el n-esimo numero de Fibonacci guardando
/// en cache los resultados ya calculados para evitar recalculos redundantes.
/// Complejidad: O(n) en tiempo y O(n) en espacio (cache), frente al O(2^n) de la
/// version recursiva naive sin memoizacion.
/// </summary>
public static class Fibonacci
{
    public static long Calcular(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "n no puede ser negativo");
        }

        var cache = new Dictionary<int, long>();

        return CalcularConCache(n, cache);
    }

    private static long CalcularConCache(int n, Dictionary<int, long> cache)
    {
        if (n is 0 or 1)
        {
            return n;
        }

        if (cache.TryGetValue(n, out long valorEnCache))
        {
            return valorEnCache;
        }

        long resultado = CalcularConCache(n - 1, cache) + CalcularConCache(n - 2, cache);
        cache[n] = resultado;

        return resultado;
    }
}
