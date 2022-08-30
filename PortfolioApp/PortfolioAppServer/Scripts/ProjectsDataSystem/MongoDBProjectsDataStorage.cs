namespace PortfolioAppServer.ProjectsDataSystem;

public class MongoDBProjectsDataStorage : IProjectsDataStorage
{
    public IReadOnlyList<IProjectData> GetProjectsData()
    {
        return new[]
        {
            new ProjectData
            {
                Name = "[NDA] Custom subscription implementation (Unity + PlayFab)"
            }
        };
    }
}