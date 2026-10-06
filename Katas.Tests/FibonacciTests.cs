using Katas;
using Xunit;

namespace Katas.Tests;

public class FibonacciTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(10, 55)]
    [InlineData(20, 6765)]
    public void Calcular_ValoresConocidos_DevuelveResultadoEsperado(int n, long esperado)
    {
        Assert.Equal(esperado, Fibonacci.Calcular(n));
    }

    [Fact]
    public void Calcular_ValorNegativo_LanzaExcepcion()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => Fibonacci.Calcular(-1));
    }

    [Fact]
    public void Calcular_ValorGrande_NoTardaPorMemoizacion()
    {
        long resultado = Fibonacci.Calcular(50);

        Assert.Equal(12586269025L, resultado);
    }
}
