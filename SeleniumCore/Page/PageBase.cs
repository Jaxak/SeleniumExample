using OpenQA.Selenium;
using SeleniumInfrastructure.Controls;

namespace SeleniumInfrastructure.Page;

public abstract class PageBase : IPage
{
    protected PageBase(IWebDriver driver) => _driver = driver;
    protected readonly IWebDriver _driver;
    public abstract string Url { get; }
    public abstract string Title { get; }

    public string CompositeUrl(string path) => Url + path;

    protected TControl Find<TControl>(By by, ISearchContext? context = null) where TControl : class, IControl
        => (TControl) Activator.CreateInstance(typeof(TControl), context ?? _driver, by);
}