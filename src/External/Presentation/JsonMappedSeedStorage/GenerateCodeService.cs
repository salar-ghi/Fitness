namespace Presentation.JsonMappedSeedStorage;

public interface IGenerateCodeService
{
    Task<(List<string>, List<string>, List<string>, List<string>, List<string>)> GenerateCodeInitializer();
}

public class GenerateCodeService : IGenerateCodeService
{

    private readonly IWebHostEnvironment _env;
    public GenerateCodeService(IWebHostEnvironment env)
    {
        _env = env;
    }

    public async Task<(List<string>, List<string>, List<string>, List<string>, List<string>)> GenerateCodeInitializer()
    {
        try
        {
            var jsonFilePath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage", "WorkoutUpdateInstructionFiles", "Quads_InnerThigh_InnerQuadriceps_OuterQuadriceps_RectusFemoris_Feet.json");
            string jsonFile = await File.ReadAllTextAsync(jsonFilePath);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var workouts = JsonSerializer.Deserialize<List<WorkoutOutput>>(jsonFile, options);

            var workoutLines = new List<string>();
            var instructionLines = new List<string>();
            var equipmentLines = new List<string>();
            var workoutLevelLines = new List<string>();
            var bodyWorkoutLines = new List<string>();

            var grouped = workouts
                .GroupBy(w => w.Equipment);

            int index = 0;
            foreach (var group in grouped)
            {
                workoutLines.Add($"// {group.Key}");

                instructionLines.Add($"#region {group.Key}");
                equipmentLines.Add($"#region {group.Key}");
                workoutLevelLines.Add($"#region {group.Key}");
                bodyWorkoutLines.Add($"#region {group.Key}");

                foreach (var workout in group)
                {
                    string escapedName = EscapeString(workout.WorkoutName);

                    string sportId;
                    if (workout.Equipment == "TRX" || workout.Equipment == "Bodyweight")
                    {
                        sportId = "crossfitId";
                    }
                    else if (workout.Equipment == "Yoga")
                    {
                        sportId = "yogaSportId";
                    }
                    else if (workout.Equipment == "Cardio" || workout.Equipment == "Recovery"
                        || workout.Equipment == "Stretches" || workout.Equipment == "Band")
                    {
                        sportId = "cardioSportId";
                    }
                    else
                    {
                        sportId = "bodybuildingId";
                    }
                    workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = {sportId}, Description = \"\" }}, // index => {index}");

                    // Instructions
                    var validSteps = workout.Instruction
                        .Where(kv => !string.IsNullOrWhiteSpace(kv.Value))
                        .OrderBy(kv => int.Parse(kv.Key));

                    foreach (var step in validSteps)
                    {
                        instructionLines.Add($"new WorkoutInstruction{{ WorkoutId = workouts[{index}].Id , Step = {step.Key} , Instruction = \" {EscapeString(step.Value)}\" }}");
                    }

                    string level = EscapeString(workout.WorkoutLevel);
                    workoutLevelLines.Add($"new WorkoutLevel{{ WorkoutId = workouts[{index}].Id, Level = Difficulty.{level} }}");

                    string equipmentId = GetEquipmentIdVariable(workout.Equipment);
                    equipmentLines.Add($"new WorkoutEquipment{{ WorkoutId = workouts[{index}].Id, EquipmentId = {equipmentId} }}");

                    foreach (var (muscle, target) in workout.Muscles)
                    {
                        string muscleName = EscapeString(muscle);
                        string priority = target.MuscleTargetLevel;

                        if (muscleName == "Outer Quadricep" || muscleName == "Rectus Femoris" || muscleName == "Quads" || muscleName == "Inner Thigh"
                            || muscleName == "Inner Quadriceps" || muscleName == "Feet")
                        {
                            var muscleId = GetMuscleId(muscleName);
                            bodyWorkoutLines.Add($"new BodyWorkout{{ BodyId = {muscleId} , WorkoutId = workouts[{index}].Id, Target = PriorityTarget.{priority} }}");
                        }
                        else
                        {
                            continue;
                        }
                    }
                    index++;
                }
                instructionLines.Add("#endregion");
                equipmentLines.Add("#endregion");
                workoutLevelLines.Add("#endregion");
                bodyWorkoutLines.Add("#endregion");
            }
            Console.Clear();
            Console.WriteLine("// Workout Initializations");
            var workoutsss = ($"var workouts = new List<Workout>\n{{\n    {string.Join(",\n    ", workoutLines)}\n}};");

            var instruction = ($"var workoutInstruction = new List<WorkoutInstruction>\n{{\n {string.Join(",\n    ", instructionLines)}\n}};");

            var equipmets = ($"var workoutEquipment = new List<WorkoutEquipment>\n{{\n    {string.Join(",\n    ", equipmentLines)}\n}};");

            var workoutLevel = ($"var workoutLevel = new List<WorkoutLevel>\n{{\n    {string.Join(",\n    ", workoutLevelLines)}\n}};");

            var bodyWorkout = ($"var bodyWorkouts = new List<BodyWorkout>\n{{\n    {string.Join(",\n    ", bodyWorkoutLines)}\n}};");



            return (workoutLines, instructionLines, equipmentLines, workoutLevelLines, bodyWorkoutLines);

        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.ToString());
            throw ex;
        }
    }

    public static string GetMuscleId(string muscle)
    {
        try
        {
            return muscle switch
            {
                "Neck" => "neckId",
                "Chest" => "chestId",
                "Upper Pectoralis" => "upChestId",
                "Mid and Lower Chest" => "midChestId",
                "Mid Chest" => "midChestId",
                "Lower Chest" => "lowChestId",
                "Biceps" => "bicepId",
                "Long Head Bicep" => "longHeadBicepId",
                "Short Head Bicep" => "shortHeadBicepId",
                "Calves" => "calvesId",
                "Tibialis" => "tibialisId",
                "Soleus" => "soleusId",
                "Gastrocnemius" => "gastrocnemiusId",
                "Glutes" => "glutesId",
                "Gluteus Medius" => "glutMedId",
                "Gluteus Maximus" => "glutMaxId",
                "Glutes Minimus" => "glutMinId",
                "Hamstrings" => "hamstringId",
                "Medial Hamstrings" => "medHamstringId",
                "Lateral Hamstrings" => "latHamstringId",
                "Hands" => "handId",
                "Forearms" => "forearmId",
                "Wrists" => "wristId",
                "Wrist Extensors" => "wristExtensorId",
                "Wrist Flexors" => "wristFlexorId",
                "Quads" => "quadId",
                "Inner Thigh" => "inThighId",
                "Inner Quadriceps" => "inQuadricepId",
                "Outer Quadricep" => "outQuadricepId",
                "Rectus Femoris" => "recFemorisId",
                "Feet" => "feetId",
                "Abdominals" => "AbdoId",
                "Lower Abdominals" => "lowAbdoId",
                "Upper Abdominals" => "upAbdoId",
                "Obliques" => "obliqueId",
                "Shoulders" => "shoulderId",
                "Front Shoulders" => "frontShoulderId",
                "Rear Shoulders" => "rearShoulderId",
                "Lateral Deltoid" => "latDeltoidId",
                "Anterior Deltoid" => "antDeltoidId",
                "Posterior Deltoid" => "postDeltoidId",
                "Traps (mid-back)" => "trapId",
                "Lower back" => "lowerbackId",
                "Lats" => "latId",
                "Traps" => "TrapId",
                "Upper Traps" => "upperTrapId",
                "Lower Traps" => "lowerTrapId",
                "Triceps" => "tricepId",
                "Long Head Tricep" => "longHeadTricepId",
                "Lateral Head Triceps" => "lateralHeadTricepId",
                "Medial Head Triceps" => "medialHeadTricepId",

            };
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.ToString());
            throw ex;
        }
    }
    private static string EscapeString(string input)
    {
        return input?.Replace("\"", "\\\"") ?? string.Empty;
    }

    private static string GetEquipmentIdVariable(string equipment)
    {
        try
        {
            return equipment switch
            {
                "Barbell" => "barbellId",
                "E-Z Curl Bar" => "ezbarId",
                "Cable Machine" => "cableMachineId",
                "Pull Up Machine" => "pullUpMachineId",
                "Machine" => "machineId",
                "Stretches" => "stretchesId",
                "Plate" => "plateId",
                "Bosu-Ball" => "bosuballId",
                "Smith-Machine" => "smithMachineId",
                "Dumbbells" => "dumbbellId",
                "Cables" => "cableId",
                "TRX" => "trxId",
                "Vitruvian" => "vitruvianId",
                "Cardio" => "cardioId",
                "Bodyweight" => "bodyweightId",
                "Kettlebells" => "kettlebellId",
                "Band" => "BandId",
                "Yoga" => "yogaId",
                "Medicine-Ball" => "medicineBallId",
                "Recovery" => "recoveryId",
            };
        }
        catch (Exception ex)
        {
            Console.Clear();
            Console.WriteLine(ex.ToString());
            throw ex;
        }
    }

}
