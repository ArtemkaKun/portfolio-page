namespace PortfolioApp.AboutDataSystem;

public class AboutHtmlDataManager : IAboutDataManager
{
    private readonly IAboutDataProvider _aboutDataProvider;
    
    public AboutHtmlDataManager(IAboutDataProvider aboutDataProvider)
    {
        _aboutDataProvider = aboutDataProvider;
    }

    public string RequestData()
    {
        return _aboutDataProvider.GetData();
    }
}