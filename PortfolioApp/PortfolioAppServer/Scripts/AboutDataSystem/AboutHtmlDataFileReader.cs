namespace PortfolioAppServer.AboutDataSystem;

public class AboutHtmlDataFileReader : IAboutDataProvider
{
    private readonly string _filePath;
    
    public AboutHtmlDataFileReader(string filePath)
    {
        _filePath = filePath;
    }
    
    public string GetData()
    {
        return File.ReadAllText(_filePath);
    }
}