using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day8Tests
{
    [Fact]
    public void AddItemToQueue_Test()
    {
        var queue = new QueueStack();
        queue.AddItemToQueue();
        var result = queue.AddItemToQueue();
        Assert.Equal("1,2", result);
    }

    [Fact]
    public void RemoveOneItemFromQueue_Test()
    {
        var queue = new QueueStack();
        queue.AddItemToQueue();
        queue.AddItemToQueue();
        queue.AddItemToQueue();

        var result = queue.RemoveOneItemFromQueue();
        Assert.Equal("2,3", result);
    }
}
