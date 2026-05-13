
namespace portfolio_website.Models;

public class Project
{
    public int Id { get; set; } 
    public string? Title { get; set; } 
    public string? Description { get; set; }
    public List<Skill>? TechStack { get; set; }
    public string? LiveUrl { get; set; }
    public string? GitHubUrl { get; set; }
}
