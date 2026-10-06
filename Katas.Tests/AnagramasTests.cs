using Katas;
using Xunit;

namespace Katas.Tests;

public class AnagramasTests
{
    [Theory]
    [InlineData("amor", "roma")]
    [InlineData("Roma", "amor")]
    [InlineData("listen", "silent")]
    [InlineData("", "")]
    [InlineData("a", "a")]
    public void SonAnagramas_CadenasValidas_DevuelveTrue(string primera, string segunda)
    {
        Assert.True(Anagramas.SonAnagramas(primera, segunda));
    }

    [Theory]
    [InlineData("amor", "mesa")]
    [InlineData("hola", "holaa")]
    [InlineData("listen", "listens")]
    public void SonAnagramas_CadenasNoAnagramas_DevuelveFalse(string primera, string segunda)
    {
        Assert.False(Anagramas.SonAnagramas(primera, segunda));
    }
}
