using Presentation.JsonSeedStorage;
using System.Text.RegularExpressions;

namespace Presentation.JsonMappedSeedStorage;

public interface IGenerateCodeService
{
    Task GenerateCodeInitializer();
}


public class GenerateCodeService : IGenerateCodeService
{

    private readonly IWebHostEnvironment _env;
    public GenerateCodeService(IWebHostEnvironment env)
    {
        _env = env;
    }



    public async Task GenerateCodeInitializer()
    {
        var jsonFilePath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage", "Biceps_LongHeadBicep_ShortHeadBicep.json");
        string jsonFile = await File.ReadAllTextAsync(jsonFilePath);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var workouts = JsonSerializer.Deserialize<List<WorkoutOutput>>(jsonFile, options);

        var workoutLines = new List<string>();
        var equipmentLines = new List<string>();
        var bodyWorkoutLines = new List<string>();

        for (int i = 0; i < workouts.Count ; i++)
        {
            var workout = workouts[i];

            // Escape quotes and handle nulls
            string escapedName = EscapeString(workout.WorkoutName);

            // 1. Generate Workout initialization
            workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = bodybuildingId, Description = \"\" }}");

            // 2. Generate WorkoutEquipment initialization
            string equipmentId = ConvertToIdVariable(workout.Equipment);
            equipmentLines.Add($"new WorkoutEquipment{{ WorkoutId = Workouts[{i}].Id, EquipmentId = {equipmentId} }}");


            foreach (var muscle in workout.Muscles)
            {
                string muscleName = EscapeString(muscle.Key);
                string priority = muscle.Value.MuscleTargetLevel;

                bodyWorkoutLines.Add($"new BodyWorkout{{ BodyId = \"{muscleName}\", WorkoutId = Workouts[{i}].Id, Target = PriorityTarget.{priority} }}");
            }
        }
        // Output the results
        Console.WriteLine("// Workout Initializations");
        var workoutsss = ($"var Workouts = new List<Workout>\n{{\n    {string.Join(",\n    ", workoutLines)}\n}};");
        Console.WriteLine(workoutsss);

        Console.WriteLine("\n// WorkoutEquipment Initializations");
        var equipmets = ($"var workoutEquipment = new List<WorkoutEquipment>\n{{\n    {string.Join(",\n    ", equipmentLines)}\n}};");

        Console.WriteLine("\n// BodyWorkout Initializations");
        var bodyWorkout = ($"var bodyWorkouts = new List<BodyWorkout>\n{{\n    {string.Join(",\n    ", bodyWorkoutLines)}\n}};");

    }


    private static string EscapeString(string input)
    {
        return input?.Replace("\"", "\\\"") ?? string.Empty;
    }

    private static string ConvertToIdVariable(string equipment)
    {
        // Convert to lowercase and remove non-alphanumeric characters
        string cleaned = Regex.Replace(equipment, "[^a-zA-Z0-9]", "").ToLower();
        return $"{cleaned}Id";
    }

}
