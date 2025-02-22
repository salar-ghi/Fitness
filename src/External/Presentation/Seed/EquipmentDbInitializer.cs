namespace Presentation.Seed;

public static class EquipmentDbInitializer
{
    public static async Task EquipmentSeedAsync(FitnessContext context)
    {
        //await context.Database.EnsureCreatedAsync();
        var equipments  = new List<Equipment>();
        if (!context.Equipments.Any())
        {
            //using var transaction = await context.Database.BeginTransactionAsync();

            equipments = new List<Equipment>
            {
                new Equipment { Name = "Bodyweight", EquipmentType = EquipmentType.Body},
                new Equipment { Name = "Dumbells", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Barbell", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "KettleBells", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Smith Machine", EquipmentType = EquipmentType.Machine, Description= "A barbell fixed within steel rails, providing stability for various lifts"},
                new Equipment { Name = "Leg Press Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the quadriceps, hamstrings, and glutes"},
                new Equipment { Name = "Chest Press Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the chest muscles with guided movements"},
                new Equipment { Name = "Lat Pulldown Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the latissimus dorsi muscles in the back"},
                new Equipment { Name = "Leg Curl Machine", EquipmentType = EquipmentType.Machine, Description= "Isolates the hamstrings for targeted strengthening"},
                new Equipment { Name = "Leg Extension Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the quadriceps"},
                new Equipment { Name = "Cable Machine", EquipmentType = EquipmentType.Machine, Description= "Versatile machines that allow for a wide range of exercises using adjustable cables"},
                new Equipment { Name = "Bench Press", EquipmentType = EquipmentType.Machine, Description = " Performed lying on a bench, allowing for a full range of motion as the barbell can descend below the chest level"},
                new Equipment { Name = "Floor Press", EquipmentType = EquipmentType.Machine, Description = "Executed lying on the floor, which limits the range of motion since the elbows stop descending when they touch the ground"},
                new Equipment { Name = "Treadmill", EquipmentType = EquipmentType.Equipment, Description= "Ideal for running or walking to improve cardiovascular fitness"},
                new Equipment { Name = "Rowing Machine", EquipmentType = EquipmentType.Equipment, Description= "Provides a full-body workout simulating rowing motions"},
                new Equipment { Name = "stationary Bike", EquipmentType = EquipmentType.Equipment, Description= "Great for low-impact cardiovascular workouts"},
                new Equipment { Name = "Stair Climber", EquipmentType = EquipmentType.Equipment, Description= "Targets lower body muscles while providing cardio benefits"},
                new Equipment { Name = "Power Rack", EquipmentType = EquipmentType.Equipment, Description= "Essential for performing squats and bench presses safely with a spotter"},
                new Equipment { Name = "Battle Ropes", EquipmentType = EquipmentType.Equipment, Description= "Used for high-intensity interval training, engaging multiple muscle groups"},
                new Equipment { Name = "Bands", EquipmentType = EquipmentType.Equipment, Description= ""},
                new Equipment { Name = "Stability Ball", EquipmentType = EquipmentType.Equipment, Description= "Used to enhance core strength and stability during workouts"},
                new Equipment { Name = "Foam Roll", EquipmentType = EquipmentType.Equipment, Description= "For muscle recovery and myofascial release post-workout"},
                new Equipment { Name = "Abdominal Bench", EquipmentType = EquipmentType.Equipment, Description= "Designed specifically for core workouts, targeting abdominal muscles"},
                new Equipment { Name = "Pull-Up Bar", EquipmentType = EquipmentType.Equipment, Description= "Essential for upper body strength training through pull-ups and chin-ups"},
                new Equipment { Name = "Cable", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Medicine Ball", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "E-Z Curl Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Trap Bar (Hex Bar)", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Cambered Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Safety Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Axle Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Swiss Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Buffalo Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Fixed Barbells", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Abdominal", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "stretches", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Bosu-Ball", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "TRX", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Vitruvian", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Yoga", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Cardio", EquipmentType = EquipmentType.Machine, Description= ""},
            };
            await context.Equipments.AddRangeAsync(equipments);
            await context.SaveChangesAsync();

            //await transaction.CommitAsync();
        }    
    }
}