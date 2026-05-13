namespace portfolio_website.Components.Layout;

public static class AppTheme
{
    public static MudTheme Default => new()
    {
        PaletteLight = new PaletteLight()
        {
            Primary = "#1a1a1a",
            Secondary = "#4a4a4a",
            AppbarBackground = "#ffffff",
            AppbarText = "#1a1a1a",
            Background = "#f5f5f5",
            Surface = "#ffffff",
            TextPrimary = "#1a1a1a",
            TextSecondary = "#6b6b6b",
            Divider = "#e0e0e0",
        },
        PaletteDark = new PaletteDark()
        {
            Primary = "#ffffff",
            Secondary = "#b0b0b0",
            AppbarBackground = "#1a1a1a",
            AppbarText = "#ffffff",
            Background = "#121212",
            Surface = "#1e1e1e",
            TextPrimary = "#ffffff",
            TextSecondary = "#9e9e9e",
            Divider = "#2e2e2e",
        }
    };
}