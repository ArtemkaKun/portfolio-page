namespace PortfolioAppServer.Scripts.ProjectsDataSystem;

public interface IProjectsDataStorage
{
    public IReadOnlyList<IProjectData> GetProjectsData();
}