using OpenQA.Selenium;
using PageObjects.PageElements;
using SeleniumInfrastructure.Page;

namespace PageObjects.Pages;

public class KonturPage : PageBase, IPage
{
    public KonturPage(IWebDriver driver) : base(driver)
    {
    }

    public override string Url => "https://kontur.ru/";
    public override string Title => _driver.Title;

    public ProductsBlock MaybeVariant => new(_driver, By.XPath("//*[@data-home-hot-product-links]"));
    public ProductsBlock GoodVariant => Find<ProductsBlock>(By.XPath("//*[@data-home-hot-product-links]"));
}