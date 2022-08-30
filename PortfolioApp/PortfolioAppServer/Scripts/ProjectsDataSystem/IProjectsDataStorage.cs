namespace PortfolioAppServer.ProjectsDataSystem;

public interface IProjectsDataStorage
{
    public IReadOnlyList<IProjectData> GetProjectsData();
}