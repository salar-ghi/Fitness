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
                new Body { Name = "Chest" },
                new Body { Name = "Pectoralis Major", ParentId = 10 },
                new Body { Name = "Pectoralis Minor", ParentId = 10 },

                // Back
                new Body { Name = "Back"},
                new Body { Name = "Upper Back", ParentId = 20 },
                new Body { Name = "Middle Back", ParentId = 20 },
                new Body { Name = "Lower Back", ParentId = 20 },
                new Body { Name = "Latissimus Dorsi (Lats)", ParentId = 20 },
                new Body { Name = "Trapezius (Traps)", ParentId = 20 },
                new Body { Name = "Rhomboids", ParentId = 20 },
                new Body { Name = "Erector Spinae", ParentId = 20 },

                // Shoulders
                new Body { Name = "Shoulders" },
                new Body { Name = "Anterior Deltoids", ParentId = 30 },
                new Body { Name = "Lateral Deltoids", ParentId = 31 },
                new Body { Name = "Posterior Deltoids", ParentId = 32 },

                // Arms
                new Body { Name = "Arms And Hands"},
                new Body { Name = "Biceps Brachii", ParentId = 40 },
                new Body { Name = "Triceps Brachii", ParentId = 40 },
                new Body { Name = "Brachialis (Lower Biceps)", ParentId = 40 },
                new Body { Name = "Forearm", ParentId = 40 },
                new Body { Name = "Wrists", ParentId = 40 },

                // Abdominals
                new Body { Name = "Abdominals", ParentId = 6 },
                new Body { Name = "Rectus Abdominis", ParentId = 6 },
                new Body { Name = "Internal Obliques", ParentId = 6 },
                new Body { Name = "External Obliques", ParentId = 6 },
                new Body { Name = "Core", ParentId = 6 },

                // Legs
                new Body { Name = "Legs" },
                new Body { Name = "Quadriceps", ParentId = 60 },
                new Body { Name = "Hamstrings", ParentId = 60 },
                new Body { Name = "Gluteus Maximus", ParentId = 60 },
                new Body { Name = "Gluteus Medius", ParentId = 60 },
                new Body { Name = "Gluteus Minimus", ParentId = 60 },
                new Body { Name = "Calves", ParentId = 60 },
                new Body { Name = "Gastrocnemius Calves", ParentId = 60 },
                new Body { Name = "Soleus Calves", ParentId = 60 },
            };
            await context.Bodies.AddRangeAsync(bodies);
            await context.SaveChangesAsync();
        }


        if (!context.Equipments.Any())
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
                new Equipment { Name = "Pull-Up Bar", EquipmentType = EquipmentType.Equipment, Description= "Essential for upper body strength training through pull-ups and chin-ups"},
                new Equipment { Name = "Cable", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Medicine Ball", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "E-Z Curl Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Abdominal", EquipmentType = EquipmentType.Machine, Description= ""},
                new Equipment { Name = "Other", EquipmentType = EquipmentType.Machine, Description= ""},
            };
            await context.Equipments.AddRangeAsync(equipments);
            await context.SaveChangesAsync();
        }

        if (!context.Sports.Any())
        {
            var sports = new List<Sport>
            {
                new Sport {Name = "BodyBuilding", Description = ""},
                new Sport {Name = "Cardio", Description = ""},
                new Sport {Name = "Yoga", Description = ""},
            };
            await context.Sports.AddRangeAsync(sports);
            await context.SaveChangesAsync();
        }

        //if (!context.Workouts.Any())
        //{
        //    var workouts = new List<Workout>
        //    {
        //        // Level // Equipments // AgeRange // Sex
        //        new Workout { Id = 1, Name = "", SportId = 1, Description = "", Instruction = "",
        //            Sex = new List<WorkoutSex> { new WorkoutSex { WorkoutId = 1, Sex = Sex.Man } },
        //            AgeRanges = new WorkoutAgeRange { WorkoutId = 1, Age = Age.Eighteen_To_TwentyNine },
        //            Equipment = new WorkoutEquipment { WorkoutId = 1, EquipmentId = 1},
        //            Level = new WorkoutLevel { WorkoutId = 1, Level = Level.Beginner }
        //        }
        //    };
        //    await context.Workouts.AddRangeAsync(workouts);
        //    await context.SaveChangesAsync();
        //}

        if (!context.WorkoutAgeRanges.Any())
        {
            var workoutAgeRanges = new List<WorkoutAgeRange>
            {
                new WorkoutAgeRange {},
            };
            await context.WorkoutAgeRanges.AddRangeAsync(workoutAgeRanges);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutLevels.Any())
        {
            var workoutLevels = new List<WorkoutLevel>
            {
                new WorkoutLevel { WorkoutId = 1, Level = Domain.Enums.Level.Beginner },
            };
            await context.WorkoutLevels.AddRangeAsync(workoutLevels);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutEquipment.Any())
        {
            var workoutEquipments = new List<WorkoutEquipment>
            {
                new WorkoutEquipment {WorkoutId = 1, EquipmentId = 1,},
            };
            await context.WorkoutEquipment.AddRangeAsync(workoutEquipments);
            await context.SaveChangesAsync();
        }

        if (!context.UserRoles.Any())
        {
            var roles = new List<IdentityRole<Guid>>
            {
                new IdentityRole<Guid> { Name = "Admin" },
                new IdentityRole<Guid> { Name = "Support" },
                new IdentityRole<Guid> { Name = "Athlete" },
                new IdentityRole<Guid> { Name = "Coach" }
            };
            await context.Roles.AddRangeAsync(roles);
            await context.SaveChangesAsync();
        }
    }
}
