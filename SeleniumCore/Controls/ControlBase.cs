using OpenQA.Selenium;

namespace SeleniumInfrastructure.Controls;

public abstract class ControlBase : IControl
{
    protected IWebElement _thisElement { get; }
    protected ISearchContext _parrentContext { get; }

    protected ControlBase(ISearchContext context, By by)
    {
        _parrentContext = context;
        _thisElement = context.FindElement(by);
    }

    public virtual void Click() => _thisElement.Click();

    protected TControl Find<TControl>(By by, ISearchContext? context = null) where TControl : class, IControl
        => (TControl) Activator.CreateInstance(typeof(TControl), context ?? _thisElement, by);
}