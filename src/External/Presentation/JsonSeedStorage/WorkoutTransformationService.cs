namespace Presentation.JsonSeedStorage;

public class WorkoutTransformationService
{
    //private readonly WorkoutOutput

    private readonly string _inputFilePath;
    private readonly string _outputFilePath;
    private readonly ILogger<WorkoutTransformationService> _logger;

    public WorkoutTransformationService(
        string inputFilePath,
        string outputFilePath,
        ILogger<WorkoutTransformationService> logger)
    {
        _inputFilePath = inputFilePath;
        _outputFilePath = outputFilePath;
        _logger = logger;
    }




}
