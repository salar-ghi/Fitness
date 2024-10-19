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

        var equipments = new List<Equipment>();
        if (!context.Equipments.Any())
        {
            equipments = new List<Equipment>
            {
                // None

                // Index => 0
                new Equipment { Name = "Body Only", EquipmentType = EquipmentType.Body, Description= "" }, 

                // Free Weights
                // Index => 1
                new Equipment { Name = "Dumbells", EquipmentType = EquipmentType.Machine, Description= "Versatile weights for various exercises targeting multiple muscle groups"},
                // Index => 2
                new Equipment { Name = "Barbells", EquipmentType = EquipmentType.Machine, Description= "Long bars used for heavy lifting, ideal for compound movements"},
                // Index => 3
                new Equipment { Name = "KettleBells", EquipmentType = EquipmentType.Machine, Description= "Cast iron weights used for dynamic exercises that combine strength and cardio"},

                // Machines
                //new Equipment { Name = "Machine", EquipmentType = EquipmentType.Machine},
                // Index => 4
                new Equipment { Name = "Smith Machine", EquipmentType = EquipmentType.Machine, Description= "A barbell fixed within steel rails, providing stability for various lifts"},
                // Index => 5
                new Equipment { Name = "Leg Press Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the quadriceps, hamstrings, and glutes"},
                // Index => 6
                new Equipment { Name = "Chest Press Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the chest muscles with guided movements"},
                // Index => 7
                new Equipment { Name = "Lat Pulldown Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the latissimus dorsi muscles in the back"},
                // Index => 8
                new Equipment { Name = "Leg Curl Machine", EquipmentType = EquipmentType.Machine, Description= "Isolates the hamstrings for targeted strengthening"},
                // Index => 9
                new Equipment { Name = "Leg Extension Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the quadriceps"},
                // Index => 10
                new Equipment { Name = "Cable Machine", EquipmentType = EquipmentType.Machine, Description= "Versatile machines that allow for a wide range of exercises using adjustable cables"},

                // Index => 11
                new Equipment { Name = "Bench Press", EquipmentType = EquipmentType.Machine, Description = " Performed lying on a bench, allowing for a full range of motion as the barbell can descend below the chest level"},                
                // Index => 12
                new Equipment { Name = "Floor Press", EquipmentType = EquipmentType.Machine, Description = "Executed lying on the floor, which limits the range of motion since the elbows stop descending when they touch the ground"},

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
                #region Dumbells	
                // Chest
                //Index => 0
                new Workout { Id = 1, Name = "Dumbbell Bench Press", Description = "Targets the chest; can be done flat, incline, or decline.", SportId = sports[0].Id },
                //Index => 1
                new Workout { Id = 2, Name = "Dumbbell Fly", Description = "Focuses on the upper and lateral pec muscles", SportId = sports[0].Id },
                //Index => 2
                new Workout { Id = 3, Name = "Dumbbell Floor Press", Description ="Similar to bench press but performed on the floor.", SportId= sports[0].Id },


                // Back
                //Index 3
                new Workout { Id = 4, Name = "Dumbbell Bent-Over Rows", Description ="Engages the entire back.", SportId= sports[0].Id },
                //Index 4
                new Workout { Id = 5, Name = "Dumbbell Pullover", Description ="Works the lats and upper chest.", SportId= sports[0].Id },
                //Index 5                
                new Workout { Id = 6, Name = "Renegade Row", Description ="Combines a plank with a row for core and back strength.", SportId= sports[0].Id },

                // Shoulders
                //Index 6
                new Workout { Id = 7, Name = "Standing Dumbbell Press", Description ="Builds shoulder strength while engaging the core.", SportId= sports[0].Id },
                //Index 7
                new Workout { Id = 8, Name = "Dumbbell Lateral Raise", Description ="Isolates the lateral deltoids.", SportId= sports[0].Id },
                //Index 8
                new Workout { Id = 9, Name = "Dumbbell Arnold Press", Description ="Targets multiple shoulder muscles through rotation.", SportId= sports[0].Id },

                // Arms
                //Index 9
                new Workout { Id = 10, Name = "Dumbbell Bicep Curls", Description ="Essential for bicep development.", SportId= sports[0].Id },
                //Index 10
                new Workout { Id = 11, Name = "Hammer Curls", Description ="Targets the brachialis and brachioradialis.", SportId= sports[0].Id },
                //Index 11
                new Workout { Id = 12, Name = "Dumbbell Tricep Kickbacks", Description ="Isolates the triceps effectively.", SportId= sports[0].Id },

                // Lower Body
                //Index 12
                new Workout { Id = 13, Name = "Dumbbell Squats (Goblet Squats)", Description ="Fundamental for leg strength.", SportId= sports[0].Id },
                //Index 13
                new Workout { Id = 14, Name = "Dumbbell Lunges (Walking Lunges)", Description ="Focuses on single-leg strength and stability.", SportId= sports[0].Id },
                //Index 14
                new Workout { Id = 15, Name = "Dumbbell Deadlifts (Stiff-Legged Deadlifts)", Description ="Engages the posterior chain, especially hamstrings and glutes.", SportId= sports[0].Id },
                //Index 15
                new Workout { Id = 16, Name = "Dumbbell Step-Ups", Description ="Improves leg strength and balance.", SportId= sports[0].Id },

                // Core Workouts
                //Index 16
                new Workout { Id = 17, Name = "Weighted Crunches", Description ="Targets the rectus abdominis.", SportId= sports[0].Id },
                //Index 17
                new Workout { Id = 18, Name = "Russian Twists", Description ="Engages obliques for rotational strength.", SportId= sports[0].Id },
                //Index 18
                new Workout { Id = 19, Name = "Plank with Dumbbells", Description ="Enhances core stability while incorporating shoulder work.", SportId= sports[0].Id },

                // Full Body Workouts
                //Index 19
                new Workout { Id = 20, Name = "Devil's Press", Description ="Combines a burpee with dumbbells for a full-body workout.", SportId= sports[0].Id },
                //Index 20
                new Workout { Id = 21, Name = "Farmer’s Carry", Description ="Enhances grip strength and overall conditioning while working multiple muscle groups.", SportId= sports[0].Id },
                //Index 21
                new Workout { Id = 22, Name = "Dumbbell High Pulls", Description ="Targets shoulders, traps, and upper back.", SportId= sports[0].Id },
                #endregion
                
                
                #region Barbells
                // Chest
                //Index => 22
                new Workout { Id = 23, Name = "Barbell Bench Press", Description ="A fundamental exercise for overall chest development.", SportId= sports[0].Id },
                //Index => 23
                new Workout { Id = 24, Name = "Incline Barbell Press", Description ="Targets the upper chest, performed on an inclined bench.", SportId= sports[0].Id },
                //Index => 24
                new Workout { Id = 25, Name = "Decline Barbell Press", Description ="Focuses on the lower chest, done on a declined bench.", SportId= sports[0].Id },
                //Index => 25
                new Workout { Id = 26, Name = "Barbell Pullover", Description ="Engages the chest and lats, performed lying on a bench.", SportId= sports[0].Id },


                // Back
                //Index => 26
                new Workout { Id = 27, Name = "Barbell Bent-Over Row", Description ="A classic exercise for building thickness in the back.", SportId= sports[0].Id },
                new Workout { Id = 27, Name = "Pendlay Row", Description ="An explosive variation of the bent-over row focusing on strength.", SportId= sports[0].Id },
                new Workout { Id = 27, Name = "T-Bar Row", Description ="Targets the middle back and lats; requires a T-bar setup.", SportId= sports[0].Id },
                new Workout { Id = 27, Name = "Barbell Deadlift", Description ="A compound movement that works the entire posterior chain.", SportId= sports[0].Id },
                new Workout { Id = 27, Name = "Barbell Shrug", Description ="Isolates the upper trapezius muscles.", SportId= sports[0].Id },

                // Shoulders
                //Index => 26
                new Workout { Id = 27, Name = "Barbell Overhead Press", Description ="A primary shoulder exercise that also engages the core.", SportId= sports[0].Id },
                new Workout { Id = 27, Name = "Barbell Upright Row", Description ="Targets the shoulders and traps by lifting the bar to chin height.", SportId= sports[0].Id },
                new Workout { Id = 27, Name = "Barbell Front Raise", Description ="Isolates the front deltoids by lifting the bar in front of you.", SportId= sports[0].Id },

                // Arms
                //Index => 26
                new Workout { Id = 3, Name = "Barbell Bicep Cur", Description ="A staple for building bicep mass.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Close-Grip Barbell Bench Press", Description ="Primarily targets the triceps while also engaging the chest.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Skull Crushers", Description ="Focuses on triceps development using a barbell.", SportId= sports[0].Id },
                
                // Core Workouts
                //Index => 26
                new Workout { Id = 3, Name = "Barbell Squat", Description ="A fundamental exercise for overall leg development.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Barbell Deadlift (Conventional)", Description ="Engages hamstrings, glutes, and lower back.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Barbell Lunges", Description ="Targets quads and glutes; can be performed forward or backward.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Barbell Romanian Deadlift", Description ="Focuses on hamstrings and glutes with a hip hinge movement.", SportId= sports[0].Id },

                // Lower Body Workouts
                //Index => 26
                new Workout { Id = 3, Name = "Barbell Rollout", Description ="Engages core muscles through an extended rollout motion.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Landmine Anti-Rotation Press", Description ="Strengthens core stability while pressing a barbell anchored at one end.", SportId= sports[0].Id },


                // Full Body Workouts
                //Index => 26
                new Workout { Id = 3, Name = "Barbell Clean and Press", Description ="A dynamic movement that works multiple muscle groups including legs, back, shoulders, and arms.", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "Barbell Thruster", Description =" Thruster: Combines a front squat with an overhead press for a full-body workout.", SportId= sports[0].Id },

                #endregion


                #region Other

	
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                new Workout { Id = 3, Name = "", Description =".", SportId= sports[0].Id },
                #endregion


            };
            await context.Workouts.AddRangeAsync(workouts);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutEquipment.Any())
        {
            var workoutEquipments = new List<WorkoutEquipment>
            {
                #region Dumbells
                // Chest // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = workouts[11].Id },
                new WorkoutEquipment { WorkoutId = workouts[1].Id, EquipmentId = workouts[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[2].Id, EquipmentId = workouts[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[2].Id, EquipmentId = workouts[12].Id },

                // Back // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[3].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[4].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[5].Id, EquipmentId = equipments[1].Id },

                // Shoulders // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[6].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[7].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[8].Id, EquipmentId = equipments[1].Id },

                // Arms // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[9].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[10].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[11].Id, EquipmentId = equipments[1].Id },

                // Lower Body // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[12].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[13].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[14].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[15].Id, EquipmentId = equipments[1].Id },

                // Core Workouts // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[16].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[17].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[18].Id, EquipmentId = equipments[1].Id },
                
                // Full Body Workouts // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[19].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[20].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[21].Id, EquipmentId = equipments[1].Id },
                #endregion


            };
            await context.WorkoutEquipment.AddRangeAsync(workoutEquipments);
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
