using MongoDB.Driver;

namespace PortfolioAppServer.ProjectsDataSystem;

public class MongoDBProjectsDataStorage : IProjectsDataStorage
{
    public IReadOnlyList<IProjectData> GetProjectsData()
    {
        IMongoClient mongoClient = new MongoClient(Environment.GetEnvironmentVariable("MONGO_CONNECTION_STRING"));
        IMongoDatabase portfolioDB = mongoClient.GetDatabase(Environment.GetEnvironmentVariable("PROJECTS_DB_NAME"));
        IMongoCollection<ProjectData> projectsCollection = portfolioDB.GetCollection<ProjectData>(Environment.GetEnvironmentVariable("PROJECTS_COLLECTION_NAME"));

        return projectsCollection.Find(_ => true).ToList();
    }
}