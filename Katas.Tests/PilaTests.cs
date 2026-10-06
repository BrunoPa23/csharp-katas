using Katas;
using Xunit;

namespace Katas.Tests;

public class PilaTests
{
    [Fact]
    public void Push_AgregaElementos_IncrementaCount()
    {
        var pila = new Pila<int>();

        pila.Push(1);
        pila.Push(2);

        Assert.Equal(2, pila.Count);
    }

    [Fact]
    public void Pop_DevuelveElementosEnOrdenInverso()
    {
        var pila = new Pila<int>();
        pila.Push(1);
        pila.Push(2);
        pila.Push(3);

        Assert.Equal(3, pila.Pop());
        Assert.Equal(2, pila.Pop());
        Assert.Equal(1, pila.Pop());
        Assert.Equal(0, pila.Count);
    }

    [Fact]
    public void Peek_NoRemueveElemento()
    {
        var pila = new Pila<string>();
        pila.Push("a");
        pila.Push("b");

        string tope = pila.Peek();

        Assert.Equal("b", tope);
        Assert.Equal(2, pila.Count);
    }

    [Fact]
    public void Pop_PilaVacia_LanzaExcepcion()
    {
        var pila = new Pila<int>();

        Assert.Throws<InvalidOperationException>(() => pila.Pop());
    }

    [Fact]
    public void Peek_PilaVacia_LanzaExcepcion()
    {
        var pila = new Pila<int>();

        Assert.Throws<InvalidOperationException>(() => pila.Peek());
    }
}
