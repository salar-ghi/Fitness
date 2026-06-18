using Application.DTOs.Response;
using Domain.Enums;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel;

namespace Infrastructure.Services;

public class PlanManagingService : IPlanManagingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IChatService _chatService;
    private readonly FitnessContext _context;
    private readonly IBeginnerPlanService _beginnerPlanService;
    public PlanManagingService(IUnitOfWork unitOfWork, 
        IChatService chatService, 
        FitnessContext context,
        IBeginnerPlanService beginnerPlanService)
    {
        _unitOfWork = unitOfWork;
        _chatService = chatService;
        _context = context;
        _beginnerPlanService = beginnerPlanService;
    }


    public async Task PlanRegisterationManage(RegisterDto dto)
    {
        // instead of this, use mapping
        User user = new User
        {
            PhoneNumber = dto.PhoneNumber,
            Email = dto.Email,
        };

        // if user exist, do not create it any more and redirect user to generate app.
        // if not, create new user then generate app according to its input values..

        // Require to return result because should use result in next query
        await _unitOfWork.UserRepository.CreateAsync(user);
        var userId = (Guid)typeof(User).GetProperty("Id").GetValue(user);

        //-----------------------------------------------------------------


        // Set user role to athelete
        var athlete = new Athlete
        {
            UserId = userId,
            Height = dto.Height,
            Weight = dto.Weight,
            Gender = dto.Gender,
            AgeRange = dto.AgeRange,
            DateOfBirth = dto.DateOfBirth,
            BodyType = dto.BodyType,
            //Level = dto.Level,
        };
        await _unitOfWork.AthleteRepository.CreateAsync(athlete);

        // ____________________________--------------------------
        // ============>>>> ???????????????????????
        //  change the role of user or register the role of athlete or add the role of athlete
        // ____________________________--------------------------

        // Injuries Table
        List<AthleteInjuries> injuries = new List<AthleteInjuries>();
        foreach (var item in dto.Injuries)
        {
            var injury = new AthleteInjuries
            {
                AthleteId = Guid.NewGuid(),
                Name = item.name,
                Description = item.description,
                BodyId = item.bodyId,
                InjuredImgUrl = item.injuredImgUrl,
            };
            injuries.Add(injury);
        }
        await _unitOfWork.AthleteInjuriesRepository.CreateRangeAsync(injuries);


        // Diseases Table
        List<Disease> diseases = new List<Disease>();
        var DiseaseNum = dto.Diseases.Count;
        foreach (var item in dto.Diseases)
        {
            var disease = new Disease
            {
                AthleteId = Guid.NewGuid(), // ???????????????? 
                Name = item.name,
                Description = item.description,
                BodyId = item.bodyId,
            };
            diseases.Add(disease);
        }
        await _unitOfWork.DiseaseRepository.CreateRangeAsync(diseases);
    }


    //public async Task<PlanResponseDto> PlanGeneratingManagement(RegisterDto dto)
    public async Task PlanGeneratingManagement(RegisterDto dto)
    {
        // Plan itself =====>  it's really imporant 
        // plan relates to Workout Model and it should have lots of data in it.


        // PlanDays Table
        List<PlanDays> planDays = new List<PlanDays>();
        var planDaysNum = dto.PlanDays.Count();
        foreach (var item in dto.PlanDays)
        {
            var planDay = new PlanDays
            {
                PlanId = Guid.NewGuid(), /// ???????????????????  create a plan then link plan days
                Day = item.Day,
                Hour = item.Hour,
            };
            planDays.Add(planDay);
        }
        await _unitOfWork.PlanDaysRepository.CreateRangeAsync(planDays);

        List<MusclePriority> musclePriorities = new List<MusclePriority>();
        var muscleNum = dto.MusclePriorities.Count();
        foreach (var item in dto.MusclePriorities)
        {
            var muscle = new MusclePriority
            {
                PlanId = Guid.NewGuid(), // ????????????????? replace it with correct muscle
                BodyId = item.Id        // replace it with correct property
            };
            musclePriorities.Add(muscle);
        }
        await _unitOfWork.MusclePriorityRepository.CreateRangeAsync(musclePriorities);


        List<PlanEquipments> equipments = new List<PlanEquipments>();
        var equipmentNum = dto.Equipments.Count();
        foreach (var item in dto.Equipments)
        {
            var equipment = new PlanEquipments
            {
                PlanId = item.PlanId.Value,
                EquipmentId = item.Id,
            };
            equipments.Add(equipment);
        }
        await _unitOfWork.PlanEquipmentRepository.CreateRangeAsync(equipments);

    }

    public async Task PlanProcessingTask(PlanDto dto)
    {
        switch (dto.PlanDuration)
        {
            case Period.Daily:
                await _beginnerPlanService.GenerateDailyPlanWorkouts(dto, dto.Level);
                break;
            case Period.Weekly:
            case Period.Monthly:
            case Period.Quarterly:
                throw new NotImplementedException($"{dto.PlanDuration} plan generation is not implemented yet.");
            default:
                throw new ArgumentOutOfRangeException(nameof(dto.PlanDuration), dto.PlanDuration, "Unsupported plan duration.");
        }

    }

    public async Task<List<PlanWorkoutResponseDto>> TestPlanProcessingTask(PlanDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);

        NormalizePlanDto(dto);

        var bmi = await CalculateBmi(dto.Height, dto.Weight);
        var categorizeBmi = await CategorizeBMI(bmi);
        var bmr = await CalculateBmr(dto.Height, dto.Weight, dto.Age, dto.Gender.ToString());
        var bodyFat = CalculateBodyFatPercentage(bmi, dto.Age, dto.Gender.ToString());

        Console.WriteLine($"User BMI: {Math.Round(bmi, 2)} ({categorizeBmi})");
        Console.WriteLine($"User BMR: {bmr}");
        Console.WriteLine($"User BFP: {bodyFat}%");

        var weeksToGenerate = GetWeeksToGenerate(dto.PlanDuration);
        var planDays = dto.PlanDays.OrderBy(x => x.Day).ThenBy(x => x.Hour).ToList();
        var exercisesPerSession = GetExercisesPerSession(dto.Level, dto.WorkoutDurationPreference);
        var generatedWorkouts = new List<Workout>();
        var savedExercises = new List<Exercise>();

        var plan = await CreatePlanAsync(dto, planDays.Count);

        for (var week = 1; week <= weeksToGenerate; week++)
        {
            var sourceWeek = week % 2 == 0 ? week - 1 : week;
            var weekWorkouts = await QueryWorkoutsForWeekAsync(dto, exercisesPerSession * planDays.Count, sourceWeek);

            if (weekWorkouts.Count == 0)
            {
                continue;
            }

            generatedWorkouts.AddRange(weekWorkouts);
            savedExercises.AddRange(CreateExercisesForWeek(plan.Id, weekWorkouts, dto.Level, week));
        }

        if (savedExercises.Count > 0)
        {
            await _context.Exercises.AddRangeAsync(savedExercises);
            await _context.SaveChangesAsync();
        }

        return generatedWorkouts
            .DistinctBy(x => x.Id)
            .Select(PlanWorkoutResponseDto.FromWorkout)
            .ToList();
    }

    private static void NormalizePlanDto(PlanDto dto)
    {
        if (dto.DateOfBirth != default)
        {
            dto.ApplyAgeFromDateOfBirth(DateOnly.FromDateTime(DateTime.UtcNow));
        }

        dto.Height = dto.Height == default ? 170 : dto.Height;
        dto.Weight = dto.Weight == default ? 90 : dto.Weight;
        dto.Gender = dto.Gender == default ? Sex.Male : dto.Gender;
        dto.PlanDuration = dto.PlanDuration == default ? Period.Daily : dto.PlanDuration;

        if (dto.Age == default)
        {
            dto.Age = 32;
            dto.AgeRange = PlanDto.ResolveAgeRange(dto.Age);
        }

        dto.BodyType = dto.BodyType == default ? Domain.Enums.BodyType.Endomorph : dto.BodyType;
        dto.BodyShapeType = dto.BodyShapeType == default ? BodyShapeType.Heavy : dto.BodyShapeType;
        dto.Goal = dto.Goal == default ? FitnessGoal.LoseWeight : dto.Goal;
        dto.DesiredBodyType = dto.DesiredBodyType == default ? DesiredBodyType.Muscular : dto.DesiredBodyType;
        dto.Level = dto.Level == default ? Difficulty.Beginner : dto.Level;
        dto.Place = dto.Place == default ? Place.Home : dto.Place;
        dto.Name = string.IsNullOrWhiteSpace(dto.Name) ? "Fitness User" : dto.Name;
        dto.PhoneNumber = string.IsNullOrWhiteSpace(dto.PhoneNumber) ? $"generated-{Guid.NewGuid():N}" : dto.PhoneNumber;

        if (dto.PlanDays.Count == 0)
        {
            dto.PlanDays = new List<PlanDaysDto>
            {
                new() { Day = DayOfWeek.Monday, Hour = new TimeSpan(18, 0, 0) },
                new() { Day = DayOfWeek.Wednesday, Hour = new TimeSpan(18, 0, 0) },
                new() { Day = DayOfWeek.Friday, Hour = new TimeSpan(18, 0, 0) },
                new() { Day = DayOfWeek.Saturday, Hour = new TimeSpan(18, 0, 0) }
            };
        }

        if (dto.MusclePriorities.Count == 0)
        {
            dto.MusclePriorities = new List<MusclePriorityDto>
            {
                new((int)MuscleGroup.Chest, MuscleGroup.Chest.ToString()),
                new((int)MuscleGroup.Back, MuscleGroup.Back.ToString()),
                new((int)MuscleGroup.Shoulders, MuscleGroup.Shoulders.ToString()),
                new((int)MuscleGroup.Arms, MuscleGroup.Arms.ToString()),
            };
        }
    }

    private async Task<Plan> CreatePlanAsync(PlanDto dto, int weeklyTrainingDays)
    {
        var user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == dto.PhoneNumber);
        if (user is null)
        {
            user = new User
            {
                Id = Guid.NewGuid(),
                UserName = dto.PhoneNumber ?? dto.Name ?? $"user-{Guid.NewGuid():N}",
                PhoneNumber = dto.PhoneNumber,
                FName = dto.Name ?? "Fitness",
                LName = "User",
            };
            await _context.Users.AddAsync(user);
        }

        var athlete = await _context.Athletes.FirstOrDefaultAsync(x => x.UserId == user.Id);
        if (athlete is null)
        {
            athlete = new Athlete
            {
                Id = Guid.NewGuid(),
                UserId = user.Id,
                Height = dto.Height,
                Weight = dto.Weight,
                Gender = dto.Gender,
                AgeRange = dto.AgeRange,
                DateOfBirth = dto.DateOfBirth,
                BodyType = dto.BodyType,
                Level = dto.Level,
            };
            await _context.Athletes.AddAsync(athlete);
        }

        var plan = new Plan
        {
            Id = Guid.NewGuid(),
            PlanCode = $"PLAN-{DateTime.UtcNow:yyyyMMddHHmmss}-{Guid.NewGuid():N}"[..32],
            Level = dto.Level,
            Duration = dto.PlanDuration,
            DaysCount = weeklyTrainingDays,
            Place = dto.Place,
            AthleteId = athlete.Id,
            PlanDays = dto.PlanDays.Select(x => new PlanDays { Day = x.Day, Hour = x.Hour }).ToList(),
            PlanEquipments = dto.Equipments.Where(x => x.Id > 0).Select(x => new PlanEquipments { EquipmentId = x.Id }).ToList(),
            MusclePriorities = dto.MusclePriorities.Where(x => x.Id > 0).Select(x => new MusclePriority { BodyId = x.Id }).ToList(),
        };

        await _context.Plans.AddAsync(plan);
        await _context.SaveChangesAsync();
        return plan;
    }

    private async Task<List<Workout>> QueryWorkoutsForWeekAsync(PlanDto dto, int take, int sourceWeek)
    {
        var allowedLevels = GetAllowedLevels(dto.Level).ToList();
        var muscleGroups = ResolveMuscleGroups(dto.MusclePriorities).ToList();
        var equipmentIds = dto.Equipments.Where(x => x.Id > 0).Select(x => x.Id).Distinct().ToList();

        var query = _context.Workouts
            .Include(x => x.WorkoutInstructions)
            .Include(x => x.BodyWorkouts)
                .ThenInclude(x => x.Body)
            .Include(x => x.WorkoutEquipment)
                .ThenInclude(x => x.Equipment)
            .Include(x => x.Level)
            .Include(x => x.AgeRanges)
            .Include(x => x.Sex)
            .AsSplitQuery()
            .Where(x => x.Level.Any(level => allowedLevels.Contains(level.Level)))
            .Where(x => x.Sex.Count == 0 || x.Sex.Any(sex => sex.Sex == dto.Gender))
            .Where(x => x.AgeRanges.Count == 0 || x.AgeRanges.Any(age => age.Age == dto.AgeRange));

        if (muscleGroups.Count > 0)
        {
            query = query.Where(x => x.BodyWorkouts.Any(bodyWorkout => muscleGroups.Contains(bodyWorkout.Body.GroupName)));
        }

        if (equipmentIds.Count > 0)
        {
            query = query.Where(x => x.WorkoutEquipment.Count == 0 || x.WorkoutEquipment.Any(equipment => equipmentIds.Contains(equipment.EquipmentId)));
        }
        else if (dto.Place == Place.Home)
        {
            query = query.Where(x => x.WorkoutEquipment.Count == 0 || x.WorkoutEquipment.Any(equipment => equipment.Equipment.Name.Contains("Bodyweight") || equipment.Equipment.Name.Contains("Resistance") || equipment.Equipment.Name.Contains("Dumbbell")));
        }

        return await query
            .OrderByDescending(x => x.BodyWorkouts.Any(bodyWorkout => muscleGroups.Contains(bodyWorkout.Body.GroupName)))
            .ThenBy(x => ((x.Id + sourceWeek) % 17))
            .ThenBy(x => x.Id)
            .Take(take)
            .ToListAsync();
    }

    private static IEnumerable<Exercise> CreateExercisesForWeek(Guid planId, IReadOnlyList<Workout> workouts, Difficulty level, int week)
    {
        var sets = level switch
        {
            Difficulty.Novice => 2,
            Difficulty.Beginner => 3,
            Difficulty.Intermediate => 3,
            Difficulty.Advanced => 4,
            Difficulty.Expert => 5,
            _ => 3,
        };

        var reps = level switch
        {
            Difficulty.Novice => 10,
            Difficulty.Beginner => 12,
            Difficulty.Intermediate => 12,
            Difficulty.Advanced => 10,
            Difficulty.Expert => 8,
            _ => 12,
        };

        return workouts.Select(workout => new Exercise
        {
            PlanId = planId,
            WorkoutId = workout.Id,
            ExerciseType = ExerciseType.Strength,
            RecommendSets = sets,
            RecommendReps = reps,
            RecommendRestTime = level >= Difficulty.Advanced ? 90 : 60,
            RecommendWeight = 0,
            IsOk = true,
            SuggestType = WorkoutGeneratedType.Machine,
            Completed = false,
        });
    }

    private static int GetWeeksToGenerate(Period period) => period switch
    {
        Period.Daily => 1,
        Period.Weekly => 1,
        Period.Monthly => 4,
        Period.Quarterly => 16,
        Period.custom => 1,
        _ => throw new ArgumentOutOfRangeException(nameof(period), period, "Unsupported plan duration."),
    };

    private static int GetExercisesPerSession(Difficulty level, WorkoutDurationPreference durationPreference)
    {
        var baseCount = level switch
        {
            Difficulty.Novice => 4,
            Difficulty.Beginner => 5,
            Difficulty.Intermediate => 6,
            Difficulty.Advanced => 7,
            Difficulty.Expert => 8,
            _ => 5,
        };

        return durationPreference switch
        {
            WorkoutDurationPreference.TenToFifteenMinutes => Math.Max(3, baseCount - 2),
            WorkoutDurationPreference.TwentyToThirtyMinutes => Math.Max(4, baseCount - 1),
            WorkoutDurationPreference.FortyFiveToSixtyMinutes => baseCount + 1,
            _ => baseCount,
        };
    }

    private static IEnumerable<Difficulty> GetAllowedLevels(Difficulty level) => level switch
    {
        Difficulty.Novice => new[] { Difficulty.Novice, Difficulty.Beginner },
        Difficulty.Beginner => new[] { Difficulty.Novice, Difficulty.Beginner, Difficulty.Intermediate },
        Difficulty.Intermediate => new[] { Difficulty.Beginner, Difficulty.Intermediate },
        Difficulty.Advanced => new[] { Difficulty.Intermediate, Difficulty.Advanced },
        Difficulty.Expert => new[] { Difficulty.Advanced, Difficulty.Expert },
        _ => new[] { Difficulty.Beginner },
    };

    private static IEnumerable<MuscleGroup> ResolveMuscleGroups(IEnumerable<MusclePriorityDto> musclePriorities)
    {
        foreach (var priority in musclePriorities)
        {
            if (Enum.IsDefined(typeof(MuscleGroup), priority.Id))
            {
                yield return (MuscleGroup)priority.Id;
                continue;
            }

            if (Enum.TryParse<MuscleGroup>(priority.GroupName, true, out var group))
            {
                yield return group;
            }
        }
    }

    public async Task PlanAiGeneratingMangement(RegisterDto dto)
    {
        // Height is clear
        // Weight is clear
        // Gender
        // AgeRange
        // Date Of birth 
        // Body Type
        // Plan Level.

        var height = dto.Height;
        var weight = dto.Weight;
        var duration = dto.PlanDuration;
        var sex = dto.Gender;
        var ageRange = dto.AgeRange;
        DateTime today = DateTime.Now;
        int age = today.Year - dto.DateOfBirth.Year;

        if (DateOnly.FromDateTime(today) < dto.DateOfBirth.AddYears(age))
        {
            age--;
        }
        var bodyType = dto.BodyType;
        //var level = dto.PlanLevel; ????????????


        // I think we just have to let user to select only 4 parts
        var muscleNum = dto.MusclePriorities.Count;
        List<Body> bodyList = new List<Body>();
        foreach (var item in dto.MusclePriorities)
        {
            var body = new Body
            {
                Id = item.Id,
                Name = item.GroupName,
            };
            bodyList.Add(body);
        }

        // equipment does not have limitations
        var equipmentNum = dto.Equipments.Count;
        List<Equipment> equipmentList = new List<Equipment>();
        foreach (var item in dto.Equipments)
        {
            var eqips = await _unitOfWork.EquipmentRepository.GetByIdAsync(item.Id);
            equipmentList.Add(eqips);

            //Equipment equipment = new Equipment
            //{
            //    Id = item.Id,
            //    Name= item.Name,
            //};
            //equipmentList.Add(equipment);
        }

        // limitation num is 5 in a week
        List<PlanDays> planDays = new List<PlanDays>();
        var planDaysNum = dto.PlanDays.Count;
        foreach (var item in dto.PlanDays)
        {
            var planDay = new PlanDays
            {
                //PlanId = Guid.NewGuid(),
                Day = item.Day,
                Hour = item.Hour,
            };
            planDays.Add(planDay);
        }


        var injuriesNum = dto.Injuries.Count;
        List<InjuryDto> injuriesList = new List<InjuryDto>();
        foreach (var item in dto.Injuries)
        {

            InjuryDto injury = new(
                name: item.name,
                bodyId: item.bodyId,
                description: item.description,
                injuredImgUrl: item.injuredImgUrl);

            injuriesList.Add(injury);
        }


        var diseasesNum = dto.Diseases.Count;
        List<DiseaseDto> diseasesList = new List<DiseaseDto>();
        List<Body> bodyDisease = new List<Body>();
        foreach (var item in dto.Diseases)
        {
            DiseaseDto disease = new(
                name: item.name,
                bodyId: item.bodyId,
                description: item.description
                );
            var body = await _unitOfWork.BodyRepository.GetByIdAsync(item.bodyId);
            bodyDisease.Add(body);
        }




    }




    public async Task<double> CalculateBmi(double heightCm, double weightKg)
    {
        //if (double.IsNaN(heightCm) || double.IsInfinity(heightCm))
        if (heightCm <= 0 || weightKg <= 0)
        {
            throw new ArgumentException("Height and Weight must be positive values");
        }
        double heightMeters = heightCm / 100.0;
        var result = weightKg / (heightMeters * heightMeters);
        return result;
    }
    public async Task<double> CalculateBmr(double heightCm, double weightKg, int age, string gender)
    {
        if (heightCm <= 0 || weightKg <= 0 || age <= 0)
        {
            throw new ArgumentException("Inputs must be positive.");
        }

        double bmr;
        if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
        {
            bmr = 88.362 + (13.397 * weightKg) + (4.799 * heightCm) - (5.677 * age);
        }
        else if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
        {
            bmr = 447.593 + (9.247 * weightKg) + (3.098 * heightCm) - (4.330 * age);
        }
        else
        {
            throw new ArgumentException("Gender must be 'Male' or 'Female'.");
        }
        return Math.Round(bmr, 2);
    }
    public double CalculateBodyFatPercentage(double bmi, int age, string gender)
    {
        // Deurenberg formula approximation
        int genderValue = gender.Equals("Male", StringComparison.OrdinalIgnoreCase) ? 1 : 0;
        double bodyFat = (1.20 * bmi) + (0.23 * age) - (10.8 * genderValue) - 5.4;
        return Math.Round(bodyFat, 2);
    }
    public async Task<string> CategorizeBMI(double bmi)
    {
        return bmi switch
        {
            <= 18.5 => "underweight",
            > 18.5 and <= 24.9 => "normal",
            > 25 and <= 29.9 => "overweight",
            > 30 => "obese"
        };
    }
    public async Task GeneratePlan(RegisterDto dto)
    {
        // 1- * Select Gender // Male // Female
        // 2- * Date of Burn // 
        // 3- * Age Range // 
        // 4- * Measurement step // Height // Weight
        // 5- * BodyTypeStep // ectomorph // mesomorph // endomorph
        // 6- * HealthConditionsStep // injuries or condition // Head & Neck // shoulders // Arms // Chest // Back // Core // Hips &  pelvis // Legs // Feet & Ankles
        // 7- * BodyGoalsStep // Target Where to fat loss
        // 8- * Desired Physique Goal // Athletic // Lean // Muscular // Balanced
        // 9- * Location exercise // Home // Gym
        //10- * equipment // Dumbell // Barbell // Smith Machine // Cable Machine // BodyWeight // Resistance Bands // 
        //11- * Target Muscle Groups // Chest // Back // Legs // Shoulders // Arms // Core
        //12- * fitness level? // Beginner // Intermediate //Advanced // Expert
        //13- target weight? // target Weight
        //14-* Plan Duration // Daily plan // Weekly plan // Monthly // Quarterly (3 months / 16 weeks ) 
        //15- schedule workout () // Day => start time // how long do you want to exercise

        //var prompt = $"create a {dto.PlanDuration} 16-weeks fitness plan each week {} 4-days, each day {} 45-mins " +
        //    $"for a {dto.PlanLevel} beginner {dto.Gender} male " +
        //    $"who is {dto.DateOfBirth} 31-year-old, {dto.Height} 170 cm Height, 89 kg weight and body type is endomorph " +
        //    $"and has injuries in {dto.Injuries} Legs, avoid aggravating in {dto.Injuries} legs," +
        //    $"wants to loss fat and Target {dto.MusclePriorities} Chest, Back, Shoulders, and Physique goal is {} Muscular" +
        //    $" with Equipments of {dto.Equipments} dumbell, smith Machine, bodyweight, resistance bands in {} Gym" +
        //    $" and target weight is {} 70 kg";

        var aiGeneratedPrompt = $"Create a detailed 16-week fitness plan for a 31-year-old female beginner with the following details:" +
            $"Body Stats: 170 cm height, 89 kg weight, endomorph body type." +
            $"Injuries: Leg injuries(avoid exercises that aggravate the legs)." +
            $"Goals: Fat loss, target weight of 70 kg, and a muscular physique with a focus on chest, back, and shoulders." +
            $"Equipment: Dumbbells, Smith machine, bodyweight exercises, and resistance bands(gym setting)." +
            $"Schedule: 4 days per week, 45 minutes per session." +
            $"Include the following in the plan:" +
            $"Warm - up and cool-down routines to prevent injury and improve mobility." +
            $"Progressive overload to ensure steady progress." +
            $"Low - impact leg exercises that do not aggravate leg injuries." +
            $"Targeted exercises for chest, back, and shoulders." +
            $"Fat - loss strategies such as incorporating cardio or HIIT in a safe manner." +
            $"Weekly breakdown of workouts, including sets, reps, and rest periods." +
            $"Tips for recovery, including stretching and hydration." +
            $"Ensure the plan is beginner - friendly, safe for someone with leg injuries, and tailored to an endomorph body type for optimal fat loss and muscle building.";
    }

}

public enum BMICategorize
{
    underweight = 1, // <18.5,
    normal = 2, // 18.5-24.9,
    overweight = 3, // 25-29.9,
    obese = 4 // >=30
}
