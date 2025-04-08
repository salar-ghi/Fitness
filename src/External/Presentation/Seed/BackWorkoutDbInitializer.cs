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
            
            // Traps (mid-back) // Machine
            new Workout{ Name = "Machine Seated Cable Row", SportId = bodybuildingId, Description = "" },                               // index => 4
            new Workout{ Name = "Narrow Pulldown", SportId = bodybuildingId, Description = "" },                                        // index => 5
            new Workout{ Name = "Neutral Pulldown", SportId = bodybuildingId, Description = "" },                                       // index => 6
            new Workout{ Name = "Machine Plate Loaded Low Row", SportId = bodybuildingId, Description = "" },                           // index => 7

            // Traps (mid-back) // Stretches
            new Workout{ Name = "Traps mid back Stretch Variation Two", SportId = cardioSportId, Description = "" },                    // index => 8
            new Workout{ Name = "Traps mid back Stretch Variation One", SportId = cardioSportId, Description = "" },                    // index => 9

            // Traps (mid-back) // Plate
            new Workout{ Name = "Plate Internally Rotated Rear Delt Fly", SportId = bodybuildingId, Description = "" },                 // index => 10
            new Workout{ Name = "Plate Rear Delt Fly", SportId = bodybuildingId, Description = "" },                                    // index => 11
            new Workout{ Name = "Plate Weighted Inverted Row", SportId = bodybuildingId, Description = "" },                            // index => 12
            new Workout{ Name = "Weighted Pull Ups", SportId = bodybuildingId, Description = "" },                                      // index => 13

            // Traps (mid-back) // smith-machine
            new Workout{ Name = "Smith Machine Inverted Row", SportId = bodybuildingId, Description = "" },                             // index => 14
            new Workout{ Name = "Smith Machine Assisted Pullup", SportId = bodybuildingId, Description = "" },                          // index => 15
            
            // Traps (mid-back) // dumbells
            new Workout{ Name = "Dumbbell Laying Silverback Shrug", SportId = bodybuildingId, Description = "" },                       // index => 16
            new Workout{ Name = "Dumbbell Silverback Shrug", SportId = bodybuildingId, Description = "" },                              // index => 17
            new Workout{ Name = "Dumbbell Row Bilateral", SportId = bodybuildingId, Description = "" },                                 // index => 18
            new Workout{ Name = "Dumbbell Row Unilateral", SportId = bodybuildingId, Description = "" },                                // index => 19
            new Workout{ Name = "Dumbbell Rear Delt Row", SportId = bodybuildingId, Description = "" },                                 // index => 20
            new Workout{ Name = "Dumbbell Seated Rear Delt Row", SportId = bodybuildingId, Description = "" },                          // index => 21
            new Workout{ Name = "Dumbbell Weighted Pull Ups", SportId = bodybuildingId, Description = "" },                             // index => 22

            // Traps (mid-back) // Cables
            new Workout{ Name = "Cable Silverback Shrug", SportId = bodybuildingId, Description = "" },                                 // index => 23
            new Workout{ Name = "Cable Row Bar Standing Row", SportId = bodybuildingId, Description = "" },                             // index => 24
            new Workout{ Name = "Cable Single Arm Underhand Grip Row", SportId = bodybuildingId, Description = "" },                    // index => 25
            new Workout{ Name = "Cable Single Arm Neutral Grip Row", SportId = bodybuildingId, Description = "" },                      // index => 26
            new Workout{ Name = "Cable Single Arm Rear Delt Row", SportId = bodybuildingId, Description = "" },                         // index => 27

            // Traps (mid-back) // TRX
            new Workout{ Name = "TRX Rear Delt Fly", SportId = bodybuildingId, Description = "" },                                      // index => 28
            new Workout{ Name = "TRX Rear Delt Row", SportId = bodybuildingId, Description = "" },                                      // index => 29
            new Workout{ Name = "TRX W Raise", SportId = bodybuildingId, Description = "" },                                            // index => 30

            // Traps (mid-back) // Vitruvian
            new Workout{ Name = "Vitruvian Row", SportId = bodybuildingId, Description = "" },                                          // index => 31
            new Workout{ Name = "Vitruvian Single Arm Row", SportId = bodybuildingId, Description = "" },                               // index => 32

            // Traps (mid-back) // Recovery
            new Workout{ Name = "Laying Ts", SportId = cardioSportId, Description = "" },                                               // index => 33
            new Workout{ Name = "Scapular Retraction", SportId = cardioSportId, Description = "" },                                     // index => 34

            // Traps (mid-back) // Bodyweight
            new Workout{ Name = "Pull Ups", SportId = bodybuildingId, Description = "" },                                               // index => 35
            new Workout{ Name = "Inverted Row", SportId = bodybuildingId, Description = "" },                                           // index => 36
            new Workout{ Name = "Elevated Pike Press", SportId = bodybuildingId, Description = "" },                                    // index => 37
            new Workout{ Name = "Bodyweight Pike Press", SportId = bodybuildingId, Description = "" },                                  // index => 38
            new Workout{ Name = "Bodyweight Overhand Inverted Row", SportId = bodybuildingId, Description = "" },                       // index => 39
            new Workout{ Name = "Bodyweight Standing Inverted Row", SportId = bodybuildingId, Description = "" },                       // index => 40
            new Workout{ Name = "L Sit Pull Up", SportId = bodybuildingId, Description = "" },                                          // index => 41

            // Traps (mid-back) // KettleBells
            new Workout{ Name = "Kettlebell Incline Shrug", SportId = bodybuildingId, Description = "" },                               // index => 42
            new Workout{ Name = "Kettlebell Deadlift (Single)", SportId = bodybuildingId, Description = "" },                           // index => 43
            new Workout{ Name = "Kettlebell Row (Single)", SportId = bodybuildingId, Description = "" },                                // index => 44
            new Workout{ Name = "Kettlebell Silverback Shrug (Single)", SportId = bodybuildingId, Description = "" },                   // index => 45
            new Workout{ Name = "Kettlebell Silverback Shrug (Single)", SportId = bodybuildingId, Description = "" },                   // index => 46
            new Workout{ Name = "Kettlebell Silverback Shrug", SportId = bodybuildingId, Description = "" },                            // index => 47

            // Traps (mid-back) // Band
            new Workout{ Name = "Band Horizontal Shrug", SportId = cardioSportId, Description = "" },                                   // index => 48
            new Workout{ Name = "Band Pull Apart", SportId = cardioSportId, Description = "" },                                         // index => 49
            new Workout{ Name = "Band High Face Pull", SportId = cardioSportId, Description = "" },                                     // index => 50
            new Workout{ Name = "Band Rear Delt Fly", SportId = cardioSportId, Description = "" },                                      // index => 51

            // Traps (mid-back) // Yoga
            new Workout{ Name = "Cat Pose", SportId = yogaSportId, Description = "" },                                                  // index => 52
            new Workout{ Name = "Easy Seated Twist Pose", SportId = yogaSportId, Description = "" },                                    // index => 53
            new Workout{ Name = "Revolved Side Angle Pose With Prayer Hands", SportId = yogaSportId, Description = "" },                // index => 54
            new Workout{ Name = "Revolved Side Angle Pose With Prayer Hands Beginner", SportId = yogaSportId, Description = "" },       // index => 55
            new Workout{ Name = "Seated Twist", SportId = yogaSportId, Description = "" },                                              // index => 56

            // Lower Back // Barbell
            new Workout{ Name = "Barbell Sumo Deadlift", SportId = bodybuildingId, Description = "" },                                  // index => 57
            new Workout{ Name = "Barbell Romanian Deadlift", SportId = bodybuildingId, Description = "" },                              // index => 58
            new Workout{ Name = "Barbell Low Bar Squat", SportId = bodybuildingId, Description = "" },                                  // index => 59
            new Workout{ Name = "Barbell Coan Deadlift", SportId = bodybuildingId, Description = "" },                                  // index => 60
            new Workout{ Name = "Barbell Pause Squat", SportId = bodybuildingId, Description = "" },                                    // index => 61
            new Workout{ Name = "Landmine Romanian Deadlift", SportId = bodybuildingId, Description = "" },                             // index => 62
            new Workout{ Name = "Landmine Single Leg Romanian Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 63
            new Workout{ Name = "Landmine Snatch", SportId = bodybuildingId, Description = "" },                                        // index => 64
            new Workout{ Name = "Barbell Sumo Pause Deadlift", SportId = bodybuildingId, Description = "" },                            // index => 65
            new Workout{ Name = "Barbell Conventional Pause Deadlift", SportId = bodybuildingId, Description = "" },                    // index => 66
            new Workout{ Name = "Barbell Block Conventional Deadlift", SportId = bodybuildingId, Description = "" },                    // index => 67
            new Workout{ Name = "Barbell Deficit Conventional Deadlift", SportId = bodybuildingId, Description = "" },                  // index => 68
            new Workout{ Name = "Barbell Muscle Snatch", SportId = bodybuildingId, Description = "" },                                  // index => 69
            new Workout{ Name = "Barbell High Pull", SportId = bodybuildingId, Description = "" },                                      // index => 70
            new Workout{ Name = "Barbell Power Snatch", SportId = bodybuildingId, Description = "" },                                   // index => 71
            new Workout{ Name = "Barbell Snatch Grip High Pull", SportId = bodybuildingId, Description = "" },                          // index => 72
            new Workout{ Name = "Barbell High Bar Good Morning", SportId = bodybuildingId, Description = "" },                          // index => 73
            new Workout{ Name = "Barbell Low Bar Good Morning", SportId = bodybuildingId, Description = "" },                           // index => 74
            new Workout{ Name = "Barbell Staggered Deadlift", SportId = bodybuildingId, Description = "" },                             // index => 75
            new Workout{ Name = "Barbell Single Leg Deadlift", SportId = bodybuildingId, Description = "" },                            // index => 76
            new Workout{ Name = "Barbell Pause Box Squat", SportId = bodybuildingId, Description = "" },                                // index => 77

            new Workout{ Name = "", SportId = bodybuildingId, Description = "" },                          // index => 73

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

            #region Traps & Stretches
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 1 , Instruction = "Sit on the ground and lay one leg flat and the other over the top."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 2 , Instruction = "Hold your leg with the same side arm and slowly rotate your hips and back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 3 , Instruction = "Hold at the peak of the stretch, then slowly return to starting position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[8].Id , Step = 4 , Instruction = "Switch sides and repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[9].Id , Step = 1 , Instruction = "Stand up with your feet shoulder width apart. Place one arm across the front of your chest at shoulder height, press the forearm of your other arm above the elbow, hooking the stretching arm with your hand."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[9].Id , Step = 2 , Instruction = "Press the arm until it is straight and rotate your upper torso to engage the stretch even deeper."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[9].Id , Step = 3 , Instruction = "Repeat with your other arm."},
            #endregion

            #region Traps & Plate
            new WorkoutInstruction{ WorkoutId = backWorkouts[10].Id , Step = 1 , Instruction = "With plates in either hand, bend your knees with your feet slightly bowed out. Hinge forward with a flat back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[10].Id , Step = 2 , Instruction = "Maintain an overhand grip and internally rotated shoulders."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[10].Id , Step = 3 , Instruction = "Raise your arms backward toward the ceiling while maintaining a light band in your elbows."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[11].Id , Step = 1 , Instruction = "Keep your back straight and bend forward slightly at the waist."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[11].Id , Step = 2 , Instruction = "With arms extended, raise the weights out to your sides until they are in line with your shoulders."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[11].Id , Step = 3 , Instruction = "Pause briefly and then lower the weights back to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[12].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip. Place a plate on your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[12].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[12].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[13].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended. Weight hanging between your legs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[13].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[13].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Smith-Machine
            new WorkoutInstruction{ WorkoutId = backWorkouts[14].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[14].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[14].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[15].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended. Leave your feet on the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[15].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar. Use your legs top assist you up."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[15].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Dumbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[16].Id , Step = 1 , Instruction = "Lay on an incline bench with your arms hanging freely."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[16].Id , Step = 2 , Instruction = "Pull your shoulder blades back toward the ceiling."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[17].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding dumbbells with both hands in front just past shoulder width."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[17].Id , Step = 2 , Instruction = "Bend forward at the hips with a slight bend in your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[17].Id , Step = 3 , Instruction = "Engage your shoulder blades, as if you are trying to touch them together."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[18].Id , Step = 1 , Instruction = "Grab both dumbbells and hinge forward at the hips. Make sure you keep a flat back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[18].Id , Step = 2 , Instruction = "The closer your torso is to parallel with the ground the longer the range of motion will be at your shoulder. The better the results you'll get from the exercise."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[18].Id , Step = 3 , Instruction = "Let your arms hang freely, and then pull your elbow joint straight back toward the ceiling."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[19].Id , Step = 1 , Instruction = "Brace your off arm against something stable (bench, box). Stagger your stance so your leg on the side of your working arm is back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[19].Id , Step = 2 , Instruction = "Try to get your torso to parallel with the ground. That will extend your range of motion."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[19].Id , Step = 3 , Instruction = "Let your arm hang freely and then pull your elbow back. Imagine you've got a tennis ball in your armpit and squeeze it each rep."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[20].Id , Step = 1 , Instruction = "Hinge forward at the hips while maintaining a flat back. Try to get your torso as close to parallel with the ground as your mobility will allow for."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[20].Id , Step = 2 , Instruction = "Let your arms hang in front of you. Pull your elbows back towards the ceiling while flaring your elbows outward."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[21].Id , Step = 1 , Instruction = "Sit on a bench. Put your chest in your lap. Try to get your torso as close to parallel with the ground as your mobility will allow for."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[21].Id , Step = 2 , Instruction = "Let your arms hang in front of you. Pull your elbows back towards the ceiling while flaring your elbows outward."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[22].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[22].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[22].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Cables
            new WorkoutInstruction{ WorkoutId = backWorkouts[23].Id , Step = 1 , Instruction = "Use a bar attachment. Cable should be set all the way to the bottom."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[23].Id , Step = 2 , Instruction = "Stand up with the attachment in hand, walk a couple of steps back make sure you are standing upright and not leaning backwards."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[23].Id , Step = 3 , Instruction = "Retract your shoulder blades and then protract to return to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[24].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a row bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[24].Id , Step = 2 , Instruction = "Pull the handles back using your arms. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[24].Id , Step = 3 , Instruction = "Pull the handles towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[25].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm upward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[25].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[25].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[26].Id , Step = 1 , Instruction = "Place the cable at shoulder height. Use a handle attachment. Face your palm toward the midline of your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[26].Id , Step = 2 , Instruction = "Pull the handle back using your arms. Push out your chest."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[26].Id , Step = 3 , Instruction = "Pull the handle towards your body until your hands are beside your abdomen."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[27].Id , Step = 1 , Instruction = "Use a handle attachment, grab with an overhand grip and take a position with the cable crossing your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[27].Id , Step = 2 , Instruction = "Pull your elbows back while flaring your elbows outward."},
            #endregion

            #region Traps & TRX
            new WorkoutInstruction{ WorkoutId = backWorkouts[28].Id , Step = 1 , Instruction = "Stand facing away from the TRX straps and grab the handles with both hands."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[28].Id , Step = 2 , Instruction = "Step forward so that your body is in a plank position, with your arms straight and your body in a straight line from your head to your heels."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[28].Id , Step = 3 , Instruction = "Keeping your arms straight, slowly lift your arms out to the side, keeping them at the same height as your shoulders. Your body should form a \"T\" shape."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 1 , Instruction = "Stand facing away from the TRX straps and grab the handles with both hands."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 2 , Instruction = "Step away so your body is leaning away from the anchor point."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 3 , Instruction = "Flex your elbows and pull your elbows straight back behind your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[29].Id , Step = 4 , Instruction = "Make sure to keep your elbows flared outward."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[30].Id , Step = 1 , Instruction = "Hold the TRX straps and lean away from the anchor point."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[30].Id , Step = 2 , Instruction = "Pull your elbows back while externally rotating your shoulder joint. Your arms should make a W shape at the back portion of the exercise."},
            #endregion

            #region Traps & Vitruvian
            new WorkoutInstruction{ WorkoutId = backWorkouts[31].Id , Step = 1 , Instruction = "Hold bosu and hinge forward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[31].Id , Step = 2 , Instruction = "Pull bosu towards chest, squeezing shoulder blades."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[32].Id , Step = 1 , Instruction = "Take a staggered stance and hinge forward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[32].Id , Step = 2 , Instruction = "Grab one of the handle attachments and pull your elbow toward the ceiling."},
            #endregion

            #region Traps & Recovery
            new WorkoutInstruction{ WorkoutId = backWorkouts[33].Id , Step = 1 , Instruction = "Lie on your front, arms outstretched to the side."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[33].Id , Step = 2 , Instruction = "Raise head and chest off the ground."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[33].Id , Step = 3 , Instruction = "Raise and lower your arms (flapping wings motion) by contracting and relaxing the muscles in between your shoulder blades."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[34].Id , Step = 1 , Instruction = "From the standing or seated position straighten your back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[34].Id , Step = 2 , Instruction = "Pull the shoulders back but keep them relaxed."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[34].Id , Step = 3 , Instruction = "Move shoulders backwards and return to the starting, relaxed position."},
            #endregion

            #region Traps & BodyWeight
            new WorkoutInstruction{ WorkoutId = backWorkouts[35].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[35].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[35].Id , Step = 3 , Instruction = "Lower your body back to starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[36].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[36].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[36].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 1 , Instruction = "Use a bench or an object to elevate your feet."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 2 , Instruction = "Lower your head towards the floor by bending your elbows."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 3 , Instruction = "Push through your hands and return to the starting pike position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[37].Id , Step = 4 , Instruction = "Repeat"},

            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 1 , Instruction = "Start in a plank position. Push your hips up toward the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 2 , Instruction = "Lower your head towards the floor by bending your elbows."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 3 , Instruction = "Push through your hands and return to the starting pike position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[38].Id , Step = 4 , Instruction = "Repeat"},

            new WorkoutInstruction{ WorkoutId = backWorkouts[39].Id , Step = 1 , Instruction = "Lay underneath a fixed horizontal bar and grab the bar with a wide overhand grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[39].Id , Step = 2 , Instruction = "Pull your body straight up to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[39].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[40].Id , Step = 1 , Instruction = "Grab a door frame or a rack and place your feet near the frame."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[40].Id , Step = 2 , Instruction = "Start with your elbows extended, row your body towards your hands."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[40].Id , Step = 3 , Instruction = "Return to the starting position, your arms fully extended. Repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[41].Id , Step = 1 , Instruction = "Grasp the bar with an overhand grip, arms and shoulders fully extended. Pull your legs up until you're in an \"L\" position."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[41].Id , Step = 2 , Instruction = "Pull your body up until your chin is above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[41].Id , Step = 3 , Instruction = "Lower your body back to starting position."},
            #endregion

            #region Traps & Kettlebells
            new WorkoutInstruction{ WorkoutId = backWorkouts[42].Id , Step = 1 , Instruction = "Leaning across the back section of the bench, with feet firmly on the floor and with arms hanging to the sides."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[42].Id , Step = 2 , Instruction = "Holding the kettlebell in both hands engage your shoulder blades, as if you are trying to touch them together. Release the shrug."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[43].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[43].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[43].Id , Step = 3 , Instruction = "Return to standing position and repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[44].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[44].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[44].Id , Step = 3 , Instruction = "Lift the kettlebell upwards towards your chest and lower - repeat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[45].Id , Step = 1 , Instruction = "Stand with your feet shoulder width apart holding the kettlebell with both hands in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[45].Id , Step = 2 , Instruction = "Bend forward at the hips bringing the kettlebell to the floor while you slightly bend your knees, keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[45].Id , Step = 3 , Instruction = "Holding the kettlebell in both hands engage your shoulder blades, as if you are trying to touch them together. Release the shrug."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[46].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, kettlebell in each hand, hinge at hips."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[46].Id , Step = 2 , Instruction = "Pull kettlebells while flaring your elbows, squeezing shoulder blades. Keep back flat."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[47].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, hold one kettlebell in each hand at your sides, and lean forward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[47].Id , Step = 2 , Instruction = "Lift your shoulders backward while keeping arms straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[47].Id , Step = 3 , Instruction = "Lower shoulders back down, repeat for desired reps."},
            #endregion

            #region Traps & Band
            new WorkoutInstruction{ WorkoutId = backWorkouts[48].Id , Step = 1 , Instruction = "Anchor the band at shoulder height. Take a few steps away until the band is taut."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[48].Id , Step = 2 , Instruction = "Retract your shoulder blades straight back in schools. Then protract to the starting position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[49].Id , Step = 1 , Instruction = "Grab the band with a shoulder width grip. Point your arms straight in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[49].Id , Step = 2 , Instruction = "Retract your shoulder blades and shoulder joint until the band taps your chest."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[50].Id , Step = 1 , Instruction = "Start with a band anchored to a high point. Stagger your stance."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[50].Id , Step = 2 , Instruction = "Pull the band to the bridge of your nose."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[51].Id , Step = 1 , Instruction = "Start by standing between the two anchored bands with your feet shoulder-width apart and the bands positioned at a high point."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[51].Id , Step = 2 , Instruction = "Grasp the ends of each band with your hands, keeping your palms facing each other.\r\n"},
            new WorkoutInstruction{ WorkoutId = backWorkouts[51].Id , Step = 3 , Instruction = "Keeping your arms slightly bent and your back straight, slowly pull the bands away from your body until your arms are extended straight out to the sides. Hold for a second, then slowly release back to the starting position. Repeat for desired reps."},
            #endregion

            #region Traps & Yoga
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Begin on your hands and knees with your wrists directly under your shoulders and your knees directly under your hips."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Inhale and arch your back, lifting your tailbone and head towards the ceiling, while lowering your belly towards the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Exhale and round your spine, tucking your chin towards your chest, and bringing your tailbone towards your knees."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[52].Id , Step = 1 , Instruction = "Repeat these movements, flowing smoothly between the two poses, for several breaths."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Begin seated with your legs extended in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Bend your right knee and place your foot on the floor next to your left thigh."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Inhale and reach your left arm up towards the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Exhale and twist to the right, placing your left elbow on the outside of your right knee. Hold for a few breaths and then repeat on the other side."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Begin seated with your legs extended in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Bend your right knee and place your foot on the floor next to your left thigh."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Inhale and reach your left arm up towards the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[53].Id , Step = 1 , Instruction = "Exhale and twist to the right, placing your left elbow on the outside of your right knee. Hold for a few breaths and then repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Begin in Warrior II pose, with your right foot forward and your left foot back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Bring your hands together in a prayer position at your heart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Exhale and twist your torso to the right, placing your left elbow on the outside of your right knee."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[54].Id , Step = 1 , Instruction = "Hold for several breaths and then repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Begin in a low lunge position with your right foot forward and your left knee on the ground."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Bring your hands together in a prayer position at your heart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Exhale and twist your torso to the right, placing your left elbow on the outside of your right knee."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[55].Id , Step = 1 , Instruction = "Hold for several breaths and then repeat on the other side."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Begin seated with your legs extended in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Bend your right knee and place your foot on the floor next to your left thigh."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Inhale and reach your left arm up towards the ceiling."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[56].Id , Step = 1 , Instruction = "Exhale and twist to the right, placing your left elbow on the outside of your right knee. Hold for a few breaths and then repeat on the other side."},
            #endregion

            #region Lower back & Barbell
            new WorkoutInstruction{ WorkoutId = backWorkouts[57].Id , Step = 1 , Instruction = "Stance width can vary with a sumo DL. Some prefer toes near the plates. Others prefer a more narrow stance to get more drive off the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[57].Id , Step = 2 , Instruction = "Make sure your arms are inside your legs. The bar should be just over your mid-foot. Flatten your back and push your heels into the floor."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[57].Id , Step = 3 , Instruction = "Try to extend your knees and hips simultaneously."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[58].Id , Step = 1 , Instruction = "Take a shoulder width, double overhand or mixed grip."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[58].Id , Step = 2 , Instruction = "Push your hips back while leaving your knees mostly extended. Look for a stretch in your hamstrings."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[58].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward until you're back in a standing position."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[59].Id , Step = 1 , Instruction = "Pull your shoulder blades back really hard and place the bar on your posterior delts."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[59].Id , Step = 2 , Instruction = "Push your hips back and break at the knees to initiate the squat."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[59].Id , Step = 3 , Instruction = "Aim to get your hamstrings to parallel with the ground. Push your heels into the floor and squat back up to a standing position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 1 , Instruction = "Stand with your feet hip-width apart and place a barbell on the floor in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 2 , Instruction = "Bend at the hips and knees to grasp the barbell with an overhand grip, positioning your hands just outside of your hips."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 3 , Instruction = "Keeping your back straight and your core engaged, lift the barbell off the floor by extending your hips and knees."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[60].Id , Step = 4 , Instruction = "As you lift the barbell, pull your shoulders back and squeeze your glutes to fully extend your hips at the top of the movement."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[61].Id , Step = 1 , Instruction = "Stand with your feet shoulder-width apart and a barbell resting on your upper back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[61].Id , Step = 2 , Instruction = "Lower your body into a squat position, pausing for a moment at the bottom of the movement before standing back up."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[61].Id , Step = 3 , Instruction = "Push through your heels to return to the standing position."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 1 , Instruction = "Stand in front of the landmine with your feet hip-width apart and your knees slightly bent. Grasp the landmine barbell with both hands, palms facing each other, and hold it in front of your thighs."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 2 , Instruction = "Keeping your back straight and your core engaged, hinge at the hips and push your hips back, allowing the landmine to travel down your thighs. Lower the landmine by bending forward at the hips while keeping your back flat, allowing the barbell to move closer to the floor. Continue the movement until you feel a stretch in your hamstrings, keeping your legs relatively straight but with a slight bend in the knees."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 3 , Instruction = "Reverse the movement by pushing your hips forward and driving through your heels while keeping your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[62].Id , Step = 4 , Instruction = "Repeat for the desired number of reps."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[63].Id , Step = 1 , Instruction = "Grab the end of the landmine and stand perpendicular to the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[63].Id , Step = 2 , Instruction = "Lift your inside leg and keep your outside leg planted."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[63].Id , Step = 3 , Instruction = "Push your hips back keeping your knees mostly extended. When you feel the stretch in your hams, push your hips forward until you are standing upright."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[64].Id , Step = 1 , Instruction = "Hold the end of the bar in front of you."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[64].Id , Step = 2 , Instruction = "Pop your hips, pull your elbows up to the ceiling, and get underneath the bar."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[65].Id , Step = 1 , Instruction = "Set up for a sumo deadlift, grip the barbell." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[65].Id , Step = 2 , Instruction = "Lift, pause at knee height." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[65].Id , Step = 3 , Instruction = "Hold briefly, then complete the lift; reset and repeat for desired reps." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[66].Id , Step = 1 , Instruction = "Set up for a standard deadlift, grip the barbell."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[66].Id , Step = 1 , Instruction = "Lift, pause at knee height."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[66].Id , Step = 1 , Instruction = "Hold briefly, then complete the lift; reset and repeat for desired reps."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 1 , Instruction = "Stand with your mid-foot under the bar, plates should be on blocks, and grip the bar with your hands, about a shoulder width apart." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 2 , Instruction = "Bend your knees, then lift the bar by straightening your back. It is important to keep your back straight." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 3 , Instruction = "Stand to your full height and hold." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[67].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 1 , Instruction = "Stand with your mid-foot under the bar, feet should be on a plate or elevated platform, and grip the bar with your hands, about a shoulder width apart."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 2 , Instruction = "Bend your knees, then lift the bar by straightening your back. It is important to keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 3 , Instruction = "Stand to your full height and hold."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[68].Id , Step = 4 , Instruction = "Lower the bar to the floor by bending your knees and keeping your back straight."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, grip the barbell with a wide overhand grip, and keep your back straight and core engaged."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 2 , Instruction = "Lift the barbell by explosively extending your hips, knees, and ankles while keeping the bar close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 3 , Instruction = "As the bar reaches chest level, rotate your wrists and elbows up and back, transitioning into an overhead press."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[69].Id , Step = 4 , Instruction = "Fully extend your arms overhead, stabilize the bar, then lower it back to the starting position with control."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[70].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, grip the barbell slightly wider than shoulder-width, and keep your back straight."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[70].Id , Step = 2 , Instruction = "Drive through your legs, extending your hips, knees, and ankles explosively while pulling the barbell upward."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[70].Id , Step = 3 , Instruction = "As the bar rises, pull it close to your body, leading with your elbows until it reaches chest level."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, barbell over midfoot. Grip the bar wide (outside shoulders), hook grip recommended."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 2 , Instruction = "Keep chest up, back straight, and drive through heels to lift the bar off the ground, keeping it close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 3 , Instruction = "As the bar reaches mid-thigh, explode upwards by extending hips, knees, and ankles, shrugging shoulders and pulling the bar high."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[71].Id , Step = 4 , Instruction = "Drop under the bar slightly, catching it overhead with arms locked out. Stand up fully to complete the lift."},

            new WorkoutInstruction{ WorkoutId = backWorkouts[72].Id , Step = 1 , Instruction = "Stand with feet hip-width apart, gripping the barbell with a wide (snatch-width) grip. Keep your back straight, chest up, and bar close to your body."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[72].Id , Step = 2 , Instruction = "Drive through your legs, extending your hips, knees, and ankles while pulling the barbell up explosively."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[72].Id , Step = 3 , Instruction = "Shrug your shoulders forcefully and pull the bar as high as possible, keeping elbows above the bar."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[72].Id , Step = 4 , Instruction = "Lower the bar back to the starting position in a controlled manner and reset for the next rep."},
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 1 , Instruction = "Place the bar on your traps. You may need a pad so the bar doesn't dig into your cervical spine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 2 , Instruction = "Push your hips straight back. Your knees should stay MOSTLY extended (think soft knees). Also make sure to" },
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 3 , Instruction = "Look for what feels like a stretch in your hamstrings. The stretch feeling means you're likely nearing the end of your Range of Motion without rounding your spine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[73].Id , Step = 4 , Instruction = "When you feel the stretch push your hips forward until you're in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 1 , Instruction = "Place the bar between your traps and rear delts. Pull your shoulder blades back to give the bar a shelf to sit on." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 2 , Instruction = "Push your hips back until you feel a stretch in your hamstrings. This means you're nearing the end of your Range of Motion with out rounding your spine." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 3 , Instruction = "When you feel the stretch push your hips forward until you're in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[75].Id , Step = 1 , Instruction = "Place one foot behind. You should only be on your toes on that back foot. Your front foot should be planted flat the entire time." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[75].Id , Step = 2 , Instruction = "Bend your back knee and push your hips back. Look for a stretch in your front hamstring." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[75].Id , Step = 3 , Instruction = "When you feel the stretch, push your hips forward again until you're back in a standing position." },
            
            new WorkoutInstruction{ WorkoutId = backWorkouts[76].Id , Step = 1 , Instruction = "Start by pushing your hips straight back and extending your non-working leg behind you. It is ok to touch your other foot back to the ground each rep." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[76].Id , Step = 2 , Instruction = "Leave your knee mostly extended. Look for a stretch in your hamstring. When you feel the stretch, push your hips forward until you're back in a standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[77].Id , Step = 1 , Instruction = "Stand in front of a box or bench with your feet shoulder-width apart and a barbell resting on your upper back."},
            new WorkoutInstruction{ WorkoutId = backWorkouts[77].Id , Step = 2 , Instruction = "Lower your body into a squat position, sitting back onto the box and pausing for a moment before standing back up." },
            new WorkoutInstruction{ WorkoutId = backWorkouts[77].Id , Step = 3 , Instruction = "Push through your heels to return to the standing position." },

            new WorkoutInstruction{ WorkoutId = backWorkouts[74].Id , Step = 1 , Instruction = ""},
            
            #endregion

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

            #region Traps & Stretches
            new WorkoutEquipment{ WorkoutId = backWorkouts[8].Id, EquipmentId = stretchesId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[9].Id, EquipmentId = stretchesId },
            #endregion

            #region Traps & Plate
            new WorkoutEquipment{ WorkoutId = backWorkouts[10].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[11].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[12].Id, EquipmentId = plateId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[13].Id, EquipmentId = plateId },
            #endregion

            #region Traps & Smith-Machine
            new WorkoutEquipment{ WorkoutId = backWorkouts[14].Id, EquipmentId = smithMachineId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[15].Id, EquipmentId = smithMachineId },
            #endregion

            #region Traps & Dumbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[16].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[17].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[18].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[19].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[20].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[21].Id, EquipmentId = dumbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[22].Id, EquipmentId = dumbellId },
            #endregion

            #region Traps & Cables
            new WorkoutEquipment{ WorkoutId = backWorkouts[23].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[24].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[25].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[26].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[27].Id, EquipmentId = barbellId },
            #endregion

            #region Traps & TRX
            new WorkoutEquipment{ WorkoutId = backWorkouts[28].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[29].Id, EquipmentId = trxId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[30].Id, EquipmentId = trxId },
            #endregion

            #region Traps & Vitruvian
            new WorkoutEquipment{ WorkoutId = backWorkouts[31].Id, EquipmentId = vitruvianId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[32].Id, EquipmentId = vitruvianId },
            #endregion

            #region Traps & Recovery
            new WorkoutEquipment{ WorkoutId = backWorkouts[33].Id, EquipmentId = cardioId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[34].Id, EquipmentId = cardioId },
            #endregion

            #region Traps & BodyWeight
            new WorkoutEquipment{ WorkoutId = backWorkouts[35].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[36].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[37].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[38].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[39].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[40].Id, EquipmentId = bodyweightId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[41].Id, EquipmentId = bodyweightId },
            #endregion

            #region Traps & Kettlebells
            new WorkoutEquipment{ WorkoutId = backWorkouts[42].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[43].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[44].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[45].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[46].Id, EquipmentId = kettlebellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[47].Id, EquipmentId = kettlebellId },
            #endregion

            #region Traps & Band
            new WorkoutEquipment{ WorkoutId = backWorkouts[48].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[49].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[50].Id, EquipmentId = BandsId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[51].Id, EquipmentId = BandsId },
            #endregion

            #region Traps & Yoga
            new WorkoutEquipment{ WorkoutId = backWorkouts[52].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[53].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[54].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[55].Id, EquipmentId = yogaId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[56].Id, EquipmentId = yogaId },
            #endregion

            #region lower back & Barbell
            new WorkoutEquipment{ WorkoutId = backWorkouts[57].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[58].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[59].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[60].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[61].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[62].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[63].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[64].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[65].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[66].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[67].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[68].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[69].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[70].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[71].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[72].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[73].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[74].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[75].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[76].Id, EquipmentId = barbellId },
            new WorkoutEquipment{ WorkoutId = backWorkouts[77].Id, EquipmentId = barbellId },
            #endregion

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

            #region Traps & Stretches
            new WorkoutLevel{ WorkoutId = backWorkouts[8].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[9].Id , Level = Difficulty.Beginner},
            #endregion

            #region Traps & Plate
            new WorkoutLevel{ WorkoutId = backWorkouts[10].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[11].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[12].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[13].Id , Level = Difficulty.Advanced},
            #endregion

            #region Traps & Smith-Machine
            new WorkoutLevel{ WorkoutId = backWorkouts[14].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[15].Id , Level = Difficulty.Novice},
            #endregion

            #region Traps & Dumbell
            new WorkoutLevel{ WorkoutId = backWorkouts[16].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[17].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[18].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[19].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[20].Id , Level = Difficulty.Intermediate},
            new WorkoutLevel{ WorkoutId = backWorkouts[21].Id , Level = Difficulty.Beginner},
            new WorkoutLevel{ WorkoutId = backWorkouts[22].Id , Level = Difficulty.Intermediate},
            #endregion
            
            #region Traps & Cables
            new WorkoutLevel{ WorkoutId = backWorkouts[23].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[24].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[25].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[26].Id , Level = Difficulty.Novice},
            new WorkoutLevel{ WorkoutId = backWorkouts[27].Id , Level = Difficulty.Advanced},
            #endregion

            #region Traps & TRX
            new WorkoutLevel{ WorkoutId = backWorkouts[28].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[29].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[30].Id , Level = Difficulty.Beginner },
            #endregion

            #region Traps & Vitruvian
            new WorkoutLevel{ WorkoutId = backWorkouts[31].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[32].Id , Level = Difficulty.Beginner },
            #endregion

            #region Traps & Recovery
            new WorkoutLevel{ WorkoutId = backWorkouts[33].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[34].Id , Level = Difficulty.Novice },
            #endregion

            #region Traps & BodyWeight
            new WorkoutLevel{ WorkoutId = backWorkouts[35].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[36].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[37].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[38].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[39].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[40].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[41].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Traps & Kettlebells
            new WorkoutLevel{ WorkoutId = backWorkouts[42].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[43].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[44].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[45].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[46].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[47].Id , Level = Difficulty.Beginner },
            #endregion

            #region Traps & Band
            new WorkoutLevel{ WorkoutId = backWorkouts[48].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[49].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[50].Id , Level = Difficulty.Novice },
            new WorkoutLevel{ WorkoutId = backWorkouts[51].Id , Level = Difficulty.Intermediate },
            #endregion

            #region Traps & Yoga
            new WorkoutLevel{ WorkoutId = backWorkouts[52].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[53].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[54].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[55].Id , Level = Difficulty.Beginner },
            new WorkoutLevel{ WorkoutId = backWorkouts[56].Id , Level = Difficulty.Beginner },
            #endregion

            #region lower back and barbell
            new WorkoutLevel{ WorkoutId = backWorkouts[57].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[58].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[59].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[60].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[61].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[62].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[63].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[64].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[65].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[66].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[67].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[68].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[69].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[70].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[71].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[72].Id , Level = Difficulty.Intermediate },
            new WorkoutLevel{ WorkoutId = backWorkouts[73].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[74].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[75].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[76].Id , Level = Difficulty.Advanced },
            new WorkoutLevel{ WorkoutId = backWorkouts[77].Id , Level = Difficulty.Advanced },
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
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[1].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[2].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[3].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Machine
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[4].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[5].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[6].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[7].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Stretches
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[8].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[9].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Plate
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[10].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[11].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[12].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[13].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Smith-Machine
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[14].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[15].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Dumbell
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[16].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[17].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[18].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[19].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[20].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[21].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[22].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Cables
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[23].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[24].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[25].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[26].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[27].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Medicine-Ball
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[28].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[29].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[30].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Vitruvian
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[31].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[32].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Recovery
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[33].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[34].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & BodyWeight
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[35].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[36].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[37].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[38].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[39].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[40].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[41].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Kettlebells
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[42].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[43].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[44].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[45].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[46].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[47].Id, Target = PriorityTarget.Primary },
            #endregion

            #region Traps & Band
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[48].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[49].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[50].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[51].Id, Target = PriorityTarget.Secondary },
            #endregion

            #region Traps & Yoga
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[52].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[53].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[54].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[55].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = trapsId, WorkoutId = backWorkouts[56].Id, Target = PriorityTarget.Primary },
            #endregion

            #region lower back & Barbell
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[57].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[58].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[59].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[60].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[61].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[62].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[63].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[64].Id, Target = PriorityTarget.Secondary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[65].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[66].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[67].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[68].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[69].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[70].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[71].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[72].Id, Target = PriorityTarget.Primary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[73].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[74].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[75].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[76].Id, Target = PriorityTarget.Tertiary },
            new BodyWorkout{ BodyId = lowerBackId, WorkoutId = backWorkouts[77].Id, Target = PriorityTarget.Tertiary },
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
            new WorkoutSex{ WorkoutId = backWorkouts[4].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[4].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[5].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[5].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[6].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[6].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[7].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[7].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[8].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[8].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[9].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[9].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[10].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[10].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[11].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[11].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[12].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[12].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[13].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[13].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[14].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[14].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[15].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[15].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[16].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[16].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[17].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[17].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[18].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[18].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[19].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[19].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[20].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[20].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[21].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[21].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[22].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[22].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[23].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[23].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[24].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[24].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[25].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[25].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[26].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[26].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[27].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[27].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[28].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[28].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[29].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[29].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[30].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[30].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[31].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[31].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[32].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[32].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[33].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[33].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[34].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[34].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[35].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[35].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[36].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[36].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[37].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[37].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[38].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[38].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[39].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[39].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[40].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[40].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[41].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[41].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[42].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[42].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[43].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[43].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[44].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[44].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[45].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[45].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[46].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[46].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[47].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[47].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[48].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[48].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[49].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[49].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[50].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[50].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[51].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[51].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[52].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[52].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[53].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[53].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[54].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[54].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[55].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[55].Id, Sex = Sex.Female},
            new WorkoutSex{ WorkoutId = backWorkouts[56].Id, Sex = Sex.Male},
            new WorkoutSex{ WorkoutId = backWorkouts[56].Id, Sex = Sex.Female},
            
            #endregion
        };
        await context.WorkoutSex.AddRangeAsync(workoutSex);
        await context.SaveChangesAsync();
    }
}
