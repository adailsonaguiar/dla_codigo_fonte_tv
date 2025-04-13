using Xunit;
using Desafios;

namespace Desafios.Tests;

public class Day11Tests
{
    [Fact]
    public void NavigateToPage_Test()
    {
        var browserStack = new BrowserStack();
        browserStack.NavigateToPage("home");
        browserStack.NavigateToPage("profile");
        browserStack.NavigateToPage("config");

        Assert.Equal(["home", "profile"], browserStack.GetBackStack());
        Assert.Equal("config", browserStack.CurrentPage);
    }

    [Fact]
    public void BackToPage_Test()
    {
        var browserStack = new BrowserStack();
        browserStack.NavigateToPage("home");
        browserStack.NavigateToPage("profile");
        browserStack.NavigateToPage("config");
        browserStack.NavigateToPage("change_password");

        browserStack.BackToPage();
        browserStack.BackToPage();

        Assert.Equal("profile", browserStack.CurrentPage);
        Assert.Equal(["config", "change_password"], browserStack.GetFowardStack());
        Assert.Equal(["home"], browserStack.GetBackStack());
    }

    [Fact]
    public void AdvanceToPage_Test()
    {
        var browserStack = new BrowserStack();
        browserStack.NavigateToPage("home");
        browserStack.NavigateToPage("profile");
        browserStack.NavigateToPage("config");
        browserStack.NavigateToPage("change_password");

        browserStack.BackToPage();
        browserStack.BackToPage();

        Assert.Equal("profile", browserStack.CurrentPage);
        Assert.Equal(["home"], browserStack.GetBackStack());

        browserStack.AdvanceToPage();

        Assert.Equal(["home", "profile"], browserStack.GetBackStack());
        Assert.Equal(["change_password"], browserStack.GetFowardStack());
        Assert.Equal("config", browserStack.CurrentPage);
    }
}
