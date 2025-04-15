public class Client
{
    public string name { get; set; }

    public Client(string name)
    {
        this.name = name;
    }
}

public class Checkout
{
    public List<Client> items { get; set; } = new List<Client> { };
    public string name { get; set; }

    public Checkout(string name)
    {
        this.name = name;
    }

    public string AddClientToQueue(Client client)
    {
        items.Add(client);

        return string.Join(",", items);
    }

    public string ServeClient()
    {
        if (items.Count == 0)
        {
            return "";
        }

        items.RemoveAt(0);

        return string.Join(",", items);
    }

    public override bool Equals(object? obj)
    {
        return obj is Checkout check &&
               name == check.name;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(name);
    }
}

public class MarketCheckouts
{
    List<Checkout> market = new List<Checkout> { };

    public void AddCheckout()
    {
        market.Add(new Checkout($"checkout_{market.Count + 1}"));
    }

    // public Checkout GetRandomCheckout()
    // {
    //     int queueCheckoutPrev = market[0].items.Count;
    //     int checkoutIndexWithMinQueue = 0;

    //     for (int i = 0; i < market.Count; i++)
    //     {
    //         if (i > 1)
    //         {
    //             if (market[i].items.Count < queueCheckoutPrev)
    //             {
    //                 checkoutIndexWithMinQueue = i;
    //             }
    //         }

    //         queueCheckoutPrev = market[i].items.Count;
    //     }

    //     return market[checkoutIndexWithMinQueue];
    // }

    public Checkout GetRandomCheckout()
    {
        return market.OrderBy(item => item.items.Count).First();
    }

    public void AddClientToQueue(Client client)
    {
        GetRandomCheckout().AddClientToQueue(client);
    }

    public void ServeClients()
    {
        for (int i = 0; i < market.Count; i++)
        {
            market[i].ServeClient();
        }
    }

    public Checkout[] GetCheckouts()
    {
        return market.ToArray();
    }

    public int GetTotalClients()
    {
        int totalClients = 0;
        foreach (Checkout checkout in market)
        {
            totalClients += checkout.items.Count;
        }

        return totalClients;
    }
}
