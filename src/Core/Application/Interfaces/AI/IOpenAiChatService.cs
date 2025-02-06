using System.Text.Json.Serialization;

namespace Application.Interfaces.AI;

public interface IOpenAiChatService
{
    Task<string> GetResponse(string question);
}
