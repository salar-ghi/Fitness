namespace Presentation.Seed;

public static class WorkoutDbInitializer
{
    public static async Task WorkoutSeedAsync(FitnessContext context)
    {
        using var transactions = await context.Database.BeginTransactionAsync();

        var workouts = new List<Workout>();
        if (!await context.Workouts.AnyAsync())
        {
            workouts = new List<Workout>
            {
                // biceps // Barbell
                new Workout{ Name = "Barbell Curl", SportId = 1, Description = "" },                                // index => 0
                new Workout{ Name = "Barbell Reverse Curl", SportId = 1, Description = "" },                        // index => 1
                new Workout{ Name = "Barbell Landmine Row", SportId = 1, Description = "" },                        // index => 2
                new Workout{ Name = "Barbell Long Landmine Row", SportId = 1, Description = "" },                   // index => 3
                new Workout{ Name = "Barbell Meadows Row", SportId = 1, Description = "" },                         // index => 4
                new Workout{ Name = "Barbell Pronated Pendlay Row", SportId = 1, Description = "" },                // index => 5
                new Workout{ Name = "Barbell Pronated Row", SportId = 1, Description = "" },                        // index => 6
                new Workout{ Name = "Barbell Supinated Pendlay Row", SportId = 1, Description = "" },               // index => 7
                new Workout{ Name = "Barbell Supinated Row", SportId = 1, Description = "" },                       // index => 8
                new Workout{ Name = "Landmine Bicep Curl", SportId = 1, Description = "" },                         // index => 9
                new Workout{ Name = "Landmine Concentration Curl", SportId = 1, Description = "" },                 // index => 10
                new Workout{ Name = "Barbell Drag Curl", SportId = 1, Description = "" },                           // index => 11
                new Workout{ Name = "Landmine T Bar Rows", SportId = 1, Description = "" },                         // index => 12
                new Workout{ Name = "Barbell Bent Over Row", SportId = 1, Description = "" },                       // index => 13
                new Workout{ Name = "EZ Bar Preacher Curl", SportId = 1, Description = "" },                        // index => 14
                new Workout{ Name = "EZ Bar Reverse Preacher Curl", SportId = 1, Description = "" },                // index => 15

                // biceps // Machine
                new Workout{ Name = "Machine Seated Cable Row", SportId = 1, Description = "" },                    // index => 16
                new Workout{ Name = "Narrow Pulldown", SportId = 1, Description = "" },                             // index => 17
                new Workout{ Name = "Neutral Pulldown", SportId = 1, Description = "" },                            // index => 18
                new Workout{ Name = "Underhand Pulldown", SportId = 1, Description = "" },                          // index => 19
                new Workout{ Name = "Machine Assisted Pull Up", SportId = 1, Description = "" },                    // index => 20
                new Workout{ Name = "Machine Assisted Narrow Pull Up", SportId = 1, Description = "" },             // index => 21
                new Workout{ Name = "Machine Assisted Neutral Chin Up", SportId = 1, Description = "" },            // index => 22
                new Workout{ Name = "Machine Assisted Chin Up", SportId = 1, Description = "" },                    // index => 23
                new Workout{ Name = "Machine Underhand Row", SportId = 1, Description = "" },                       // index => 24
                new Workout{ Name = "Machine Plate Loaded Pulldown", SportId = 1, Description = "" },               // index => 25
                new Workout{ Name = "Machine Standing Plate Loaded Preacher Curl", SportId = 1, Description = "" }, // index => 26
                new Workout{ Name = "Machine Seated Plate Loaded Preacher Curl", SportId = 1, Description = "" },   // index => 27
                new Workout{ Name = "Machine Bicep Curl", SportId = 1, Description = "" },                          // index => 28


                #region Others
                new Workout{ Name = "Dumbbell Curl", SportId = 1, Description = "" }, // index => 1
                new Workout{ Name = "Dumbbell Hammer Curl", SportId = 1, Description = "" }, // index => 2
                new Workout{ Name = "Kettlebell Goblet Curl", SportId = 1, Description = "" }, // index => 3
                new Workout{ Name = "Kettlebell Concentration Curl", SportId = 1, Description = "" }, // index => 4
                new Workout{ Name = "Kettlebell Preacher Curl", SportId = 1, Description = "" }, // index => 5
                new Workout{ Name = "Kettlebell Single Arm Curl", SportId = 1, Description = "" }, // index => 6
                new Workout{ Name = "Biceps Stretch Variation Five", SportId = 3, Description = "" }, // index => 7
                new Workout{ Name = "Biceps Stretch Variation Four", SportId = 3, Description = "" }, // index => 8
                new Workout{ Name = "Biceps Stretch Variation Three", SportId = 3, Description = "" }, // index => 9
                new Workout{ Name = "Biceps Stretch Variation Two", SportId = 3, Description = "" }, // index => 10
                new Workout{ Name = "Biceps Stretch Variation One", SportId = 3, Description = "" }, // index => 11
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
                new Workout{ Name = "Plate Bicep Curl", SportId = 1, Description = "" }, // index => 28
                new Workout{ Name = "Plate Curl To Overhead Press", SportId = 1, Description = "" }, // index => 29
                new Workout{ Name = "Plate Curl To Overhead Press To Tricep Extension", SportId = 1, Description = "" }, // index => 30
                new Workout{ Name = "Plate Squat Hold Curl", SportId = 1, Description = "" }, // index => 31
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
                new Workout{ Name = "Plate Pinch Grip Row", SportId = 1, Description = "" }, // index => 57
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
                new Workout{ Name = "Bosu Ball Curl", SportId = 1, Description = "" }, // index => 70
                new Workout{ Name = "Bosu Ball Row", SportId = 1, Description = "" }, // index => 71
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
                new Workout{ Name = "Smith Machine Underhand Row", SportId = 1, Description = "" }, // index => 100
                new Workout{ Name = "Cable Seated Bayesian Reverse Curl", SportId = 1, Description = "" }, // index => 89
                new Workout{ Name = "Cable Reverse Bayesian Curl", SportId = 1, Description = "" }, // index => 90
                new Workout{ Name = "Cable Hammer Bayesian Curl", SportId = 1, Description = "" }, // index => 91
                new Workout{ Name = "Kettlebell Single Arm Reverse Curl", SportId = 1, Description = "" }, // index => 96
                new Workout{ Name = "Kettlebell Single Arm Row On Bench", SportId = 1, Description = "" }, // index => 97
                new Workout{ Name = "Smith Machine Drag Curl", SportId = 1, Description = "" }, // index => 98
                new Workout{ Name = "Smith Machine Overhand Row", SportId = 1, Description = "" }, // index => 99
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
                new Workout{ Name = "Weighted Chin Ups", SportId = 1, Description = "" }, // index => 131
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

                #region Other

                new WorkoutInstruction{ WorkoutId = workouts[29].Id , Step = 1 , Instruction = "" },
                #endregion

            };
        };

        var workoutEquipment = new List<WorkoutEquipment>();
        if (!await context.WorkoutEquipment.AnyAsync())
        {
            var barbellId  = context.Equipments.Where(x => x.Name == "Barbell").Select(x => x.Id).FirstOrDefault();
            var ezbarId  = context.Equipments.Where(x => x.Name == "E-Z Curl Bar").Select(x => x.Id).FirstOrDefault();
            var cableMachineId = context.Equipments.Where(x => x.Name == "Cable Machine").Select(x => x.Id).FirstOrDefault();
            var pullUpMachineId = context.Equipments.Where(x => x.Name == "Pull Up Machine").Select(x => x.Id).FirstOrDefault();
            var MachineId = context.Equipments.Where(x => x.Name == "Machine").Select(x => x.Id).FirstOrDefault();

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
                new WorkoutEquipment{ WorkoutId = workouts[24].Id, EquipmentId = MachineId },
                new WorkoutEquipment{ WorkoutId = workouts[25].Id, EquipmentId = MachineId },
                new WorkoutEquipment{ WorkoutId = workouts[26].Id, EquipmentId = MachineId },
                new WorkoutEquipment{ WorkoutId = workouts[27].Id, EquipmentId = MachineId },
                new WorkoutEquipment{ WorkoutId = workouts[28].Id, EquipmentId = MachineId },
                new WorkoutEquipment{ WorkoutId = workouts[29].Id, EquipmentId = MachineId },
                #endregion

                new WorkoutEquipment{ WorkoutId = workouts[16].Id, EquipmentId = 21 },

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

                new WorkoutLevel{ WorkoutId = workouts[16].Id , Level = Difficulty.Novice},

            };
        };

        var bodyWorkouts = new List<BodyWorkout>();
        if (!await context.BodyWorkouts.AnyAsync())
        {
            bodyWorkouts = new List<BodyWorkout>
            {
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[0].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[1].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[2].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[3].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[4].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[5].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[6].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[7].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[8].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[9].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[10].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[11].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[12].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[13].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[14].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[15].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[16].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[17].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[18].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[19].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[20].Id },
                new BodyWorkout{ BodyId = 25, WorkoutId = workouts[21].Id },
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
