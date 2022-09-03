namespace PortfolioAppServer.ProjectsDataSystem;

public interface IProjectData
{
    public string Name { get; }
    public IReadOnlyList<string> Tags { get; }
    public string Description { get; }
    public IReadOnlyList<string> Achievements { get; }
}