using Domain.Models;

namespace Presentation.Seed;

public static class WorkoutDbInitializer
{
    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        using var transactions = await context.Database.BeginTransactionAsync();

        var workouts = new List<Workout>();
        if (!await context.Workouts.AnyAsync())
        {
            workouts = new List<Workout>
            {
                // biceps
                new Workout{ Name = "Barbell Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Dumbbell Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Dumbbell Hammer Curl", SportId = 1, Description = "" },

                new Workout{ Name = "Kettlebell Goblet Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Kettlebell Concentration Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Kettlebell Preacher Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Kettlebell Single Arm Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Biceps Stretch Variation Five", SportId = 1, Description = "" },
                new Workout{ Name = "Biceps Stretch Variation Four", SportId = 1, Description = "" },
                new Workout{ Name = "Biceps Stretch Variation Three", SportId = 1, Description = "" },
                new Workout{ Name = "Biceps Stretch Variation Two", SportId = 1, Description = "" },
                new Workout{ Name = "Biceps Stretch Variation One", SportId = 1, Description = "" },
                new Workout{ Name = "Cable Twisting Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Cable Single Arm Bayesian Curl", SportId = 1, Description = "" },


            };
        };

        var workoutInstruction = new List<WorkoutInstruction>();
        if (!await context.WorkoutInstructions.AnyAsync())
        {
            workoutInstruction = new List<WorkoutInstruction>
            {
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 1 , Instruction = "While holding the upper arms stationary, curl the weights forward while contracting the biceps as you breathe out."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 2 , Instruction = "Continue the movement until your biceps are fully contracted and the bar is at shoulder level."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 3 , Instruction = "Hold the contracted position for a second and squeeze the biceps hard."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 4 , Instruction = "Slowly bring the weight back down to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 1 , Instruction = "Stand up straight with a dumbbell in each hand at arm's length."},
                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 2 , Instruction = "Raise one dumbbell and twist your forearm until it is vertical and your palm faces the shoulder."},
                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 3 , Instruction = "Lower to original position and repeat with opposite arm"},

                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 1 , Instruction = "Hold the dumbbells with a neutral grip (thumbs facing the ceiling)" },
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 2 , Instruction = "Slowly lift the dumbbell up to chest height" },
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 3 , Instruction = "Return to starting position and repeat" },

                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 3 , Instruction = "Return to starting position and repeat" },


            };
        };

        var bodyWorkouts = new List<BodyWorkout>();
        if (!await context.BodyWorkouts.AnyAsync())
        {
            bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[0].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[1].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[2].Id },
            };
        };

        var workoutEquipment = new List<WorkoutEquipment>();
        if (!await context.WorkoutEquipment.AnyAsync())
        {
            workoutEquipment = new List<WorkoutEquipment>
            {
                new WorkoutEquipment{ WorkoutId = workouts[0].Id, EquipmentId = 4 },
                new WorkoutEquipment{ WorkoutId = workouts[1].Id, EquipmentId = 3 },
                
                new WorkoutEquipment{ WorkoutId = workouts[2].Id, EquipmentId = 3 },

            };
        };

        var workoutLevel = new List<WorkoutLevel>();
        if (!await context.WorkoutLevels.AnyAsync())
        {
            workoutLevel = new List<WorkoutLevel>
            {
                new WorkoutLevel{ WorkoutId = workouts[0].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[1].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[2].Id , Level = Difficulty.Beginner},
            };
        };

        var workoutSex = new List<WorkoutSex>();
        if (!await context.WorkoutSex.AnyAsync())
        {
            workoutSex = new List<WorkoutSex>
            {
                new WorkoutSex{ WorkoutId = workouts[0].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[0].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[1].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[1].Id, Sex = Sex.Female},
            };
        };



        await context.WorkoutInstructions.AddRangeAsync(workoutInstruction);
        await context.SaveChangesAsync();

        await transactions.CommitAsync();

    }

    //public static async Task WorkoutInstructionSeedAsync(FitnessContext context)
    //{
    //    var workoutInstruction = new List<WorkoutInstruction>();
    //    if (!await context.WorkoutInstructions.AnyAsync())
    //    {
    //        using var transactions = await context.Database.BeginTransactionAsync();

    //        workoutInstruction = new List<WorkoutInstruction>
    //        {
    //            new WorkoutInstruction{ WorkoutId = 1, Step = 1 , Instruction = "While holding the upper arms stationary, curl the weights forward while contracting the biceps as you breathe out."},
    //            new WorkoutInstruction{ WorkoutId = 1 , Step = 2 , Instruction = "Continue the movement until your biceps are fully contracted and the bar is at shoulder level."},
    //            new WorkoutInstruction{ WorkoutId = 1 , Step = 3 , Instruction = "Hold the contracted position for a second and squeeze the biceps hard."},
    //            new WorkoutInstruction{ WorkoutId = 1 , Step = 4 , Instruction = "Slowly bring the weight back down to the starting position."},
    //        };
    //        await context.WorkoutInstructions.AddRangeAsync(workoutInstruction);
    //        await context.SaveChangesAsync();

    //        await transactions.CommitAsync();
    //    };
    //}

    //public static async Task BodyWorkoutsSeedAsync(FitnessContext context)
    //{
    //    var bodyWorkouts = new List<BodyWorkout>();
    //    if (!await context.BodyWorkouts.AnyAsync())
    //    {
    //        using var transactions = await context.Database.BeginTransactionAsync();
    //        bodyWorkouts = new List<BodyWorkout>
    //        {
    //            new BodyWorkout{ BodyId = 25, WorkoutId = },
    //        };
    //        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
    //        await context.SaveChangesAsync();

    //        await transactions.CommitAsync();
    //    };
    //}


    //public static async Task WorkoutEquipmentSeedAsync(FitnessContext context)
    //{
    //    var workoutEquipment = new List<WorkoutEquipment>();
    //    if (!await context.WorkoutEquipment.AnyAsync())
    //    {
    //        using var transactions = await context.Database.BeginTransactionAsync();
    //        workoutEquipment = new List<WorkoutEquipment>
    //        {
    //            new WorkoutEquipment{ WorkoutId = 1, EquipmentId = 1 },
    //        };
    //        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
    //        await context.SaveChangesAsync();

    //        await transactions.CommitAsync();
    //    };
    //}

    //public static async Task WorkoutLevelSeedAsync(FitnessContext context)
    //{
    //    var workoutLevel = new List<WorkoutLevel>();
    //    if (!await context.WorkoutLevels.AnyAsync())
    //    {
    //        using var transactions = await context.Database.BeginTransactionAsync();
    //        workoutLevel = new List<WorkoutLevel>
    //        {
    //            new WorkoutLevel{ WorkoutId = 1, Level = Difficulty.Intermediate},
    //        };
    //        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
    //        await context.SaveChangesAsync();

    //        await transactions.CommitAsync();
    //    };
    //}

    //public static async Task WorkoutSexSeedAsync(FitnessContext context)
    //{
    //    var workoutSex = new List<WorkoutSex>();
    //    if (!await context.WorkoutSex.AnyAsync())
    //    {
    //        using var transactions = await context.Database.BeginTransactionAsync();
    //        workoutSex = new List<WorkoutSex>
    //        {
    //            new WorkoutSex{ WorkoutId = 1, Sex = Sex.Male}
    //        };
    //        await context.WorkoutSex.AddRangeAsync(workoutSex);
    //        await context.SaveChangesAsync();

    //        await transactions.CommitAsync();
    //    };
    //}


}
