using Presentation.JsonSeedStorage;

namespace Presentation.JsonMappedSeedStorage;

public class GenerateCodeService
{

    private readonly IWebHostEnvironment _env;
    public GenerateCodeService(IWebHostEnvironment env)
    {
        _env = env;
    }



    public async Task GenerateCodeInitializer()
    {
        var jsonFilePath = Path.Combine(_env.ContentRootPath, "JsonStorageFile", "Biceps_LongHeadBicep_ShortHeadBicep.json");
        string jsonFile = await File.ReadAllTextAsync(jsonFilePath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var inputExercises = JsonSerializer.Deserialize<List<WorkoutOutput>>(jsonFile, options);

    }



}
