using OpenQA.Selenium;

namespace SeleniumInfrastructure.Page;

public class PageFactory : IPageFactory
{
    public TPage Create<TPage>(IWebDriver webDriver) where TPage : class, IPage
    {
        var page = (TPage) Activator.CreateInstance(typeof(TPage), webDriver);
        webDriver.Navigate().GoToUrl(page.Url);
        return page;
    }

    public TPage Create<TPage>(IWebDriver webDriver, string path) where TPage : class, IPage
    {
        var page = (TPage) Activator.CreateInstance(typeof(TPage), webDriver);
        webDriver.Navigate().GoToUrl(page.CompositeUrl(path));
        return page;
    }
}