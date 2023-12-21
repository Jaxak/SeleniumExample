using OpenQA.Selenium;
using SeleniumInfrastructure.Page;

namespace SeleniumInfrastructure;

public class Browser : IBrowser
{
    private readonly IWebDriver _webDriver;
    private readonly IPageFactory _pageFactory;

    public Browser(IWebDriver webDriver, IPageFactory pageFactory)
    {
        _webDriver = webDriver;
        _pageFactory = pageFactory;
    }

    public TPage GoToPage<TPage>() where TPage : class, IPage
        => _pageFactory.Create<TPage>(_webDriver);

    public TPage GoToPage<TPage>(string path) where TPage : class, IPage
        => _pageFactory.Create<TPage>(_webDriver, path);

    public void Dispose() => _webDriver.Dispose();
}