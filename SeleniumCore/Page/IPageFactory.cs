using OpenQA.Selenium;

namespace SeleniumInfrastructure.Page;

public interface IPageFactory
{
    TPage Create<TPage>(IWebDriver webDriver) where TPage : class, IPage;
    TPage Create<TPage>(IWebDriver webDriver, string path) where TPage : class, IPage;
}