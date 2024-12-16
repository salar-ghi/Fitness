using Microsoft.Extensions.AI;

namespace Infrastructure.Services;

public class OllamaChatService : IChatService
{
    private bool disposedValue;
    private readonly IChatClient _chatClient;
    public OllamaChatService(IChatClient chatClient)
    {
        _chatClient = chatClient;
    }


    public async Task<string> AskQuestionAsync(string qustion)
    {
        var response = await _chatClient.CompleteAsync(qustion);
        var message = response.Message;
        return response.Message.Text;
    }

    public TService? GetService<TService>(object? key = null) where TService : class
    {
        throw new NotImplementedException();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    // ~OllamaChatService()
    // {
    //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    //     Dispose(disposing: false);
    // }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
