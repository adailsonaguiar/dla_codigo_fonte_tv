using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day4Tests
{
    [Fact]
    public void TestHowManyYearsToRenovate_FirstTime()
    {
        var result = Day4.howManyYearsToRenovate(true, 21);
        Assert.Equal(1, result);
    }

    [Fact]
    public void TestHowManyYearsToRenovate_60Years()
    {
        var result = Day4.howManyYearsToRenovate(false, 60);
        Assert.Equal(5, result);
    }

    [Fact]
    public void TestCalculateStudentPerformance_Insufficient()
    {
        var result = Day4.calculateStudentPerformance(5);
        Assert.Equal("Insufficient", result);
    }

    [Fact]
    public void TestCalculateStudentPerformance_Regular()
    {
        var result = Day4.calculateStudentPerformance(6);
        Assert.Equal("Regular", result);
    }
}
