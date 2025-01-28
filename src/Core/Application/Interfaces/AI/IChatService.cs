using Application.DTOs.Response;

namespace Application.Interfaces.AI;

public interface IChatService : IDisposable
{
    Task<string> AskQuestionAsync(string qustion);
    Task<string> AskQuestion(string question);
    Task<DeepSeekResponse> AskQuestionDeepSeekAsync(string question);

}
