namespace PortfolioAppServer.ProjectsDataSystem;

public class MongoDBProjectsDataStorage : IProjectsDataStorage
{
    public IReadOnlyList<IProjectData> GetProjectsData()
    {
        return new[]
        {
            new ProjectData
            {
                Name = "[NDA] Custom subscription implementation (Unity + PlayFab)",

                Tags = new[]
                {
                    "Unity",
                    "PlayFab",
                    "C#",
                    "JSON",
                    "JS"
                },

                Description = "Custom subscription implementation for Unity game. It uses PlayFab as a backend. It's a part of a bigger project, so I can't show the code."
            }
        };
    }
}