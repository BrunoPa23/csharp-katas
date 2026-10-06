using System.Globalization;

namespace Katas;

/// <summary>
/// Kata Anagramas: determina si dos cadenas son anagramas entre si, es decir,
/// si contienen las mismas letras con la misma frecuencia (ignorando mayusculas y espacios).
/// Complejidad: O(n) en tiempo usando un diccionario de conteo, O(n) en espacio.
/// </summary>
public static class Anagramas
{
    public static bool SonAnagramas(string primera, string segunda)
    {
        string a = Normalizar(primera);
        string b = Normalizar(segunda);

        if (a.Length != b.Length)
        {
            return false;
        }

        var conteo = new Dictionary<char, int>();

        foreach (char c in a)
        {
            conteo[c] = conteo.GetValueOrDefault(c) + 1;
        }

        foreach (char c in b)
        {
            if (!conteo.TryGetValue(c, out int valor) || valor == 0)
            {
                return false;
            }

            conteo[c] = valor - 1;
        }

        return true;
    }

    private static string Normalizar(string texto)
    {
        var builder = new System.Text.StringBuilder(texto.Length);

        foreach (char c in texto)
        {
            if (char.IsLetterOrDigit(c))
            {
                builder.Append(char.ToLower(c, CultureInfo.InvariantCulture));
            }
        }

        return builder.ToString();
    }
}
