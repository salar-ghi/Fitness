using Domain.Models;

namespace Presentation.Seed;

public static class WorkoutDbInitializer
{
    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        var workouts = new List<Workout>();
        if (!await context.Workouts.AnyAsync())
        {
            using var transaction = await context.Database.BeginTransactionAsync();
            workouts = new List<Workout>
            {
                new Workout{ Name = "Barbell Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Dumbbell Curl", SportId = 1, Description = "" },
                new Workout{ Name = "Dumbbell Hammer Curl", SportId = 1, Description = "" },
            };
            await context.Workouts.AddRangeAsync(workouts);
            await context.SaveChangesAsync();

            await transaction.CommitAsync();
        };
    }

    public static async Task WorkoutInstructionSeedAsync(FitnessContext context)
    {
        var workoutInstruction = new List<WorkoutInstruction>();
        if (!await context.WorkoutInstructions.AnyAsync())
        {
            using var transactions = await context.Database.BeginTransactionAsync();
            workoutInstruction = new List<WorkoutInstruction>
            {
                new WorkoutInstruction{ WorkoutId = 1 , Instruction = ""},
            };
            await context.WorkoutInstructions.AddRangeAsync(workoutInstruction);
            await context.SaveChangesAsync();

            await transactions.CommitAsync();
        };
    }

    public static async Task BodyWorkoutsSeedAsync(FitnessContext context)
    {
        var bodyWorkouts = new List<BodyWorkout>();
        if (!await context.BodyWorkouts.AnyAsync())
        {
            using var transactions = await context.Database.BeginTransactionAsync();
            bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout{ BodyId = 1, WorkoutId = 1},
            };
            await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
            await context.SaveChangesAsync();

            await transactions.CommitAsync();
        };
    }

    public static async Task WorkoutEquipmentSeedAsync(FitnessContext context)
    {
        var workoutEquipment = new List<WorkoutEquipment>();
        if (!await context.WorkoutEquipment.AnyAsync())
        {
            using var transactions = await context.Database.BeginTransactionAsync();
            workoutEquipment = new List<WorkoutEquipment>
            {
                new WorkoutEquipment{ WorkoutId = 1, EquipmentId = 1 },
            };
            await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
            await context.SaveChangesAsync();

            await transactions.CommitAsync();
        };
    }

    public static async Task WorkoutLevelSeedAsync(FitnessContext context)
    {
        var workoutLevel = new List<WorkoutLevel>();
        if (! await context.WorkoutLevels.AnyAsync())
        {
            using var transactions = await context.Database.BeginTransactionAsync();
            workoutLevel = new List<WorkoutLevel>
            {
                new WorkoutLevel{ WorkoutId = 1, Level = Difficulty.Intermediate},
            };
            await context.WorkoutLevels.AddRangeAsync(workoutLevel);
            await context.SaveChangesAsync();

            await transactions.CommitAsync();
        };
    }

    public static async Task WorkoutSexSeedAsync(FitnessContext context)
    {
        var workoutSex = new List<WorkoutSex>();
        if (! await context.WorkoutSex.AnyAsync())
        {
            using var transactions = await context.Database.BeginTransactionAsync();
            workoutSex = new List<WorkoutSex>
            {
                new WorkoutSex{ WorkoutId = 1, Sex = Sex.Man}
            };
            await context.WorkoutSex.AddRangeAsync(workoutSex);
            await context.SaveChangesAsync();

            await transactions.CommitAsync();
        };
    }


}
