public class QueueStack
{
    List<int> items = new List<int> { };

    public string AddItemToQueue()
    {
        items.Add(items.Count + 1);

        return string.Join(",", items);
    }

    public string RemoveOneItemFromQueue()
    {
        items.RemoveAt(0);

        return string.Join(",", items);
    }
}
