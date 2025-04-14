using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day13Tests
{
    [Fact]
    public void AddToEnd_Test()
    {
        var deque = new DequeTasks();
        deque.AddToEnd(new Task("client 1", 1));
        deque.AddToEnd(new Task("client 2", 2));
        deque.AddToEnd(new Task("client 3", 1));

        Assert.Equal([
            new Task("client 1", 1),
            new Task("client 2", 2),
            new Task("client 3", 1)
        ], deque.GetQueue());
    }

    [Fact]
    public void AddToStart_Test()
    {
        var deque = new DequeTasks();
        deque.AddToStart(new Task("client 1", 1));
        deque.AddToStart(new Task("client 2", 2));
        deque.AddToStart(new Task("client 3", 1));

        Assert.Equal([
            new Task("client 3", 1),
            new Task("client 2", 2),
            new Task("client 1", 1)
        ], deque.GetQueue());
    }

    [Fact]
    public void SolveTask_Test()
    {
        var deque = new DequeTasks();
        deque.AddToEnd(new Task("client 1", 1));
        deque.AddToEnd(new Task("client 2", 2));
        deque.AddToEnd(new Task("client 3", 1));

        deque.SolveTask();

        Assert.Equal([
            new Task("client 2", 2),
            new Task("client 3", 1)
        ], deque.GetQueue());
    }

    [Fact]
    public void ChangePriorityTask_Test()
    {
        var deque = new DequeTasks();
        deque.AddToEnd(new Task("client 1", 1));
        deque.AddToEnd(new Task("client 2", 2));
        deque.AddToEnd(new Task("client 3", 1));

        deque.ChangePriorityTask("client 2", 3);

        Assert.Equal([
            new Task("client 1", 1),
            new Task("client 3", 1),
            new Task("client 2", 3)
        ], deque.GetQueue());
    }

    [Fact]
    public void IncreasePositionTask_Test()
    {
        var deque = new DequeTasks();
        deque.AddToEnd(new Task("client 1", 1));
        deque.AddToEnd(new Task("client 2", 2));
        deque.AddToEnd(new Task("client 3", 1));

        deque.IncreasePositionTask("client 2");

        Assert.Equal([
            new Task("client 1", 1),
            new Task("client 3", 1),
            new Task("client 2", 2)
        ], deque.GetQueue());
    }

    [Fact]
    public void DecreasePositionTask_Test()
    {
        var deque = new DequeTasks();
        deque.AddToEnd(new Task("client 1", 1));
        deque.AddToEnd(new Task("client 2", 2));
        deque.AddToEnd(new Task("client 3", 1));

        deque.DecreasePositionTask("client 2");

        Assert.Equal([
            new Task("client 2", 2),
            new Task("client 1", 1),
            new Task("client 3", 1),
        ], deque.GetQueue());
    }
}
