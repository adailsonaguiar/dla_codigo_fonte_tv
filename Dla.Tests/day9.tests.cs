using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day9Tests
{
    [Fact]
    public void getIndexOf_Test()
    {
        var list = new ListImplementation([5, 2, 9]);
        var result = list.getIndexOf(9);
        Assert.Equal(2, result);

        var result2 = list.getIndexOf(10);
        Assert.Equal(-1, result2);
    }

    [Fact]
    public void HasIncludes_Test()
    {
        var list = new ListImplementation([5, 2, 9]);
        var result = list.HasIncludes(9);
        Assert.True(result);
    }

    [Fact]
    public void GetLastIndexOf_Test()
    {
        var list = new ListImplementation([5, 2, 9, 9]);
        Assert.Equal(3, list.GetLastIndexOf(9));
        Assert.Equal(0, list.GetLastIndexOf(5));
    }

    [Fact]
    public void SliceImplementation_Test()
    {
        var list = new ListImplementation([5, 2, 9, 9, 8, 0]);
        Assert.Equal([2, 9, 9], list.SliceImplementation(1, 3));
    }
}
