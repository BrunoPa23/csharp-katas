namespace Katas;

/// <summary>
/// Kata TwoSum: dado un arreglo de numeros y un valor objetivo, devuelve los indices
/// de los dos elementos cuya suma es igual al objetivo.
/// Complejidad: O(n) en tiempo y O(n) en espacio, usando un diccionario que guarda
/// valor -> indice ya visitado (evita el enfoque de fuerza bruta O(n^2)).
/// </summary>
public static class TwoSum
{
    public static int[] EncontrarIndices(int[] numeros, int objetivo)
    {
        var vistos = new Dictionary<int, int>();

        for (int i = 0; i < numeros.Length; i++)
        {
            int complemento = objetivo - numeros[i];

            if (vistos.TryGetValue(complemento, out int indiceComplemento))
            {
                return [indiceComplemento, i];
            }

            vistos[numeros[i]] = i;
        }

        throw new InvalidOperationException("No existen dos elementos cuya suma sea el objetivo");
    }
}
