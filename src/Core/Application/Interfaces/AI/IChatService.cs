using Application.DTOs.Response;

namespace Application.Interfaces.AI;

public interface IChatService
{
    Task<string> AskQuestion(string question);
    Task<DeepSeekResponse> AskQuestionDeepSeekAsync(string question);

}
