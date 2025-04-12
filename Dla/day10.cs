public class StackList
{
    List<List<string>> productPackages = new List<List<string>>();
    List<string> stack = new List<string>();

    public void ClearStack(List<string> stack)
    {
        Console.WriteLine("Dispatching stack...");
        stack.Clear();

    }

    public void AddProduct(string productName)
    {
        if (stack.Count < 10)
        {
            Console.WriteLine($"Add {productName} on stack #{productPackages.Count}");
            stack.Add(productName);
            return;
        }

        Console.WriteLine($"Add stack to package");
        productPackages.Add(stack);

        ClearStack(stack);

        Console.WriteLine($"Add {productName} on stack #{productPackages.Count}");
        stack.Add(productName);
    }

    public void PutOnStack(string[] products)
    {
        for (int i = 0; i < products.Length; i++)
        {
            AddProduct(products[i]);
        }
    }

}