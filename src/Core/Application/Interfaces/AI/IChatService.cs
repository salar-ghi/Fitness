namespace Application.Interfaces.AI;

public interface IChatService : IDisposable
{
    Task<string> AskQuestionAsync(string qustion);
    Task<string> AskQuestion(string question);

    //Task<ChatCompletion> CompleteAsync(string qustion);
    //IAsyncEnumerable<StreamingChatCompletionUpdate> CompleteStreamingAsync(...);
    //ChatClientMetadata Metadata { get; }
    TService? GetService<TService>(object? key = null) where TService : class;
}
