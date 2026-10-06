using Katas;
using Xunit;

namespace Katas.Tests;

public class BusquedaBinariaTests
{
    private static readonly int[] NumerosOrdenados = [1, 3, 5, 7, 9, 11, 13];

    [Theory]
    [InlineData(1, 0)]
    [InlineData(13, 6)]
    [InlineData(7, 3)]
    [InlineData(3, 1)]
    public void Buscar_ValorExistente_DevuelveIndiceCorrecto(int objetivo, int indiceEsperado)
    {
        int resultado = BusquedaBinaria.Buscar(NumerosOrdenados, objetivo);

        Assert.Equal(indiceEsperado, resultado);
    }

    [Theory]
    [InlineData(4)]
    [InlineData(0)]
    [InlineData(100)]
    public void Buscar_ValorInexistente_DevuelveMenosUno(int objetivo)
    {
        int resultado = BusquedaBinaria.Buscar(NumerosOrdenados, objetivo);

        Assert.Equal(-1, resultado);
    }

    [Fact]
    public void Buscar_ArregloVacio_DevuelveMenosUno()
    {
        int resultado = BusquedaBinaria.Buscar([], 5);

        Assert.Equal(-1, resultado);
    }
}
