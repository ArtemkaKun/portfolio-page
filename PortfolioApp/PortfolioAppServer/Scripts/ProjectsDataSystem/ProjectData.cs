using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PortfolioAppServer.ProjectsDataSystem;

public record ProjectData : IProjectData
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    private string? Id { get; init; }
    [BsonElement("name")]
    public string Name { get; init; } = null!;
    [BsonElement("tags")]
    public IReadOnlyList<string> Tags { get; init; } = null!;
    [BsonElement("description")]
    public string Description { get; init; } = null!;
    [BsonElement("achievements")]
    public IReadOnlyList<string> Achievements { get; init; } = null!;
}