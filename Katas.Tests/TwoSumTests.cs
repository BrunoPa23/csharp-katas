using Katas;
using Xunit;

namespace Katas.Tests;

public class TwoSumTests
{
    [Fact]
    public void EncontrarIndices_ParExistente_DevuelveIndicesCorrectos()
    {
        int[] numeros = [2, 7, 11, 15];

        int[] resultado = TwoSum.EncontrarIndices(numeros, 9);

        Assert.Equal([0, 1], resultado);
    }

    [Fact]
    public void EncontrarIndices_ParAlFinal_DevuelveIndicesCorrectos()
    {
        int[] numeros = [3, 2, 4];

        int[] resultado = TwoSum.EncontrarIndices(numeros, 6);

        Assert.Equal([1, 2], resultado);
    }

    [Fact]
    public void EncontrarIndices_ValoresDuplicados_DevuelveIndicesCorrectos()
    {
        int[] numeros = [3, 3];

        int[] resultado = TwoSum.EncontrarIndices(numeros, 6);

        Assert.Equal([0, 1], resultado);
    }

    [Fact]
    public void EncontrarIndices_SinSolucion_LanzaExcepcion()
    {
        int[] numeros = [1, 2, 3];

        Assert.Throws<InvalidOperationException>(() => TwoSum.EncontrarIndices(numeros, 100));
    }
}
