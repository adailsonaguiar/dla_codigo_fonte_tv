using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day3Tests
{
    [Fact]
    public void TestIsOdd_EvenNumber()
    {
        var result = Day3.isOdd(4);
        Assert.Equal("The number 4 is even", result);
    }

    [Fact]
    public void TestGetIMC_NormalWeight()
    {
        var result = Day3.getIMC(70, 1.75);
        Assert.Equal("Normal", result);
    }

    [Fact]
    public void TestCalculateGass()
    {
        var result = Day3.calculateGassByDistance(300, 5.5, 10);
        Assert.Equal("The total used gass is 30 liters and the total cost is R$165.00", result);
    }
}
