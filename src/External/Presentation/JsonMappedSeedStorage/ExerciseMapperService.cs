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
        //string inutFilePath = Path.Combine(_env.ContentRootPath, "JsonStorageFile", "Chest_Mid_LowerChest_UpperPectoralis.json");
        //string jsonFilePath = await System.IO.File.ReadAllTextAsync(inutFilePath);
        //if (!System.IO.File.Exists(inutFilePath))

        //string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonMappedSeedStorage", "Biceps_LongHeadBicep_ShortHeadBicep.json");
        string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "JsonStorageFile", "Abdominals_Lower_UpperAbdominals_Obliques.json");
        string json = await File.ReadAllTextAsync(inputPath);

        var inputExercises = JsonSerializer.Deserialize<List<WorkoutInput>>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

        var outputExercises = await MapToOutputExercise(inputExercises);


        var options = new JsonSerializerOptions { WriteIndented = true };
        string outputJson = JsonSerializer.Serialize(outputExercises, options);
        string outputFolderPath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage");
        string filePath = Path.Combine(outputFolderPath, "Abdominals_Lower_UpperAbdominals_Obliques.json");
        if (!System.IO.File.Exists(outputFolderPath))
        {
            Directory.CreateDirectory(outputFolderPath);
        }
        await File.WriteAllTextAsync(filePath, outputJson);
    }


    private async Task<List<WorkoutOutput>> MapToOutputExercise(List<WorkoutInput> inputExercises)
    {
        var equipmentOrder = new List<string>
        {
            "Barbell","Machine","Stretches","Plate","Bosu-Ball","Smith-Machine",
            "Dumbbells","Medicine-Ball","Cables","TRX", "Vitruvian", "Recovery",
            "Bodyweight", "Kettlebells", "Band", "Yoga", "Cardio",
        };

        var groupedExercises = inputExercises
            .GroupBy(x => x.Category.Name)
            .ToDictionary(g => g.Key, g => g.ToList());

        var outputExercises = new List<WorkoutOutput>();
        foreach (var equipment in equipmentOrder)
        {
            if (groupedExercises.TryGetValue(equipment, out var exercises))
            {
                foreach (var inputEx in exercises)
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
            }
        }
        return outputExercises;
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
