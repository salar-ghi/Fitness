namespace Presentation.Seed;

// Workout Strategies
// 1- Supersets: Pair floor presses with other exercises like push-ups or overhead presses for increased intensity and muscle fatigue.
// 2- Drop Sets: After reaching failure with a heavier weight, immediately reduce the weight and continue until failure again.
// 3- Pyramid Sets: Gradually increase weight with each set until reaching a peak, then decrease back down for added volume.
// 4- Cluster Sets: Perform multiple mini-sets with short rest periods in between to maximize muscle engagement and strength gains.
// 5- Countdown Sets: Perform a set number of reps followed by isometric holds (e.g., 5 reps followed by a 5-second hold) to increase endurance and strength.


//Workout Formats
// 1-Circuit Training
//Combine multiple exercises into a circuit for a full-body workout(e.g., push-ups, rows, squats).
// 2-Supersets
//Pair two exercises(e.g., bicep curls followed by tricep extensions) with minimal rest for increased intensity.
// 3-Pyramid Sets
//Gradually increase resistance or repetitions over several sets before decreasing again.
// 4-Interval Training
//Alternate between high-intensity exercises (e.g., 30 seconds of push-ups) followed by rest periods(e.g., 15 seconds).
// 5-Tabata Training
//Perform 20 seconds of work followed by 10 seconds of rest for 8 rounds on various exercises.

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
                // Index => 0
                new Body { Id = 1, Name = "Chest" },
                // Index => 1
                new Body { Id = 2, Name = "Pectoralis Major", ParentId = 1 },
                // Index => 2
                new Body { Id = 3, Name = "Pectoralis Minor", ParentId = 1 },

                // Back
                // Index => 3
                new Body { Id = 11, Name = "Back"},
                // Index => 4
                new Body { Id = 12, Name = "Upper Back", ParentId = 11 },
                // Index => 5
                new Body { Id = 13, Name = "Middle Back", ParentId = 11 },
                // Index => 6
                new Body { Id = 14, Name = "Lower Back", ParentId = 11 },
                // Index => 7
                new Body { Id = 15, Name = "Latissimus Dorsi (Lats)", ParentId = 11 },
                // Index => 8
                new Body { Id = 16, Name = "Trapezius (Traps)", ParentId = 11 },
                // Index => 9
                new Body { Id = 17, Name = "Rhomboids", ParentId = 11 },
                // Index => 10
                new Body { Id = 18, Name = "Erector Spinae", ParentId = 11 },

                // Shoulders
                // Index => 11
                new Body { Id = 21, Name = "Shoulders" },
                // Index => 12
                new Body { Id = 22, Name = "Anterior Deltoids", ParentId = 21 },
                // Index => 13
                new Body { Id = 23, Name = "Lateral Deltoids", ParentId = 21 },
                // Index => 14
                new Body { Id = 24, Name = "Posterior Deltoids", ParentId = 21 },

                // Arms
                // Index => 15
                new Body { Id = 31, Name = "Arms And Hands"},
                // Index => 16
                new Body { Id = 32, Name = "Biceps Brachii", ParentId = 31 },
                // Index => 17
                new Body { Id = 33, Name = "Triceps Brachii", ParentId = 31 },
                // Index => 18
                new Body { Id = 34, Name = "Brachialis (Lower Biceps)", ParentId = 31 },
                // Index => 19
                new Body { Id = 35, Name = "Forearm", ParentId = 31 },
                // Index => 20
                new Body { Id = 36, Name = "Wrists", ParentId = 31 },

                // Abdominals
                // Index => 21
                new Body { Id = 41, Name = "Abdominals" },
                // Index => 22
                new Body { Id = 42, Name = "Rectus Abdominis", ParentId = 41 },
                // Index => 23
                new Body { Id = 43, Name = "Internal Obliques", ParentId = 41 },
                // Index => 24
                new Body { Id = 44, Name = "External Obliques", ParentId = 41 },
                // Index => 25
                new Body { Id = 45, Name = "Core", ParentId = 41 },

                // Legs
                // Index => 26
                new Body { Id = 51, Name = "Legs" },
                // Index => 27
                new Body { Id = 52, Name = "Quadriceps", ParentId = 51 },
                // Index => 28
                new Body { Id = 53, Name = "Hamstrings", ParentId = 51 },
                // Index => 29
                new Body { Id = 54, Name = "Gluteus Maximus", ParentId = 51 },
                // Index => 30
                new Body { Id = 55, Name = "Gluteus Medius", ParentId = 51 },
                // Index => 31
                new Body { Id = 56, Name = "Gluteus Minimus", ParentId = 51 },
                // Index => 32
                new Body { Id = 57, Name = "Calves", ParentId = 51 },
                // Index => 33
                new Body { Id = 58, Name = "Gastrocnemius Calves", ParentId = 51 },
                // Index => 34
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
                new Equipment { Id = 1, Name = "Body Only", EquipmentType = EquipmentType.Body, Description= "" }, 

                // Free Weights
                // Index => 1
                new Equipment { Id = 2, Name = "Dumbells", EquipmentType = EquipmentType.Machine, Description= "Versatile weights for various exercises targeting multiple muscle groups"},
                // Index => 2
                new Equipment { Id = 3, Name = "Barbells", EquipmentType = EquipmentType.Machine, Description= "Long bars used for heavy lifting, ideal for compound movements"},
                // Index => 3
                new Equipment { Id = 4, Name = "KettleBells", EquipmentType = EquipmentType.Machine, Description= "Cast iron weights used for dynamic exercises that combine strength and cardio"},

                // Machines
                //new Equipment { Name = "Machine", EquipmentType = EquipmentType.Machine},
                // Index => 4
                new Equipment { Id = 5, Name = "Smith Machine", EquipmentType = EquipmentType.Machine, Description= "A barbell fixed within steel rails, providing stability for various lifts"},
                // Index => 5
                new Equipment { Id = 6, Name = "Leg Press Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the quadriceps, hamstrings, and glutes"},
                // Index => 6
                new Equipment { Id = 7, Name = "Chest Press Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the chest muscles with guided movements"},
                // Index => 7
                new Equipment { Id = 8, Name = "Lat Pulldown Machine", EquipmentType = EquipmentType.Machine, Description= "Targets the latissimus dorsi muscles in the back"},
                // Index => 8
                new Equipment { Id = 9, Name = "Leg Curl Machine", EquipmentType = EquipmentType.Machine, Description= "Isolates the hamstrings for targeted strengthening"},
                // Index => 9
                new Equipment { Id = 10, Name = "Leg Extension Machine", EquipmentType = EquipmentType.Machine, Description= "Focuses on the quadriceps"},
                // Index => 10
                new Equipment { Id = 11, Name = "Cable Machine", EquipmentType = EquipmentType.Machine, Description= "Versatile machines that allow for a wide range of exercises using adjustable cables"},

                // Index => 11
                new Equipment { Id = 12, Name = "Bench Press", EquipmentType = EquipmentType.Machine, Description = " Performed lying on a bench, allowing for a full range of motion as the barbell can descend below the chest level"},                
                // Index => 12
                new Equipment { Id = 13, Name = "Floor Press", EquipmentType = EquipmentType.Machine, Description = "Executed lying on the floor, which limits the range of motion since the elbows stop descending when they touch the ground"},

                // Cardiovascular Equipment
                // Index => 13
                new Equipment { Id = 14, Name = "Treadmill", EquipmentType = EquipmentType.Equipment, Description= "Ideal for running or walking to improve cardiovascular fitness"},
                // Index => 14
                new Equipment { Id = 15, Name = "Rowing Machine", EquipmentType = EquipmentType.Equipment, Description= "Provides a full-body workout simulating rowing motions"},
                // Index => 15
                new Equipment { Id = 16, Name = "stationary Bike", EquipmentType = EquipmentType.Equipment, Description= "Great for low-impact cardiovascular workouts"},
                // Index => 16
                new Equipment { Id = 17, Name = "Stair Climber", EquipmentType = EquipmentType.Equipment, Description= "Targets lower body muscles while providing cardio benefits"},

                // Specialty Equipment
                // Index => 17
                new Equipment { Id = 18, Name = "Power Rack", EquipmentType = EquipmentType.Equipment, Description= "Essential for performing squats and bench presses safely with a spotter"},
                // Index => 18
                new Equipment { Id = 19, Name = "Battle Ropes", EquipmentType = EquipmentType.Equipment, Description= "Used for high-intensity interval training, engaging multiple muscle groups"},
                // Index => 19
                new Equipment { Id = 20, Name = "Bands", EquipmentType = EquipmentType.Equipment, Description= ""},
                // new Equipment { Name = "Resistance Bands", EquipmentType = EquipmentType.Equipment, Description= "Portable bands that provide resistance for various exercises"},
                // Index => 20
                new Equipment { Id = 21, Name = "Stability Ball", EquipmentType = EquipmentType.Equipment, Description= "Used to enhance core strength and stability during workouts"},

                // Other 
                // Index => 21
                new Equipment { Id = 22, Name = "Foam Roll", EquipmentType = EquipmentType.Equipment, Description= "For muscle recovery and myofascial release post-workout"},
                // Index => 22
                new Equipment { Id = 23, Name = "Abdominal Bench", EquipmentType = EquipmentType.Equipment, Description= "Designed specifically for core workouts, targeting abdominal muscles"},
                // Index => 23
                new Equipment { Id = 24, Name = "Pull-Up Bar", EquipmentType = EquipmentType.Equipment, Description= "Essential for upper body strength training through pull-ups and chin-ups"},
                // Index => 24
                new Equipment { Id = 25, Name = "Cable", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 25
                new Equipment { Id = 26, Name = "Medicine Ball", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 26
                new Equipment { Id = 27, Name = "E-Z Curl Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 27
                new Equipment { Id = 28, Name = "Trap Bar (Hex Bar)", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 28
                new Equipment { Id = 29, Name = "Cambered Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 29
                new Equipment { Id = 30, Name = "Safety Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 30
                new Equipment { Id = 31, Name = "Axle Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 31
                new Equipment { Id = 32, Name = "Swiss Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 32
                new Equipment { Id = 33, Name = "Buffalo Bar", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 33
                new Equipment { Id = 34, Name = "Fixed Barbells", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 34
                new Equipment { Id = 35, Name = "Abdominal", EquipmentType = EquipmentType.Machine, Description= ""},
                // Index => 35
                new Equipment { Id = 36, Name = "Other", EquipmentType = EquipmentType.Machine, Description= ""},
            };
            await context.Equipments.AddRangeAsync(equipments);
            await context.SaveChangesAsync();
        }

        var sports = new List<Sport>();
        if (!context.Sports.Any())
        {
            sports = new List<Sport>
            {
                // Index => 0
                new Sport { Id = 1, Name = "BodyBuilding", Description = ""},
                new Sport { Id = 2, Name = "Cardio", Description = ""},
                new Sport { Id = 3, Name = "Yoga", Description = ""},
            };
            await context.Sports.AddRangeAsync(sports);
            await context.SaveChangesAsync();
        }


        // Workout Models
        #region Workout Models

        var workouts = new List<Workout>();
        if (!context.Workouts.Any())
        {
            // Workouts according to Eqiupments ...
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
                //Index => 27
                new Workout { Id = 28, Name = "Pendlay Row", Description ="An explosive variation of the bent-over row focusing on strength.", SportId= sports[0].Id },
                //Index => 28
                new Workout { Id = 29, Name = "T-Bar Row", Description ="Targets the middle back and lats; requires a T-bar setup.", SportId= sports[0].Id },
                //Index => 29
                new Workout { Id = 30, Name = "Barbell Deadlift", Description ="A compound movement that works the entire posterior chain.", SportId= sports[0].Id },
                //Index => 30
                new Workout { Id = 31, Name = "Barbell Shrug", Description ="Isolates the upper trapezius muscles.", SportId= sports[0].Id },

                // Shoulders
                //Index => 31
                new Workout { Id = 32, Name = "Barbell Overhead Press", Description ="A primary shoulder exercise that also engages the core.", SportId= sports[0].Id },
                //Index => 32
                new Workout { Id = 33, Name = "Barbell Upright Row", Description ="Targets the shoulders and traps by lifting the bar to chin height.", SportId= sports[0].Id },
                //Index => 33
                new Workout { Id = 34, Name = "Barbell Front Raise", Description ="Isolates the front deltoids by lifting the bar in front of you.", SportId= sports[0].Id },

                // Arms
                //Index => 34
                new Workout { Id = 35, Name = "Barbell Bicep Curl", Description ="A staple for building bicep mass.", SportId= sports[0].Id },
                //Index => 35
                new Workout { Id = 36, Name = "Close-Grip Barbell Bench Press", Description ="Primarily targets the triceps while also engaging the chest.", SportId= sports[0].Id },
                //Index => 36
                new Workout { Id = 37, Name = "Skull Crushers", Description ="Focuses on triceps development using a barbell.", SportId= sports[0].Id },
                
                // Core Workouts
                //Index => 37
                new Workout { Id = 38, Name = "Barbell Squat", Description ="A fundamental exercise for overall leg development.", SportId= sports[0].Id },
                //Index => 38
                new Workout { Id = 39, Name = "Barbell Deadlift (Conventional)", Description ="Engages hamstrings, glutes, and lower back.", SportId= sports[0].Id },
                //Index => 39
                new Workout { Id = 40, Name = "Barbell Lunges", Description ="Targets quads and glutes; can be performed forward or backward.", SportId= sports[0].Id },
                //Index => 40
                new Workout { Id = 41, Name = "Barbell Romanian Deadlift", Description ="Focuses on hamstrings and glutes with a hip hinge movement.", SportId= sports[0].Id },

                // Lower Body Workouts
                //Index => 41
                new Workout { Id = 42, Name = "Barbell Rollout", Description ="Engages core muscles through an extended rollout motion.", SportId= sports[0].Id },
                //Index => 42
                new Workout { Id = 43, Name = "Landmine Anti-Rotation Press", Description ="Strengthens core stability while pressing a barbell anchored at one end.", SportId= sports[0].Id },


                // Full Body Workouts
                //Index => 43
                new Workout { Id = 44, Name = "Barbell Clean and Press", Description ="A dynamic movement that works multiple muscle groups including legs, back, shoulders, and arms.", SportId= sports[0].Id },
                //Index => 44
                new Workout { Id = 45, Name = "Barbell Thruster", Description =" Thruster: Combines a front squat with an overhead press for a full-body workout.", SportId= sports[0].Id },

                #endregion

                #region KettleBells
                // Lower Body Exercises
                //Index => 45
                new Workout { Id = 46, Name = "Kettlebell Goblet Squat", Description ="A fundamental squat variation that enhances leg strength and mobility", SportId= sports[0].Id },
                //Index => 46
                new Workout { Id = 47, Name = "Kettlebell Swing", Description ="A ballistic movement targeting the glutes and hamstrings", SportId= sports[0].Id },
                //Index => 47
                new Workout { Id = 48, Name = "Kettlebell Deadlift", Description ="Effective for developing posterior chain strength", SportId= sports[0].Id },
                //Index => 48
                new Workout { Id = 49, Name = "Kettlebell Single-Leg Deadlift", Description ="Improves balance and engages the core", SportId= sports[0].Id },
                //Index => 49
                new Workout { Id = 50, Name = "Kettlebell Racked Lunge", Description ="", SportId= sports[0].Id },
                //Index => 50
                new Workout { Id = 51, Name = "Kettlebell Reverse Lunge", Description ="", SportId= sports[0].Id },
                //Index => 51
                new Workout { Id = 52, Name = "Kettlebell Side Lunge", Description ="", SportId= sports[0].Id },
                //Index => 52
                new Workout { Id = 53, Name = "Kettlebell Walking Lunge", Description ="", SportId= sports[0].Id },
                //Index => 53
                new Workout { Id = 54, Name = "Kettlebell Overhead Squat", Description ="Enhances shoulder stability and lower body strength.", SportId= sports[0].Id },

                // Upper Body Exercises
                // Index => 54
                new Workout { Id = 55, Name = "Kettlebell Overhead Press", Description ="Builds shoulder strength and stability.", SportId= sports[0].Id },
                // Index => 55
                new Workout { Id = 56, Name = "Kettlebell Snatch", Description ="A full-body power exercise that requires technique and explosiveness.", SportId= sports[0].Id },
                // Index => 56
                new Workout { Id = 57, Name = "Kettlebell Renegade Row", Description ="Engages the core while working the back and arms.", SportId= sports[0].Id },
                // Index => 57
                new Workout { Id = 58, Name = "Kettlebell Push Press", Description ="Combines a squat with an overhead press for total-body engagement.", SportId= sports[0].Id },
                // Index => 58
                new Workout { Id = 59, Name = "Kettlebell High Pulls", Description ="Focuses on the upper back and shoulders.", SportId= sports[0].Id },
                
                // Core Exercises
                // Index => 59
                new Workout { Id = 60, Name = "Turkish Get-Up", Description ="A complex movement that builds core strength and stability.", SportId= sports[0].Id },
                // Index => 60
                new Workout { Id = 61, Name = "Kettlebell Windmill", Description ="Engages the obliques and improves shoulder mobility.", SportId= sports[0].Id },
                // Index => 61
                new Workout { Id = 62, Name = "Kettlebell Russian Twist", Description ="Targets the obliques while enhancing rotational strength.", SportId= sports[0].Id },


                // Full Body Exercises
                // Index => 62
                new Workout { Id = 63, Name = "Kettlebell Clean and Press", Description ="A compound movement that works multiple muscle groups.", SportId= sports[0].Id },
                // Index => 63                
                new Workout { Id = 64, Name = "Kettlebell Thruster (Squat and Press)", Description ="Combines a squat with an overhead press for a high-intensity workout", SportId= sports[0].Id },
                // Index => 64
                new Workout { Id = 65, Name = "Kettlebell Farmer's Walk", Description ="Improves grip strength while engaging the entire body.", SportId= sports[0].Id },

                // Dynamic Movements
                // Index => 65
                new Workout { Id = 66, Name = "Kettlebell Swing (Single-Handed)", Description ="Adds instability to the traditional swing, enhancing grip and core engagement.", SportId= sports[0].Id },
                // Index => 66
                new Workout { Id = 67, Name = "Kettlebell Gorilla Row", Description ="A unique row variation that targets the back while maintaining a strong core position.", SportId= sports[0].Id },
                
                // Specialty Movements
                // Index => 67
                new Workout { Id = 68, Name = "Kettlebell Halo", Description ="Improves shoulder mobility while engaging the core.", SportId= sports[0].Id },
                // Index => 68
                new Workout { Id = 69, Name = "Kettlebell Bottoms Up Press", Description ="Challenges stability and grip strength by holding the kettlebell upside down.", SportId= sports[0].Id },
                #endregion

                #region Smith Machine
                // Chest
                // Index => 69
                new Workout { Id = 70, Name = "Smith Machine Bench Press", Description ="Targets the chest, triceps, and shoulders.", SportId= sports[0].Id },
                // Index => 70
                new Workout { Id = 71, Name = "Smith Machine Incline Bench Press", Description ="Focuses on the upper chest and shoulders.", SportId= sports[0].Id },
                // Index => 71
                new Workout { Id = 72, Name = "Smith Machine Decline Bench Press", Description ="Emphasizes the lower chest.", SportId= sports[0].Id },
                // Index => 72
                new Workout { Id = 73, Name = "Smith Machine Close-Grip Bench Press", Description ="Targets the triceps while engaging the", SportId= sports[0].Id },

                // Back
                // Index => 73
                new Workout { Id = 74, Name = "Smith Machine Bent Over Row", Description ="Works the upper back and lats.", SportId= sports[0].Id },
                // Index => 74
                new Workout { Id = 75, Name = "Smith Machine Inverted Row", Description ="Engages the back and biceps with a bodyweight variation.", SportId= sports[0].Id },
                // Index => 75
                new Workout { Id = 76, Name = "Smith Machine Reverse Grip Bent Over Row", Description ="Targets the upper back with a different grip for varied muscle activation.", SportId= sports[0].Id },

                // Shoulders
                // Index => 76
                new Workout { Id = 77, Name = "Smith Machine Seated Shoulder Press", Description ="Isolates the shoulders and triceps.", SportId= sports[0].Id },
                // Index => 77                
                new Workout { Id = 78, Name = "Smith Machine Upright Row", Description ="Engages the shoulders and traps.", SportId= sports[0].Id },
                // Index => 78                
                new Workout { Id = 79, Name = "Smith Machine Behind-the-Neck Press", Description ="Targets the shoulders but should be done with caution.", SportId= sports[0].Id },

                // Legs
                // Index => 79
                new Workout { Id = 80, Name = "Smith Machine Back Squat", Description ="A classic exercise for overall leg development.", SportId= sports[0].Id },
                // Index => 80
                new Workout { Id = 81, Name = "Smith Machine Front Squat", Description ="Emphasizes the quads and core stability.", SportId= sports[0].Id },
                // Index => 81
                new Workout { Id = 82, Name = "Smith Machine Romanian Deadlift", Description ="Targets the hamstrings and glutes.", SportId= sports[0].Id },
                // Index => 82
                new Workout { Id = 83, Name = "Smith Machine Split Squat", Description ="Focuses on one leg at a time for balance and strength.", SportId= sports[0].Id },
                // Index => 83
                new Workout { Id = 84, Name = "Smith Machine Reverse Lunge", Description ="Works the quads, hamstrings, and glutes.", SportId= sports[0].Id },
                // Index => 84
                new Workout { Id = 85, Name = "Smith Machine Hip Thrust", Description ="Builds strength in the glutes and hamstrings.", SportId= sports[0].Id },
                // Index => 85
                new Workout { Id = 86, Name = "Smith Machine Calf Raise", Description ="Isolates the calf muscles.", SportId= sports[0].Id },

                // Core
                // Index => 86
                new Workout { Id = 87, Name = "Smith Machine Hanging Leg Raise", Description ="Engages the abdominal muscles effectively.", SportId= sports[0].Id },
                // Index => 87
                new Workout { Id = 88, Name = "Smith Machine Plank (with feet on bar)", Description ="A variation that challenges core stability.", SportId= sports[0].Id },

                // Arms
                // Index => 88
                new Workout { Id = 89, Name = "Smith Machine Skull Crushers", Description ="Targets the triceps effectively.", SportId= sports[0].Id },
                // Index => 89
                new Workout { Id = 90, Name = "Smith Machine Bicep Curl", Description ="Isolates the biceps for focused development.", SportId= sports[0].Id },

                // Additional Exercises
                // Index => 90
                new Workout { Id = 91, Name = "Smith Machine Kaz Press", Description ="A unique press that targets both triceps and chest.", SportId= sports[0].Id },
                // Index => 91
                new Workout { Id = 92, Name = "Smith Machine Single-Leg Deadlift", Description ="Enhances balance while targeting hamstrings and glutes.", SportId= sports[0].Id },

                #endregion

                #region Leg Press Machine
                // Index => 92
                new Workout {Id = 93, Name = "Standard Leg Press", Description = "A foundational exercise that targets the quadriceps, hamstrings, and glutes.", SportId = sports[0].Id },
                // Index => 93
                new Workout {Id = 94, Name = "Wide Stance Leg Press", Description = "Emphasizes the inner thighs and glutes by placing feet wider than shoulder-width apart", SportId = sports[0].Id },
                // Index => 94
                new Workout {Id = 95, Name = "Narrow Stance Leg Press", Description = "Focuses on the outer quadriceps with feet placed closer together.", SportId = sports[0].Id },
                // Index => 95
                new Workout {Id = 96, Name = "High Foot Placement Leg Press", Description = "Targets the hamstrings and glutes by positioning feet higher on the platform.", SportId = sports[0].Id },                
                // Index => 96
                new Workout {Id = 97, Name = "Low Foot Placement Leg Press", Description = "Shifts emphasis to the quadriceps by placing feet lower on the platform.", SportId = sports[0].Id },                
                // Index => 97
                new Workout {Id = 98, Name = "Single Leg Press", Description = "Addresses strength imbalances by performing the leg press one leg at a time.", SportId = sports[0].Id },                
                // Index => 98
                new Workout {Id = 99, Name = "Calf Press on the Leg Press Machine", Description = "Targets the calf muscles by pressing with just the toes while keeping heels off the platform.", SportId = sports[0].Id },                
                // Index => 99
                new Workout {Id = 100, Name = "Single-Leg Calf Raise on Leg Press Machine", Description = "Similar to the calf press but performed one leg at a time for added focus.", SportId = sports[0].Id },                
                // Index => 100
                new Workout {Id = 101, Name = "Sumo Leg Press", Description = "A variation where feet are placed wider and turned outwards to target inner thighs more effectively.", SportId = sports[0].Id },                
                // Index => 101
                new Workout {Id = 102, Name = "Feet Elevated Leg Press", Description = " Elevating feet on a block or platform increases range of motion and targets glutes and hamstrings more intensely.", SportId = sports[0].Id },
                #endregion

                #region chest press machine
                // Index => 102
                new Workout {Id = 103, Name = "Machine Chest Press", Description = "This is the standard exercise that targets the pectoral muscles, triceps, and shoulders. It's typically performed for moderate to high reps (8-12) to build muscle mass", SportId = sports[0].Id },
                // Index => 103
                new Workout {Id = 104, Name = "Incline Chest Press", Description = "Adjust the machine to an incline position to emphasize the upper chest. This variation helps in developing the upper pectoral muscles more effectively.", SportId = sports[0].Id },
                // Index => 104
                new Workout {Id = 105, Name = "Decline Chest Press", Description = "Set the machine to a decline position to target the lower part of the chest. This variation can help in achieving a more balanced chest development", SportId = sports[0].Id },
                // Index => 105
                new Workout {Id = 106, Name = "Leverage Chest Press", Description = "Similar to the machine chest press but uses a leverage system, allowing for a different angle and resistance curve, which can enhance muscle engagement", SportId = sports[0].Id },
                // Index => 106
                new Workout {Id = 107, Name = "Plate-Loaded Chest Press", Description = "Utilize a plate-loaded version of the chest press machine for increased weight versatility and a different feel during the lift", SportId = sports[0].Id },
                // Index => 107
                new Workout {Id = 108, Name = "Cable Chest Press", Description = "Perform seated, standing, or lying cable chest presses for varied resistance and muscle engagement, focusing on stability and control", SportId = sports[0].Id },
                // Index => 108
                new Workout {Id = 109, Name = "Drop Sets", Description = "After reaching muscle fatigue at your maximum weight, immediately reduce the weight and continue pressing until failure. This technique enhances muscle endurance and hypertrophy", SportId = sports[0].Id },
                // Index => 109
                new Workout {Id = 110, Name = "Partial Reps", Description = "Focus on the strongest part of your range of motion by performing partial reps at the peak contraction of the lift, which can help in building strength at specific points in your lift", SportId = sports[0].Id },
                // Index => 110
                new Workout {Id = 111, Name = "High-Rep Finishing Set", Description = "Use the machine for a burnout set at the end of your workout with high repetitions (15-20) to fully exhaust your muscles", SportId = sports[0].Id },

                #endregion

                #region Lat Pulldown Machine
                // Index => 111
                new Workout {Id = 112, Name = "Standard Lat Pulldown", Description = "The basic lat pulldown targets the latissimus dorsi, rhomboids, and biceps.", SportId = sports[0].Id },
                // Index => 112
                new Workout {Id = 113, Name = "Wide Grip Lat Pulldown", Description = "Emphasizes the outer lats for a broader back.", SportId = sports[0].Id },
                // Index => 113
                new Workout {Id = 114, Name = "Close Grip Lat Pulldown", Description = "Focuses more on the inner lats and biceps", SportId = sports[0].Id },
                // Index => 114
                new Workout {Id = 115, Name = "Reverse Grip Lat Pulldown", Description = "Targets the middle back and biceps effectively.", SportId = sports[0].Id },
                // Index => 115
                new Workout {Id = 116, Name = "Single Arm Lat Pulldown", Description = "Allows for unilateral training, helping to correct muscle imbalances.", SportId = sports[0].Id },
                // Index => 116
                new Workout {Id = 117, Name = "Behind-the-Neck Lat Pulldown", Description = "Targets the upper lats and deltoids but should be performed with caution to avoid shoulder strain.", SportId = sports[0].Id },
                // Index => 117
                new Workout {Id = 118, Name = "Straight Arm Lat Pulldown", Description = "Isolates the lats without involving the biceps significantly.", SportId = sports[0].Id },
                // Index => 118
                new Workout {Id = 119, Name = "Alternating Grip Lat Pulldown", Description = "Combines different grips in one set for varied muscle engagement.", SportId = sports[0].Id },
                #endregion

                #region Leg Curl Machine
                // Index => 119
                new Workout {Id = 120, Name = "Seated Leg Curl", Description = "This is the most common exercise performed on a leg curl machine. It effectively isolates the hamstrings while allowing for a comfortable seated position. Adjust the machine so that the pad rests just above your ankles, and curl your legs down towards your glutes", SportId = sports[0].Id },
                // Index => 120
                new Workout {Id = 121, Name = "Lying Leg Curl", Description = "This variation involves lying face down on the machine. The pad should be positioned just above your calves, and you curl your legs upward towards your glutes. This position emphasizes the hamstrings differently than the seated version", SportId = sports[0].Id },
                // Index => 121
                new Workout {Id = 122, Name = "Standing Leg Curl", Description = "Some machines allow for a standing position, where you curl one leg at a time while standing. This variation helps improve balance and engages the stabilizing muscles in addition to targeting the hamstrings", SportId = sports[0].Id },
                // Index => 122
                new Workout {Id = 123, Name = "Single-Leg Curl", Description = "Perform leg curls one leg at a time to focus on muscle imbalances and enhance isolation of each hamstring individually", SportId = sports[0].Id },
                // Index => 123
                new Workout {Id = 124, Name = "Foot Position Variations", Description = "Adjust your foot positioning (toes pointed in, out, or straight) during curls to target different parts of the hamstrings and engage other stabilizing muscles", SportId = sports[0].Id },
                // Index => 124
                new Workout {Id = 125, Name = "Eccentric Focus", Description = "Emphasize the eccentric (lowering) phase of the curl by lowering the weight slowly after reaching the peak contraction, which can help increase muscle hypertrophy.", SportId = sports[0].Id },
                // Index => 125
                new Workout {Id = 126, Name = "Leg Curl Drop Sets", Description = "After reaching failure at a heavier weight, immediately reduce the weight and continue performing curls until failure again to maximize muscle fatigue.", SportId = sports[0].Id },
                // Index => 126
                new Workout {Id = 127, Name = "Supersets with Other Exercises", Description = "Combine leg curls with other lower body exercises (like squats or deadlifts) for a comprehensive leg workout that targets multiple muscle groups.", SportId = sports[0].Id },
                #endregion

                #region Leg Extension Machine
                // Index => 127
                new Workout {Id = 128, Name = "Standard Leg Extension", Description = "Sit on the machine with your back against the pad. Adjust the pad so it rests on your lower legs, just above your ankles. Extend your legs until they are straight, then lower back down", SportId = sports[0].Id },
                // Index => 128
                new Workout {Id = 129, Name = "Single-Leg Extension", Description = "Use the same machine but perform the exercise one leg at a time. This helps address muscle imbalances and allows for greater focus on each quadricep.", SportId = sports[0].Id },
                // Index => 129
                new Workout {Id = 130, Name = "One-Legged Machine Extension", Description = "If available, use a unilateral leg extension machine that allows each leg to work independently, providing an additional challenge and variety.", SportId = sports[0].Id },
                // Index => 130
                new Workout {Id = 131, Name = "Foot Position Variations", Description = "Experiment with different foot positions (toes pointed in, out, or straight) during the extension to target various parts of the quadriceps.", SportId = sports[0].Id },
                // Index => 131
                new Workout {Id = 132, Name = "Eccentric Focus", Description = "Emphasize the eccentric phase by lowering the weight slowly after reaching full extension. This technique can enhance muscle hypertrophy.", SportId = sports[0].Id },
                // Index => 132
                new Workout {Id = 133, Name = "Drop Sets", Description = "Perform a set to failure at a heavier weight, then immediately reduce the weight and continue until failure again to maximize muscle fatigue.", SportId = sports[0].Id },
                // Index => 133
                new Workout {Id = 134, Name = "Supersets with Other Exercises", Description = "Combine leg extensions with other leg exercises (like squats or lunges) for a comprehensive workout that targets multiple muscle groups.", SportId = sports[0].Id },
                // Index => 134
                new Workout {Id = 135, Name = "Controlled Tempo", Description = "Focus on maintaining a slow and controlled tempo throughout both the lifting and lowering phases to maximize muscle engagement.", SportId = sports[0].Id },
                #endregion

                #region Cable Machine
                // Upper Body Workouts
                // Index => 135
                new Workout { Id = 136, Name = "Cable Lat Pulldown", Description = "Targets the lats and upper back.", SportId = sports[0].Id },
                // Index => 136
                new Workout { Id = 137, Name = "Seated Cable Row", Description = "Focuses on the middle back and biceps.", SportId = sports[0].Id },
                // Index => 137
                new Workout { Id = 138, Name = "Cable Chest Flye", Description = "Great for isolating the pectoral muscles.", SportId = sports[0].Id },
                // Index => 138
                new Workout { Id = 139, Name = "Cable Crossover", Description = "Engages the chest from different angles.", SportId = sports[0].Id },
                // Index => 139
                new Workout { Id = 140, Name = "Cable Bicep Curl", Description = "Isolates the biceps for muscle growth.", SportId = sports[0].Id },
                // Index => 140
                new Workout { Id = 141, Name = "Cable Tricep Pushdown", Description = "Targets the triceps effectively.", SportId = sports[0].Id },
                // Index => 141
                new Workout { Id = 142, Name = "Face Pull", Description = "Strengthens the rear deltoids and rotator cuff muscles.", SportId = sports[0].Id },
                // Index => 142
                new Workout { Id = 143, Name = "Cable Lateral Raise", Description = "Works the deltoids, particularly the side delts.", SportId = sports[0].Id },
                // Index => 143
                new Workout { Id = 144, Name = "Cable Upright Row", Description = "Targets the shoulders and traps.", SportId = sports[0].Id },
                // Index => 144
                new Workout { Id = 145, Name = "Straight Arm Pulldown", Description = "Focuses on the lats and core stability.", SportId = sports[0].Id },

                // Core Workouts
                // Index => 145
                new Workout { Id = 146, Name = "Cable Crunch", Description = "Engages the abdominal muscles with constant tension.", SportId = sports[0].Id },
                // Index => 146
                new Workout { Id = 147, Name = "Kneeling Cable Crunch", Description = "A variation that targets the core from a kneeling position.", SportId = sports[0].Id },
                // Index => 147
                new Workout { Id = 148, Name = "Cable Wood Chop", Description = "Strengthens the obliques and improves rotational power.", SportId = sports[0].Id },
                // Index => 148
                new Workout { Id = 149, Name = "Cable Pallof Press", Description = "Enhances core stability and anti-rotation strength.", SportId = sports[0].Id },
                // Index => 149
                new Workout { Id = 150, Name = "Single-Arm Cable Side Bend", Description = "Targets the obliques while improving lateral strength.", SportId = sports[0].Id },

                // Lower Body Workouts
                // Index => 150
                new Workout { Id = 151, Name = "Cable Kickback", Description = "Isolates the glutes effectively.", SportId = sports[0].Id },
                // Index => 151
                new Workout { Id = 152, Name = "Single-Leg Cable Hip Extension", Description = "Focuses on glute activation and stability.", SportId = sports[0].Id },
                // Index => 152
                new Workout { Id = 153, Name = "Cable Pull-Through", Description = "Engages the hamstrings and glutes with minimal spinal load.", SportId = sports[0].Id },
                // Index => 153
                new Workout { Id = 154, Name = "Cable Squats", Description = "Adds resistance to traditional squats for extra challenge.", SportId = sports[0].Id },
                // Index => 154
                new Workout { Id = 155, Name = "Low-Cable Cross-Over (for legs)", Description = "Targets inner thighs when performed correctly.", SportId = sports[0].Id },
                // Index => 155
                new Workout { Id = 156, Name = "Incline Cable Chest Fly", Description = "Targets the upper portion of the chest.", SportId = sports[0].Id },
                // Index => 156
                new Workout { Id = 157, Name = "Overhead Cable Tricep Extension", Description = "Focuses on tricep development from an overhead position.", SportId = sports[0].Id },
                // Index => 157
                new Workout { Id = 158, Name = "Reverse Grip Triceps Pushdown", Description = "A variation that emphasizes different parts of the triceps.", SportId = sports[0].Id },
                // Index => 158
                new Workout { Id = 159, Name = "Standing Cable Low-to-High Twist", Description = "Engages both core and shoulder muscles through rotation.", SportId = sports[0].Id },
                // Index => 159
                new Workout { Id = 160, Name = "Rope Hammer Curl", Description = "Works both biceps and forearms effectively.", SportId = sports[0].Id },
                
                #endregion

                #region Bench Press
                // Primary Bench Press Variations
                // Index => 160
                new Workout { Id = 161, Name = "Flat Barbell Bench Press", Description = "The classic exercise for building overall chest strength and mass.", SportId = sports[0].Id },
                // Index => 161
                new Workout { Id = 162, Name = "Incline Barbell Bench Press", Description = "Performed on an incline bench (typically set at 30-45 degrees), this variation emphasizes the upper chest and shoulders.", SportId = sports[0].Id },
                // Index => 162
                new Workout { Id = 163, Name = "Decline Barbell Bench Press", Description = "Involves a decline bench position, targeting the lower part of the pectorals.", SportId = sports[0].Id },
                // Index => 163
                new Workout { Id = 164, Name = "Dumbbell Bench Press", Description = "Can be performed flat, incline, or decline; allows for a greater range of motion and engages stabilizing muscles.", SportId = sports[0].Id },
                // Index => 164
                new Workout { Id = 165, Name = "Close-Grip Bench Press", Description = "A narrower grip that shifts focus to the triceps while still engaging the chest.", SportId = sports[0].Id },
                // Index => 165
                new Workout { Id = 166, Name = "Wide-Grip Bench Press", Description = "A wider grip that targets the outer pectoral muscles more intensely.", SportId = sports[0].Id },
                // Index => 166
                new Workout { Id = 167, Name = "Tempo Bench Press", Description = "Involves controlling the speed of the lift (e.g., slow lowering phase) to increase time under tension.", SportId = sports[0].Id },
                // Index => 167
                new Workout { Id = 168, Name = "Spoto Press", Description = "Pauses just above the chest to enhance control and stability before pressing back up.", SportId = sports[0].Id },
                // Index => 168
                new Workout { Id = 169, Name = "Floor Press", Description = "Performed lying on the floor, this variation limits the range of motion and emphasizes triceps strength.", SportId = sports[0].Id },
                // Index => 169
                new Workout { Id = 170, Name = "Swiss Bar Bench Press", Description = "Utilizes a Swiss bar for a neutral grip, reducing shoulder strain while still effectively targeting the chest and triceps.", SportId = sports[0].Id },

                // Primary Bench Press Variations
                // Index => 170
                new Workout { Id = 171, Name = "Pause Bench Press", Description = "A standard press with a pause at the bottom position, enhancing strength off the chest.", SportId = sports[0].Id },                
                // Index => 171
                new Workout { Id = 172, Name = "Pin Press", Description = "Performed by setting pins in a power rack at a specific height, focusing on pressing from a dead stop.", SportId = sports[0].Id },
                // Index => 172
                new Workout { Id = 173, Name = "Board Press", Description = "Involves pressing with a board placed on the chest to limit range of motion, emphasizing lockout strength.", SportId = sports[0].Id },
                // Index => 173
                new Workout { Id = 174, Name = "Reverse Grip Bench Press", Description = "A unique grip that shifts emphasis to the upper chest and triceps while providing shoulder stability.", SportId = sports[0].Id },
                // Index => 174
                new Workout { Id = 175, Name = "Single-Arm Dumbbell Bench Press", Description = "Engages core stability while isolating each side of the chest independently.", SportId = sports[0].Id },
                #endregion

                #region Floor Press
                // Primary Floor Press Variations
                // Index => 175
                new Workout { Id = 176, Name = "Barbell Floor Press", Description ="The standard version that targets the chest, shoulders, and triceps with minimal shoulder strain.", SportId= sports[0].Id },
                // Index => 176
                new Workout { Id = 177, Name = "Dumbbell Floor Press", Description ="Allows for a greater range of motion and engages stabilizing muscles. Can be performed with a neutral grip for shoulder comfort.", SportId= sports[0].Id },
                // Index => 177
                new Workout { Id = 178, Name = "Kettlebell Floor Press", Description ="Similar to the dumbbell variation but adds unique stabilization challenges due to the kettlebell's shape.", SportId= sports[0].Id },
                // Index => 178
                new Workout { Id = 179, Name = "Single-Arm Dumbbell Floor Press", Description ="Focuses on one side at a time, addressing muscle imbalances and enhancing core stability.", SportId= sports[0].Id },
                // Index => 179
                new Workout { Id = 180, Name = "Single-Arm Kettlebell Floor Press", Description ="Involves pressing a kettlebell with one arm while maintaining core stability, increasing the challenge.", SportId= sports[0].Id },
                // Index => 180
                new Workout { Id = 181, Name = "Swiss Bar Floor Press", Description ="Utilizes a Swiss bar for a neutral grip, which can reduce shoulder strain while still effectively targeting the upper body.", SportId= sports[0].Id },

                // Primary Floor Press Variations
                // Index => 181
                new Workout { Id = 182, Name = "Paused Floor Press", Description ="Involves pausing at the bottom of the movement before pressing up, which increases time under tension for hypertrophy.", SportId= sports[0].Id },
                // Index => 182
                new Workout { Id = 183, Name = "Resisted Floor Press", Description ="Incorporates bands or chains to increase resistance as you press, enhancing strength development throughout the movement.", SportId= sports[0].Id },
                // Index => 183
                new Workout { Id = 184, Name = "Close-Grip Floor Press", Description ="A variation that emphasizes triceps engagement while still targeting the chest.", SportId= sports[0].Id },
                // Index => 184
                new Workout { Id = 185, Name = "Floor Press with Chains or Bands", Description ="Adding chains or bands increases resistance as you press, challenging your muscles differently.", SportId= sports[0].Id },
                // Index => 185
                new Workout { Id = 186, Name = "Eccentric Floor Press", Description ="Focuses on slowly lowering the weight to build strength in the eccentric phase of the lift.", SportId= sports[0].Id },
                #endregion

                #region Treadmill
                // Index => 186
                new Workout { Id = 187, Name = "Steady-State Jogging", Description ="A basic workout where you jog at a consistent pace for a set duration (e.g., 20-30 minutes) to improve cardiovascular endurance.", SportId= sports[0].Id },
                // Index => 187
                new Workout { Id = 188, Name = "Sprint Intervals", Description ="Alternate between high-intensity sprints and rest periods.", SportId= sports[0].Id },
                // Index => 188
                new Workout { Id = 189, Name = "Incline Walking or Running", Description ="Set the treadmill to an incline (e.g., 5-15%) and walk or run to increase intensity and engage the legs more effectively.", SportId= sports[0].Id },
                // Index => 189
                new Workout { Id = 190, Name = "Fartlek Training", Description ="A mix of different speeds during your run.", SportId= sports[0].Id },
                // Index => 190
                new Workout { Id = 191, Name = "Hill Sprints", Description ="Set the incline to a steep level (e.g., 10-15%) and perform short sprints (10-30 seconds) followed by recovery periods (1-2 minutes).", SportId= sports[0].Id },
                // Index => 191
                new Workout { Id = 192, Name = "12-3-30 Workout", Description ="Set the treadmill to a 12% incline, a speed of 3 mph, and walk for 30 minutes. This low-impact workout is effective for building endurance.", SportId= sports[0].Id },
                // Index => 192
                new Workout { Id = 193, Name = "Bodyweight HIIT", Description ="Incorporate bodyweight exercises between running intervals.", SportId= sports[0].Id },
                // Index => 193
                new Workout { Id = 194, Name = "Treadmill Circuit Training", Description ="Combine treadmill running with strength exercises.", SportId= sports[0].Id },
                // Index => 194
                new Workout { Id = 195, Name = "Tempo Runs", Description ="Gradually increase your pace to a challenging but sustainable speed, maintaining it for a set duration before cooling down.", SportId= sports[0].Id },
                // Index => 195
                new Workout { Id = 196, Name = "Recovery Walks", Description ="After intense workouts, use the treadmill for light walking to aid recovery and keep your muscles active.", SportId= sports[0].Id },

                // Advanced Techniques
                // Index => 196
                new Workout { Id = 197, Name = "Pyramid Intervals", Description ="Gradually increase sprint durations (e.g., from 20 seconds up to 1 minute) followed by equal rest periods, then decrease back down.", SportId = sports[0].Id },
                // Index => 197
                new Workout { Id = 198, Name = "Progressive Runs", Description ="Start at a slow pace and gradually increase speed every few minutes until reaching your maximum effort.", SportId= sports[0].Id },
                // Index => 198
                new Workout { Id = 199, Name = "Mixed Speed Workouts", Description ="Alternate between different speeds every few minutes (e.g., fast run, moderate jog, brisk walk) to enhance endurance and speed.", SportId = sports[0].Id },
                #endregion

                #region Rowing Machine
                // Index => 199
                new Workout { Id= 200, Name = "Interval Training", Description= "High-intensity intervals to improve endurance and burn fat", SportId = sports[0].Id  },
                // Index => 200
                new Workout { Id= 201, Name = "Row and Core Workout", Description= "Combines rowing with core strengthening", SportId = sports[0].Id  },
                // Index => 201
                new Workout { Id= 202, Name = "Renegade & Row EMOM", Description= "Targets back and core while incorporating rowing for cardio", SportId = sports[0].Id  },
                // Index => 202
                new Workout { Id= 203, Name = "Pump and Row Pyramid", Description= "Full-body workout with emphasis on endurance and strength", SportId = sports[0].Id  },
                // Index => 203
                new Workout { Id= 204, Name = "Burpee Blast Challenge", Description= "Combines cardio with explosive strength movements", SportId = sports[0].Id  },
                // Index => 204
                new Workout { Id= 205, Name = "The Ultimate Rowing Workout", Description= "Builds lean muscle while enhancing cardiovascular fitness", SportId = sports[0].Id  },
                // Index => 205
                new Workout { Id= 206, Name = "Endurance Rows", Description= "Improves overall cardiovascular health while toning muscles", SportId = sports[0].Id  },
                #endregion

                #region stationary Bike
                // Index => 206
                new Workout { Id= 207, Name = "Steady-State Cycling", Description= "Maintain a consistent pace at a moderate resistance for 20-60 minutes to improve cardiovascular endurance.", SportId = sports[0].Id  },
                // Index => 207
                new Workout { Id= 208, Name = "High-Intensity Interval Training (HIIT)", Description= "Alternate between high-intensity sprints and recovery periods. For example:\r\n30 seconds of maximum effort followed by 30 seconds of easy pedaling, repeated for 15-20 minutes.", SportId = sports[0].Id  },
                // Index => 208
                new Workout { Id= 209, Name = "Tabata Training", Description= "Perform 20 seconds of all-out cycling followed by 10 seconds of rest, repeated for 4 minutes (8 rounds). This is an intense workout that boosts anaerobic capacity.", SportId = sports[0].Id  },
                // Index => 209
                new Workout { Id= 210, Name = "Pyramid Intervals", Description= "Gradually increase the duration of sprints (e.g., 20 seconds, 40 seconds, 60 seconds) followed by equal rest periods, then decrease back down.", SportId = sports[0].Id  },
                // Index => 210
                new Workout { Id= 211, Name = "Hill Climb Simulation", Description= "Increase the resistance to simulate hill climbing. Cycle at a challenging resistance for a set time (e.g., 3-5 minutes), followed by recovery periods.", SportId = sports[0].Id  },
                // Index => 211
                new Workout { Id= 212, Name = "Fartlek Training", Description= "Incorporate varying speeds throughout your ride. For example:\r\nJog for 5 minutes, sprint for 1 minute, then recover with light cycling for 2 minutes, repeating the cycle.", SportId = sports[0].Id  },
                // Index => 212
                new Workout { Id= 213, Name = "Sprinting Intervals", Description= "Sprint at high intensity for short bursts (e.g., 20-40 seconds) followed by longer recovery periods (e.g., 1-2 minutes). Repeat several times.", SportId = sports[0].Id  },                
                // Index => 213
                new Workout { Id = 214, Name = "Resistance Pyramid", Description = "Start with low resistance and gradually increase every few minutes until reaching maximum effort, then decrease back down.", SportId = sports[0].Id },
                // Index => 214
                new Workout { Id = 215, Name = "Mixed Cardio Circuit", Description = "Combine stationary bike workouts with bodyweight exercises (like push-ups or squats) in between cycling intervals to enhance muscle engagement.", SportId = sports[0].Id },
                // Index => 215
                new Workout { Id = 216, Name = "Recovery Ride", Description = "Use the bike for low-intensity cycling after heavy lifting sessions to promote recovery without putting too much strain on the muscles.", SportId = sports[0].Id },
                // Index => 216
                new Workout { Id = 217, Name = "Sprint-Focused Workout", Description = "Warm up for 5 minutes, then alternate between 30 seconds of sprinting and 1 minute of easy cycling for a total of about 15-20 minutes.", SportId = sports[0].Id },
                // Index => 217
                new Workout { Id = 218, Name = "Endurance Challenge", Description = "Aim for longer durations at a steady pace (45-60 minutes) to build aerobic capacity and endurance.Aim for longer durations at a steady pace (45-60 minutes) to build aerobic capacity and endurance.", SportId = sports[0].Id },
                // Index => 218
                new Workout { Id = 219, Name = "LISS (Low-Intensity Steady State) Cardio", Description = "Maintain a low intensity over a longer duration (e.g., 30-60 minutes) to promote fat burning while minimizing fatigue.", SportId = sports[0].Id },
                // Index => 219
                new Workout { Id = 220, Name = "Cooldown Sessions", Description = "After intense workouts, spend 5-10 minutes cycling at a very light pace to help with muscle recovery and prevent stiffness.", SportId = sports[0].Id },

                #endregion

                #region Stair Climber
                // Index => 220
                new Workout { Id = 221, Name = "Steady-State Climbing", Description = "Maintain a consistent pace for 20-30 minutes at a moderate intensity to improve cardiovascular endurance and burn calories.", SportId = sports[0].Id },
                // Index => 221
                new Workout { Id= 222, Name = "Interval Training", Description= "Alternate between high-intensity climbing and recovery periods. For example:\r\n1 minute of fast climbing followed by 1-2 minutes of slower climbing. Repeat for 20-30 minutes.", SportId = sports[0].Id  },
                // Index => 222
                new Workout { Id= 223, Name = "Hill Climb Simulation", Description= "Increase the resistance or speed to simulate climbing a steep hill for a set duration (e.g., 5 minutes), followed by a recovery period.", SportId = sports[0].Id  },
                // Index => 223
                new Workout { Id= 224, Name = "Pyramid Intervals", Description= "Gradually increase the intensity for a set number of minutes (e.g., 1 minute, 2 minutes, 3 minutes) and then decrease back down.", SportId = sports[0].Id },
                // Index => 224
                new Workout { Id= 225, Name = "Tabata Training", Description= "Perform 20 seconds of maximum effort followed by 10 seconds of rest, repeated for 4 minutes (8 rounds). This is an intense workout that boosts anaerobic capacity.", SportId = sports[0].Id  },
                // Index => 225
                new Workout { Id= 226, Name = "Fartlek Training", Description= "Incorporate varying speeds throughout your climb. For example:\r\nClimb at a moderate pace for 5 minutes, then sprint for 1 minute, followed by easy climbing for 2 minutes. Repeat.", SportId = sports[0].Id  },
                // Index => 226
                new Workout { Id= 227, Name = "25-7-2 Workout", Description= "Set the stair climber to an intensity level of 7 and climb for 25 minutes without holding onto the handrails to engage your core more effectively.", SportId = sports[0].Id  },
                // Index => 227
                new Workout { Id= 228, Name = "Circuit Training", Description= "Combine stair climbing with bodyweight exercises (like push-ups or squats) in between climbing intervals to enhance muscle engagement.", SportId = sports[0].Id  },
                // Index => 228
                new Workout { Id= 229, Name = "Endurance Challenge", Description= "Aim for longer durations at a steady pace (e.g., 30-60 minutes) to build aerobic capacity and endurance.", SportId = sports[0].Id  },
                // Index => 229
                new Workout { Id= 230, Name = "Cooldown Sessions", Description= "After intense workouts, spend 5-10 minutes on the stair climber at a very light pace to help with muscle recovery and prevent stiffness.", SportId = sports[0].Id  },
                // Index => 230
                new Workout { Id= 231, Name = "Resistance Training", Description= "Increase the resistance setting on the stair climber to challenge your muscles more and build strength in your legs and glutes.", SportId = sports[0].Id  },
                // Index => 231
                new Workout { Id= 232, Name = "Single-Leg Climbing", Description= "Alternate between using one leg at a time to target each leg individually, which can help improve balance and address muscle imbalances.", SportId = sports[0].Id  },
                // Index => 232
                new Workout { Id= 233, Name = "Backward Climbing", Description= "If your machine allows it, try climbing backward for short intervals to engage different muscle groups and improve coordination.", SportId = sports[0].Id  },
                // Index => 233
                new Workout { Id= 234, Name = "Sprints on the Stair Climber", Description= "Perform short bursts of maximum effort climbing (e.g., 20-30 seconds) followed by longer recovery periods (e.g., 1-2 minutes).", SportId = sports[0].Id  },
                #endregion

                #region Power Rack
                // Index => 234
                new Workout { Id = 235, Name="Barbell Squat", Description="A foundational exercise for building leg strength and mass. Can be performed as back squats or front squats.", SportId = sports[0].Id },
                // Index => 235
                new Workout { Id = 236, Name="Rack Pulls", Description="A partial deadlift that starts with the barbell positioned at knee height, focusing on the upper portion of the deadlift movement.", SportId = sports[0].Id },
                // Index => 236
                new Workout { Id = 237, Name="Barbell Bench Press", Description="Performed inside the rack for safety, this exercise targets the chest, shoulders, and triceps.", SportId = sports[0].Id },
                // Index => 237
                new Workout { Id = 238, Name="Overhead Press", Description="Standing or seated, this movement targets the shoulders and triceps while engaging the core for stability.", SportId = sports[0].Id },
                // Index => 238
                new Workout { Id = 239, Name="Deadlifts", Description="Can be performed with the barbell set at different heights to focus on various parts of the lift (e.g., conventional deadlifts or sumo deadlifts).", SportId = sports[0].Id },                
                // Index => 239
                new Workout { Id = 240, Name="Pull-Ups/Chin-Ups", Description="Utilize the pull-up bar attached to the power rack for bodyweight exercises targeting the back and biceps.", SportId = sports[0].Id },
                // Index => 240
                new Workout { Id = 241, Name="Barbell Lunges", Description="Perform lunges with the barbell resting on your back to enhance leg strength and stability.", SportId = sports[0].Id },
                // Index => 241
                new Workout { Id = 242, Name="Incline Bench Press", Description="Adjust a bench inside the rack to perform incline presses, targeting the upper chest.", SportId = sports[0].Id },

                // Isolation Exercises
                // Index => 242
                new Workout { Id = 243, Name="Barbell Curl", Description="Use the power rack to perform curls with a barbell for focused bicep training.", SportId = sports[0].Id },
                // Index => 243
                new Workout { Id = 244, Name="Tricep Dips", Description="If your rack has dip bars, perform dips to target the triceps and chest.", SportId = sports[0].Id },
                // Index => 244
                new Workout { Id = 245, Name="Leg Extensions (using attachments)", Description="If your power rack has attachments, you can perform leg extensions for isolated quadricep work.", SportId = sports[0].Id },
                // Index => 245
                new Workout { Id = 246, Name="Leg Curls (using attachments)", Description="Similar to leg extensions, if equipped, this can target the hamstrings effectively.", SportId = sports[0].Id },

                // Advanced Techniques
                // Index => 246
                new Workout { Id = 247, Name="Paused Squats", Description="Pause at the bottom of your squat for a few seconds before pressing up to increase time under tension.", SportId = sports[0].Id },
                // Index => 247
                new Workout { Id = 248, Name="Tempo Training", Description="Control the speed of each lift (e.g., slow descent) to enhance muscle engagement and growth.\r\n", SportId = sports[0].Id },
                // Index => 248
                new Workout { Id = 249, Name="Drop Sets", Description="After reaching failure with a heavier weight, immediately reduce weight and continue until failure again.", SportId = sports[0].Id },
                // Index => 249
                new Workout { Id = 250, Name="Supersets", Description="Combine two exercises (e.g., squat followed by overhead press) with minimal rest in between for increased intensity.", SportId = sports[0].Id },
                // Index => 250
                new Workout { Id = 251, Name="Dynamic Effort Training", Description="Use lighter weights at higher speeds to develop explosive strength in compound lifts.", SportId = sports[0].Id },
                
                // Full-Body Workouts
                // Index => 251
                new Workout { Id = 252, Name="Full-Body Circuit", Description="Create a circuit using multiple exercises (squats, bench press, rows, etc.) within the power rack for comprehensive training.", SportId = sports[0].Id },
                // Index => 252
                new Workout { Id = 253, Name="Progressive Overload Routine", Description="Focus on gradually increasing weights across various lifts performed in the power rack over time to build strength and muscle mass.", SportId = sports[0].Id },
                #endregion

                #region Battle Ropes
                // Index  => 253
                new Workout { Id = 254, Name="Alternating Waves", Description="Raise one arm and then the other to create waves down the rope, focusing on speed and power.", SportId = sports[0].Id },
                // Index  => 254
                new Workout { Id = 255, Name="Two-Handed Waves", Description="Raise both ends of the rope simultaneously and slam them down, engaging the core and upper body.", SportId = sports[0].Id },
                // Index  => 255
                new Workout { Id = 256, Name="In and Out Waves", Description="Bring both arms in simultaneously to cross over, then back out, targeting the chest and shoulders.", SportId = sports[0].Id },
                // Index  => 256
                new Workout { Id = 257, Name="Rope Slams", Description="Lift both ends overhead and slam them down as hard as possible to engage the entire body.", SportId = sports[0].Id },
                // Index  => 257
                new Workout { Id = 258, Name="Sidewinders", Description="Move the arms side to side while creating waves, engaging the obliques and core.", SportId = sports[0].Id },
                // Index  => 258
                new Workout { Id = 259, Name="Snakes", Description="Create small waves by moving your arms up and down quickly, focusing on shoulder stability.", SportId = sports[0].Id },
                // Index  => 259
                new Workout { Id = 260, Name="Rainbows", Description="Swing the ropes in an arc from one side of your body to the other, engaging the core throughout.", SportId = sports[0].Id },
                // Index  => 260
                new Workout { Id = 261, Name="Plank Alternating Slams", Description="In a plank position, alternate slamming each end of the rope while maintaining core stability.", SportId = sports[0].Id },
                // Index  => 261
                new Workout { Id = 262, Name="Battle Rope Russian Twists", Description="In a seated position with feet elevated, twist your torso while pulling the ropes side to side.", SportId = sports[0].Id },
                // Index  => 262
                new Workout { Id = 263, Name="Jumping Jack Waves", Description="Perform jumping jacks while simultaneously raising and lowering the ropes, combining cardio with upper body work.", SportId = sports[0].Id },
                // Index  => 263
                new Workout { Id = 264, Name="Alternating Lunge Wave", Description="Step back into a lunge while creating waves with the ropes, targeting legs and core.", SportId = sports[0].Id },
                // Index  => 264
                new Workout { Id = 265, Name="Half-Kneeling Waves", Description="Perform waves from a half-kneeling position to engage the core and improve balance.", SportId = sports[0].Id },
                // Index  => 265
                new Workout { Id = 266, Name="Tsunami Waves", Description="Create large waves by moving both arms in unison, focusing on explosive power.", SportId = sports[0].Id },
                // Index  => 266
                new Workout { Id = 267, Name="Fireman’s Carry", Description="Sling the rope across your shoulder and perform sprints or lateral movements for added resistance.", SportId = sports[0].Id },
                // Index  => 267
                new Workout { Id = 268, Name="Squat Waves", Description="Perform squats while creating waves with the ropes for a full-body workout.", SportId = sports[0].Id },
                // Index  => 268
                new Workout { Id = 269, Name="Interval Training", Description="Alternate between high-intensity work (e.g., 20 seconds of alternating waves) followed by rest (10 seconds).", SportId = sports[0].Id },
                // Index  => 269
                new Workout { Id = 270, Name="Tabata Workout", Description="Perform 20 seconds of work followed by 10 seconds of rest for 8 rounds on various exercises (e.g., alternating waves, slams).", SportId = sports[0].Id },                
                // Index  => 270
                new Workout { Id = 271, Name ="Circuit Training", Description = "Combine multiple battle rope exercises into a circuit (e.g., 1 minute each of alternating waves, slams, and rainbows).", SportId = sports[0].Id},
                // Index  => 271
                new Workout { Id = 272, Name ="Pyramid Intervals", Description = "Gradually increase work duration (e.g., 20 seconds up to 1 minute) followed by equal rest periods.", SportId = sports[0].Id},
                // Index  => 272
                new Workout { Id = 273, Name ="Unilateral Workouts", Description = "Focus on one side at a time (e.g., unilateral waves) to improve muscle imbalances and core stability.", SportId = sports[0].Id},
                // Index  => 273
                new Workout { Id = 274, Name ="Full-Body Conditioning Circuit", Description = "Incorporate battle ropes with bodyweight exercises (e.g., push-ups or burpees) for comprehensive conditioning.", SportId = sports[0].Id},
                #endregion

                #region Bands
                // Upper Body Workouts
                // Index  => 274
                new Workout { Id = 275, Name ="Banded Push-Ups", Description = "Place the band around your upper back and hold the ends under your hands to increase resistance during push-ups.", SportId = sports[0].Id},
                
                // Index => 275
                new Workout { Id = 276, Name ="Banded Chest Press", Description = "Anchor the band behind you and press forward, mimicking a bench press motion to target the chest.", SportId = sports[0].Id},                
                // Index => 276
                new Workout { Id = 277, Name ="Banded Tricep Extensions", Description = "Anchor the band above you and extend your arms downward to target the triceps.", SportId = sports[0].Id},
                // Index => 277
                new Workout { Id = 278, Name ="Single-Arm Lat Pulldown", Description = "Anchor the band above you and pull down with one arm to target the lats.", SportId = sports[0].Id},                
                // Index => 278
                new Workout { Id = 279, Name ="Reverse Fly", Description = "Stand on a band, bend forward slightly, and raise your arms to the side, targeting the rear delts.", SportId = sports[0].Id},


                // Index  => 279
                new Workout { Id = 280, Name ="Banded Shoulder Press", Description = "Stand on the band and press overhead, engaging the shoulders and triceps.", SportId = sports[0].Id},
                // Index  => 280
                new Workout { Id = 281, Name ="Banded Bent-Over Row", Description = "Stand on the band, bend forward, and pull the handles towards your ribcage to target the back muscles.", SportId = sports[0].Id},
                // Index  => 281
                new Workout { Id = 282, Name ="Banded Bicep Curl", Description = "Stand on the band and curl the handles towards your shoulders, focusing on the biceps.", SportId = sports[0].Id},
                // Index  => 282
                new Workout { Id = 283, Name ="Banded Tricep Kickback", Description = "Anchor the band and extend your arms backward to work the triceps.", SportId = sports[0].Id},
                // Index  => 283
                new Workout { Id = 284, Name ="Banded Lateral Raise", Description = "Stand on the band and raise your arms to the side to target the deltoids.", SportId = sports[0].Id},
                // Index  => 284
                new Workout { Id = 285, Name ="Banded Chest Fly", Description = "Anchor the band behind you and perform a fly motion to engage the chest muscles.", SportId = sports[0].Id},
                // Index  => 285
                new Workout { Id = 286, Name ="Banded Face Pull", Description = "Anchor the band at head height and pull towards your face to strengthen rear delts and upper back.", SportId = sports[0].Id},

                // Core Workouts
                // Index  => 286
                new Workout { Id = 287, Name ="Band Pallof Press", Description = "Stand sideways to an anchored band and press it away from your chest, engaging your core for stability.", SportId = sports[0].Id},
                // Index  => 287
                new Workout { Id = 288, Name ="Band Russian Twists", Description = "Sit with your feet elevated, holding a band anchored behind you, and twist side to side.", SportId = sports[0].Id},
                // Index  => 288
                new Workout { Id = 289, Name ="Band Assisted Dragon Flags", Description = "Use a band for support while performing dragon flags to enhance core strength.", SportId = sports[0].Id},
                // Index  => 289
                new Workout { Id = 290, Name ="Band Crunches", Description = "Lie on your back with the band anchored above you, pulling down as you crunch up.", SportId = sports[0].Id},
                // Index  => 290
                new Workout { Id = 291, Name ="Band Alternate Heel Touches", Description = "Lie on your back with knees bent, holding a band, and alternate tapping each heel while engaging your core.", SportId = sports[0].Id},

                // Index  => 291
                new Workout { Id = 292, Name ="Banded Plank Rows", Description = "In a plank position, row each arm while maintaining core stability.", SportId = sports[0].Id},
                // Index  => 292
                new Workout { Id = 293, Name ="Banded Woodchoppers", Description = "Anchor the band low and pull diagonally across your body to engage obliques.", SportId = sports[0].Id},
                
                
                // Lower Body Workouts
                // Index  => 293
                new Workout { Id = 294, Name ="Banded Squats", Description = "Stand on the band with feet shoulder-width apart and perform squats, adding resistance.", SportId = sports[0].Id},
                // Index  => 294
                new Workout { Id = 295, Name ="Banded Bulgarian Split Squats", Description = "Place one foot behind you on a bench while standing on a band with the other foot to perform split squats.", SportId = sports[0].Id},
                // Index  => 295
                new Workout { Id = 296, Name ="Banded Deadlifts", Description = "Stand on the band and perform deadlifts by hinging at the hips while keeping tension in the band.", SportId = sports[0].Id},
                // Index  => 296
                new Workout { Id = 297, Name ="Banded Lying Hamstring Curl", Description = "Lie on your stomach with a band secured around your ankles; curl your legs towards your glutes.", SportId = sports[0].Id},
                // Index  => 297
                new Workout { Id = 298, Name ="Banded Glute Bridges", Description = "Place a band around your thighs and perform glute bridges to activate glutes effectively.", SportId = sports[0].Id},
                // Index  => 298
                new Workout { Id = 299, Name ="Banded Calf Raises", Description = "Stand on the band with feet shoulder-width apart and raise up onto your toes for calf engagement.", SportId = sports[0].Id},
                
                // Index  => 299
                new Workout { Id = 300, Name ="Banded Lunges", Description = "Step back into lunges while holding onto bands for added resistance.", SportId = sports[0].Id},
                // Index  => 300
                new Workout { Id = 301, Name ="Banded Hamstring Curls", Description = "Anchor one end of the band at ankle height; curl your leg towards your glutes while standing or lying down.", SportId = sports[0].Id},
                // Index  => 301
                new Workout { Id = 302, Name ="Banded Side Steps (Abductions)", Description = "Place a band around your legs just above your knees; step side-to-side to target hip abductors.", SportId = sports[0].Id},
                #endregion

                #region Stability Ball
                // Core Workouts
                // Index => 302
                new Workout { Id = 303, Name ="Stability Ball Crunch", Description = "Lie faceup on the ball with your low back supported, feet flat on the floor, and perform a crunch by raising your shoulders off the ball.", SportId = sports[0].Id},
                // Index => 303
                new Workout { Id = 304, Name ="Stability Ball Oblique Crunch", Description = "Similar to the crunch, but rotate your upper body to one side to engage the obliques.", SportId = sports[0].Id},
                // Index => 304
                new Workout { Id = 305, Name ="Stability Ball Knee Raise", Description = "Balance on the ball and lift one knee towards your chest, alternating sides.", SportId = sports[0].Id},
                // Index => 305
                new Workout { Id = 306, Name ="Stability Ball Bicycle Crunch", Description = "Perform a bicycle crunch while lying on the ball, bringing opposite elbow to knee.", SportId = sports[0].Id},
                // Index => 306
                new Workout { Id = 307, Name ="Stability Ball Tuck", Description = "Start in a plank position with feet on the ball and pull your knees towards your chest.", SportId = sports[0].Id},
                // Index => 307
                new Workout { Id = 308, Name ="Stability Ball Pike", Description = "From a plank position, pull your feet towards your hands while keeping your legs straight to raise your hips.", SportId = sports[0].Id},
                // Index => 308
                new Workout { Id = 309, Name ="Stability Ball Hands-to-Feet Pass", Description = "Lie on your back holding the ball between your hands and feet. Lift both to pass the ball from hands to feet and back.", SportId = sports[0].Id},
                // Index => 309
                new Workout { Id = 310, Name ="Stability Ball Dead Bug", Description = "Lie on your back with legs up and arms extended, squeezing the ball between your hands and knees while alternating arm and leg movements.", SportId = sports[0].Id},                
                // Index => 310
                new Workout { Id = 311, Name ="Stability Ball Stir the Pot", Description = "In a plank position with forearms on the ball, move your arms in circular motions while keeping your body stable.", SportId = sports[0].Id},
                // Index => 311
                new Workout { Id = 312, Name ="Stability Ball Rollout", Description = "Kneel with the ball in front of you and roll it forward while keeping your core engaged.", SportId = sports[0].Id},

                // Lower Body Workouts
                // Index => 312
                new Workout { Id = 313, Name ="Stability Ball Hip Thrust", Description = "Lie on your back with shoulders on the ball and feet flat on the ground; lift hips to engage glutes.", SportId = sports[0].Id},
                // Index => 313
                new Workout { Id = 314, Name ="Stability Ball Hamstring Curl", Description = "Lie on your back with heels resting on the ball; lift hips and curl the ball towards you by bending your knees.", SportId = sports[0].Id},
                // Index => 314
                new Workout { Id = 315, Name ="Stability Ball Squat", Description = "Stand with your back against a wall and place a stability ball between you and the wall; perform squats while pressing against the ball.", SportId = sports[0].Id},
                // Index => 315
                new Workout { Id = 316, Name ="Stability Ball Lunge", Description = "Place one foot on the ball behind you and perform lunges with the other leg.", SportId = sports[0].Id},
                // Index => 316
                new Workout { Id = 317, Name ="Stability Ball Glute Bridge", Description = "With feet on the ball, lift hips off the ground to engage glutes and hamstrings.", SportId = sports[0].Id},
                // Index => 317
                new Workout { Id = 318, Name ="Stability Ball Single-Leg Hamstring Curl", Description = "Perform hamstring curls with one leg while keeping the other extended.", SportId = sports[0].Id},
                // Index => 318
                new Workout { Id = 319, Name ="Stability Ball Rearfoot Elevated Split Squat", Description = "Place one foot on the ball behind you; squat down with the front leg.", SportId = sports[0].Id},
                // Index => 319
                new Workout { Id = 320, Name ="Stability Ball Calf Raises", Description = "Stand on a stability ball or use it for balance while performing calf raises.", SportId = sports[0].Id},

                // Upper Body Workouts
                // Index => 320
                new Workout { Id = 321, Name ="Stability Ball Push-Ups", Description = "Place hands on the stability ball while performing push-ups to engage stabilizing muscles.", SportId = sports[0].Id},
                // Index => 321
                new Workout { Id = 322, Name ="Stability Ball Tricep Dips", Description = "With hands on the ball behind you, lower and raise your body using triceps.", SportId = sports[0].Id},
                // Index => 322
                new Workout { Id = 323, Name ="Kneeling Triceps Extension", Description = "Kneel with arms resting on the stability ball; extend arms to work triceps.", SportId = sports[0].Id},
                // Index => 323
                new Workout { Id = 324, Name ="Chest Flys on Stability Ball", Description = "Lie back on a stability ball holding dumbbells; perform flys to target chest muscles.", SportId = sports[0].Id},
                // Index => 324
                new Workout { Id = 325, Name ="Y's and T's", Description = "Lie face down on the stability ball and raise arms in a Y or T position to engage shoulders and upper back.", SportId = sports[0].Id},
                // Index => 325
                new Workout { Id = 326, Name ="Stability Ball Plank Rows", Description = "In plank position with hands on the ball, row one arm at a time to engage back muscles.", SportId = sports[0].Id},
                // Index => 326
                new Workout { Id = 327, Name ="Forearm Plank with Feet on Stability Ball", Description = "Hold a plank position with feet resting on the stability ball for core stability training.", SportId = sports[0].Id},
                // Index => 327
                new Workout { Id = 328, Name ="Push-Up Variations (Feet or Hands Elevated)", Description = "Elevate either feet or hands on the stability ball for added difficulty during push-ups.", SportId = sports[0].Id},

                #endregion

                #region Foam Roll
                // Lower Body
                // Index => 328
                new Workout { Id = 329, Name ="Quadriceps Roll", Description = "Position the foam roller under your quads and roll from the hip to just above the knee to release tension.", SportId = sports[0].Id},
                // Index => 329
                new Workout { Id = 330, Name ="Hamstring Roll", Description = "Sit with your legs extended and place the roller under your hamstrings. Roll from just below the glutes to just above the knees.", SportId = sports[0].Id},
                // Index => 330
                new Workout { Id = 331, Name ="IT Band Roll", Description = "Lie on your side with the roller positioned along the outside of your thigh. Roll from just below the hip to just above the knee.", SportId = sports[0].Id},
                // Index => 331
                new Workout { Id = 332, Name ="Calf Roll", Description = "Sit with your legs extended and place the roller under your calves. Lift your body off the ground and roll from knee to ankle.", SportId = sports[0].Id},
                // Index => 332
                new Workout { Id = 333, Name ="Glute Roll", Description = "Sit on the foam roller and cross one ankle over the opposite knee. Lean into the glute and roll back and forth.", SportId = sports[0].Id},
                // Index => 333
                new Workout { Id = 334, Name ="Hip Flexor Roll", Description = "Lie face down with the roller under one hip flexor, rolling slowly to release tightness in that area.", SportId = sports[0].Id},
                
                // Upper Body
                // Index => 334
                new Workout { Id = 335, Name ="Thoracic Spine Roll", Description = "Place the roller under your upper back and roll from the mid-back to the shoulder blades to improve spinal mobility.", SportId = sports[0].Id},
                // Index => 335
                new Workout { Id = 336, Name ="Lats Roll", Description = "Lie on your side with the foam roller positioned under your lat (just below your armpit). Roll down towards your mid-back.", SportId = sports[0].Id},
                // Index => 336
                new Workout { Id = 337, Name ="Shoulder Roll", Description = "Lie on your side with the roller under one shoulder and roll up and down to target shoulder tightness.", SportId = sports[0].Id},
                // Index => 337
                new Workout { Id = 338, Name ="Pectoral Stretch", Description = "Position the foam roller vertically along your spine and relax into a stretch with arms outstretched in a \"Y\" position for chest opening.", SportId = sports[0].Id},

                // Core
                // Index => 338
                new Workout { Id = 339, Name ="Lower Back Roll", Description = "Caution: Only perform if you have adequate core strength. Lie on your back with the roller positioned under your lower back, rolling gently from mid-back to low back.", SportId = sports[0].Id},
                // Index => 339
                new Workout { Id = 340, Name ="Abdominal Foam Rolling", Description = "Lie face down with the foam roller positioned under your abdomen; gently roll side to side for core relaxation.", SportId = sports[0].Id},
                #endregion

                #region Abdominal Bench
                // Index => 340
                new Workout { Id = 341, Name ="Bench Crunch", Description = "Lie on your back on the bench with feet on the bench or in the air. Lift your shoulders off the bench to engage your abs.", SportId = sports[0].Id},
                // Index => 341
                new Workout { Id = 342, Name ="Reverse Crunch", Description = "Lie on your back, grab the bench behind your head, and lift your hips off the bench while bringing your knees towards your chest.", SportId = sports[0].Id},
                // Index => 342
                new Workout { Id = 343, Name ="Jackknife", Description = "Lie on your back with legs in the air. Simultaneously lift your shoulders off the bench while lowering your legs towards the bench.", SportId = sports[0].Id},
                // Index => 343
                new Workout { Id = 344, Name ="Leg Raises", Description = "Lie on your back, hold the bench at your sides, and lift your legs towards the ceiling, keeping them straight or slightly bent.", SportId = sports[0].Id},
                // Index => 344
                new Workout { Id = 345, Name ="Flutter Kicks", Description = "Lie on your back, lift your shoulders off the bench, and alternate raising each leg in a fluttering motion.", SportId = sports[0].Id},
                // Index => 345
                new Workout { Id = 346, Name ="Knee to Chest Crunches", Description = "Lie on your back, bend your knees, and simultaneously lift your shoulders off the bench while bringing your knees to your chest.", SportId = sports[0].Id},
                // Index => 346
                new Workout { Id = 347, Name ="Decline Sit-Ups", Description = "Set the bench at a decline angle and perform full sit-ups.", SportId = sports[0].Id},
                // Index => 347
                new Workout { Id = 348, Name ="Russian Twists", Description = "Sit on the bench, lean back slightly, lift your feet, and rotate your torso from side to side.", SportId = sports[0].Id},
                // Index => 348
                new Workout { Id = 349, Name ="Bicycle Crunches", Description = "Lie on your back, lift your shoulders, and alternate bringing opposite elbow to knee in a cycling motion.", SportId = sports[0].Id},
                // Index => 349
                new Workout { Id = 350, Name ="Hip Lifts", Description = "Lie on your back, anchor your hands overhead, and lift your hips towards the ceiling.", SportId = sports[0].Id},
                // Index => 350
                new Workout { Id = 351, Name ="Straight Leg Raises", Description = "Similar to leg raises, but keep your legs completely straight throughout the movement.", SportId = sports[0].Id},
                // Index => 351
                new Workout { Id = 352, Name ="Decline Plank", Description = "Set up in a plank position with your feet elevated on the bench.", SportId = sports[0].Id},
                #endregion

                #region Pull-Up Bar
                // Index => 352
                new Workout { Id = 353, Name ="Standard Pull-Ups", Description = "Grip the bar with palms facing away from you, pull your body up until your chin is above the bar.", SportId = sports[0].Id},
                // Index => 353
                new Workout { Id = 354, Name ="Chin-Ups", Description = "Grip the bar with palms facing you. This variation emphasizes the biceps more than standard pull-ups.", SportId = sports[0].Id},
                // Index => 354
                new Workout { Id = 355, Name ="Wide-Grip Pull-Ups", Description = "Use a wider grip to target the upper back and lats more intensely.", SportId = sports[0].Id},

                // Index => 355
                new Workout { Id = 356, Name ="Close-Grip Pull-Ups", Description = "A narrower grip that focuses more on the biceps and inner back muscles.", SportId = sports[0].Id},

                // Index => 356
                new Workout { Id = 357, Name ="Weighted Pull-Ups", Description = "Add weight using a dip belt or weighted vest to increase resistance during pull-ups.", SportId = sports[0].Id},

                // Index => 357
                new Workout { Id = 358, Name ="Assisted Pull-Ups", Description = "Use a resistance band or an assisted pull-up machine to help lift your body weight.", SportId = sports[0].Id},

                // Index => 358
                new Workout { Id = 359, Name ="Negative Pull-Ups", Description = "Jump or step up to the top position and slowly lower yourself down to build strength.", SportId = sports[0].Id},

                // Index => 359
                new Workout { Id = 360, Name ="Scapular Pull-Ups", Description = "Hang from the bar and perform small movements by retracting and depressing your shoulder blades without bending your elbows.", SportId = sports[0].Id},

                // Index => 360
                new Workout { Id = 361, Name ="L-Sit Pull-Ups", Description = "Perform pull-ups while holding your legs straight out in front of you, engaging your core throughout.", SportId = sports[0].Id},

                // Index => 361
                new Workout { Id = 362, Name ="Muscle-Ups", Description = "A combination of a pull-up and a dip; pull up explosively and transition into a dip position above the bar.", SportId = sports[0].Id},

                // Core Exercises
                // Index => 362
                new Workout { Id = 363, Name ="Hanging Knee Raises", Description = "Hang from the bar and lift your knees towards your chest, focusing on engaging your abs.", SportId = sports[0].Id},

                // Index => 363
                new Workout { Id = 364, Name ="Hanging Leg Raises", Description = "Similar to knee raises but keep your legs straight as you lift them towards the bar.", SportId = sports[0].Id},

                // Index => 364
                new Workout { Id = 365, Name ="Hanging Windshield Wipers", Description = "From a hanging position, move your legs side to side in a controlled manner to target obliques.", SportId = sports[0].Id},

                // Index => 365
                new Workout { Id = 366, Name ="Hanging L-Sit", Description = "Hang from the bar with legs extended in front of you, holding this position to engage core muscles.\r\nHanging Straight Leg Raise", SportId = sports[0].Id},
                // Dynamic Movements
                // Index => 366
                new Workout { Id = 367, Name ="Burpee Pull-Ups", Description = "Perform a burpee followed by a pull-up, combining cardio with strength training.", SportId = sports[0].Id},

                // Index => 367
                new Workout { Id = 368, Name ="Kipping Pull-Ups", Description = "Use momentum from your hips to assist in pulling yourself up, often used in CrossFit workouts.", SportId = sports[0].Id},

                // Index => 368
                new Workout { Id = 369, Name ="Towel Pull-Ups", Description = "Drape a towel over the bar and grip it for added difficulty and grip training.", SportId = sports[0].Id},

                // Index => 369
                new Workout { Id = 370, Name ="One-Arm Pull-Up (Assisted)", Description = "Use one arm while holding onto the other arm for assistance; progress towards full one-arm pull-ups.", SportId = sports[0].Id},

                // Index => 370
                new Workout { Id = 371, Name ="Front Lever Holds", Description = "Hang from the bar and lift your body into a horizontal position, engaging multiple muscle groups for strength.", SportId = sports[0].Id},
                #endregion

                #region Cable
                // Upper Body Exercises:
                // Index => 371
                new Workout { Id = 372, Name ="Cable Bicep Curl", Description = "", SportId = sports[0].Id},
                // Index => 372
                new Workout { Id = 373, Name ="Cable Crossover", Description = "", SportId = sports[0].Id},

                // Index => 373
                new Workout { Id = 374, Name ="Cable Lateral Raise", Description = "", SportId = sports[0].Id},

                // Index => 374
                new Workout { Id = 375, Name ="Cable Fly", Description = "", SportId = sports[0].Id},

                // Index => 375
                new Workout { Id = 376, Name ="Cable Press-Around", Description = "", SportId = sports[0].Id},

                // Index => 376
                new Workout { Id = 377, Name ="Straight-Arm Pulldown", Description = "", SportId = sports[0].Id},

                // Index => 377
                new Workout { Id = 378, Name ="Face Pull", Description = "", SportId = sports[0].Id},

                // Index => 378
                new Workout { Id = 379, Name ="Close-Grip Lat Pulldown", Description = "", SportId = sports[0].Id},
                
                // Index => 379
                new Workout { Id = 380, Name ="Single-Arm Overhead Triceps Extension", Description = "", SportId = sports[0].Id},

                // Index => 380
                new Workout { Id = 381, Name ="Cable Row", Description = "", SportId = sports[0].Id},

                // Index => 381
                new Workout { Id = 382, Name ="Cable Chest Press", Description = "", SportId = sports[0].Id},

                // Index => 382
                new Workout { Id = 383, Name ="Upright Cable Fly", Description = "", SportId = sports[0].Id},

                // Index => 383
                new Workout { Id = 384, Name ="Low to High Cable Raise", Description = "", SportId = sports[0].Id},

                // Index => 384
                new Workout { Id = 385, Name ="Front Raise (Hammer Grip, Single Arm, and with Bar)", Description = "", SportId = sports[0].Id},

                // Index => 385
                new Workout { Id = 386, Name ="Side Hang Lateral Raise", Description = "", SportId = sports[0].Id},

                // Index => 386
                new Workout { Id = 387, Name ="Bent Over Cable Crossover", Description = "", SportId = sports[0].Id},

                // Index => 387
                new Workout { Id = 388, Name ="Bent Over Row with Bar", Description = "", SportId = sports[0].Id},

                // Index => 388
                new Workout { Id = 389, Name ="Standing Row (Single Arm)", Description = "", SportId = sports[0].Id},

                // Index => 389
                new Workout { Id = 390, Name="Kneeling Row (Single Arm)", Description="", SportId= sports[0].Id},

                // Index => 390
                new Workout { Id = 391, Name="Cable Pushdown", Description="", SportId= sports[0].Id},

                // Index => 391
                new Workout { Id = 392, Name="Rope Pushdown", Description="", SportId= sports[0].Id},

                // Index => 392
                new Workout { Id = 393, Name="Single Arm Cable Extension", Description="", SportId= sports[0].Id},

                // Index => 393
                new Workout { Id = 394, Name="Double Handle Cable Extension", Description="", SportId= sports[0].Id},

                // Index => 394
                new Workout { Id = 395, Name="Overhead Extension", Description="", SportId= sports[0].Id},


                //Lower Body Exercises:
                // Index => 395
                new Workout { Id = 396, Name="Cable Kickback", Description="", SportId= sports[0].Id},

                // Index => 396
                new Workout { Id = 397, Name="Cable Squats", Description="", SportId= sports[0].Id},

                // Index => 397
                new Workout { Id = 398, Name="Cable Lunges", Description="", SportId= sports[0].Id},

                // Index => 398
                new Workout { Id = 399, Name="Cable Leg Extensions", Description="", SportId= sports[0].Id},

                // Index => 399
                new Workout { Id = 400, Name="Cable Hamstring Curls", Description="", SportId= sports[0].Id},

                // Core Exercises
                // Index => 400
                new Workout { Id = 401, Name="Cable Crunches", Description="", SportId= sports[0].Id},

                // Index => 401
                new Workout { Id = 402, Name="Cable Wood Chop", Description="", SportId= sports[0].Id},

                // Index => 402
                new Workout { Id = 403, Name="Cable Pallof Press", Description="", SportId= sports[0].Id},

                // Index => 403
                new Workout { Id = 404, Name="Cable Russian Twists", Description="", SportId= sports[0].Id},
                #endregion

                #region Medicine Ball
                // Core Exercises
                // Index => 404
                new Workout { Id = 405, Name ="Russian Twist", Description = "Sit on the ground, lean back slightly, and twist your torso side to side while holding the medicine ball.", SportId = sports[0].Id},
                // Index => 405
                new Workout { Id = 406, Name ="Medicine Ball V-Up", Description = "Lie on your back, hold the ball overhead, and lift your arms and legs simultaneously to form a V shape, passing the ball from hands to feet.", SportId = sports[0].Id},
                // Index => 406
                new Workout { Id = 407, Name ="Medicine Ball Crunch", Description = "Lie on your back with legs elevated; hold the ball overhead and crunch up, bringing the ball towards your knees.", SportId = sports[0].Id},
                // Index => 407
                new Workout { Id = 408, Name ="Medicine Ball Toe Touches", Description = "Lie on your back with legs straight up; lift your shoulders off the ground and reach for your toes with the medicine ball.", SportId = sports[0].Id},
                // Index => 408
                new Workout { Id = 409, Name ="Medicine Ball Plank Pass", Description = "In a plank position, pass the medicine ball from one hand to the other while maintaining stability.", SportId = sports[0].Id},

                // Index => 409
                new Workout { Id = 410, Name ="Medicine Ball Woodchoppers", Description = "Stand with feet shoulder-width apart; hold the ball overhead and bring it diagonally down across your body to engage your core.", SportId = sports[0].Id},
                // Index => 410
                new Workout { Id = 411, Name ="Medicine Ball Side Plank Rotation", Description = "In a side plank position, hold the medicine ball and rotate your torso to bring it towards the ground, then back up.", SportId = sports[0].Id},
                
                
                // Upper Body Exercises
                // Index => 411
                new Workout { Id = 412, Name ="Medicine Ball Push-Ups", Description = "Place one hand on the medicine ball while performing push-ups to engage stabilizing muscles.", SportId = sports[0].Id},
                // Index => 412
                new Workout { Id = 413, Name ="Medicine Ball Overhead Press", Description = "Stand or sit with the ball at chest height; press it overhead and lower it back down.", SportId = sports[0].Id},
                // Index => 413
                new Workout { Id = 414, Name ="Medicine Ball Slams", Description = "Lift the ball overhead and slam it down to the ground, engaging your entire body for power.", SportId = sports[0].Id},

                // Index => 414
                new Workout { Id = 415, Name ="Rolling Push-Ups", Description = "Perform push-ups while rolling the medicine ball between hands after each rep.", SportId = sports[0].Id},
                // Index => 415
                new Workout { Id = 416, Name ="Medicine Ball Chest Pass", Description = "Stand facing a wall; throw the ball against it explosively and catch it on the rebound.", SportId = sports[0].Id},
                // Index => 416
                new Workout { Id = 417, Name ="Medicine Ball Tricep Extensions", Description = "Hold the ball overhead with both hands, lower it behind your head, then extend back up.", SportId = sports[0].Id},


                // Index => 417
                new Workout { Id = 418, Name ="Bicep Curl with Medicine Ball", Description = "Stand with feet shoulder-width apart; hold the ball at chest level and curl it towards your chest.", SportId = sports[0].Id},
                
                // Lower Body Exercises
                // Index => 418
                new Workout { Id = 419, Name ="Medicine Ball Squat", Description = "Hold the medicine ball at chest level while performing squats to add resistance.", SportId = sports[0].Id},
                // Index => 419
                new Workout { Id = 420, Name ="Medicine Ball Lunge and Twist", Description = "Step forward into a lunge while twisting your torso towards the leg that is forward, holding the medicine ball.", SportId = sports[0].Id},


                // Index => 420
                new Workout { Id = 421, Name ="Reaching Romanian Deadlift", Description = "Stand on one leg while holding a medicine ball; hinge at your hips to lower the ball toward the ground while extending the other leg behind you.", SportId = sports[0].Id},
                // Index => 421
                new Workout { Id = 422, Name ="Medicine Ball Thruster", Description = "Perform a squat holding the ball at chest level, then explode upward while pressing the ball overhead.", SportId = sports[0].Id},
                // Index => 422
                new Workout { Id = 423, Name ="Medicine Ball Side Lunges", Description = "Hold the medicine ball at chest level as you perform side lunges, keeping your core engaged.", SportId = sports[0].Id},
                // Index => 423
                new Workout { Id = 424, Name ="Medicine Ball Step-Ups", Description = "Step onto a bench or platform while holding a medicine ball at chest height for added resistance.", SportId = sports[0].Id},

                // Dynamic Movements
                // Index => 424
                new Workout { Id = 425, Name ="Overhead Medicine Ball Throw", Description = "Stand 8-10 feet from a wall; throw the medicine ball overhead against it and catch it on rebound.", SportId = sports[0].Id},
                // Index => 425
                new Workout { Id = 426, Name ="Rotational Medicine Ball Throw", Description = "Stand sideways to a wall; rotate your torso and throw the ball against it explosively using hip rotation for power.", SportId = sports[0].Id},
                // Index => 426
                new Workout { Id = 427, Name ="Medicine Ball Soccer Throw", Description = "Hold the medicine ball overhead and step forward as you throw it against a wall in a soccer-style motion.", SportId = sports[0].Id},
                // Index => 427
                new Workout { Id = 428, Name ="Medicine Ball Figure 8s", Description = "Pass the medicine ball around your legs in a figure-eight pattern to engage core stability and coordination.", SportId = sports[0].Id},
                // Index => 428
                new Workout { Id = 429, Name ="Medicine Ball Around-the-World", Description = "Hold the medicine ball above your head and make large circular movements with your arms in both directions.", SportId = sports[0].Id},
                #endregion

                #region E-Z Curl Bar
                // Bicep Exercises
                // Index => 429
                new Workout { Id = 430, Name ="Standard Bicep Curl", Description = "Stand with the bar at shoulder height and curl it up towards your chest, focusing on squeezing your biceps at the top.", SportId = sports[0].Id},
                // Index => 430
                new Workout { Id = 431, Name ="Close-Grip E-Z Bar Curl", Description = "Use a closer grip to target the long head of the biceps, enhancing peak development", SportId = sports[0].Id},
                // Index => 431
                new Workout { Id = 432, Name ="Preacher Curl", Description = "Sit on a preacher bench and curl the bar towards your shoulders, isolating the biceps effectively", SportId = sports[0].Id},
                // Index => 432
                new Workout { Id = 433, Name ="Reverse Curl", Description = "Hold the bar with an overhand grip and curl it upwards, targeting the forearms and biceps", SportId = sports[0].Id},
                // Index => 433
                new Workout { Id = 434, Name ="21s", Description = "Perform seven curls in the lower half of the movement, seven in the upper half, and seven full curls for an intense bicep workout", SportId = sports[0].Id},
                
                // Triceps Exercises
                // Index => 434
                new Workout { Id = 435, Name ="Skull Crushers", Description = "Lie on a bench and lower the bar towards your forehead before extending back up to work the triceps", SportId = sports[0].Id},
                // Index => 435
                new Workout { Id = 436, Name ="Overhead Triceps Extension", Description = "Hold the bar overhead with arms extended, then lower it behind your head before raising it back up", SportId = sports[0].Id},
                // Index => 436
                new Workout { Id = 437, Name ="Close-Grip Bench Press", Description = "Lie on a bench and press the bar upwards with a close grip to target the triceps more than the chest", SportId = sports[0].Id},
                
                // Shoulder Exercises
                // Index => 437
                new Workout { Id = 438, Name ="Shoulder Press", Description = "Press the bar overhead while standing or seated to engage shoulder muscles effectively", SportId = sports[0].Id},
                // Index => 438
                new Workout { Id = 439, Name ="Upright Row", Description = "Hold the bar with an overhand grip and pull it vertically towards your chin, engaging both shoulders and traps", SportId = sports[0].Id},
                
                // Back Exercises
                // Index => 439
                new Workout { Id = 440, Name ="Bent Over Row", Description = "Bend forward at the hips while holding the bar and pull it towards your waist to work on back strength", SportId = sports[0].Id},

                #endregion

                #region Trap Bar (Hex Bar)
                // Lower Body Exercises
                // Index => 440
                new Workout { Id = 441, Name ="Trap Bar Deadlift", Description = "A fundamental exercise for building strength in the legs and back.", SportId = sports[0].Id},
                // Index => 441
                new Workout { Id = 442, Name ="Romanian Deadlift", Description = "Focuses on the hamstrings and glutes while maintaining a slight bend in the knees.", SportId = sports[0].Id},
                // Index => 442
                new Workout { Id = 443, Name ="Stiff-Legged Deadlift", Description = "Targets the hamstrings and lower back with minimal knee flexion.", SportId = sports[0].Id},
                // Index => 443
                new Workout { Id = 444, Name ="Split Squat", Description = "A unilateral exercise that enhances balance and leg strength.", SportId = sports[0].Id},
                // Index => 444
                new Workout { Id = 445, Name ="Lunges", Description = "Can be performed forward or backward to target the quads and glutes.", SportId = sports[0].Id},
                // Index => 445
                new Workout { Id = 446, Name ="Hex Bar Squat", Description = "Allows for squatting with a more natural grip, reducing stress on the lower back.", SportId = sports[0].Id},
                // Index => 446
                new Workout { Id = 447, Name ="Jump Squats", Description = "A plyometric variation that builds explosive power in the legs.", SportId = sports[0].Id},
                // Index => 447
                new Workout { Id = 448, Name ="Farmer's Walk", Description = "Enhances grip strength and overall conditioning by carrying the bar over distance.", SportId = sports[0].Id},
                // Upper Body Exercises
                // Index => 448
                new Workout { Id = 449, Name ="Overhead Press", Description = "Strengthens shoulders and triceps with a neutral grip, reducing shoulder strain.", SportId = sports[0].Id},
                // Index => 449
                new Workout { Id = 450, Name ="Floor Press", Description = "Targets the chest and triceps while minimizing shoulder strain compared to traditional bench pressing.", SportId = sports[0].Id},
                // Index => 450
                new Workout { Id = 451, Name ="Push-Ups on Trap Bar", Description = "Elevates the push-up position for increased range of motion and comfort.", SportId = sports[0].Id},
                // Index => 451
                new Workout { Id = 452, Name ="Bent Over Row", Description = "Engages the back muscles effectively while allowing for a neutral grip.", SportId = sports[0].Id},
                // Index => 452
                new Workout { Id = 453, Name ="Shrugs", Description = "Targets the trapezius muscles, focusing on shoulder stability and strength.", SportId = sports[0].Id},
                // Index => 453
                new Workout { Id = 454, Name ="Chest Supported Row", Description = "Provides support for the chest while targeting upper back muscles.", SportId = sports[0].Id},
                // Index => 454
                new Workout { Id = 455, Name ="Pendlay Row", Description = "A strict rowing variation that emphasizes pulling strength from a dead stop.", SportId = sports[0].Id},

                // Core Exercises
                // Index => 455
                new Workout { Id = 456, Name ="Plank Holds", Description = "Engages core muscles effectively while stabilizing with the barbell.", SportId = sports[0].Id},                
                // Index => 456
                new Workout { Id = 457, Name ="Burpee Jumps with Trap Bar", Description = "Combines cardio with strength training, enhancing explosiveness and endurance.", SportId = sports[0].Id},
                // Index => 457
                new Workout { Id = 458, Name ="Suitcase Carry", Description = "Improves core stability and grip strength by carrying the bar on one side.", SportId = sports[0].Id},
                
                // Advanced Variations
                // Index => 458
                new Workout { Id = 459, Name ="Elevated Split Squat", Description = "Involves placing one foot on an elevated surface to increase range of motion and difficulty.", SportId = sports[0].Id},
                // Index => 459
                new Workout { Id = 460, Name ="Single Leg Deadlift", Description = "A balance-focused exercise that targets hamstrings and glutes unilaterally.", SportId = sports[0].Id},
                // Index => 460
                new Workout { Id = 461, Name ="Trap Bar Push Press", Description = "Combines a leg drive with an overhead press for full-body engagement.", SportId = sports[0].Id},
                #endregion

                #region Cambered Bar
                // Lower Body Exercises
                // Index => 461
                new Workout { Id = 462, Name ="Cambered Bar Squat", Description = "A variation of the squat that allows for a lower center of gravity, promoting better balance and engagement of the posterior chain.", SportId = sports[0].Id},
                // Index => 462
                new Workout { Id = 463, Name ="Paused Squats", Description = "Incorporate pauses at the bottom of the squat to enhance strength and control.", SportId = sports[0].Id},
                // Index => 463
                new Workout { Id = 464, Name ="Box Squats", Description = "Sit back onto a box or bench to improve squat depth and technique.", SportId = sports[0].Id},
                // Index => 464
                new Workout { Id = 465, Name ="Front Squats", Description = "Use the cambered bar for front squats to challenge your core stability while maintaining an upright torso.", SportId = sports[0].Id},
                // Index => 465
                new Workout { Id = 466, Name ="Good Mornings", Description = "Hinge at the hips with the bar on your back to target the hamstrings and lower back.", SportId = sports[0].Id},
                // Index => 466
                new Workout { Id = 467, Name ="Lunges", Description = "Perform forward or reverse lunges with the cambered bar for added resistance.", SportId = sports[0].Id},
                // Index => 467
                new Workout { Id = 468, Name ="Romanian Deadlifts", Description = "Focus on hamstring development by lowering the bar while keeping your legs relatively straight.", SportId = sports[0].Id},
                
                // Upper Body Exercises
                // Index => 468
                new Workout { Id = 469, Name ="Cambered Bar Overhead Press", Description = "Press the bar overhead while standing or seated, benefiting from a neutral grip that reduces shoulder strain.", SportId = sports[0].Id},
                // Index => 469
                new Workout { Id = 470, Name ="Bent-Over Row", Description = "Hinge forward and row the cambered bar towards your torso to target the upper back and lats.", SportId = sports[0].Id},

                // Index => 470
                new Workout { Id = 471, Name ="Floor Press", Description = "Lying on the floor, press the cambered bar from a neutral position to engage the chest and triceps.", SportId = sports[0].Id},
                // Index => 471
                new Workout { Id = 472, Name ="Push-Ups on Cambered Bar", Description = "Elevate your push-up position using the cambered bar for increased range of motion.", SportId = sports[0].Id},
                // Index => 472
                new Workout { Id = 473, Name ="Shrugs", Description = "Use the cambered bar to perform shrugs, targeting the trapezius muscles effectively.", SportId = sports[0].Id},
                
                // Core Exercises
                // Index => 473
                new Workout { Id = 474, Name ="Plank Holds with Cambered Bar", Description = "Place your hands on the bar while holding a plank position to engage your core muscles.", SportId = sports[0].Id},
                // Index => 474
                new Workout { Id = 475, Name ="Suitcase Carry", Description = "Load one side of the cambered bar and carry it to improve grip strength and core stability.", SportId = sports[0].Id},
                // Index => 475
                new Workout { Id = 476, Name ="Farmers Walk", Description = "Carry the cambered bar over a distance to enhance grip strength and overall conditioning.", SportId = sports[0].Id},                
                // Advanced Variations
                // Index => 476
                new Workout { Id = 477, Name ="Tempo Squats", Description = "Perform squats with controlled tempos (slow descent and explosive ascent) to increase time under tension.", SportId = sports[0].Id},
                // Index => 477
                new Workout { Id = 478, Name ="Single-Leg Deadlifts", Description = "Use the cambered bar for unilateral training, focusing on balance and coordination while targeting each leg individually.", SportId = sports[0].Id},
                // Index => 478
                new Workout { Id = 479, Name ="Split Squats", Description = "Perform split squats with one foot elevated behind you, using the cambered bar for added resistance.", SportId = sports[0].Id},
                #endregion

                #region Safety Bar
                // Lower Body Exercises
                // Index => 479
                new Workout { Id = 480, Name ="Safety Bar Squat", Description = "The primary exercise that targets the quads, hamstrings, and glutes while allowing for a more upright torso position.", SportId = sports[0].Id},
                // Index => 480
                new Workout { Id = 481, Name ="Hatfield Squat", Description = "A variation where you can hold onto supports for balance, making it easier to focus on depth and form.", SportId = sports[0].Id},
                // Index => 481
                new Workout { Id = 482, Name ="Walking Lunges", Description = "Perform lunges while holding the Safety Bar to engage the legs and improve stability.", SportId = sports[0].Id},
                // Index => 482
                new Workout { Id = 483, Name ="Split Squats", Description = "Use the Safety Bar to perform split squats, enhancing unilateral leg strength.", SportId = sports[0].Id},
                // Index => 483
                new Workout { Id = 484, Name ="Good Mornings", Description = "Hinge at the hips while keeping your back straight to target the hamstrings and lower back.", SportId = sports[0].Id},
                // Index => 484
                new Workout { Id = 485, Name ="Upper Back Good Mornings", Description = "A variation focusing more on upper back engagement while performing the good morning movement.", SportId = sports[0].Id},
                // Index => 485
                new Workout { Id = 486, Name ="Side Bends", Description = "Perform side bends with the Safety Bar to target the obliques and improve core strength.", SportId = sports[0].Id},
                // Index => 486
                new Workout { Id = 487, Name ="Box Squats", Description = "Use a box or bench to squat down to, focusing on form and depth.", SportId = sports[0].Id},

                // Upper Body Exercises
                // Index => 487
                new Workout { Id = 488, Name ="Tricep Extensions", Description = "Use the Safety Bar for overhead tricep extensions, effectively targeting the triceps.", SportId = sports[0].Id},
                // Index => 488
                new Workout { Id = 489, Name ="JM Press", Description = "A hybrid movement combining a close-grip bench press with a skull crusher for tricep development.", SportId = sports[0].Id},
                // Index => 489
                new Workout { Id = 490, Name ="Safety Bar Floor Press", Description = "Lying on the floor, press the Safety Bar from a neutral position to target the chest and triceps without straining the shoulders.", SportId = sports[0].Id},
                // Index => 490
                new Workout { Id = 491, Name ="Overhead Press", Description = "Press the bar overhead while standing or seated, benefiting from a stable grip that reduces shoulder strain.", SportId = sports[0].Id},
                // Index => 491
                new Workout { Id = 492, Name ="Shrugs", Description = "Use the Safety Bar to perform shrugs, targeting the trapezius muscles effectively.", SportId = sports[0].Id},
                
                // Core Exercises
                // Index => 492
                new Workout { Id = 493, Name ="Loaded Carry", Description = "Carrying the Safety Bar over a distance helps improve grip strength and core stability.", SportId = sports[0].Id},
                // Index => 493
                new Workout { Id = 494, Name ="Plank Holds with Safety Bar", Description = "Position yourself in a plank while holding onto the Safety Bar for added core engagement.", SportId = sports[0].Id},
                #endregion

                #region Axle Bar
                // Lower Body Exercises
                // Index => 494
                new Workout { Id = 495, Name ="Axle Bar Deadlift", Description = "A fundamental exercise for building overall strength in the posterior chain, particularly the hamstrings, glutes, and lower back.", SportId = sports[0].Id},
                // Index => 495
                new Workout { Id = 496, Name ="Axle Bar Squat", Description = "Perform squats with the Axle Bar to target the quads and glutes while benefiting from the thicker grip.", SportId = sports[0].Id},
                // Index => 496
                new Workout { Id = 497, Name ="Romanian Deadlift", Description = "Focus on hamstring development by hinging at the hips while keeping the knees slightly bent.", SportId = sports[0].Id},
                // Index => 497
                new Workout { Id = 498, Name ="Good Mornings", Description = "Hinge at the hips with the bar across your shoulders to target the hamstrings and lower back.", SportId = sports[0].Id},
                // Index => 498
                new Workout { Id = 499, Name ="Walking Lunges", Description = "Use the Axle Bar for added resistance while performing lunges to enhance leg strength and stability.", SportId = sports[0].Id},
                // Index => 499
                new Workout { Id = 500, Name ="Split Squats", Description = "Perform split squats with the Axle Bar to isolate each leg and improve balance.", SportId = sports[0].Id},
                // Upper Body Exercises
                // Index => 500
                new Workout { Id = 501, Name ="Axle Bar Overhead Press", Description = "Press the Axle Bar overhead to develop shoulder strength, utilizing a neutral grip that can reduce shoulder strain.", SportId = sports[0].Id},
                // Index => 501
                new Workout { Id = 503, Name ="Bent-Over Row", Description = "Hinge at the hips and row the Axle Bar towards your torso to engage the upper back and lats.", SportId = sports[0].Id},
                // Index => 502
                new Workout { Id = 504, Name ="Floor Press", Description = "Lying on your back, press the Axle Bar from a neutral position to target the chest and triceps effectively.", SportId = sports[0].Id},
                // Index => 503
                new Workout { Id = 505, Name ="Shrugs", Description = "Use the Axle Bar for shrugs to effectively target the trapezius muscles.", SportId = sports[0].Id},
                // Index => 504
                new Workout { Id = 506, Name ="Axle Bar Bench Press", Description = "Perform bench presses with the Axle Bar to enhance chest development while challenging grip strength.", SportId = sports[0].Id},
                // Core Exercises
                // Index => 505
                new Workout { Id = 507, Name ="Plank Holds with Axle Bar", Description = "Position yourself in a plank while holding onto the Axle Bar for increased core engagement.", SportId = sports[0].Id},
                // Index => 506
                new Workout { Id = 508, Name ="Farmers Walk", Description = "Carrying the Axle Bar over a distance improves grip strength and overall conditioning.", SportId = sports[0].Id},
                // Index => 507
                new Workout { Id = 509, Name ="Suitcase Carry", Description = "Load one side of the Axle Bar and carry it to challenge core stability and grip strength unilaterally.", SportId = sports[0].Id},
                
                // Advanced Variations
                // Index => 508                
                new Workout { Id = 510, Name ="Axle Bar Clean and Press", Description = "A compound movement that combines a clean with an overhead press, enhancing full-body coordination and strength.", SportId = sports[0].Id},                
                // Index => 509
                new Workout { Id = 511, Name ="Axle Bar Thrusters", Description = "A dynamic movement combining a front squat with an overhead press, great for conditioning and leg development.", SportId = sports[0].Id},
                // Index => 510
                new Workout { Id = 512, Name ="Jump Squats with Axle Bar", Description = "Incorporate jump squats for explosive power training while using the added resistance of the Axle Bar.", SportId = sports[0].Id},
                #endregion

                #region Swiss Bar
                // 
                // Index => 511
                new Workout { Id = 513, Name ="Swiss Bar Bench Press", Description = "A staple exercise for building chest strength while reducing shoulder strain.", SportId = sports[0].Id},
                // Index => 512
                new Workout { Id = 514, Name ="Swiss Bar Overhead Press", Description = "Targets the shoulders and triceps with a neutral grip to minimize discomfort.", SportId = sports[0].Id},
                // Index => 513
                new Workout { Id = 515, Name ="Swiss Bar Bent-Over Row", Description = "Engages the back muscles effectively while allowing for a neutral grip to reduce elbow strain.", SportId = sports[0].Id},
                // Index => 514
                new Workout { Id = 516, Name ="Swiss Bar Skull Crushers", Description = "Focuses on triceps development with less stress on the elbows compared to traditional methods.", SportId = sports[0].Id},
                // Index => 515
                new Workout { Id = 517, Name ="Swiss Bar Hammer Curls", Description = "A bicep exercise that allows for heavier loads due to the bilateral grip.", SportId = sports[0].Id},
                // Index => 516
                new Workout { Id = 518, Name ="Swiss Bar Pullovers", Description = "Works the lats and chest, providing a strong stretch and contraction.", SportId = sports[0].Id},
                // Index => 517
                new Workout { Id = 519, Name ="Swiss Bar Push-Ups", Description = "Increases range of motion and allows for various grip positions to target different muscle areas.", SportId = sports[0].Id},
                // Index => 518
                new Workout { Id = 520, Name ="Swiss Bar Seal Row", Description = "A variation of the row that eliminates momentum, focusing purely on back strength.", SportId = sports[0].Id},
                // Index => 519
                new Workout { Id = 521, Name ="Swiss Bar Ab Rollout", Description = "Engages the core effectively while utilizing the Swiss bar for stability.", SportId = sports[0].Id},
                // Index => 520
                new Workout { Id = 522, Name ="Swiss Bar Front Raise", Description = "Targets the front deltoids with a safer shoulder position.", SportId = sports[0].Id},
                // Index => 522
                new Workout { Id = 523, Name ="Swiss Bar Single-Leg Romanian Deadlift", Description = "Enhances balance and unilateral strength in the hamstrings and glutes.", SportId = sports[0].Id},
                // Index => 523
                new Workout { Id = 524, Name ="Swiss Bar Jammer Press", Description = "A dynamic pressing movement that can improve explosiveness and power.", SportId = sports[0].Id},
                // Index => 524
                new Workout { Id = 525, Name ="Swiss Bar Supported Hip Thrust", Description = "Utilizes the Swiss bar to add weight to hip thrusts, targeting glute development.", SportId = sports[0].Id},
                // Index => 525
                new Workout { Id = 526, Name ="Swiss Bar Elevated Rack Row", Description = "A variation of the row that focuses on upper back engagement from an elevated position.", SportId = sports[0].Id},
                // Index => 526
                new Workout { Id = 527, Name ="Swiss Bar Suitcase Carry", Description = "Enhances grip strength and engages the core through unilateral loading.", SportId = sports[0].Id},
                // Index => 527
                new Workout { Id = 528, Name ="Swiss Bar Zercher Squat", Description = "A squat variation that emphasizes core stability and leg strength while reducing forearm strain.", SportId = sports[0].Id},
                // Index => 528
                new Workout { Id = 529, Name ="Swiss Bar Hamstring Curl", Description = "A lower-intensity exercise targeting hamstring strength, suitable for later in workouts.", SportId = sports[0].Id},
                // Index => 529
                new Workout { Id = 530, Name ="Swiss Bar Weighted Push-Up", Description = "Adds resistance to traditional push-ups, increasing difficulty and muscle engagement.", SportId = sports[0].Id},
                // Index => 530
                new Workout { Id = 531, Name ="Swiss Bar Elevated Push-Up", Description = "Similar to weighted push-ups but performed at an angle for increased challenge.", SportId = sports[0].Id},
                // Index => 531
                new Workout { Id = 532, Name ="Swiss Bar Trap Raise", Description = "Focuses on developing upper traps with a neutral grip for comfort during lifting.", SportId = sports[0].Id},

                #endregion

                #region Buffalo Bar
                // Index => 532
                new Workout { Id = 533, Name ="Buffalo Bar Back Squat", Description = "Utilizes the unique curve of the bar to allow for a more natural shoulder position, reducing discomfort while performing squats.", SportId = sports[0].Id},
                // Index => 533
                new Workout { Id = 534, Name ="Buffalo Bar Front Squat", Description = "The design allows the bar to rest comfortably on the shoulders, making it easier to maintain an upright torso during the squat.", SportId = sports[0].Id},
                // Index => 534
                new Workout { Id = 535, Name ="Buffalo Bar Bench Press", Description = "The bend in the bar enables a greater range of motion, allowing for deeper presses that can enhance muscle activation in the chest.", SportId = sports[0].Id},
                // Index => 535
                new Workout { Id = 536, Name ="Buffalo Bar Overhead Press", Description = "This exercise benefits from the neutral grip position, which can reduce shoulder strain compared to traditional overhead pressing.", SportId = sports[0].Id},
                // Index => 536
                new Workout { Id = 537, Name ="Buffalo Bar Lunges", Description = "The bar's design allows for comfortable lunging movements without straining the shoulders, making it ideal for leg workouts.", SportId = sports[0].Id},
                // Index => 537
                new Workout { Id = 538, Name ="Buffalo Bar Good Mornings", Description = "This exercise targets the hamstrings and lower back while providing a stable grip and comfortable positioning on the shoulders.", SportId = sports[0].Id},
                // Index => 538
                new Workout { Id = 539, Name ="Buffalo Bar Romanian Deadlift", Description = "Similar to traditional deadlifts but with improved comfort due to the bar's design, focusing on hamstring and glute engagement.", SportId = sports[0].Id},
                // Index => 539
                new Workout { Id = 540, Name ="Buffalo Bar Skull Crushers", Description = "A triceps exercise that allows for a neutral grip, reducing elbow strain while effectively targeting the triceps.", SportId = sports[0].Id},
                // Index => 540
                new Workout { Id = 541, Name ="Buffalo Bar Bent-Over Row", Description = "This variation allows for a neutral grip, reducing stress on the elbows and shoulders while effectively working the back muscles.", SportId = sports[0].Id},
                // Index => 541
                new Workout { Id = 542, Name ="Buffalo Bar Ab Rollout", Description = "Engages the core effectively while providing stability through the unique grip and positioning of the bar.", SportId = sports[0].Id},
                // Index => 542
                new Workout { Id = 543, Name ="Buffalo Bar Farmer's Walk", Description = "The neutral grip helps maintain shoulder stability while carrying heavy loads, enhancing grip strength and core stability.", SportId = sports[0].Id},
                // Index => 543
                new Workout { Id = 544, Name ="Buffalo Bar Single-Leg Deadlift", Description = "Focuses on unilateral strength development in the hamstrings and glutes while maintaining balance and stability.", SportId = sports[0].Id},
                #endregion
                
                #region Fixed Barbells
                //
                // Index => 544
                new Workout { Id = 545, Name ="Barbell Bench Press", Description = "A fundamental exercise for developing chest, shoulders, and triceps strength.", SportId = sports[0].Id},
                // Index => 545
                new Workout { Id = 546, Name ="Barbell Squat", Description = "Targets the quadriceps, hamstrings, and glutes, essential for lower body strength.", SportId = sports[0].Id},
                // Index => 546
                new Workout { Id = 547, Name ="Barbell Deadlift", Description = "Engages the entire posterior chain, including the back, glutes, and hamstrings.", SportId = sports[0].Id},
                // Index => 547
                new Workout { Id = 548, Name ="Barbell Bent-Over Row", Description = "Focuses on the upper back, lats, and biceps while promoting good posture.", SportId = sports[0].Id},
                // Index => 548
                new Workout { Id = 549, Name ="Barbell Overhead Press", Description = "Strengthens the shoulders and triceps while engaging the core for stability.", SportId = sports[0].Id},
                // Index => 549
                new Workout { Id = 550, Name ="Barbell Curl", Description = "Primarily targets the biceps; variations include standing curls and preacher curls.", SportId = sports[0].Id},
                // Index => 550
                new Workout { Id = 551, Name ="Barbell Skull Crushers", Description = "Isolates the triceps effectively while minimizing strain on the elbows.", SportId = sports[0].Id},
                // Index => 551
                new Workout { Id = 552, Name ="Barbell Front Squat", Description = "Emphasizes the quadriceps and core stability, promoting an upright squat position.", SportId = sports[0].Id},
                // Index => 552
                new Workout { Id = 553, Name ="Barbell Romanian Deadlift", Description = "Targets the hamstrings and glutes, focusing on hip hinge mechanics.", SportId = sports[0].Id},                
                // Index => 553
                new Workout { Id = 554, Name ="Barbell Hip Thrust", Description = "Isolates the glutes for strength development and improved posture.", SportId = sports[0].Id},
                // Index => 554
                new Workout { Id = 555, Name ="Barbell Lunges", Description = "Engages the legs and glutes; can be performed as forward or reverse lunges.", SportId = sports[0].Id},
                // Index => 555
                new Workout { Id = 556, Name ="Barbell High Pull", Description = "A dynamic movement that targets the upper back and shoulders while improving explosiveness.", SportId = sports[0].Id},
                // Index => 556
                new Workout { Id = 557, Name ="Barbell Landmine Press", Description = "Excellent for shoulder stability and strength; performed with one end of the bar secured.", SportId = sports[0].Id},
                // Index => 557
                new Workout { Id = 558, Name ="Barbell Man Maker", Description = "A full-body exercise combining a burpee with a clean and press to elevate heart rate.", SportId = sports[0].Id},
                // Index => 558
                new Workout { Id = 559, Name ="Barbell Reverse Bicep Curl", Description = "Works both the biceps and forearms through an overhand grip for increased grip strength.", SportId = sports[0].Id},
                // Index => 559
                new Workout { Id = 560, Name ="Barbell Push Press", Description = "A powerful overhead movement that engages the legs for momentum in pressing.", SportId = sports[0].Id},
                // Index => 560
                new Workout { Id = 561, Name ="Barbell Zercher Squat", Description = "Holds the bar in the crook of your arms, emphasizing core engagement and leg strength.", SportId = sports[0].Id},
                // Index => 561
                new Workout { Id = 562, Name ="Barbell Farmer's Walk", Description = "Enhances grip strength and core stability while walking with a fixed barbell at your side.", SportId = sports[0].Id},
                // Index => 562
                new Workout { Id = 563, Name ="Barbell Tyre Flip (alternative)", Description = "A functional exercise simulating tire flips using a barbell to engage multiple muscle groups.", SportId = sports[0].Id},
                // Index => 563
                new Workout { Id = 564, Name ="Barbell Abs Rollout", Description = "Utilizes a fixed bar for rolling out to engage core muscles effectively.", SportId = sports[0].Id},
                #endregion

                #region Abdominal
                // Index => 564 / Target => Upper Abs
                new Workout { Id = 565, Name ="Sit-Ups", Description = "Lie on your back with knees bent and feet secured. Raise your torso towards your knees.", SportId = sports[0].Id},
                // Index => 565 / Target => Lower Abs
                new Workout { Id = 566, Name ="Leg Lifts", Description = "Lie flat and lift your legs until perpendicular to the floor, then lower them slowly.", SportId = sports[0].Id},
                // Index => 566 / Target => Upper and Lower Abs
                new Workout { Id = 567, Name ="V-Ups", Description = "Simultaneously raise your legs and torso off the ground, reaching for your toes.", SportId = sports[0].Id},
                // Index => 567 / Target => Lower Abs
                new Workout { Id = 568, Name ="Seated Knee Tucks", Description = "Sit with legs extended, pull your knees to your chest, then return to the starting position.", SportId = sports[0].Id},
                // Index => 568 / Target => Upper and Lower Abs
                new Workout { Id = 569, Name ="Toe Touches", Description = "Lie flat, lift your legs and reach your hands towards your toes.", SportId = sports[0].Id},
                // Index => 569 / Target => Upper Abs
                new Workout { Id = 570, Name ="Crunches", Description = "Curl your torso towards your knees while keeping your lower back on the floor.", SportId = sports[0].Id},
                // Index => 570 / Target => Reverse Crunches
                new Workout { Id = 571, Name ="Upper and Lower Abs", Description = "Pull your knees towards your chest while curling your torso upwards.", SportId = sports[0].Id},
                // Index => 571 / Target => Lower Abs
                new Workout { Id = 572, Name ="Hanging Leg Raises", Description = "Hang from a pull-up bar and raise your legs to a 90-degree angle.", SportId = sports[0].Id},
                // Index => 572 / Target => Upper and Lower Abs
                new Workout { Id = 573, Name ="Cable Crunches", Description = "Kneel at a cable machine and pull the rope down while crunching forward.", SportId = sports[0].Id},
                // Index => 573 / Target => Core Stability
                new Workout { Id = 574, Name ="Plank", Description = "Hold a push-up position with a straight body line, engaging the core.", SportId = sports[0].Id},
                // Index => 574 / Target => Obliques
                new Workout { Id = 575, Name ="Woodchoppers", Description = "Use a cable or resistance band to simulate chopping wood across your body.", SportId = sports[0].Id},
                // Index => 575 / Target => Core Stability
                new Workout { Id = 576, Name ="Ab Rollouts", Description = "Roll out on an ab wheel or barbell from a kneeling position, extending forward.", SportId = sports[0].Id},
                // Index => 576 / Target => Core Stability and Mobility
                new Workout { Id = 577, Name ="Spider Crawls", Description = "Crawl forward on all fours while maintaining tight abs.", SportId = sports[0].Id},
                // Index => 577 / Target => Full Core Engagement
                new Workout { Id = 578, Name ="Sledgehammer Swings", Description = "Swing a sledgehammer against a tire or similar object, engaging the core throughout.", SportId = sports[0].Id},
                // Index => 578 / Target => Obliques and Upper Abs
                new Workout { Id = 579, Name ="Cross-Body Crunches (Bicycle crunches)", Description = "Perform crunches while bringing opposite elbow to knee in a twisting motion.", SportId = sports[0].Id},
                // Index => 579 / Target => Lower Abs
                new Workout { Id = 580, Name ="Decline Reverse Crunches", Description = "Use a decline bench to perform reverse crunches for added difficulty.", SportId = sports[0].Id},
                // Index => 580 / Target => Bottoms Up (Hip Raise)
                new Workout { Id = 581, Name ="Lower Abs and Glutes", Description = "Lying on your back, raise hips off the ground while keeping legs extended.", SportId = sports[0].Id},
                // Index => 581 / Target => Obliques
                new Workout { Id = 582, Name ="Russian Twists", Description = "Sit with knees bent, lean back slightly, and twist from side to side holding a weight.", SportId = sports[0].Id},
                // Index => 582 / Target => Full Core Engagement and Cardio
                new Workout { Id = 583, Name ="Mountain Climbers", Description = "In a plank position, alternate bringing knees toward the chest quickly.", SportId = sports[0].Id},
                // Index => 583 / Target => Lower Abs
                new Workout { Id = 584, Name ="Flutter Kicks", Description = "Lie on your back and alternate kicking legs up and down while keeping them straight.", SportId = sports[0].Id},
                // Index => 584 / Target =>
                new Workout { Id = 585, Name ="Side plank", Description = "", SportId = sports[0].Id},
                // Index => 585 / Target =>
                new Workout { Id = 586, Name ="Scissor kicks", Description = "", SportId = sports[0].Id},
                // Index => 586 / Target =>
                new Workout { Id = 587, Name ="Copenhagen plank", Description = "", SportId = sports[0].Id},
                // Index => 587 / Target =>
                new Workout { Id = 588, Name ="Hollow hold", Description = "", SportId = sports[0].Id},
                // Index => 588 / Target =>
                new Workout { Id = 589, Name ="Squat", Description = "", SportId = sports[0].Id},
                // Index => 589 / Target =>
                new Workout { Id = 590, Name ="Barbell rollout", Description = "", SportId = sports[0].Id},
                // Index => 590 / Target =>
                new Workout { Id = 591, Name ="Swiss ball crunch", Description = "", SportId = sports[0].Id},
                // Index => 591 / Target =>
                new Workout { Id = 592, Name ="Deadbug", Description = "", SportId = sports[0].Id},
                // Index => 582 / Target =>
                new Workout { Id = 593, Name ="Cable crunch", Description = "", SportId = sports[0].Id},
                // Index => 583 / Target =>
                new Workout { Id = 594, Name ="Reverse crunch", Description = "", SportId = sports[0].Id},
                // Index => 584 / Target =>
                new Workout { Id = 595, Name ="Bird dog exercise", Description = "", SportId = sports[0].Id},
                // Index => 585 / Target =>
                new Workout { Id = 596, Name ="Flutter kick", Description = "", SportId = sports[0].Id},
                // Index => 586 / Target =>
                new Workout { Id = 597, Name ="Toe touchers", Description = "", SportId = sports[0].Id},
                // Index => 587 / Target =>
                new Workout { Id = 598, Name ="Dead bug", Description = "", SportId = sports[0].Id},
                // Index => 598 / Target =>
                new Workout { Id = 599, Name ="Crunch", Description = "", SportId = sports[0].Id},
                // Index => 599 / Target =>
                new Workout { Id = 600, Name ="Horizontal Cable Woodchop", Description = "", SportId = sports[0].Id},
                #endregion

            };

            // Workouts according to Body...
            workouts = new List<Workout>
            {
                #region Pectoralis Major
                // 
                // Index => 600
                new Workout { Id = 601, Name="Incline Dumbbell Bench Press", Description= "Focuses on the upper part of the pectoralis major. / Set an incline bench at 30-45 degrees, press dumbbells from shoulder height upwards.", SportId= sports[0].Id },
                // Index => 601
                new Workout { Id = 602, Name="Decline Bench Press", Description= "Targets the lower portion of the pectoralis major. / Execution: Lie on a decline bench and press a barbell or dumbbells upward.", SportId= sports[0].Id },
                // Index => 602
                new Workout { Id = 603, Name="Cable Crossovers", Description="Excellent for isolating the pecs with variations targeting different angles. / Execution: Stand between two cable machines and pull the cables together in front of you at various heights (low to high and high to low) to engage different parts of the muscle.", SportId= sports[0].Id},
                // Index => 603
                new Workout { Id = 604, Name="Dumbbell Flyes", Description="Isolates the pectoralis major effectively. Execution: Lie on a flat or incline bench with dumbbells in hand, arms extended above, lower them out to the sides in a wide arc, then bring them back together.", SportId= sports[0].Id},
                // Index => 604
                new Workout { Id = 605, Name="Push-Ups (Standard and Variations)", Description="Bodyweight exercise that engages the pecs significantly. / Variations include close-grip push-ups for inner pecs and elevated push-ups for added difficulty.", SportId= sports[0].Id},
                // Index => 605
                new Workout { Id = 606, Name="Kettlebell Fly", Description="A variation that provides dynamic movement and stability work. /  Perform as you would with dumbbells but using kettlebells for added challenge.", SportId= sports[0].Id},
                // Index => 606
                new Workout { Id = 607, Name="Guillotine Press", Description="A unique variation that targets the upper chest. / Execution: Lower a barbell towards your neck instead of your chest while lying on a flat bench.", SportId= sports[0].Id},
                // Index => 607
                new Workout { Id = 608, Name="180-Degree Twisting Dumbbell Bench Press", Description="Engages both heads of the pectoralis major through rotation. / Lower dumbbells to your sides while twisting palms inward at the top of the movement.", SportId= sports[0].Id},
                // Index => 608
                new Workout { Id = 609, Name="Standing Cable Chest Fly", Description="Provides constant tension throughout the movement. / Execution: Stand with cables at shoulder height and perform fly movements similar to dumbbell flyes.", SportId= sports[0].Id},
                // Index => 609
                new Workout { Id = 610, Name="Resistance Band Push-Ups", Description="Adds resistance to traditional push-ups, enhancing pec activation. / Execution: Place bands across your back and hold them under your hands while performing push-ups.", SportId= sports[0].Id},

                #endregion

                #region Pectoralis Minor
                // Index => 610
                new Workout { Id = 611, Name="Dips", Description="Dips are excellent for targeting both the pectoralis major and minor./ Use parallel bars, lean slightly forward, and lower your body by bending your elbows until you feel a stretch in your chest, then press back up.", SportId= sports[0].Id},
                // Index => 611
                new Workout { Id = 612, Name="Cable Crossovers (Low to High)", Description="This exercise emphasizes the upper portion of the chest, engaging the pec minor. / Execution: Set the cables at the lowest position, grab the handles with palms facing up, and pull them upward in a scooping motion until they meet at eye level.", SportId= sports[0].Id},
                // Index => 612
                new Workout { Id = 613, Name="Cable Crossovers (High to Low)", Description="Targets the lower part of the pectoralis major but also engages the pec minor./ Execution: Set cables at a high position and pull them down towards your core using a neutral grip.", SportId= sports[0].Id},
                // Index => 613
                new Workout { Id = 614, Name="Incline Dumbbell Press", Description="Focuses on the upper chest while also engaging the pec minor. / Execution: Set an incline bench at 30-45 degrees, press dumbbells from shoulder height upwards.", SportId= sports[0].Id},
                // Index => 614
                new Workout { Id = 615, Name="Push-Ups (with Forward Lean)", Description="A bodyweight exercise that can effectively engage the pec minor. / Execution: Perform standard push-ups but lean forward during the movement to increase involvement of the pecs.", SportId= sports[0].Id},
                // Index => 615
                new Workout { Id = 616, Name="Serratus Punches", Description="While primarily targeting the serratus anterior, this exercise also activates the pec minor. / Execution: Stand or kneel with weights in hand and punch forward while keeping your elbow slightly bent.", SportId= sports[0].Id},
                // Index => 616
                new Workout { Id = 617, Name="Modified Push-Up Plus", Description="Enhances activation of both pectoral muscles while focusing on scapular stability. / Execution: Perform a standard push-up but add an extra push at the top to protract your shoulder blades.", SportId= sports[0].Id},
                // Index => 617
                new Workout { Id = 618, Name="Front Raises with Dumbbells", Description="Engages shoulder muscles while indirectly working on pec minor stabilization. / Execution: Hold dumbbells at your sides and raise them straight in front of you to shoulder height.", SportId= sports[0].Id},
                #endregion

                #region Chest
                // Index => 618
                new Workout { Id = 619, Name="Cable Flyes (Low to High)", Description="Engages different angles of the chest. / Execution: Set cables at a low position, pull them upward in front of you", SportId= sports[0].Id},
                // Index => 619
                new Workout { Id = 620, Name="Cable Flyes (High to Low)", Description="Targets lower pecs while also engaging the pectoralis minor. / Execution: Set cables at a high position and pull them down towards your core.", SportId= sports[0].Id},
                // Index => 620
                new Workout { Id = 621, Name="Plyometric Push-Ups", Description="xplosive movement that targets fast-twitch muscle fibers in the chest. / Perform standard push-ups but push off explosively so your hands leave the ground.", SportId= sports[0].Id},
                // Index => 621
                new Workout { Id = 622, Name="Half-Kneeling Cable Chest Press", Description="Engages core muscles while focusing on one side of the chest./ Kneel with one leg forward and press a cable out in front of you.", SportId= sports[0].Id},
                #endregion

                #region Back                
                // Index => 622
                new Workout { Id = 623, Name="Single-Arm Dumbbell Row", Description=" Unilateral exercise that focuses on independent contractions of each side of the back, allowing for deeper engagement of core musculature.", SportId= sports[0].Id},
                // Index => 623
                new Workout { Id = 624, Name="Chest-Supported Dumbbell Row", Description="Places less strain on the lower back while maintaining significant engagement of upper back muscles", SportId= sports[0].Id},
                // Index => 624
                new Workout { Id = 625, Name="Renegade Row", Description="Combines a plank position with alternating rows, emphasizing trap and lat activation.", SportId= sports[0].Id},
                // Index => 625
                new Workout { Id = 626, Name="Seated Row", Description="Often done with either a machine or dumbbells, this exercise targets the mid-to-lower back regions, including the latissimus dorsi and trapezius muscles", SportId= sports[0].Id},
                // Index => 626
                new Workout { Id = 627, Name="Superman Exercise", Description="Engages mid-back muscles along with rotator cuff muscles without needing equipment.", SportId= sports[0].Id},
                // Index => 627
                new Workout { Id = 628, Name="Med Ball Wood Chop", Description="Incorporates rotational forces to engage obliques and mid-back muscles simultaneously", SportId= sports[0].Id},
                // Index => 628                
                new Workout { Id = 629, Name="Scapula Shrug", Description="Directly targets the trapezius muscles, contributing to overall back thickness and definition", SportId= sports[0].Id},
                // Index => 629
                new Workout { Id = 630, Name="Band Pull-apart", Description="Helps maintain scapular stability and engages the broader back region, including the rhomboids and levators scapulae", SportId= sports[0].Id},
                // Index => 630
                new Workout { Id = 631, Name="Good Morning Exercise", Description="Though traditionally considered a hip extension exercise, it does contribute to activating certain portions of the lumbar extensors which play a supportive role in back health and aesthetics", SportId= sports[0].Id},
                #endregion

                #region Upper Back                
                // Index => 631
                new Workout { Id = 632, Name="Face Pulls", Description="Excellent for targeting the rear deltoids and upper traps. / Execution: Use a cable machine set at face height, pull the rope towards your face while keeping elbows high.", SportId= sports[0].Id},
                // Index => 632
                new Workout { Id = 633, Name="Dumbbell Flyes (Reverse)", Description="Targets the rear deltoids and upper back muscles. / Execution: Bend at the hips, hold dumbbells with palms facing each other, and lift them out to the sides.", SportId= sports[0].Id},
                // Index => 633
                new Workout { Id = 634, Name="Inverted Rows", Description="Bodyweight exercise that targets the entire upper back. / Execution: Set a barbell in a squat rack at waist height; lie underneath it and pull your chest to the bar.", SportId= sports[0].Id},
                // Index => 634
                new Workout { Id = 635, Name="Dumbbell Pullovers", Description="Although primarily targeting the chest, this exercise also engages the lats effectively. / Execution: Lie on a bench, hold a dumbbell above your chest, and lower it behind your head before bringing it back up.", SportId= sports[0].Id},
                #endregion
                
                #region Middle Back
                // Index => 635
                new Workout { Id = 636, Name="Cable Face Pull", Description="Targets the upper traps and rear deltoids, contributing to overall upper back development. / Execution: Use a cable machine set at face height, pull the rope towards your face with elbows high.", SportId= sports[0].Id},
                // Index => 636
                new Workout { Id = 637, Name="Seal Row", Description="A variation that minimizes lower back strain while targeting the mid-back. / Execution: Lie face down on a bench with arms hanging down, pull dumbbells towards your chest.", SportId= sports[0].Id},
                // Index => 637
                new Workout { Id = 638, Name="Hammer Iso Row", Description="Ideal for isolating the middle back with controlled movements. / Execution: Sit on a machine with your chest against the pad, pull handles towards your body while keeping elbows close.", SportId= sports[0].Id},
                // Index => 638
                new Workout { Id = 639, Name="Reverse Grip Barbell Row", Description="Changes grip to emphasize different parts of the mid-back. / Execution: Perform as you would with a standard bent-over row but with an underhand grip.", SportId= sports[0].Id},
                // Index => 639
                new Workout { Id = 640, Name="Incline Dumbbell Row", Description="Chest-supported variation that allows for higher rep training. / Execution: Lie on an incline bench and row dumbbells towards your sides.", SportId= sports[0].Id},
                // Index => 640
                new Workout { Id = 641, Name="Prone Cobra", Description="Strengthens mid-back muscles while improving posture. / Execution: Lie face down, lift your chest off the ground while pinching shoulder blades together, and hold for several seconds.", SportId= sports[0].Id},
                // Index => 641
                new Workout { Id = 642, Name="Unilateral Band Row", Description="Enhances unilateral strength and stability in the middle back. / Execution: Attach a resistance band at waist height, stand facing away, and pull one arm back while keeping your core engaged.", SportId= sports[0].Id},
                // Index => 642
                new Workout { Id = 643, Name="Meadow Landmine Row", Description="Targets the mid-back with an emphasis on range of motion. / Execution: Stand next to a landmine setup, grab the bar with one hand, and row it towards your hip.", SportId= sports[0].Id},
                #endregion

                #region latissimus dorsi (lats),
                // Index => 643
                new Workout { Id = 644, Name="Meadow Landmine Row", Description="Utilizes a landmine attachment for unique angles of resistance targeting the lats. / Execution: Stand over a landmine, grip it with both hands, and row towards your body.", SportId= sports[0].Id},                
                // Index => 644
                new Workout { Id = 645, Name="One-Arm Cable Pulldown", Description="Isolates each lat individually for better muscle engagement. / Execution: Use a cable machine with a single handle; pull down towards your hip while keeping your core engaged.", SportId= sports[0].Id},                
                // Index => 645
                new Workout { Id = 646, Name="Plank Rows (Renegade Rows)", Description="Engages core stability while working on lat strength. / Execution: In a plank position with dumbbells, row one weight at a time towards your hip.", SportId= sports[0].Id},
                #endregion
                
                // Index => 646
                new Workout { Id = 647, Name="", Description="", SportId= sports[0].Id},
                // Index => 647
                new Workout { Id = 648, Name="", Description="", SportId= sports[0].Id},
                // Index => 648
                new Workout { Id = 649, Name="", Description="", SportId= sports[0].Id},
                // Index => 649
                new Workout { Id = 650, Name="", Description="", SportId= sports[0].Id},
                // Index => 650
                new Workout { Id = 651, Name="", Description="", SportId= sports[0].Id},
                

                #region latissimus dorsi (lats),
                // Index => 651
                new Workout { Id = 652, Name="", Description="", SportId= sports[0].Id},
                // Index => 652
                new Workout { Id = 653, Name="", Description="", SportId= sports[0].Id},
                // Index => 653
                new Workout { Id = 654, Name="", Description="", SportId= sports[0].Id},
                // Index => 654
                new Workout { Id = 655, Name="", Description="", SportId= sports[0].Id},
                // Index => 655
                new Workout { Id = 656, Name="", Description="", SportId= sports[0].Id},
                // Index => 656
                new Workout { Id = 657, Name="", Description="", SportId= sports[0].Id},
                // Index => 657
                new Workout { Id = 658, Name="", Description="", SportId= sports[0].Id},
                // Index => 658
                new Workout { Id = 659, Name="", Description="", SportId= sports[0].Id},
                // Index => 659
                new Workout { Id = 660, Name="", Description="", SportId= sports[0].Id},
                // Index => 660
                new Workout { Id = 661, Name="", Description="", SportId= sports[0].Id},
                // Index => 661
                new Workout { Id = 662, Name="", Description="", SportId= sports[0].Id},
                // Index => 662
                new Workout { Id = 663, Name="", Description="", SportId= sports[0].Id},

                #endregion


            };

            await context.Workouts.AddRangeAsync(workouts);
            await context.SaveChangesAsync();
        }

        if (!context.BodyWorkouts.Any())
        {
            var bodyWorkouts = new List<BodyWorkout>
            {
                #region Chest
                new BodyWorkout { WorkoutId = workouts[22].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[163].Id, BodyId = bodies[0].Id },                
                new BodyWorkout { WorkoutId = workouts[161].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[614].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[601].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[603].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[610].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[605].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[4].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[606].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[174].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[618].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[619].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[620].Id, BodyId = bodies[0].Id },
                new BodyWorkout { WorkoutId = workouts[621].Id, BodyId = bodies[0].Id },
                #endregion

                #region Pectoralis Major
                new BodyWorkout { WorkoutId = workouts[0].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[22].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[600].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[601].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[602].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[603].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[243].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[604].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[605].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[606].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[607].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[608].Id, BodyId = bodies[1].Id },
                new BodyWorkout { WorkoutId = workouts[609].Id, BodyId = bodies[1].Id },
                #endregion

                #region Pectoralis Minor
                new BodyWorkout { WorkoutId = workouts[12].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[610].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[611].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[612].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[613].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[614].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[615].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[616].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[617].Id, BodyId = bodies[2].Id },
                new BodyWorkout { WorkoutId = workouts[374].Id, BodyId = bodies[2].Id },
                #endregion

                #region Back
                new BodyWorkout { WorkoutId = workouts[29].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[26].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[111].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[352].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[447].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[622].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[623].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[624].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[625].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[626].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[627].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[628].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[629].Id, BodyId = bodies[3].Id },
                new BodyWorkout { WorkoutId = workouts[630].Id, BodyId = bodies[3].Id },
                #endregion

                #region Upper Back
                new BodyWorkout { WorkoutId = workouts[239].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[111].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[547].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[3].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[136].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[631].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[632].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[235].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[622].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[465].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[633].Id, BodyId = bodies[4].Id },
                new BodyWorkout { WorkoutId = workouts[634].Id, BodyId = bodies[4].Id },
                #endregion

                #region Middle Back 
                new BodyWorkout { WorkoutId = workouts[26].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[3].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[136].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[380].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[622].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[633].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[635].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[636].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[637].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[638].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[639].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[640].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[641].Id, BodyId = bodies[5].Id },
                new BodyWorkout { WorkoutId = workouts[642].Id, BodyId = bodies[5].Id },
                #endregion

                #region Latissimus Dorsi (Lats)
                new BodyWorkout { WorkoutId = workouts[239].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[111].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[547].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[3].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[622].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[136].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[634].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[144].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[235].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[631].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[633].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[643].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[644].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[645].Id, BodyId = bodies[7].Id },

                #endregion



                #region MyRegion
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                new BodyWorkout { WorkoutId = workouts[28].Id, BodyId = bodies[7].Id },
                #endregion

            };
            await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
            await context.SaveChangesAsync();
        }

        if (!context.WorkoutEquipment.Any())
        {
            var workoutEquipments = new List<WorkoutEquipment>
            {
                #region Dumbells
                // Chest // Dumbells
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[11].Id },
                new WorkoutEquipment { WorkoutId = workouts[1].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[2].Id, EquipmentId = equipments[1].Id },
                new WorkoutEquipment { WorkoutId = workouts[2].Id, EquipmentId = equipments[12].Id },

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

                #region Barbells
                // Chest // Barbells
                new WorkoutEquipment { WorkoutId = workouts[22].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[22].Id, EquipmentId = equipments[11].Id },

                new WorkoutEquipment { WorkoutId = workouts[23].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[23].Id, EquipmentId = equipments[11].Id },

                new WorkoutEquipment { WorkoutId = workouts[24].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[24].Id, EquipmentId = equipments[11].Id },

                new WorkoutEquipment { WorkoutId = workouts[25].Id, EquipmentId = equipments[2].Id },

                // Back // Barbells
                new WorkoutEquipment { WorkoutId = workouts[26].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[27].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[28].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[29].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[30].Id, EquipmentId = equipments[2].Id },

                // Shoulders // Barbells
                new WorkoutEquipment { WorkoutId = workouts[31].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[32].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[33].Id, EquipmentId = equipments[2].Id },

                // Arms // Barbells
                new WorkoutEquipment { WorkoutId = workouts[34].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[35].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[36].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[37].Id, EquipmentId = equipments[2].Id },

                // Core Workouts // Barbells
                new WorkoutEquipment { WorkoutId = workouts[38].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[39].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[40].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[41].Id, EquipmentId = equipments[2].Id },

                // Lower Body // Barbells
                new WorkoutEquipment { WorkoutId = workouts[42].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[43].Id, EquipmentId = equipments[2].Id },

                // Full Body Workouts // Barbells
                new WorkoutEquipment { WorkoutId = workouts[44].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[45].Id, EquipmentId = equipments[2].Id },

                #endregion

                #region KettleBells
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[3].Id },

                #endregion

                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[2].Id },
                new WorkoutEquipment { WorkoutId = workouts[0].Id, EquipmentId = equipments[2].Id },

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
