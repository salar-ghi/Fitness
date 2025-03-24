namespace Presentation.Seed;

public static class BackWorkoutDbInitializer
{
    public static async Task BackWorkoutSeedAsync(FitnessContext context)
    {
        var backWorkouts = new List<Workout>();
        
        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        backWorkouts = new List<Workout>
        {
            // Traps (mid-back) // Barbell
            new Workout{ Name = "Barbell Landmine Row", SportId = bodybuildingId, Description = "" },                                   // index => 0
            new Workout{ Name = "Barbell Deadlift", SportId = bodybuildingId, Description = "" },                                       // index => 1
            new Workout{ Name = "Barbell High Pull", SportId = bodybuildingId, Description = "" },                                      // index => 2
            new Workout{ Name = "Barbell Snatch Grip High Pull", SportId = bodybuildingId, Description = "" },                          // index => 3

            new Workout{ Name = "Machine Seated Cable Row", SportId = bodybuildingId, Description = "" },                               // index => 4
            new Workout{ Name = "Narrow Pulldown", SportId = bodybuildingId, Description = "" },                                        // index => 5
            new Workout{ Name = "Neutral Pulldown", SportId = bodybuildingId, Description = "" },                                       // index => 6
            new Workout{ Name = "Machine Plate Loaded Low Row", SportId = bodybuildingId, Description = "" },                           // index => 7

            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                                       // index => 8
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                                       // index => 9
            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                                       // index => 10

            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                                       // index => 10
        };
        await context.Workouts.AddRangeAsync(backWorkouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var backWorkoutInstruction = new List<WorkoutInstruction>();
        backWorkoutInstruction = new List<WorkoutInstruction>
        {
            #region Traps & Barbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 2 , Instruction = "Grasp the end of the barbell with a neutral grip, keeping your arms straight and your shoulders relaxed."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 1 , Instruction = "Stand with your mid-foot under the bar and grip the bar with your hands, about a shoulder width apart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 2 , Instruction = "Bend your knees, then lift the bar by straightening your back. It is important to keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 3 , Instruction = "Stand to your full height and hold."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[1].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[2].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, grip the barbell slightly wider than shoulder-width, and keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[2].Id , Step = 2 , Instruction = "Drive through your legs, extending your hips, knees, and ankles explosively while pulling the barbell upward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[2].Id , Step = 3 , Instruction = "As the bar rises, pull it close to your body, leading with your elbows until it reaches chest level."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, gripping the barbell with a wide (snatch-width) grip. Keep your back straight, chest up, and bar close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 2 , Instruction = "Drive through your legs, extending your hips, knees, and ankles while pulling the barbell up explosively."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 3 , Instruction = "Shrug your shoulders forcefully and pull the bar as high as possible, keeping elbows above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[3].Id , Step = 4 , Instruction = "Lower the bar back to the starting position in a controlled manner and reset for the next rep."},
            #endregion

            #region Traps & Machine
            new WorkoutInstruction{ WorkoutId = backWorkouts[4].Id , Step = 1 , Instruction = "Sit with your back straight on the machine and grip the handles."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[4].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Your legs and torso should be at a 90° angle. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[4].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[5].Id , Step = 1 , Instruction = "Use the Straight Bar attachment."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[5].Id , Step = 1 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[5].Id , Step = 1 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[6].Id , Step = 1 , Instruction = "Use the V Bar attachment."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[6].Id , Step = 1 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[6].Id , Step = 1 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[7].Id , Step = 1 , Instruction = "Press your chest into the chest pad and grab the horizontal handles with an overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[7].Id , Step = 1 , Instruction = "Pull the handles toward you, make sure your elbows stay flared out."},
            #endregion

            new WorkoutInstruction{ WorkoutId = backWorkouts[0].Id , Step = 1 , Instruction = ""},
        };
        await context.WorkoutInstructions.AddRangeAsync(backWorkoutInstruction);
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

        workoutEquipment = new List<WorkoutEquipment>
        {
            #region Traps & Barbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[0].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[1].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[2].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[3].Id, EquipmentId = barbellId },
            #endregion

            #region Traps & Machine
            new WorkoutEquipment{ WorkoutId = backWorkouts[4].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[5].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[6].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[7].Id, EquipmentId = machineId },
            #endregion

            new WorkoutEquipment{ WorkoutId = backWorkouts[3].Id, EquipmentId = barbellId },
        };
        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        workoutLevel = new List<WorkoutLevel>
        {
            #region Traps & Barbell
            new WorkoutLevel{ WorkoutId = backWorkouts[0].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[1].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[2].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[3].Id , Level = Difficulty.Intermediate},
            #endregion

            #region Traps & Machine
            new WorkoutLevel{ WorkoutId = backWorkouts[4].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[5].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[6].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[7].Id , Level = Difficulty.Novice},
            #endregion

        };
        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //

        var bodyWorkouts = new List<BodyWorkout>();
        var backId = await context.Bodies.Where(z => z.Name == "Back").Select(z => z.Id).FirstOrDefaultAsync();
        var upperBackId = await context.Bodies.Where(z => z.Name == "Upper Back (Upper Traps)").Select(z => z.Id).FirstOrDefaultAsync();
        var trapsId = await context.Bodies.Where(z => z.Name == "Trapezius (Traps)").Select(z => z.Id).FirstOrDefaultAsync();
        var lowerBackId = await context.Bodies.Where(z => z.Name == "Lower Back (Lower Traps)").Select(z => z.Id).FirstOrDefaultAsync();

        bodyWorkouts = new List<BodyWorkout>
        {
            #region Traps & Barbell
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[0].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[2].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[3].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Machine
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[4].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[5].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[6].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[7].Id, Target = PriorityTarget.Primary },
            #endregion
        };
        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        workoutSex = new List<WorkoutSex>
        {
            #region Traps & Barbell
            new WorkoutSex{ WorkoutId = backWorkouts[0].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[0].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[1].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[1].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[2].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[2].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[3].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[3].Id, Sex = Sex.Female},
            #endregion

            #region Traps & Machine
            #endregion

        };
        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}
