using System.Globalization;
using System.Text;

namespace Katas;

/// <summary>
/// Kata Palindromo: determina si una cadena es palindromo, ignorando mayusculas,
/// espacios y signos de puntuacion (solo se comparan letras y digitos).
/// Complejidad: O(n) en tiempo (normalizacion + dos punteros), O(n) en espacio
/// por la cadena normalizada.
/// </summary>
public static class Palindromo
{
    public static bool EsPalindromo(string texto)
    {
        string normalizado = Normalizar(texto);

        int izquierda = 0;
        int derecha = normalizado.Length - 1;

        while (izquierda < derecha)
        {
            if (normalizado[izquierda] != normalizado[derecha])
            {
                return false;
            }

            izquierda++;
            derecha--;
        }

        return true;
    }

    private static string Normalizar(string texto)
    {
        var builder = new StringBuilder(texto.Length);

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
