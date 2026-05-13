using Microsoft.JSInterop;

namespace portfolio_website.Services;

public class ThemeService
{
    private readonly IJSRuntime _js;

    public bool IsDarkMode { get; private set; } = true;

    public ThemeService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task InitializeAsync()
    {
        var stored = await _js.InvokeAsync<string>("localStorage.getItem", "darkMode");
        IsDarkMode = stored == null ? true : stored == "true";

    }

    public async Task SetDarkModeAsync(bool value)
    {
        IsDarkMode = value;
        await _js.InvokeVoidAsync("localStorage.setItem", "darkMode", value.ToString().ToLower());
    }
}