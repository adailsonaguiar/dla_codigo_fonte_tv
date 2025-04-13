public class DriveThru
{
    private List<string> queue = new List<string>();

    public void JoinQueue(string clientName)
    {
        queue.Add(clientName);
    }

    public void ServeCustomer()
    {
        queue.RemoveAt(0);
    }

    public string[] GetQueue()
    {
        return queue.ToArray();
    }
}