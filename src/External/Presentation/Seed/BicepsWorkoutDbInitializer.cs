namespace Presentation.Seed;

public static class BicepsWorkoutDbInitializer
{
    // Biceps // Long Head Bicep // Short Head Bicep
    public static async Task BicepsWorkoutSeedAsync(FitnessContext context)
    {
        //using var transactions = await context.Database.BeginTransactionAsync();

        var workouts = new List<Workout>();

        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        

        await context.Workouts.AddRangeAsync(workouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var workoutInstruction = new List<WorkoutInstruction>();

        


        await context.WorkoutInstructions.AddRangeAsync(workoutInstruction);
        await context.SaveChangesAsync();
        // ***************************************************************** //

        var workoutEquipment = new List<WorkoutEquipment>();
        var barbellId = context.Equipments.Where(x => x.Name == "Barbell").Select(x => x.Id).FirstOrDefault();
        var ezbarId = context.Equipments.Where(x => x.Name == "E-Z Curl Bar").Select(x => x.Id).FirstOrDefault();
        var cableMachineId = context.Equipments.Where(x => x.Name == "Cable Machine").Select(x => x.Id).FirstOrDefault();
        var pullUpMachineId = context.Equipments.Where(x => x.Name == "Pull Up Machine").Select(x => x.Id).FirstOrDefault();
        var machineId = context.Equipments.Where(x => x.Name == "Machine").Select(x => x.Id).FirstOrDefault();
        var stretchesId = context.Equipments.Where(x => x.Name == "stretches").Select(x => x.Id).FirstOrDefault();
        var plateId = context.Equipments.Where(x => x.Name == "Plate").Select(x => x.Id).FirstOrDefault();
        var bosuballId = context.Equipments.Where(x => x.Name == "Bosu-Ball").Select(x => x.Id).FirstOrDefault();
        var smithMachineId = context.Equipments.Where(x => x.Name == "Smith Machine").Select(x => x.Id).FirstOrDefault();
        var dumbellId = context.Equipments.Where(x => x.Name == "Dumbells").Select(x => x.Id).FirstOrDefault();
        var cableId = context.Equipments.Where(x => x.Name == "Cable").Select(x => x.Id).FirstOrDefault();
        var trxId = context.Equipments.Where(x => x.Name == "TRX").Select(x => x.Id).FirstOrDefault();
        var vitruvianId = context.Equipments.Where(x => x.Name == "Vitruvian").Select(x => x.Id).FirstOrDefault();
        var cardioId = context.Equipments.Where(x => x.Name == "Cardio").Select(x => x.Id).FirstOrDefault();
        var bodyweightId = context.Equipments.Where(x => x.Name == "Bodyweight").Select(x => x.Id).FirstOrDefault();
        var kettlebellId = context.Equipments.Where(x => x.Name == "KettleBells").Select(x => x.Id).FirstOrDefault();
        var BandsId = context.Equipments.Where(x => x.Name == "Bands").Select(x => x.Id).FirstOrDefault();
        var yogaId = context.Equipments.Where(x => x.Name == "Yoga").Select(x => x.Id).FirstOrDefault();

        var medicineBallId = context.Equipments.Where(x => x.Name == "Medicine-Ball").Select(x => x.Id).FirstOrDefault();
        var recoveryId = context.Equipments.Where(x => x.Name == "Recovery").Select(x => x.Id).FirstOrDefault();

        



        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        




        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var bodyWorkouts = new List<BodyWorkout>();
        var bicepId = await context.Bodies.Where(z => z.Name == "Biceps").Select(z => z.Id).FirstOrDefaultAsync();
        var longHeadBicepId = await context.Bodies.Where(z => z.Name == "Long Head Bicep").Select(z => z.Id).FirstOrDefaultAsync();
        var shortHeadBicepId = await context.Bodies.Where(z => z.Name == "Short Head Bicep").Select(z => z.Id).FirstOrDefaultAsync();

        

        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        



        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}
