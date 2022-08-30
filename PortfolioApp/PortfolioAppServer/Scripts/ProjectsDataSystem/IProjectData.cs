namespace PortfolioAppServer.Scripts.ProjectsDataSystem;

public interface IProjectData
{
    public string GetName();
    public IReadOnlyList<string> GetTags();
    public string GetDescription();
}