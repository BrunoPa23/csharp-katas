using Katas;
using Xunit;

namespace Katas.Tests;

public class FizzBuzzTests
{
    [Fact]
    public void Generar_Hasta15_DevuelveSecuenciaCorrecta()
    {
        var resultado = FizzBuzz.Generar(15);

        Assert.Equal(15, resultado.Count);
        Assert.Equal("1", resultado[0]);
        Assert.Equal("2", resultado[1]);
        Assert.Equal("Fizz", resultado[2]);
        Assert.Equal("4", resultado[3]);
        Assert.Equal("Buzz", resultado[4]);
        Assert.Equal("Fizz", resultado[5]);
        Assert.Equal("FizzBuzz", resultado[14]);
    }

    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(9, "Fizz")]
    [InlineData(10, "Buzz")]
    [InlineData(30, "FizzBuzz")]
    [InlineData(7, "7")]
    public void Generar_ValorEspecifico_DevuelveTextoEsperado(int n, string esperado)
    {
        var resultado = FizzBuzz.Generar(n);

        Assert.Equal(esperado, resultado[n - 1]);
    }
}
