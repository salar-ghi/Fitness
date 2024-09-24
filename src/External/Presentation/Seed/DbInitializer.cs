using System.Runtime.CompilerServices;

namespace Presentation.Seed;

public static class DbInitializer
{
    public static async Task SeedAsync(FitnessContext context)
    {
        if (!context.Bodies.Any())
        {
            var bodies = new List<Body>
            {
                // Chest
                //new Body { BodyPartId = 10, Name = "Torso" },
                new Body { BodyPartId = 10, Name = "Chest" },
                new Body { BodyPartId = 11, Name = "Pectoralis Major", Parent = 10 },
                new Body { BodyPartId = 12, Name = "Pectoralis Minor", Parent = 10 },

                // Back
                new Body { BodyPartId = 20, Name = "Back"},
                new Body { BodyPartId = 21, Name = "Upper Back", Parent = 20 },
                new Body { BodyPartId = 22, Name = "Middle Back", Parent = 20 },
                new Body { BodyPartId = 23, Name = "Lower Back", Parent = 20 },
                new Body { BodyPartId = 24, Name = "Latissimus Dorsi (Lats)", Parent = 20 },
                new Body { BodyPartId = 25, Name = "Trapezius (Traps)", Parent = 20 },
                new Body { BodyPartId = 26, Name = "Rhomboids", Parent = 20 },
                new Body { BodyPartId = 27, Name = "Erector Spinae", Parent = 20 },

                // Shoulders
                new Body { BodyPartId = 30 , Name = "Shoulders" },
                new Body { BodyPartId = 31 , Name = "Anterior Deltoids", Parent = 30 },
                new Body { BodyPartId = 32 , Name = "Lateral Deltoids", Parent = 31 },
                new Body { BodyPartId = 33 , Name = "Posterior Deltoids", Parent = 32 },

                // Arms
                new Body { BodyPartId = 40, Name = "Arms And Hands"},
                new Body { BodyPartId = 41, Name = "Biceps Brachii", Parent = 40 },
                new Body { BodyPartId = 42, Name = "Triceps Brachii", Parent= 40 },
                new Body { BodyPartId = 43, Name = "Brachialis (Lower Biceps)", Parent = 40 },
                new Body { BodyPartId = 44, Name = "Forearm", Parent = 40 },
                new Body { BodyPartId = 45, Name = "Wrists", Parent = 40 },

                // Abdominals
                new Body { BodyPartId = 50, Name = "Abdominals", Parent = 6 },
                new Body { BodyPartId = 50, Name = "Rectus Abdominis", Parent = 6 },
                new Body { BodyPartId = 50, Name = "Internal Obliques", Parent = 6 },
                new Body { BodyPartId = 50, Name = "External Obliques", Parent = 6 },
                new Body { BodyPartId = 50, Name = "Core", Parent = 6 },

                // Legs
                new Body { BodyPartId = 60 , Name = "Legs" },
                new Body { BodyPartId = 61 , Name = "Quadriceps", Parent = 60 },
                new Body { BodyPartId = 62 , Name = "Hamstrings", Parent = 60 },
                new Body { BodyPartId = 63 , Name = "Gluteus Maximus", Parent = 60 },
                new Body { BodyPartId = 64 , Name = "Gluteus Medius", Parent = 60 },
                new Body { BodyPartId = 65 , Name = "Gluteus Minimus", Parent = 60 },
                new Body { BodyPartId = 66 , Name = "Calves", Parent = 60 },
                new Body { BodyPartId = 67 , Name = "Gastrocnemius Calves", Parent = 60 },
                new Body { BodyPartId = 68 , Name = "Soleus Calves", Parent = 60 },
            };
            await context.Bodies.AddRangeAsync(bodies);
            await context.SaveChangesAsync();
        }


        if (!context.Equipment.Any())
        {
            var equipments = new List<Equipment>
            {
                // None
                //new Equipment { Name = "None", EquipmentType = EquipmentType.Body },
                new Equipment { Name = "Body Only", EquipmentType = EquipmentType.Body, Description= "" },

                // Free Weights
                new Equipment { Name = "Dumbells", EquipmentType = EquipmentType.Machine, Description= "Versatile weights for various exercises targeting multiple muscle groups"},
                new Equipment { Name = "Barbells", EquipmentType = EquipmentType.Machine, Description= "Long bars used for heavy lifting, ideal for compound movements"},
                new Equipment { Name = "KettleBells", EquipmentType = EquipmentType.Machine, Description= "Cast iron weights used for dynamic exercises that combine strength and cardio"},

                // Machines
                //new Equipment { Name = "Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Smith Machine", EquipmentType = EquipmentType.Machine, Description= "A barbell fixed within steel rails, providing stability for various lifts"},
                new Equipment { Name = "Leg Press Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the quadriceps, hamstrings, and glutes"},
                new Equipment { Name = "Chest Press Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the chest muscles with guided movements"},
                new Equipment { Name = "Lat Pulldown Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the latissimus dorsi muscles in the back"},
                new Equipment { Name = "Leg Curl Machine", EquipmentType = EquipmentType.Machine, Description= "Isolates the hamstrings for targeted strengthening"},
                new Equipment { Name = "Leg Extension Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the quadriceps"},
                new Equipment { Name = "Cable Machine", EquipmentType = EquipmentType.Machine, Description= "Versatile machines that allow for a wide range of exercises using adjustable cables"},

                // Cardiovascular Equipment
                new Equipment { Name = "Treadmill", EquipmentType = EquipmentType.Equipment, Description= "Ideal for running or walking to improve cardiovascular fitness"},
                new Equipment { Name = "Rowing Machine", EquipmentType = EquipmentType.Equipment, Description= "Provides a full-body workout simulating rowing motions"},
                new Equipment { Name = "stationary Bike", EquipmentType = EquipmentType.Equipment, Description= "Great for low-impact cardiovascular workouts"},
                new Equipment { Name = "Stair Climber", EquipmentType = EquipmentType.Equipment, Description= "Targets lower body muscles while providing cardio benefits"},

                // Specialty Equipment
                new Equipment { Name = "Power Rack", EquipmentType = EquipmentType.Equipment, Description= "Essential for performing squats and bench presses safely with a spotter"},
                new Equipment { Name = "Battle Ropes", EquipmentType = EquipmentType.Equipment, Description= "Used for high-intensity interval training, engaging multiple muscle groups"},
                new Equipment { Name = "Bands", EquipmentType = EquipmentType.Equipment, Description= ""},
                new Equipment { Name = "Resistance Bands", EquipmentType = EquipmentType.Equipment, Description= "Portable bands that provide resistance for various exercises"},
                new Equipment { Name = "Stability Ball", EquipmentType = EquipmentType.Equipment, Description= "Used to enhance core strength and stability during workouts"},

                // Other 
                new Equipment { Name = "Foam Roll", EquipmentType = EquipmentType.Equipment, Description= "For muscle recovery and myofascial release post-workout"},
                new Equipment { Name = "Abdominal Bench", EquipmentType = EquipmentType.Equipment, Description= "Designed specifically for core workouts, targeting abdominal muscles"},
                new Equipment { Name = "Pull-Up Bar", EquipmentType = EquipmentType.Equipment, Description= " Essential for upper body strength training through pull-ups and chin-ups"},
                new Equipment { Name = "Cable", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Medicine Ball", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "E-Z Curl Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Abdominal", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Other", EquipmentType = EquipmentType.Machine, Description= ""},
            };
            await context.Equipment.AddRangeAsync(equipments);
            await context.SaveChangesAsync();
        }


        if (!context.Sports.Any())
        {
            var sports = new List<Sport>
            {
                new Sport {Name = "", Description = ""},
            };
            await context.Sports.AddRangeAsync(sports);
            await context.SaveChangesAsync();
        }

        if (!context.UserRoles.Any())
        {
            var roles = new List<UserRole>
            {
                new UserRole { }
            };
            await context.UserRoles.AddRangeAsync(roles);
            await context.SaveChangesAsync();
        }
    }


    // Chest
    // Forearms
    // Lats
    // Middle Back
    // Lower Back
    // Neck
    // Quadriceps
    // Hamstrings

    // Calves
    // Traps

    // Shoulders
    // Abdominals
    // Glutes
    // Biceps
    // Adductors
    // Abductors

}
