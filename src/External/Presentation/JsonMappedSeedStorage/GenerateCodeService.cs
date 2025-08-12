using Domain.Models;
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
        var instructionLines = new List<string>();
        var equipmentLines = new List<string>();
        var workoutLevelLines = new List<string>();
        var bodyWorkoutLines = new List<string>();


        for (int i = 0; i < workouts.Count; i++)
        {
            var workout = workouts[i];

            // Escape quotes and handle nulls
            string escapedName = EscapeString(workout.WorkoutName);

            // 1. Generate Workout initialization
            workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = bodybuildingId, Description = \"\" }}");


            if (true)
            {
                var validSteps = workout.Instruction
                    .Where(kv => !string.IsNullOrWhiteSpace(kv.Value))
                    .OrderBy(kv => int.Parse(kv.Key));

                foreach (var step in validSteps)
                {
                    //if (string.IsNullOrWhiteSpace(inst.Value)) continue;
                    //int step = int.Parse(inst.Key);
                    //string Instruction = inst.Value.Replace("\"", "\\\"");

                    instructionLines.Add($"new WorkoutInstruction{{ WorkoutId = Workouts[{i}].Id , Step = {step.Key} , Instruction = \" {EscapeString(step.Value)}\" }},");
                }

            }

            // 2. Generate WorkoutEquipment initialization
            string equipmentId = GetEquipmentIdVariable(workout.Equipment);
            equipmentLines.Add($"new WorkoutEquipment{{ WorkoutId = Workouts[{i}].Id, EquipmentId = {equipmentId} }}");

            string level = EscapeString(workout.WorkoutLevel);
            workoutLevelLines.Add($"new WorkoutLevel{{ WorkoutId = Workouts[{i}].Id, Level = Difficulty.{level} }}");
            //foreach (var muscle in workout.Muscles)
            //{
            //    string muscleName = EscapeString(muscle.Key);
            //    string priority = muscle.Value.MuscleTargetLevel;

            //    bodyWorkoutLines.Add($"new BodyWorkout{{ BodyId = \"{muscleName}\", WorkoutId = Workouts[{i}].Id, Target = PriorityTarget.{priority} }}");
            //}

            foreach (var (muscle, target) in workout.Muscles)
            {
                string muscleName = EscapeString(muscle);
                string priority = target.MuscleTargetLevel;

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

    private static string GetEquipmentIdVariable(string equipment)
    {
        return equipment switch
        {
            "Barbell"           => "barbellId",
            "E-Z Curl Bar"      => "ezbarId",
            "Cable Machine"     => "cableMachineId",
            "Pull Up Machine"   => "pullUpMachineId",
            "Machine"           => "machineId",
            "stretches"         => "stretchesId",
            "Plate"             => "plateId",
            "Bosu-Ball"         => "bosuballId",
            "Smith Machine"     => "smithMachineId",
            "Dumbells"          => "dumbellId",
            "Cable"             => "cableId",
            "TRX"               => "trxId",
            "Vitruvian"         => "vitruvianId",
            "Cardio" => "cardioId",
            "Bodyweight" => "bodyweightId",
            "KettleBells" => "kettlebellId",
            "Bands" => "BandsId",
            "Yoga" => "yogaId",
        };


        //string cleaned = Regex.Replace(equipment, "[^a-zA-Z0-9]", "").ToLower();
        //return $"{cleaned}Id";
    }

}
