using OpenQA.Selenium;

namespace SeleniumInfrastructure.Controls;

public class Button : ControlBase
{
    public Button(ISearchContext context, By by) : base(context, by)
    {
    }

    public virtual void Send(string text) => _thisElement.SendKeys(text);
}