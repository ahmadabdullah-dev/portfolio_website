namespace portfolio_website.Services;
public class SkillsService
{
    private readonly string _filePath;
    public SkillsService(IWebHostEnvironment env)
    {
        _filePath = Path.Combine(env.ContentRootPath, "Data", "Skills.json");
    }
    private async Task<List<Skill>> ReadAsync()
    {
        var json = await File.ReadAllTextAsync(_filePath);
        return JsonSerializer.Deserialize<List<Skill>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        }) ?? new List<Skill>();
    }
    public async Task<List<Skill>> GetAllAsync() => await ReadAsync();
    public async Task<List<Skill>> GetByCategoryAsync(string category)
    {
        var skills = await ReadAsync();
        return skills.Where(s => s.Category.ToLower() == category.ToLower()).ToList();
    }
}

