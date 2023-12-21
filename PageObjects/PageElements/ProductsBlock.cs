using OpenQA.Selenium;
using SeleniumInfrastructure.Controls;

namespace PageObjects.PageElements;

public class ProductsBlock : ControlBase
{
    public ProductsBlock(ISearchContext context, By by) : base(context, by)
    {
    }

    public ProductsBlock Extern => Find<ProductsBlock>(By.XPath("//*[@data-event-name = \"main-product-click-extern\"]"));
}