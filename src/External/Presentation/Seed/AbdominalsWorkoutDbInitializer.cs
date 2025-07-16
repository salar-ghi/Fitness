namespace Presentation.Seed;

public class AbdominalsWorkoutDbInitializer
{
    //private readonly FitnessContext _context;

    //public AbdominalsWorkoutDbInitializer(FitnessContext context)
    //{
    //    _context = context;
    //}

    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        var Workouts = new List<Workout>();

        var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
        var cardioSportId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
        var crossfitId = await context.Sports.Where(s => s.Name == "Cross Fit").Select(z => z.Id).FirstOrDefaultAsync();
        var yogaSportId = await context.Sports.Where(s => s.Name == "Yoga").Select(z => z.Id).FirstOrDefaultAsync();

        Workouts = new List<Workout>
        {
            // Abdominals // Barbell
            new Workout{ Name = "Barbell Roll Outs", SportId = bodybuildingId, Description = "" },                                      // index => 0
            new Workout{ Name = "Barbell Situp", SportId = bodybuildingId, Description = "" },                                          // index => 1
            new Workout{ Name = "Barbell Larsen Bench Press", SportId = bodybuildingId, Description = "" },                             // index => 2
            new Workout{ Name = "Landmine Hollow Hold", SportId = bodybuildingId, Description = "" },                                   // index => 3
            new Workout{ Name = "Landmine Sit Up", SportId = bodybuildingId, Description = "" },                                        // index => 4
            new Workout{ Name = "Barbell Front Squat Olympic", SportId = bodybuildingId, Description = "" },                            // index => 5
            new Workout{ Name = "Barbell Hooklying Bench Press", SportId = bodybuildingId, Description = "" },                          // index => 6

            // Abdominals // Machine
            new Workout{ Name = "Machine Roll Outs", SportId = bodybuildingId, Description = "" },                                      // index => 7
            new Workout{ Name = "Rower Knee Tuck", SportId = bodybuildingId, Description = "" },                                        // index => 8
            new Workout{ Name = "Rower Pike", SportId = bodybuildingId, Description = "" },                                             // index => 9
            new Workout{ Name = "Machine Plate Loaded Crunch", SportId = bodybuildingId, Description = "" },                            // index => 10
            new Workout{ Name = "Machine Crunch", SportId = bodybuildingId, Description = "" },                                         // index => 11

            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                                   // index => 10
        };
        await context.Workouts.AddRangeAsync(Workouts);
        await context.SaveChangesAsync();

        // ***************************************************************** //
        var backWorkoutInstruction = new List<WorkoutInstruction>();
        backWorkoutInstruction = new List<WorkoutInstruction>
        {
            #region Abdominals & Barbell
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 1 , Instruction = "Hold the Barbell with both hands and kneel on the floor with your feet up"},
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 2 , Instruction = "Slowly roll the Barbell straight forward, stretching your body into a straight position."},
            new WorkoutInstruction{ WorkoutId = Workouts[0].Id , Step = 3 , Instruction = "After a pause at the stretched position, start pulling yourself back to the starting position. This should be a slow and controlled movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 1 , Instruction = "Hold the bar with a slightly wider than shoulder width grip. Push the bar up toward the ceiling and maintain that elbow extension."},
            new WorkoutInstruction{ WorkoutId = Workouts[1].Id , Step = 2 , Instruction = "Flex your abs and sit-up. Aim to get your torso vertical while maintaining the barbell overhead."},

            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 1 , Instruction = "Start in a bench press position with your legs elevated. Try to keep your knees with a slight bend in them."},
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 2 , Instruction = "Unrack the bar then initiate the rep."},
            new WorkoutInstruction{ WorkoutId = Workouts[2].Id , Step = 3 , Instruction = "Bring the bar to your torso and tap your ribcage before pressing back to the ceiling."},

            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 1 , Instruction = "Start by lying flat on your back with your legs extended towards the landmine attachment and your arms overhead, holding the landmine barbell with both hands while engaging your core muscles by pressing your lower back into the ground and drawing your belly button in towards your spine."},
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 2 , Instruction = "Lift your legs off the ground, keeping them together and straight, and simultaneously raise your upper body off the ground, reaching the landmine barbell away from your face."},
            new WorkoutInstruction{ WorkoutId = Workouts[3].Id , Step = 3 , Instruction = "Hold this position for the desired duration, then carefully lower the barbell to the ground."},

            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 1 , Instruction = "Lay flat on the ground and hold the end of the bar with your arms extended."},
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 2 , Instruction = "Raise your back off the ground until you are sitting at a 90 degree angle."},
            new WorkoutInstruction{ WorkoutId = Workouts[4].Id , Step = 3 , Instruction = "Then lower slowly back to the floor."},

            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 1 , Instruction = "Measure your hands by the markings on the bar to make sure you're even. Then throw your elbows underneath the bar."},
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 2 , Instruction = "The bar should be set so high on your shoulders it digs into your neck a bit. Make sure to push your elbows up to the ceiling for the entire rep. To make sure you don't get too pitched forward."},
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 3 , Instruction = "Use the squat stance you would use for a back or goblet squat. Push your hips back to initiate the squat. Break at the knees until you hit parallel depth."},
            new WorkoutInstruction{ WorkoutId = Workouts[5].Id , Step = 4 , Instruction = "Squat back up to a standing position."},

            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 1 , Instruction = "Start in a bench press position with your feet planted on the bench and knees bent."},
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 2 , Instruction = "Grasp the barbell with an overhand grip, positioning your hands slightly wider than shoulder-width apart."},
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 3 , Instruction = "Lift the barbell off the rack and lower it to your chest, keeping your elbows close to your sides."},
            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 4 , Instruction = "Push the barbell back up to the starting position, fully extending your arms."},
            #endregion

            #region Abdominals && Machine
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 1 , Instruction = "Hold the Ab Roller with both hands and kneel on the floor with your feet up and crossed."},
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 2 , Instruction = "Slowly roll the ab roller straight forward, stretching your body into a straight position."},
            new WorkoutInstruction{ WorkoutId = Workouts[7].Id , Step = 3 , Instruction = "After a pause at the stretched position, start pulling yourself back to the starting position. This should be a slow and controlled movement."},

            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 1 , Instruction = "Place your feet on the rower seat and get in to a hand plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[8].Id , Step = 2 , Instruction = "Pull your knees to your chest and flex your abs."},

            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 1 , Instruction = "Place your feet on the rower seat and get in to a plank position."},
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 2 , Instruction = "Pull your hips straight up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = Workouts[9].Id , Step = 3 , Instruction = "Lower your hips until you're back in a plank position."},

            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 1 , Instruction = "Place your feet under the foot pads and grab the handles with your hands."},
            new WorkoutInstruction{ WorkoutId = Workouts[10].Id , Step = 2 , Instruction = "Flex your spine and bring your upper and lower body together."},

            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 1 , Instruction = "Place your feet under the foot pads and grab the handles with your hands."},
            new WorkoutInstruction{ WorkoutId = Workouts[11].Id , Step = 2 , Instruction = "Flex your spine and bring your upper and lower body together."},
            #endregion

            new WorkoutInstruction{ WorkoutId = Workouts[6].Id , Step = 1 , Instruction = ""},

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
            #region Abdominals & Barbell
            new WorkoutEquipment{ WorkoutId = Workouts[0].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[1].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[2].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[3].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[4].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[5].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = Workouts[6].Id, EquipmentId = barbellId },
            #endregion

            #region Abdominals && Machine
            new WorkoutEquipment{ WorkoutId = Workouts[7].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[8].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[9].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[10].Id, EquipmentId = machineId },
            new WorkoutEquipment{ WorkoutId = Workouts[11].Id, EquipmentId = machineId },
            #endregion
        };
        await context.WorkoutEquipment.AddRangeAsync(workoutEquipment);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutLevel = new List<WorkoutLevel>();
        workoutLevel = new List<WorkoutLevel>
        {
            #region Abdominals & Barbell
            new WorkoutLevel{ WorkoutId = Workouts[0].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[1].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[2].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[3].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[4].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[5].Id , Level = Difficulty.Advanced},
            new WorkoutLevel{ WorkoutId = Workouts[6].Id , Level = Difficulty.Advanced},
            #endregion

            #region Abdominals && Machine
            new WorkoutLevel{ WorkoutId = Workouts[7].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[8].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = Workouts[9].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = Workouts[10].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = Workouts[11].Id , Level = Difficulty.Novice},
            #endregion
        };
        await context.WorkoutLevels.AddRangeAsync(workoutLevel);
        await context.SaveChangesAsync();

        // ***************************************************************** //

        var bodyWorkouts = new List<BodyWorkout>();
        var AbdoId = await context.Bodies.Where(z => z.Name == "Abdominals").Select(z => z.Id).FirstOrDefaultAsync();

        bodyWorkouts = new List<BodyWorkout>
        {
            #region Abdominals & Barbell
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[0].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[2].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[3].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[4].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[5].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[6].Id, Target = PriorityTarget.Tertiary },
            #endregion

            #region Abdominals && Machine
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[7].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[8].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[9].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[10].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = AbdoId, WorkoutId = Workouts[11].Id, Target = PriorityTarget.Primary },
            #endregion

        };
        await context.BodyWorkouts.AddRangeAsync(bodyWorkouts);
        await context.SaveChangesAsync();
        // ***************************************************************** //
        var workoutSex = new List<WorkoutSex>();
        workoutSex = new List<WorkoutSex>
        {
            #region Traps & Barbell
            new WorkoutSex{ WorkoutId = Workouts[0].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = Workouts[0].Id, Sex = Sex.Female},


            #endregion
        };
        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}
