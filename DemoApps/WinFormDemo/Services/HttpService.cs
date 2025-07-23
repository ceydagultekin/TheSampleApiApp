namespace WinFormDemo.Services;

public static class HttpService
{
    public static readonly HttpClient Client = new()
    {
        BaseAddress = new Uri("https://localhost:7188")
    };
}
