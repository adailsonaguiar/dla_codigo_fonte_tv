public class BrowserStack
{
    public List<string> backStack = new List<string>();
    public List<string> fowardStack = new List<string>();
    public string CurrentPage = "";

    public void NavigateToPage(string pageName)
    {
        CurrentPage = pageName;
        backStack.Add(pageName);
    }

    public void BackToPage()
    {
        if (backStack.Count == 0)
        {
            return;
        }

        CurrentPage = backStack.Last();
        fowardStack.Add(CurrentPage);
        backStack.RemoveAt(backStack.Count - 1);
    }

    public void AdvanceToPage()
    {
        if (fowardStack.Count == 0)
        {
            return;
        }

        CurrentPage = fowardStack.First();
        fowardStack.Remove(CurrentPage);
        NavigateToPage(CurrentPage);
    }
}