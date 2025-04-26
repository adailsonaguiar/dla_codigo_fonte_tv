using Xunit;
using Desafios;
using System.Text.Json;

namespace Desafios.Tests;

public class Day15Tests
{
    // [Fact]
    // public void InsertLast_Test()
    // {
    //     LinkedList linkedList = new();
    //     linkedList.InsertLast(1);
    //     linkedList.InsertLast(5);
    //     linkedList.InsertLast(3);

    //     Assert.Equal([1, 5, 3], linkedList.GetList());
    // }

    // [Fact]
    // public void InsertAt_Test()
    // {
    //     LinkedList linkedList = new();

    //     linkedList.InsertAt(1, 0);
    //     linkedList.InsertAt(3, 2);
    //     linkedList.InsertAt(5, 3);
    //     linkedList.InsertAt(1, 1);
    //     linkedList.InsertAt(1, 10);
    //     linkedList.InsertAt(0, 11);

    //     Assert.Equal([11, 0, 10, 1, 2, 3], linkedList.GetList());
    // }

    [Fact]
    public void DeleteAt_Test()
    {
        LinkedList linkedList = new();

        linkedList.InsertLast(0);
        linkedList.InsertLast(1);
        linkedList.InsertLast(2);
        linkedList.InsertLast(3);
        linkedList.DeleteAt(0);

        Assert.Equal([1, 2, 3], linkedList.GetList());

        linkedList.InsertLast(4);
        linkedList.InsertLast(5);
        linkedList.DeleteAt(2);

        Assert.Equal([1, 2, 4, 5], linkedList.GetList());

        linkedList.DeleteAt(3);
        Assert.Equal([1, 2, 4], linkedList.GetList());
    }

    [Fact]
    public void SearchAt_Test()
    {
        LinkedList linkedList = new();

        linkedList.InsertLast(0);
        linkedList.InsertLast(1);
        linkedList.InsertLast(10);
        linkedList.InsertLast(3);

        Assert.Equal(10, linkedList.SearchAt(2));
    }

    [Fact]
    public void IndexOf_Test()
    {
        LinkedList linkedList = new();

        linkedList.InsertLast(0);
        linkedList.InsertLast(1);
        linkedList.InsertLast(10);
        linkedList.InsertLast(3);

        Assert.Equal(2, linkedList.IndexOf(new Node(10)));
        Assert.Equal(0, linkedList.IndexOf(new Node(0)));
        Assert.Equal(3, linkedList.IndexOf(new Node(3)));
    }
}
