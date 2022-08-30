namespace PortfolioAppServer.ProjectsDataSystem;

public record ProjectData : IProjectData
{
    public string Name { get; init; } = null!;
    public IReadOnlyList<string> Tags { get; init; } = null!;
    public string Description { get; init; } = null!;
}