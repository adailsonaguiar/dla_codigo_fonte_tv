using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day12Tests
{
    [Fact]
    public void JoinQueue_Test()
    {
        var driveThru = new DriveThru();
        driveThru.JoinQueue("client 1");
        driveThru.JoinQueue("client 2");
        driveThru.JoinQueue("client 3");

        driveThru.ServeCustomer();
        driveThru.ServeCustomer();

        Assert.Equal(["client 3"], driveThru.GetQueue());
    }
}
