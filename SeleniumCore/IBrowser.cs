using SeleniumInfrastructure.Page;

namespace SeleniumInfrastructure;

public interface IBrowser : IDisposable
{
    TPage GoToPage<TPage>() where TPage : class, IPage;
    TPage GoToPage<TPage>(string path) where TPage : class, IPage;
}