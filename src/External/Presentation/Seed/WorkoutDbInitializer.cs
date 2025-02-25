namespace Presentation.Seed;

public static class WorkoutDbInitializer
{
    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        using var transactions = await context.Database.BeginTransactionAsync();

        var workouts = new List<Workout>();
        if (!await context.Workouts.AnyAsync())
        {
            var bodybuildingId = await context.Sports.Where(s => s.Name == "Body Building").Select(z => z.Id).FirstOrDefaultAsync();
            var cardioId = await context.Sports.Where(s => s.Name == "Cardio").Select(z => z.Id).FirstOrDefaultAsync();
            workouts = new List<Workout>
            {
                // biceps // Barbell
                new Workout{ Name = "Barbell Curl", SportId = bodybuildingId, Description = "" },                                // index => 0
                new Workout{ Name = "Barbell Reverse Curl", SportId = bodybuildingId, Description = "" },                        // index => 1
                new Workout{ Name = "Barbell Landmine Row", SportId = bodybuildingId, Description = "" },                        // index => 2
                new Workout{ Name = "Barbell Long Landmine Row", SportId = bodybuildingId, Description = "" },                   // index => 3
                new Workout{ Name = "Barbell Meadows Row", SportId = bodybuildingId, Description = "" },                         // index => 4
                new Workout{ Name = "Barbell Pronated Pendlay Row", SportId = bodybuildingId, Description = "" },                // index => 5
                new Workout{ Name = "Barbell Pronated Row", SportId = bodybuildingId, Description = "" },                        // index => 6
                new Workout{ Name = "Barbell Supinated Pendlay Row", SportId = bodybuildingId, Description = "" },               // index => 7
                new Workout{ Name = "Barbell Supinated Row", SportId = bodybuildingId, Description = "" },                       // index => 8
                new Workout{ Name = "Landmine Bicep Curl", SportId = bodybuildingId, Description = "" },                         // index => 9
                new Workout{ Name = "Landmine Concentration Curl", SportId = bodybuildingId, Description = "" },                 // index => 10
                new Workout{ Name = "Barbell Drag Curl", SportId = bodybuildingId, Description = "" },                           // index => 11
                new Workout{ Name = "Landmine T Bar Rows", SportId = bodybuildingId, Description = "" },                         // index => 12
                new Workout{ Name = "Barbell Bent Over Row", SportId = bodybuildingId, Description = "" },                       // index => 13
                new Workout{ Name = "EZ Bar Preacher Curl", SportId = bodybuildingId, Description = "" },                        // index => 14
                new Workout{ Name = "EZ Bar Reverse Preacher Curl", SportId = bodybuildingId, Description = "" },                // index => 15

                // biceps // Machine
                new Workout{ Name = "Machine Seated Cable Row", SportId = bodybuildingId, Description = "" },                    // index => 16
                new Workout{ Name = "Narrow Pulldown", SportId = bodybuildingId, Description = "" },                             // index => 17
                new Workout{ Name = "Neutral Pulldown", SportId = bodybuildingId, Description = "" },                            // index => 18
                new Workout{ Name = "Underhand Pulldown", SportId = bodybuildingId, Description = "" },                          // index => 19
                new Workout{ Name = "Machine Assisted Pull Up", SportId = bodybuildingId, Description = "" },                    // index => 20
                new Workout{ Name = "Machine Assisted Narrow Pull Up", SportId = bodybuildingId, Description = "" },             // index => 21
                new Workout{ Name = "Machine Assisted Neutral Chin Up", SportId = bodybuildingId, Description = "" },            // index => 22
                new Workout{ Name = "Machine Assisted Chin Up", SportId = bodybuildingId, Description = "" },                    // index => 23
                new Workout{ Name = "Machine Underhand Row", SportId = bodybuildingId, Description = "" },                       // index => 24
                new Workout{ Name = "Machine Plate Loaded Pulldown", SportId = bodybuildingId, Description = "" },               // index => 25
                new Workout{ Name = "Machine Standing Plate Loaded Preacher Curl", SportId = bodybuildingId, Description = "" }, // index => 26
                new Workout{ Name = "Machine Seated Plate Loaded Preacher Curl", SportId = bodybuildingId, Description = "" },   // index => 27
                new Workout{ Name = "Machine Bicep Curl", SportId = bodybuildingId, Description = "" },                          // index => 28

                // biceps // stretches
                new Workout{ Name = "Biceps Stretch Variation Five", SportId = cardioId, Description = "" },                // index => 29
                new Workout{ Name = "Biceps Stretch Variation Four", SportId = cardioId, Description = "" },                // index => 30
                new Workout{ Name = "Biceps Stretch Variation Three", SportId = cardioId, Description = "" },               // index => 31
                new Workout{ Name = "Biceps Stretch Variation Two", SportId = cardioId, Description = "" },                 // index => 32
                new Workout{ Name = "Biceps Stretch Variation One", SportId = cardioId, Description = "" },                 // index => 33

                // biceps // plate
                new Workout{ Name = "Plate Bicep Curl", SportId = bodybuildingId, Description = "" },                                   // index => 34
                new Workout{ Name = "Plate Curl To Overhead Press", SportId = bodybuildingId, Description = "" },                       // index => 35
                new Workout{ Name = "Plate Curl To Overhead Press To Tricep Extension", SportId = bodybuildingId, Description = "" },   // index => 36
                new Workout{ Name = "Plate Squat Hold Curl", SportId = bodybuildingId, Description = "" },                              // index => 37
                new Workout{ Name = "Plate Pinch Grip Row", SportId = bodybuildingId, Description = "" },                               // index => 38
                new Workout{ Name = "Weighted Chin Ups", SportId = bodybuildingId, Description = "" },                                  // index => 39

                // biceps // bosu-ball
                new Workout{ Name = "Bosu Ball Curl", SportId = cardioId, Description = "" },                                           // index => 40
                new Workout{ Name = "Bosu Ball Row", SportId = cardioId, Description = "" },                                            // index => 41

                // biceps // smith machine
                new Workout{ Name = "Smith Machine Drag Curl", SportId = bodybuildingId, Description = "" },                            // index => 42
                new Workout{ Name = "Smith Machine Underhand Row", SportId = bodybuildingId, Description = "" },                        // index => 43
                new Workout{ Name = "Smith Machine Overhand Row", SportId = bodybuildingId, Description = "" },                         // index => 44

                #region Others
                new Workout{ Name = "Dumbbell Curl", SportId = 1, Description = "" }, // index => 1
                new Workout{ Name = "Dumbbell Hammer Curl", SportId = 1, Description = "" }, // index => 2
                new Workout{ Name = "Kettlebell Goblet Curl", SportId = 1, Description = "" }, // index => 3
                new Workout{ Name = "Kettlebell Concentration Curl", SportId = 1, Description = "" }, // index => 4
                new Workout{ Name = "Kettlebell Preacher Curl", SportId = 1, Description = "" }, // index => 5
                new Workout{ Name = "Kettlebell Single Arm Curl", SportId = 1, Description = "" }, // index => 6
                new Workout{ Name = "Cable Twisting Curl", SportId = 1, Description = "" }, // index => 12
                new Workout{ Name = "Cable Single Arm Bayesian Curl", SportId = 1, Description = "" }, // index => 13
                new Workout{ Name = "Cable Single Arm Reverse Curl", SportId = 1, Description = "" }, // index => 14
                new Workout{ Name = "Cable Single Arm Hammer Curl", SportId = 1, Description = "" }, // index => 15
                new Workout{ Name = "Band Bayesian Curl", SportId = 1, Description = "" }, // index => 16
                new Workout{ Name = "Band Bayesian Hammer Curl", SportId = 1, Description = "" }, // index => 17
                new Workout{ Name = "Band Bayesian Reverse Curl", SportId = 1, Description = "" }, // index => 18
                new Workout{ Name = "Dumbbell Reverse Curl", SportId = 1, Description = "" }, // index => 19
                new Workout{ Name = "Dumbbell Incline Hammer Curl", SportId = 1, Description = "" }, // index => 21
                new Workout{ Name = "Dumbbell Incline Reverse Curl", SportId = 1, Description = "" }, // index => 22
                new Workout{ Name = "Dumbbell Incline Zottman Curl", SportId = 1, Description = "" }, // index => 23
                new Workout{ Name = "Dumbbell Single Arm Preacher Curl", SportId = 1, Description = "" }, // index => 24
                new Workout{ Name = "Dumbbell Single Arm Spider Curl", SportId = 1, Description = "" }, // index => 25
                new Workout{ Name = "Dumbbell Spider Curl", SportId = 1, Description = "" }, // index => 26
                new Workout{ Name = "Dumbbell Twisting Curl", SportId = 1, Description = "" }, // index => 27
                new Workout{ Name = "Band High Curl", SportId = 1, Description = "" }, // index => 32
                new Workout{ Name = "Band High Hammer Curl", SportId = 1, Description = "" }, // index => 34
                new Workout{ Name = "Band High Reverse Curl", SportId = 1, Description = "" }, // index => 35
                new Workout{ Name = "Band Curl", SportId = 1, Description = "" }, // index => 36
                new Workout{ Name = "Band Reverse Curl", SportId = 1, Description = "" }, // index => 37
                new Workout{ Name = "Dumbbell Concentration Curl", SportId = 1, Description = "" }, // index => 38
                new Workout{ Name = "TRX Curl", SportId = 1, Description = "" }, // index => 39
                new Workout{ Name = "TRX Hammer Curl", SportId = 1, Description = "" }, // index => 40
                new Workout{ Name = "TRX Reverse Curl", SportId = 1, Description = "" }, // index => 41
                new Workout{ Name = "Chin Ups", SportId = 1, Description = "" }, // index => 43
                new Workout{ Name = "Band Kneeling Single Arm Pulldown", SportId = 1, Description = "" }, // index => 44
                new Workout{ Name = "Dumbbell Alternating Pendlay Row", SportId = 1, Description = "" }, // index => 51
                new Workout{ Name = "Dumbbell Kneeling Single Arm Row", SportId = 1, Description = "" }, // index => 52
                new Workout{ Name = "Dumbbell Laying Incline Row", SportId = 1, Description = "" }, // index => 53
                new Workout{ Name = "Dumbbell Pendlay Row", SportId = 1, Description = "" }, // index => 54
                new Workout{ Name = "Dumbbell Single Arm Row", SportId = 1, Description = "" }, // index => 55
                new Workout{ Name = "Dumbbell Single Arm Row Knee", SportId = 1, Description = "" }, // index => 56
                new Workout{ Name = "Lawnmower Row", SportId = 1, Description = "" }, // index => 58
                new Workout{ Name = "Dumbbell Knee Lawnmower Row", SportId = 1, Description = "" }, // index => 59
                new Workout{ Name = "Dumbbell Supinated Row", SportId = 1, Description = "" }, // index => 60
                new Workout{ Name = "TRX Rotating Row", SportId = 1, Description = "" }, // index => 61
                new Workout{ Name = "Corpse Pose", SportId = 1, Description = "" }, // index => 62
                new Workout{ Name = "Crow Pose", SportId = 1, Description = "" }, // index => 63
                new Workout{ Name = "Downward Dog", SportId = 1, Description = "" }, // index => 64
                new Workout{ Name = "Downward Dog With Fingers Facing Feet", SportId = 1, Description = "" }, // index => 65
                new Workout{ Name = "Scorpion Twist Pose", SportId = 1, Description = "" }, // index => 66
                new Workout{ Name = "Seated Arm Stretch", SportId = 1, Description = "" }, // index => 67
                new Workout{ Name = "Vitruvian Hammer Curl", SportId = 1, Description = "" }, // index => 72
                new Workout{ Name = "Vitruvian Row", SportId = 1, Description = "" }, // index => 73
                new Workout{ Name = "Vitruvian Single Arm Row", SportId = 1, Description = "" }, // index => 74
                new Workout{ Name = "Kettlebell Alternating Row", SportId = 1, Description = "" }, // index => 75
                new Workout{ Name = "Kettlebell Curl", SportId = 1, Description = "" }, // index => 76
                new Workout{ Name = "Kettlebell Gorilla Row", SportId = 1, Description = "" }, // index => 77
                new Workout{ Name = "Kettlebell Reverse Curl", SportId = 1, Description = "" }, // index => 78
                new Workout{ Name = "Kettlebell Row", SportId = 1, Description = "" }, // index => 79
                new Workout{ Name = "Cable Archer Row", SportId = 1, Description = "" }, // index => 80
                new Workout{ Name = "Cable Bar Curl", SportId = 1, Description = "" }, // index => 81
                new Workout{ Name = "Cable Bayesian Curl", SportId = 1, Description = "" }, // index => 82
                new Workout{ Name = "Cable Rope Hammer Curl", SportId = 1, Description = "" }, // index => 83
                new Workout{ Name = "Cable Supinating Row", SportId = 1, Description = "" }, // index => 84
                new Workout{ Name = "Cable Seated Bayesian Curl", SportId = 1, Description = "" }, // index => 85
                new Workout{ Name = "Cable Single Arm Underhand Grip Row", SportId = 1, Description = "" }, // index => 86
                new Workout{ Name = "Cable Single Arm Neutral Grip Row", SportId = 1, Description = "" }, // index => 87
                new Workout{ Name = "Cable Seated Bayesian Hammer Curl", SportId = 1, Description = "" }, // index => 88
                new Workout{ Name = "Cable Seated Bayesian Reverse Curl", SportId = 1, Description = "" }, // index => 89
                new Workout{ Name = "Cable Reverse Bayesian Curl", SportId = 1, Description = "" }, // index => 90
                new Workout{ Name = "Cable Hammer Bayesian Curl", SportId = 1, Description = "" }, // index => 91
                new Workout{ Name = "Kettlebell Single Arm Reverse Curl", SportId = 1, Description = "" }, // index => 96
                new Workout{ Name = "Kettlebell Single Arm Row On Bench", SportId = 1, Description = "" }, // index => 97
                new Workout{ Name = "Cardio Band Hammer Curl Jacks", SportId = 1, Description = "" }, // index => 101
                new Workout{ Name = "Cable Pull In", SportId = 1, Description = "" }, // index => 103
                new Workout{ Name = "Band Row", SportId = 1, Description = "" }, // index => 105
                new Workout{ Name = "Kettlebell Row (Single)", SportId = 1, Description = "" }, // index => 106
                new Workout{ Name = "Kettlebell Single Arm Row", SportId = 1, Description = "" }, // index => 107
                new Workout{ Name = "Dumbbell Rear Delt Row", SportId = 1, Description = "" }, // index => 108
                new Workout{ Name = "Kettlebell Rear Delt Row", SportId = 1, Description = "" }, // index => 109
                new Workout{ Name = "Kettlebell Rear Delt Row (Double)", SportId = 1, Description = "" }, // index => 101
                new Workout{ Name = "Cable Row Bar Standing Row", SportId = 1, Description = "" }, // index => 102
                new Workout{ Name = "TRX Single Arm row", SportId = 1, Description = "" }, // index => 103
                new Workout{ Name = "Core Stability 2 Opposite Shoulder Tap 4Pt Position", SportId = 1, Description = "" }, // index => 104
                new Workout{ Name = "Cardio Row Erg Rower", SportId = 1, Description = "" }, // index => 105
                new Workout{ Name = "Cardio Row Erg Rower Arms Only", SportId = 1, Description = "" }, // index => 106
                new Workout{ Name = "Cardio Row Erg Rower Four Stroke Sprint Start", SportId = 1, Description = "" }, // index => 107
                new Workout{ Name = "Dumbbell Preacher Curl", SportId = 1, Description = "" }, // index => 110
                new Workout{ Name = "Bodyweight Assisted Chin Up", SportId = 1, Description = "" }, // index => 116
                new Workout{ Name = "Bodyweight Assisted Gironda Chin Up", SportId = 1, Description = "" }, // index => 117
                new Workout{ Name = "Bodyweight Assisted Mixed Grip Pullup", SportId = 1, Description = "" }, // index => 118
                new Workout{ Name = "Bodyweight Assisted Pull Up", SportId = 1, Description = "" }, // index => 119
                new Workout{ Name = "Bodyweight Inverted Curl", SportId = 1, Description = "" }, // index => 120
                new Workout{ Name = "Bodyweight Close Grip Inverted Curl", SportId = 1, Description = "" }, // index => 121
                new Workout{ Name = "Bodyweight Concentration Curl", SportId = 1, Description = "" }, // index => 122
                new Workout{ Name = "Bodyweight Underhand Inverted Row", SportId = 1, Description = "" }, // index => 123
                new Workout{ Name = "Ring Row", SportId = 1, Description = "" }, // index => 124
                new Workout{ Name = "Ring Curl", SportId = 1, Description = "" }, // index => 125
                new Workout{ Name = "Dumbbell Incline Curl", SportId = 1, Description = "" }, // index => 126
                new Workout{ Name = "Dumbbell Service Exercise", SportId = 1, Description = "" }, // index => 127
                new Workout{ Name = "Seated Ulnar Nerve Slider", SportId = 1, Description = "" }, // index => 128
                new Workout{ Name = "Seated Ulnar Nerve Tensioner", SportId = 1, Description = "" }, // index => 129
                new Workout{ Name = "Dumbbell Weighted Chin Ups", SportId = 1, Description = "" }, // index => 130
                new Workout{ Name = "L Sit Chin Up", SportId = 1, Description = "" }, // index => 132
                new Workout{ Name = "Band Squat Hold Row", SportId = 1, Description = "" }, // index => 133
                new Workout{ Name = "Band Squat Hold Single Arm Row", SportId = 1, Description = "" }, // index => 134
                new Workout{ Name = "Band Single Arm Row", SportId = 1, Description = "" }, // index => 135
                new Workout{ Name = "Band Single Arm Pulldown", SportId = 1, Description = "" }, // index => 136
                new Workout{ Name = "Cable High Bayesian Curl", SportId = 1, Description = "" }, // index => 141
                new Workout{ Name = "Dumbbell Laying Curl", SportId = 1, Description = "" }, // index => 142
	            #endregion
            };
        };

        var workoutInstruction = new List<WorkoutInstruction>();
        if (!await context.WorkoutInstructions.AnyAsync())
        {
            workoutInstruction = new List<WorkoutInstruction>
            {
                #region Biceps & Barbell
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 1 , Instruction = "While holding the upper arms stationary, curl the weights forward while contracting the biceps as you breathe out."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 2 , Instruction = "Continue the movement until your biceps are fully contracted and the bar is at shoulder level."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 3 , Instruction = "Hold the contracted position for a second and squeeze the biceps hard."},
                new WorkoutInstruction{ WorkoutId = workouts[0].Id , Step = 4 , Instruction = "Slowly bring the weight back down to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 1 , Instruction = "Take a double overhand grip that's about shoulder width. Flex your elbows while keeping your elbows tucked in. Try not to let them flare out."},
                new WorkoutInstruction{ WorkoutId = workouts[1].Id , Step = 2 , Instruction = "Curl until your forearm presses into your bicep. Then fully extend your elbows at the bottom of each rep."},

                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 2 , Instruction = "Grasp the end of the barbell with a neutral grip, keeping your arms straight and your shoulders relaxed."},
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[2].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing it with your feet shoulder-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 2 , Instruction = "Grasp the end of the barbell with an overhand grip, keeping your arms straight and your shoulders relaxed."},
                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[3].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},

                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 1 , Instruction = "Position a barbell in a landmine or corner of a room and stand facing sideways with a staggered stance and your feet shoulder-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 2 , Instruction = "Grasp the end of the barbell with an overhand grip, keeping your arms straight and your shoulders relaxed."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 3 , Instruction = "Bend at the hips and knees to lower your torso until it is almost parallel to the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 4 , Instruction = "Pull the barbell towards your chest, squeezing your shoulder blades together as you row the weight up."},
                new WorkoutInstruction{ WorkoutId = workouts[4].Id , Step = 5 , Instruction = "*Named after the late John Meadows"},

                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 1 , Instruction = "Start hinged forward with a flat back and the plates resting on the floor. Make sure your elbows are fully extended."},
                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 2 , Instruction = "Pull the bar to your sternum."},
                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 3 , Instruction = "Return the plates back to the floor and let the bar come to a full dead stop."},
                new WorkoutInstruction{ WorkoutId = workouts[5].Id , Step = 4 , Instruction = "Then initiate the next rep."},

                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 1 , Instruction = "Grab the barbell with an overhand grip. Hinge forward while keeping your back flat until your torso is about parallel with the ground."},
                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 2 , Instruction = "Let your arms hang freely."},
                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 3 , Instruction = "Pull the bar to your torso while tucking your elbows in slightly."},
                new WorkoutInstruction{ WorkoutId = workouts[6].Id , Step = 4 , Instruction = "Extend your elbows fully before initiating the next rep."},

                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart and your palms facing towards your body."},
                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a pronated (overhand) grip, positioning the barbell about an inch away from your shins."},
                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest."},
                new WorkoutInstruction{ WorkoutId = workouts[7].Id , Step = 4 , Instruction = "As the barbell reaches your chest, rotate your wrists so that your palms are facing towards your body (supinated grip), and then lower the barbell back to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 1 , Instruction = "Begin by standing in front of a barbell with your feet about hip-width apart."},
                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the barbell with a supinated (underhand) grip, positioning the barbell about an inch away from your shins."},
                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the barbell straight up towards your chest."},
                new WorkoutInstruction{ WorkoutId = workouts[8].Id , Step = 4 , Instruction = "As the barbell reaches your chest, pause briefly, and then lower the barbell back to the starting position."},

                new WorkoutInstruction{ WorkoutId = workouts[9].Id , Step = 1 , Instruction = "Stand beside the landmine with your feet shoulder-width apart while grasping the end of the landmine barbell with the hand farther away from the landmine attachment, palm facing up and your elbow close to your side."},
                new WorkoutInstruction{ WorkoutId = workouts[9].Id , Step = 2 , Instruction = "Curl the barbell up towards your opposite shoulder, contracting your bicep muscles, then slowly lower the barbell back down."},
                new WorkoutInstruction{ WorkoutId = workouts[9].Id , Step = 3 , Instruction = "Repeat for the desired number of reps before switching sides."},

                new WorkoutInstruction{ WorkoutId = workouts[10].Id , Step = 1 , Instruction = "Start on one knee facing the landmine, holding the end of the barbell with your hand on the side of your forward leg."},
                new WorkoutInstruction{ WorkoutId = workouts[10].Id , Step = 2 , Instruction = "While keeping your elbow braced against the inside of your knee, curl the barbell upward towards your shoulder, then lower it back down with control."},
                new WorkoutInstruction{ WorkoutId = workouts[10].Id , Step = 3 , Instruction = "Repeat for the desired number of reps before switching sides."},

                new WorkoutInstruction{ WorkoutId = workouts[11].Id , Step = 1 , Instruction = "Grab a barbell with an underhand grip."},
                new WorkoutInstruction{ WorkoutId = workouts[11].Id , Step = 2 , Instruction = "Pull your elbows straight back and let the bar drag against your upper body (or very close to it)."},

                new WorkoutInstruction{ WorkoutId = workouts[12].Id , Step = 1 , Instruction = "Grab a v bar and place it under the bar's collar."},
                new WorkoutInstruction{ WorkoutId = workouts[12].Id , Step = 2 , Instruction = "Hinge forward with a flat back and pull your elbows straight back toward the ceiling."},
                new WorkoutInstruction{ WorkoutId = workouts[12].Id , Step = 3 , Instruction = "Fully extend your elbows before initiating the next rep."},

                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 1 , Instruction = "Grab a barbell with a shoulder width pronated or supinated grip."},
                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 2 , Instruction = "Bend forward at your hips while maintaining a flat back."},
                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 3 , Instruction = "Pull the weight toward your upper abdomen."},
                new WorkoutInstruction{ WorkoutId = workouts[13].Id , Step = 4 , Instruction = "Lower the weight in a controlled manner and repeat."},

                new WorkoutInstruction{ WorkoutId = workouts[14].Id , Step = 1 , Instruction = "Position yourself on preacher bench; grasp EZ bar with underhand grip, elbows extended."},
                new WorkoutInstruction{ WorkoutId = workouts[14].Id , Step = 2 , Instruction = "Slowly curl bar towards shoulders; keep upper arms stationary, focus on biceps."},
                new WorkoutInstruction{ WorkoutId = workouts[14].Id , Step = 3 , Instruction = "Lower bar back to starting position; maintain control, repeat for reps."},

                new WorkoutInstruction{ WorkoutId = workouts[15].Id , Step = 1 , Instruction = "Sit on preacher bench, grip EZ bar overhand at shoulder width, elbows resting on pad."},
                new WorkoutInstruction{ WorkoutId = workouts[15].Id , Step = 2 , Instruction = "Curl bar towards chin, keep elbows stable."},
                new WorkoutInstruction{ WorkoutId = workouts[15].Id , Step = 3 , Instruction = "Lower bar slowly to starting position, maintaining control throughout."},
                #endregion

                #region biceps & Machine
                new WorkoutInstruction{ WorkoutId = workouts[16].Id , Step = 1 , Instruction = "Sit with your back straight on the machine and grip the handles." },
                new WorkoutInstruction{ WorkoutId = workouts[16].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Your legs and torso should be at a 90° angle. Push out your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[16].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen." },

                new WorkoutInstruction{ WorkoutId = workouts[17].Id , Step = 1 , Instruction = "Use the Straight Bar attachment." },
                new WorkoutInstruction{ WorkoutId = workouts[17].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
                new WorkoutInstruction{ WorkoutId = workouts[17].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

                new WorkoutInstruction{ WorkoutId = workouts[18].Id , Step = 1 , Instruction = "Use the V Bar attachment." },
                new WorkoutInstruction{ WorkoutId = workouts[18].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
                new WorkoutInstruction{ WorkoutId = workouts[18].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

                new WorkoutInstruction{ WorkoutId = workouts[19].Id , Step = 1 , Instruction = "Use the Straight Bar attachment. Hold with an underhand grip." },
                new WorkoutInstruction{ WorkoutId = workouts[19].Id , Step = 2 , Instruction = "Hold the attachment as you sit on the machine and put your legs under the leg pads." },
                new WorkoutInstruction{ WorkoutId = workouts[19].Id , Step = 3 , Instruction = "Pull the bar to your clavicle, then raise back up until your arm are extended." },

                new WorkoutInstruction{ WorkoutId = workouts[20].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[20].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[20].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[21].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[21].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[21].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[22].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[22].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[22].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[23].Id , Step = 1 , Instruction = "Adjust weight for assistance. Stand on platform, grip handles above shoulder-width. Knees on pad if available." },
                new WorkoutInstruction{ WorkoutId = workouts[23].Id , Step = 2 , Instruction = "Slowly pull up until chin is above the bar. Keep elbows close, core engaged." },
                new WorkoutInstruction{ WorkoutId = workouts[23].Id , Step = 3 , Instruction = "Lower back with control. Pause at bottom. Repeat for reps." },

                new WorkoutInstruction{ WorkoutId = workouts[24].Id , Step = 1 , Instruction = "Sit on the machine, feet flat, and grab the handles with palms facing up, keeping your back straight." },
                new WorkoutInstruction{ WorkoutId = workouts[24].Id , Step = 2 , Instruction = "Pull handles towards your lower abdomen, squeezing your shoulder blades together. Keep elbows close to your body." },
                new WorkoutInstruction{ WorkoutId = workouts[24].Id , Step = 3 , Instruction = "Slowly return to the starting position, fully extending your arms without locking elbows. Repeat for desired reps." },

                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 1 , Instruction = "Grip the handles with the palms facing down." },
                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 2 , Instruction = "Sit on the machine and press your knees into the knee pad." },
                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 3 , Instruction = "Pull the handles until your upper arm is even with your torso, or just behind your torso." },
                new WorkoutInstruction{ WorkoutId = workouts[25].Id , Step = 4 , Instruction = "Extend until your elbows are fully extended before initiating the next rep." },

                new WorkoutInstruction{ WorkoutId = workouts[26].Id , Step = 1 , Instruction = "Rest the back of your arms on the preacher bench." },
                new WorkoutInstruction{ WorkoutId = workouts[26].Id , Step = 2 , Instruction = "Grab the handles. Curl the weight up until your elbows are fully flexed." },
                new WorkoutInstruction{ WorkoutId = workouts[26].Id , Step = 3 , Instruction = "Lower until the point just before the weight rests at the bottom." },

                new WorkoutInstruction{ WorkoutId = workouts[27].Id , Step = 1 , Instruction = "Sit at the bench and rest the back of your arms on the preacher bench." },
                new WorkoutInstruction{ WorkoutId = workouts[27].Id , Step = 2 , Instruction = "Grab the handles. Curl the weight up until your elbows are fully flexed." },
                new WorkoutInstruction{ WorkoutId = workouts[27].Id , Step = 3 , Instruction = "Lower until the point just before the weight rests at the bottom." },

                new WorkoutInstruction{ WorkoutId = workouts[28].Id , Step = 1 , Instruction = "Adjust the seat to fit your height and place your elbows on the elbow pad." },
                new WorkoutInstruction{ WorkoutId = workouts[28].Id , Step = 2 , Instruction = "Grab the handles and flex your elbows." },
                #endregion

                #region biceps & stretches
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 1 , Instruction = "Stand upright with your feet shoulder width apart." },
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 2 , Instruction = "Raise your arms out to your sides, bringing them up to shoulder level." },
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 3 , Instruction = "Rotate your palms so they are facing the ceiling." },
                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 4 , Instruction = "Then, change direction and rotate the arms as much as you can." },

                new WorkoutInstruction{ WorkoutId = workouts[30].Id , Step = 1 , Instruction = "Stand an arms width away from the wall." },
                new WorkoutInstruction{ WorkoutId = workouts[30].Id , Step = 2 , Instruction = "Raise your arms out behind you, and place them on the wall with your fingers pointing up." },
                new WorkoutInstruction{ WorkoutId = workouts[30].Id , Step = 3 , Instruction = "Bend your knees whilst keeping your hands in the same position." },

                new WorkoutInstruction{ WorkoutId = workouts[31].Id , Step = 1 , Instruction = "Bend your arm at the elbow, raising your hand to your shoulder." },
                new WorkoutInstruction{ WorkoutId = workouts[31].Id , Step = 2 , Instruction = "Using your other hand, stretch the arm down to its full extent." },

                new WorkoutInstruction{ WorkoutId = workouts[32].Id , Step = 1 , Instruction = "Stand facing the wall, an arm's width away." },
                new WorkoutInstruction{ WorkoutId = workouts[32].Id , Step = 2 , Instruction = "Place your hand on the wall with your fingers pointing down." },
                new WorkoutInstruction{ WorkoutId = workouts[32].Id , Step = 3 , Instruction = "Lean slightly into the wall to feel the stretch in your bicep." },

                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 1 , Instruction = "Stand one foot in front of the other with the wall to your right, an arms width away." },
                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 2 , Instruction = "Place your hand on the wall, fingers pointing away from you." },
                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 3 , Instruction = "Gently lean forward, keeping your hand stationary." },
                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 4 , Instruction = "Repeat with the other arm." },
                #endregion

                #region biceps & plate
                new WorkoutInstruction{ WorkoutId = workouts[34].Id , Step = 1 , Instruction = "" },

                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart and the plate in front of the torso, palms facing forward." },
                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 2 , Instruction = "Curl the plate up to the front of the shoulder while keeping the elbows close to the body." },
                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 3 , Instruction = "Rotate the palms to face forward and press the plate overhead, locking out the arms." },
                new WorkoutInstruction{ WorkoutId = workouts[35].Id , Step = 4 , Instruction = "Lower the plate back to the starting position, keeping control of it, and repeat for desired reps." },

                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 1 , Instruction = "Stand with feet shoulder-width apart and the plate in front of the torso, palms facing forward." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 2 , Instruction = "Curl the plate up to the front of the shoulder while keeping the elbows close to the body." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 3 , Instruction = "Rotate the palms to face forward and press the plate overhead, locking out the arms." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 4 , Instruction = "Lower the plate back behind the head to the starting position of a tricep extension." },
                new WorkoutInstruction{ WorkoutId = workouts[36].Id , Step = 5 , Instruction = "Push the plate back up overhead, then lower it back to the starting position and repeat for desired reps." },

                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 1 , Instruction = "Lower into a squat position, keeping the plate at chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 2 , Instruction = "Slowly curl the plate towards your shoulders, keeping your elbows close to your body." },
                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 3 , Instruction = "Hold for a moment at the top of the curl before lowering the plate back to chest height." },
                new WorkoutInstruction{ WorkoutId = workouts[37].Id , Step = 4 , Instruction = "Repeat the curls as you hold the squat position." },

                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 1 , Instruction = "Make sure to keep your elbow close to your body and your core engaged throughout the movement." },
                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 2 , Instruction = "Bend forward at your hips while maintaining a flat back." },
                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 3 , Instruction = "Pull the plate toward your upper abdomen." },
                new WorkoutInstruction{ WorkoutId = workouts[38].Id , Step = 4 , Instruction = "Lower the weight in a controlled manner and repeat." },

                new WorkoutInstruction{ WorkoutId = workouts[39].Id , Step = 1 , Instruction = "Grab the bar shoulder width apart with a supinated grip (palms facing you). Use a dip belt and the let the weight hang between your legs." },
                new WorkoutInstruction{ WorkoutId = workouts[39].Id , Step = 2 , Instruction = "With your body hanging and arms fully extended, pull yourself up until your chin is past the bar." },
                new WorkoutInstruction{ WorkoutId = workouts[39].Id , Step = 3 , Instruction = "Slowly return to starting position. Repeat." },
                #endregion

                #region Bosu ball
                new WorkoutInstruction{ WorkoutId = workouts[40].Id , Step = 1 , Instruction = "Hold the bosu vertically." },
                new WorkoutInstruction{ WorkoutId = workouts[40].Id , Step = 2 , Instruction = "Flex your elbows curling the bosu toward your chin." },

                new WorkoutInstruction{ WorkoutId = workouts[41].Id , Step = 1 , Instruction = "Hold bosu and hinge forward." },
                new WorkoutInstruction{ WorkoutId = workouts[41].Id , Step = 2 , Instruction = "Pull bosu towards chest, squeezing shoulder blades." },
                #endregion

                #region smith machine
                new WorkoutInstruction{ WorkoutId = workouts[42].Id , Step = 1 , Instruction = "Grab the bar with an underhand grip." },
                new WorkoutInstruction{ WorkoutId = workouts[42].Id , Step = 2 , Instruction = "Pull your elbows straight back and let the bar drag against your upper body (or very close to it)." },

                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 1 , Instruction = "Begin by standing in front of a bar with your feet about hip-width apart." },
                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 2 , Instruction = "Bend at the hips and knees to grab the bar with a supinated (underhand) grip, positioning the bar about an inch away from your shins." },
                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, use your back muscles to lift the bar straight up towards your chest." },
                new WorkoutInstruction{ WorkoutId = workouts[43].Id , Step = 4 , Instruction = "As the bar reaches your chest, pause briefly, and then lower the bar back to the starting position." },

                new WorkoutInstruction{ WorkoutId = workouts[44].Id , Step = 1 , Instruction = "Start hinged forward with a flat back. Make sure your elbows are fully extended." },
                new WorkoutInstruction{ WorkoutId = workouts[44].Id , Step = 2 , Instruction = "Pull the bar to your sternum." },
                
                #endregion

                new WorkoutInstruction{ WorkoutId = workouts[33].Id , Step = 1 , Instruction = "" },

            };
        };

        var workoutEquipment = new List<WorkoutEquipment>();
        if (!await context.WorkoutEquipment.AnyAsync())
        {
            var barbellId  = context.Equipments.Where(x => x.Name == "Barbell").Select(x => x.Id).FirstOrDefault();
            var ezbarId  = context.Equipments.Where(x => x.Name == "E-Z Curl Bar").Select(x => x.Id).FirstOrDefault();
            var cableMachineId = context.Equipments.Where(x => x.Name == "Cable Machine").Select(x => x.Id).FirstOrDefault();
            var pullUpMachineId = context.Equipments.Where(x => x.Name == "Pull Up Machine").Select(x => x.Id).FirstOrDefault();
            var machineId = context.Equipments.Where(x => x.Name == "Machine").Select(x => x.Id).FirstOrDefault();
            var stretchesId = context.Equipments.Where(x => x.Name == "stretches").Select(x => x.Id).FirstOrDefault();
            var plateId = context.Equipments.Where(x => x.Name == "Plate").Select(x => x.Id).FirstOrDefault();
            var bosuballId  = context.Equipments.Where(x => x.Name == "Bosu-Ball").Select(x => x.Id).FirstOrDefault();
            var smithMachineId  = context.Equipments.Where(x => x.Name == "Smith Machine").Select(x => x.Id).FirstOrDefault();
            workoutEquipment = new List<WorkoutEquipment>
            {
                #region Barbell & biceps
                new WorkoutEquipment{ WorkoutId = workouts[0].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[1].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[2].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[3].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[4].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[5].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[6].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[7].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[8].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[9].Id, EquipmentId = barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[10].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[11].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[12].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[13].Id, EquipmentId =barbellId },
                new WorkoutEquipment{ WorkoutId = workouts[14].Id, EquipmentId =ezbarId },
                new WorkoutEquipment{ WorkoutId = workouts[15].Id, EquipmentId =ezbarId },
                #endregion

                #region Biceps & Machine
                new WorkoutEquipment{ WorkoutId = workouts[16].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[17].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[18].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[19].Id, EquipmentId = cableMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[20].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[21].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[22].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[23].Id, EquipmentId = pullUpMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[24].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[25].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[26].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[27].Id, EquipmentId = machineId },
                new WorkoutEquipment{ WorkoutId = workouts[28].Id, EquipmentId = machineId },
                #endregion

                #region biceps & stretches
                new WorkoutEquipment{ WorkoutId = workouts[29].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[30].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[31].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[32].Id, EquipmentId = stretchesId },
                new WorkoutEquipment{ WorkoutId = workouts[33].Id, EquipmentId = stretchesId },
                #endregion

                #region biceps & plate
                new WorkoutEquipment{ WorkoutId = workouts[34].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[35].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[36].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[37].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[38].Id, EquipmentId = plateId },
                new WorkoutEquipment{ WorkoutId = workouts[39].Id, EquipmentId = plateId },
                #endregion

                #region bosuball
                new WorkoutEquipment{ WorkoutId = workouts[40].Id, EquipmentId = bosuballId },
                new WorkoutEquipment{ WorkoutId = workouts[41].Id, EquipmentId = bosuballId },
                #endregion

                #region smithMachine
                new WorkoutEquipment{ WorkoutId = workouts[42].Id, EquipmentId = smithMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[43].Id, EquipmentId = smithMachineId },
                new WorkoutEquipment{ WorkoutId = workouts[44].Id, EquipmentId = smithMachineId },
                #endregion

                new WorkoutEquipment{ WorkoutId = workouts[40].Id, EquipmentId = 21 },

            };
        };

        var workoutLevel = new List<WorkoutLevel>();
        if (!await context.WorkoutLevels.AnyAsync())
        {
            workoutLevel = new List<WorkoutLevel>
            {
                #region barbell & biceps
                new WorkoutLevel{ WorkoutId = workouts[0].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[1].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[2].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[3].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[4].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[5].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[6].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[7].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[8].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[9].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[10].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[11].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[12].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[13].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[14].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[15].Id , Level = Difficulty.Novice},
                #endregion

                #region biceps & Machine
                new WorkoutLevel{ WorkoutId = workouts[16].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[17].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[18].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[19].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[20].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[21].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[22].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[23].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[24].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[25].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[26].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[27].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[28].Id , Level = Difficulty.Novice},
                #endregion

                #region biceps & stretches
                new WorkoutLevel{ WorkoutId = workouts[29].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[30].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[31].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[32].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[33].Id , Level = Difficulty.Novice},
                #endregion

                #region biceps & plate
                new WorkoutLevel{ WorkoutId = workouts[34].Id , Level = Difficulty.Novice},
                new WorkoutLevel{ WorkoutId = workouts[35].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[36].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[37].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[38].Id , Level = Difficulty.Intermediate},
                new WorkoutLevel{ WorkoutId = workouts[39].Id , Level = Difficulty.Advanced},
                #endregion

                #region bosu Ball
                new WorkoutLevel{ WorkoutId = workouts[40].Id , Level = Difficulty.Beginner},
                new WorkoutLevel{ WorkoutId = workouts[41].Id , Level = Difficulty.Beginner},
                #endregion

                #region smith Machine
                new WorkoutLevel{ WorkoutId = workouts[42].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[43].Id , Level = Difficulty.Advanced},
                new WorkoutLevel{ WorkoutId = workouts[44].Id , Level = Difficulty.Advanced},
                #endregion

                new WorkoutLevel{ WorkoutId = workouts[39].Id , Level = Difficulty.Advanced},

            };
        };

        var bodyWorkouts = new List<BodyWorkout>();
        if (!await context.BodyWorkouts.AnyAsync())
        {
            var bicepId = await context.Bodies.Where(z => z.Name == "Biceps").Select(z => z.Id).FirstOrDefaultAsync();
            bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[0].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[1].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[2].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[3].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[4].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[5].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[6].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[7].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[8].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[9].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[10].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[11].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[12].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[13].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[14].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[15].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[16].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[17].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[18].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[19].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[20].Id },
                new BodyWorkout{ BodyId = bicepId, WorkoutId = workouts[21].Id },
            };
        };

        var workoutSex = new List<WorkoutSex>();
        if (!await context.WorkoutSex.AnyAsync())
        {
            workoutSex = new List<WorkoutSex>
            {
                new WorkoutSex{ WorkoutId = workouts[0].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[0].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[1].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[1].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[2].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[2].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[3].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[3].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[4].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[4].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[5].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[5].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[6].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[6].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[7].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[7].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[8].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[8].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[9].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[9].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[10].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[10].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[11].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[11].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[12].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[12].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[13].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[13].Id, Sex = Sex.Female},
                new WorkoutSex{ WorkoutId = workouts[14].Id, Sex = Sex.Male},
                new WorkoutSex{ WorkoutId = workouts[14].Id, Sex = Sex.Female},
            };
        };



        await context.WorkoutInstructions.AddRangeAsync(workoutInstruction);
        await context.SaveChangesAsync();

        await transactions.CommitAsync();

    }

}
