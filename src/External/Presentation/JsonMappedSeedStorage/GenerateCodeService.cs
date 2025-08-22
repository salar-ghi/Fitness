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
            var jsonFilePath = Path.Combine(_env.ContentRootPath, "JsonMappedSeedStorage", "WorkoutUpdateInstructionFiles", "Calves_Tibialis_Soleus_Gastrocnemius.json");
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
                if (workout.Equipment == "TRX" || workout.Equipment == "Bodyweight")
                {
                    workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = crossfitId, Description = \"\" }}");
                }
                else if (workout.Equipment == "Yoga")
                {
                    workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = yogaSportId, Description = \"\" }}");
                }
                else if (workout.Equipment == "Cardio" || workout.Equipment == "Recovery"
                    || workout.Equipment == "Stretches" || workout.Equipment == "Band")
                {
                    workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = cardioSportId, Description = \"\" }}");
                }
                else
                {
                    workoutLines.Add($"new Workout{{ Name = \"{escapedName}\", SportId = bodybuildingId, Description = \"\" }}");
                }

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

                        instructionLines.Add($"new WorkoutInstruction{{ WorkoutId = Workouts[{i}].Id , Step = {step.Key} , Instruction = \" {EscapeString(step.Value)}\" }}");
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

                    if (muscleName == "Calves" || muscleName == "Tibialis" || muscleName == "Soleus" || muscleName == "Gastrocnemius")
                    {
                        var muscleId = GetMuscleId(muscleName);
                        bodyWorkoutLines.Add($"new BodyWorkout{{ BodyId = {muscleId} , WorkoutId = Workouts[{i}].Id, Target = PriorityTarget.{priority} }}");
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            // Output the results
            Console.Clear();
            Console.WriteLine("// Workout Initializations");
            var workoutsss = ($"var Workouts = new List<Workout>\n{{\n    {string.Join(",\n    ", workoutLines)}\n}};");

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
                "UpperChest (Upper Pectoralis)" => "upChestId",
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
                "Outer Quadricep" => "OutQuadricepId",
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
