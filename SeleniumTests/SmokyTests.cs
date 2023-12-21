using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using PageObjects.Pages;
using SeleniumInfrastructure;
using SeleniumInfrastructure.Page;

namespace SeleniumTests;

public class SmokyTests
{
    private IBrowser Browser = new Browser(new FirefoxDriver(), new PageFactory());

    [TestCase("Контур.Экстерн")]
    public void ClickByButtonShould_BeGoToExternPage(string substring)
    {
        var page = Browser.GoToPage<KonturPage>();
        page.GoodVariant.Extern.Click();
        Assert.That(page.Title, Contains.Substring(substring).After(5000, 1000));
    }

    [TearDown]
    protected void TearDown() => Browser.Dispose();
}