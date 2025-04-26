using Xunit;
using Desafios;
using System.Text.Json;

namespace Desafios.Tests;

public class Day14Tests
{
    [Fact]
    public void AddCheckout_Test()
    {
        var market = new MarketCheckouts();
        market.AddCheckout();
        market.AddCheckout();
        market.AddCheckout();

        Assert.Equal([
            new Checkout("checkout_1"),
            new Checkout("checkout_2"),
            new Checkout("checkout_3"),
        ], market.GetCheckouts());
    }

    [Fact]
    public void GetRandomCheckout_Test()
    {
        var market = new MarketCheckouts();
        market.AddCheckout();
        market.AddCheckout();
        market.AddCheckout();
        market.AddClientToQueue(new Client("client 1"));
        market.AddClientToQueue(new Client("client 2"));
        market.AddClientToQueue(new Client("client 3"));
        market.AddClientToQueue(new Client("client 4"));
        market.AddClientToQueue(new Client("client 5"));
        market.AddClientToQueue(new Client("client 6"));
        market.AddClientToQueue(new Client("client 7"));
        market.AddClientToQueue(new Client("client 8"));
        market.AddClientToQueue(new Client("client 9"));
        market.AddClientToQueue(new Client("client 10"));
        market.AddClientToQueue(new Client("client 11"));


        Assert.Equal(3, market.GetRandomCheckout().items.Count);

        market.ServeClients();

        Checkout[] checkouts = market.GetCheckouts();
        string json = JsonSerializer.Serialize(checkouts, new JsonSerializerOptions { WriteIndented = true });

        Assert.Equal(8, market.GetTotalClients());

        market.ServeClients();

        Assert.Equal(5, market.GetTotalClients());

        market.ServeClients();

        Assert.Equal(2, market.GetTotalClients());

        market.ServeClients();

        Assert.Equal(0, market.GetTotalClients());
    }
}
