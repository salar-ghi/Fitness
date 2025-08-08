using Presentation.JsonStorageFile;

namespace Presentation.JsonSeedStorage;


public interface IExerciseMapperService
{
    Task ProcessAndSaveExercisesAsync();
}

public class ExerciseMapperService : IExerciseMapperService
{
    private readonly IWebHostEnvironment _env;
    public ExerciseMapperService(IWebHostEnvironment env)
    {
        _env = env;
    }

    private static readonly string[] TargetLevels =
    {
        "Primary", "Secondary", "Tertiary"
    };

    public async Task ProcessAndSaveExercisesAsync()
    {
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonStorageFile", "Biceps_LongHeadBicep_ShortHeadBicep.json");
        string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonMappedSeedStorage", "Biceps_LongHeadBicep_ShortHeadBicep.json");

        string inutFilePath = Path.Combine(_env.ContentRootPath, "JsonStorageFile", "Biceps_LongHeadBicep_ShortHeadBicep.json");
        //if (!System.IO.File.Exists(inutFilePath))

        string jsonFilePath = System.IO.File.ReadAllText(inputPath);            
            
        //string outputFilePath = ;

        string json = await File.ReadAllTextAsync(inputPath);

        var inputExercises = JsonSerializer.Deserialize<List<WorkoutInput>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        var outputExercises = new List<WorkoutOutput>();
        foreach (var inputEx in inputExercises) 
        {
            var outputEx = new WorkoutOutput
            {
                WorkoutName = inputEx.Name,
                Instruction = CreateEmptyInstructions(3),
                WorkoutLevel = inputEx.Difficulty.Name,
                Equipment = inputEx.Category.Name,
            };
            for (int i = 0; i < inputEx.Muscles.Count; i++) 
            {
                string level = i < TargetLevels.Length
                    ? TargetLevels[i]
                    : $"Level {i + 1}";

                outputEx.Muscles[inputEx.Muscles[i].Name] =
                    new OutputMuscleTarget { MuscleTargetLevel = level };
            }
            outputExercises.Add(outputEx);
        }

        var options = new JsonSerializerOptions { WriteIndented = true };
        string outputJson = JsonSerializer.Serialize(outputExercises, options);
        string outputFolderPath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage");
        string filePath = Path.Combine(outputFolderPath, "Biceps_LongHeadBicep_ShortHeadBicep.json");
        if (!System.IO.File.Exists(outputFolderPath))
        {
            Directory.CreateDirectory(outputFolderPath);
        }
        await File.WriteAllTextAsync(filePath, outputJson);
    }

    private Dictionary<string, string> CreateEmptyInstructions(int count)
    {
        var instructions = new Dictionary<string, string>();
        for (int i = 1; i <= count; i++)
        {
            instructions[i.ToString()] = "";
        }
        return instructions;
    }
}
