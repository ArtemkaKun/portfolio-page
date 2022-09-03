using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioAppServer.ProjectsDataSystem;

public record ProjectData : IProjectData
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    private string? Id { get; init; }
    [BsonElement("Name")]
    public string Name { get; init; } = null!;
    [BsonElement("Tags")]
    public IReadOnlyList<string> Tags { get; init; } = null!;
    [BsonElement("Description")]
    public string Description { get; init; } = null!;
    [BsonElement("Achievements")]
    public IReadOnlyList<string> Achievements { get; init; } = null!;
}