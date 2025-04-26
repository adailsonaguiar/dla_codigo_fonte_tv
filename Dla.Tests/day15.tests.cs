using Xunit;
using Desafios;
using System.Text.Json;

namespace Desafios.Tests;

public class Day15Tests
{
    [Fact]
    public void InsertLast_Test()
    {
        var linkedList = new LinkedList();
        linkedList.InsertLast(1);
        linkedList.InsertLast(5);
        linkedList.InsertLast(3);

        Assert.Equal([1, 5, 3], linkedList.GetList());
    }

    [Fact]
    public void InsertAt_Test()
    {
        var linkedList = new LinkedList();

        linkedList.InsertAt(1, 0);
        linkedList.InsertAt(3, 2);
        linkedList.InsertAt(5, 3);
        linkedList.InsertAt(1, 1);
        linkedList.InsertAt(1, 10);
        linkedList.InsertAt(0, 11);

        Assert.Equal([11, 0, 10, 1, 2, 3], linkedList.GetList());
    }
}
