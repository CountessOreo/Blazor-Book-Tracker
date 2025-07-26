using Microsoft.JSInterop;

public class ThemeService
{
    private readonly IJSRuntime js;

    public bool IsDarkMode { get; private set; } = false;

    public ThemeService(IJSRuntime jsRuntime)
    {
        js = jsRuntime;
    }

    public async Task ToggleThemeAsync()
    {
        IsDarkMode = !IsDarkMode;
        await js.InvokeVoidAsync("toggleBodyClass", IsDarkMode ? "dark-mode" : "light-mode");
    }

    public async Task SetInitialThemeAsync()
    {
        await js.InvokeVoidAsync("toggleBodyClass", "light-mode");
    }
}
