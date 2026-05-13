namespace portfolio_website.Models;

public class BlogPost
{
    public int Id { get; set; } 
    public string? Title { get; set; } 
    public Dictionary<string,string>? Content { get; set; } 
    public string? Slug { get; set; } 
    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;
}
