namespace Presentation.Seed;

public static class DbInitializer
{
    public static async Task SeedAsync(FitnessContext context)
    {
        var bodies = new List<Body>();
        if (!context.Bodies.Any())
        {
            bodies = new List<Body>
            {
                // Chest
                //new Body { BodyPartId = 10, Name = "Torso" },
                new Body { Id = 1, Name = "Chest" },
                new Body { Id = 2, Name = "Pectoralis Major", ParentId = 1 },
                new Body { Id = 3, Name = "Pectoralis Minor", ParentId = 1 },

                // Back
                new Body { Id = 11, Name = "Back"},
                new Body { Id = 12, Name = "Upper Back", ParentId = 11 },
                new Body { Id = 13, Name = "Middle Back", ParentId = 11 },
                new Body { Id = 14, Name = "Lower Back", ParentId = 11 },
                new Body { Id = 15, Name = "Latissimus Dorsi (Lats)", ParentId = 11 },
                new Body { Id = 16, Name = "Trapezius (Traps)", ParentId = 11 },
                new Body { Id = 17, Name = "Rhomboids", ParentId = 11 },
                new Body { Id = 18, Name = "Erector Spinae", ParentId = 11 },

                // Shoulders
                new Body { Id = 21, Name = "Shoulders" },
                new Body { Id = 22, Name = "Anterior Deltoids", ParentId = 21 },
                new Body { Id = 23, Name = "Lateral Deltoids", ParentId = 21 },
                new Body { Id = 24, Name = "Posterior Deltoids", ParentId = 21 },

                // Arms
                new Body { Id = 31, Name = "Arms And Hands"},
                new Body { Id = 32, Name = "Biceps Brachii", ParentId = 31 },
                new Body { Id = 33, Name = "Triceps Brachii", ParentId = 31 },
                new Body { Id = 34, Name = "Brachialis (Lower Biceps)", ParentId = 31 },
                new Body { Id = 35, Name = "Forearm", ParentId = 31 },
                new Body { Id = 36, Name = "Wrists", ParentId = 31 },

                // Abdominals
                new Body { Id = 41, Name = "Abdominals" },
                new Body { Id = 42, Name = "Rectus Abdominis", ParentId = 41 },
                new Body { Id = 43, Name = "Internal Obliques", ParentId = 41 },
                new Body { Id = 44, Name = "External Obliques", ParentId = 41 },
                new Body { Id = 45, Name = "Core", ParentId = 41 },

                // Legs
                new Body { Id = 51, Name = "Legs" },
                new Body { Id = 52, Name = "Quadriceps", ParentId = 51 },
                new Body { Id = 53, Name = "Hamstrings", ParentId = 51 },
                new Body { Id = 54, Name = "Gluteus Maximus", ParentId = 51 },
                new Body { Id = 55, Name = "Gluteus Medius", ParentId = 51 },
                new Body { Id = 56, Name = "Gluteus Minimus", ParentId = 51 },
                new Body { Id = 57, Name = "Calves", ParentId = 51 },
                new Body { Id = 58, Name = "Gastrocnemius Calves", ParentId = 51 },
                new Body { Id = 59, Name = "Soleus Calves", ParentId = 51 },
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

        var sports = new List<Sport>();
        if (!context.Sports.Any())
        {
            sports = new List<Sport>
            {
                new Sport { Id = 1, Name = "BodyBuilding", Description = ""},
                new Sport { Id = 1, Name = "Cardio", Description = ""},
                new Sport { Id = 1, Name = "Yoga", Description = ""},
            };
            await context.Sports.AddRangeAsync(sports);
            await context.SaveChangesAsync();
        }


        // Workout Models
        #region Workout Models

        var workouts = new List<Workout>();
        if (!context.Workouts.Any())
        {
            // Instruction // Body // AgeRange // Equipments // Level // Sex
            workouts = new List<Workout>
            {
                new Workout { Id = 1, Name = "", Description = "", SportId = sports[0].Id },
                new Workout { Id = 1, Name = "", Description = "", SportId = sports[0].Id }

                    //Sex = new List<WorkoutSex> { new WorkoutSex { WorkoutId = 1, Sex = Sex.Man } },
                    //AgeRanges = new WorkoutAgeRange { WorkoutId = 1, Age = Age.Eighteen_To_TwentyNine },
                    //Equipment = new WorkoutEquipment { WorkoutId = 1, EquipmentId = 1},
                    //Level = new WorkoutLevel { WorkoutId = 1, Level = Level.Beginner 
            };
            await context.Workouts.AddRangeAsync(workouts);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutInstructions.Any())
        {
            var instructions = new List<WorkoutInstruction>
            {
                new WorkoutInstruction { WorkoutId = workouts[0].Id, Description = "", ImgUrl = "", VideoUrl = ""},
                new WorkoutInstruction { WorkoutId = workouts[0].Id, Description = "", ImgUrl = "", VideoUrl = ""}
            };
            await context.WorkoutInstructions.AddRangeAsync(instructions);
            await context.SaveChangesAsync();
        }

        if (!context.BodyWorkouts.Any())
        {
            var bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout { WorkoutId = workouts[0].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[0].Id, BodyId = bodies[0].Id }
            };
            await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutAgeRanges.Any())
        {
            var workoutAgeRanges = new List<WorkoutAgeRange>
            {
                new WorkoutAgeRange {WorkoutId = workouts[0].Id, Age = Age.Eighteen_To_TwentyNine },
                new WorkoutAgeRange {WorkoutId = workouts[0].Id, Age = Age.Thirty_To_Thirty_Nine },
            };
            await context.WorkoutAgeRanges.AddRangeAsync(workoutAgeRanges);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutEquipment.Any())
        {
            var workoutEquipments = new List<WorkoutEquipment>
            {
                new WorkoutEquipment {WorkoutId = 1, EquipmentId = 1},
                new WorkoutEquipment {WorkoutId = 1, EquipmentId = 1},
            };
            await context.WorkoutEquipment.AddRangeAsync(workoutEquipments);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutLevels.Any())
        {
            var workoutLevels = new List<WorkoutLevel>
            {
                new WorkoutLevel { WorkoutId = 1, Level = Domain.Enums.Level.Beginner, Description="" },
            };
            await context.WorkoutLevels.AddRangeAsync(workoutLevels);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutSex.Any())
        {
            var genders = new List<WorkoutSex>
            {
                new WorkoutSex { WorkoutId = workouts[0].Id, Sex = Sex.Man},
                new WorkoutSex { WorkoutId = workouts[0].Id, Sex = Sex.Man}
            };
            await context.WorkoutSex.AddRangeAsync(genders);
            await context.SaveChangesAsync();
        }

        #endregion
        // Done Workout Models

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
