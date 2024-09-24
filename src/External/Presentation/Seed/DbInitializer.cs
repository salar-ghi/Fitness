using Domain.Enums;
using Domain.Models;
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
                new Equipment { Name = "Body Only", EquipmentType = EquipmentType.Body},

                // Free Weights
                new Equipment { Name = "Dumbells", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Barbells", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "KettleBells", EquipmentType = EquipmentType.Machine},

                // Machines
                //new Equipment { Name = "Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Smith Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Leg Press Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Chest Press Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Lat Pulldown Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Leg Curl Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Leg Extension Machine", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Cable Machine", EquipmentType = EquipmentType.Machine},

                // Cardiovascular Equipment
                new Equipment { Name = "Treadmill", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Rowing Machine", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "stationary Bike", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Stair Climber", EquipmentType = EquipmentType.Equipment},

                // Specialty Equipment
                new Equipment { Name = "Power Rack", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Battle Ropes", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Resistance Bands", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Stability Ball", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Bands", EquipmentType = EquipmentType.Equipment},

                // Other 
                new Equipment { Name = "Foam Roll", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Abdominal Bench", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Pull-Up Bar", EquipmentType = EquipmentType.Equipment},
                new Equipment { Name = "Cable", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Medicine Ball", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "E-Z Curl Bar", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Abdominal", EquipmentType = EquipmentType.Machine},
                new Equipment { Name = "Other", EquipmentType = EquipmentType.Machine},
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
