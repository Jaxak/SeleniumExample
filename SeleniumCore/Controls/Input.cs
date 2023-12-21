using OpenQA.Selenium;

namespace SeleniumInfrastructure.Controls;

public class Input : ControlBase
{
    public Input(ISearchContext context, By by) : base(context, by)
    {
    }
}