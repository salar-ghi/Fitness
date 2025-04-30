namespace Presentation.Services;

public class DeepSeekService
{
    public readonly HttpClient _client;

    public DeepSeekService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _client = httpClientFactory.CreateClient();
    }

}
