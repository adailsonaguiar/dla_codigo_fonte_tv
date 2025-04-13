public class BrowserStack
{
    private List<string> backStack = new List<string>();
    private List<string> fowardStack = new List<string>();
    public string CurrentPage = "";

    public string[] GetFowardStack()
    {
        List<string> list = fowardStack;
        list.Reverse();
        return list.ToArray();
    }

    public string[] GetBackStack()
    {
        List<string> list = backStack;
        return list.ToArray();
    }

    public void NavigateToPage(string pageName)
    {
        fowardStack = [];

        if (CurrentPage == "")
        {
            CurrentPage = pageName;
            return;
        }

        backStack.Add(CurrentPage);
        CurrentPage = pageName;

    }

    public void BackToPage()
    {
        if (backStack.Count == 0)
        {
            return;
        }

        fowardStack.Add(CurrentPage);
        CurrentPage = backStack.Last();
        backStack.RemoveAt(backStack.Count - 1);
    }

    public void AdvanceToPage()
    {
        if (fowardStack.Count == 0)
        {
            return;
        }

        backStack.Add(CurrentPage);
        CurrentPage = fowardStack.Last();
        fowardStack.RemoveAt(fowardStack.Count - 1);
    }
}