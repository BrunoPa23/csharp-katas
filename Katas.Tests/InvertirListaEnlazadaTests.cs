using Katas;
using Xunit;

namespace Katas.Tests;

public class InvertirListaEnlazadaTests
{
    [Fact]
    public void Invertir_ListaConVariosElementos_DevuelveOrdenInverso()
    {
        NodoLista<int>? lista = InvertirListaEnlazada.DesdeArreglo([1, 2, 3, 4, 5]);

        NodoLista<int>? invertida = InvertirListaEnlazada.Invertir(lista);

        List<int> resultado = InvertirListaEnlazada.AArreglo(invertida);
        Assert.Equal([5, 4, 3, 2, 1], resultado);
    }

    [Fact]
    public void Invertir_ListaConUnElemento_DevuelveMismaLista()
    {
        NodoLista<int>? lista = InvertirListaEnlazada.DesdeArreglo([1]);

        NodoLista<int>? invertida = InvertirListaEnlazada.Invertir(lista);

        List<int> resultado = InvertirListaEnlazada.AArreglo(invertida);
        Assert.Equal([1], resultado);
    }

    [Fact]
    public void Invertir_ListaVacia_DevuelveNull()
    {
        NodoLista<int>? lista = InvertirListaEnlazada.DesdeArreglo<int>([]);

        NodoLista<int>? invertida = InvertirListaEnlazada.Invertir(lista);

        Assert.Null(invertida);
    }
}
