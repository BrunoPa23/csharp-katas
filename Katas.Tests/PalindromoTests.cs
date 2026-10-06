using Katas;
using Xunit;

namespace Katas.Tests;

public class PalindromoTests
{
    [Theory]
    [InlineData("Anita lava la tina")]
    [InlineData("A man, a plan, a canal: Panama")]
    [InlineData("Somos")]
    [InlineData("")]
    [InlineData("a")]
    [InlineData("12321")]
    public void EsPalindromo_CadenasPalindromo_DevuelveTrue(string texto)
    {
        Assert.True(Palindromo.EsPalindromo(texto));
    }

    [Theory]
    [InlineData("Hola mundo")]
    [InlineData("No es palindromo")]
    [InlineData("12345")]
    public void EsPalindromo_CadenasNoPalindromo_DevuelveFalse(string texto)
    {
        Assert.False(Palindromo.EsPalindromo(texto));
    }
}
