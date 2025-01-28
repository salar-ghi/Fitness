namespace Application.DTOs.Response;

public class DeepSeekResponse
{
    public string Answer { get; set; }
    public List<string> Tokens { get; set; }
    public double Confidence { get; set; }

}
