using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day5Tests
{
    [Fact]
    public void TestGetInvestmentValueByYear_Value()
    {
        var result = Day5.getInvestmentValueByYear(5, 12, 100);
        Assert.Equal(176.23, result);
    }
}
