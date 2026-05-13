namespace portfolio_website;
public static class DependencyInjection
{
    public static IServiceCollection AddDI(this IServiceCollection services)
    {
        services.AddMudServices();
        services.AddScoped<ThemeService>();
        services.AddScoped<SkillsService>();
        return services;
    }
}