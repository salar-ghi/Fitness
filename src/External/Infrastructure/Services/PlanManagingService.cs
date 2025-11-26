using Domain.Enums;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel;

namespace Infrastructure.Services;

public class PlanManagingService : IPlanManagingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IChatService _chatService;
    private readonly FitnessContext _context;
    public PlanManagingService(IUnitOfWork unitOfWork, IChatService chatService, FitnessContext context)
    {
        _unitOfWork = unitOfWork;
        _chatService = chatService;
        _context = context;
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
        var height = dto.Height;
        var weight = dto.Weight;
        var duration = dto.PlanDuration;
        var gender = dto.Gender;
        var ageRange = dto.AgeRange;
        var dateOfBirth = dto.DateOfBirth;
        var bodyType = dto.BodyType;
        var level = dto.Level;

        var injuries = dto.Injuries;
        var diseases = dto.Diseases;
        var planDays = dto.PlanDays;
        var musclePriorities = dto.MusclePriorities;
        var equipments = dto.Equipments;

    }

    public async Task TestPlanProcessingTask(PlanDto dto)
    {
        var height = dto.Height = 170;
        var weight = dto.Weight = 90;

        Console.Clear();
        Console.WriteLine($"height is {height} and weight is {weight}");
        var bmi = await CalculateBmi(height, weight);
        // ***** If high BMI suggest incorporating more cardio. *********
        // اگر BMI بالا باشد، پیشنهاد می‌شود که کاردیو بیشتری را در برنامه خود بگنجانید.

        //Console.Clear();
        // BMI (Body Mass Index)
        Console.WriteLine($"user BMI (Body Mass Index) is {bmi}");
        var categorizeBmi = await CategorizeBMI(bmi);
        Console.WriteLine($"categorize BMI is {categorizeBmi}");

        // BMR (Basal Metabolic Rate) 
        var bmr = CalculateBmr(height, weight, dto.Age, dto.Gender.ToString());

        // BFP (Body fat percentage )
        var bodyFat = CalculateBodyFatPercentage(bmi, dto.Age, "Male");

        var bodyType = dto.BodyType = Domain.Enums.BodyType.Endomorph; 
        var level = dto.Level = Difficulty.Beginner;
        // warm-ups (5-12 min) and cool-downs / Avoid advanced techniques like supersets initially
        // Limit to 3 sets per exercise, 8-12 reps.

        var duration = dto.PlanDuration = Period.Monthly;
        var gender = dto.Gender = Sex.Male;
        var ageRange = dto.AgeRange = Age.Thirty_To_Thirty_Nine;
        //var dateOfBirth = dto.DateOfBirth;

        var injuries = dto.Injuries; // no injuries
        var diseases = dto.Diseases; // no disease

        var planDaysNum = dto.PlanDays.Count();
        var planDays = dto.PlanDays ?? new List<PlanDaysDto> {
            new PlanDaysDto { Day = DayOfWeek.Monday, Hour = new TimeSpan(18, 0, 0) },
            new PlanDaysDto { Day = DayOfWeek.Wednesday, Hour = new TimeSpan(18, 0, 0) },
            new PlanDaysDto { Day = DayOfWeek.Friday, Hour = new TimeSpan(18, 0, 0) },
            new PlanDaysDto { Day = DayOfWeek.Saturday, Hour = new TimeSpan(18, 0, 0) }
        };

        var musclePrioritiesNum = dto.MusclePriorities.Count();
        var musclePriorities = dto.MusclePriorities ?? new List<MusclePriorityDto> {
            new MusclePriorityDto(1, "Chest"),
            new MusclePriorityDto(2, "Back"),
            new MusclePriorityDto(3, "Shoulders"),
            new MusclePriorityDto(4, "Biceps"),
        };

        var equipmentNum = dto.Equipments.Count(); // 4 days in a week
        var equipments = dto.Equipments ?? new List<PlanEquipmentDto>
        {
            new PlanEquipmentDto{ },
        };

        int exercisesPerSession = 0;

        var workoutLevels = await _context.WorkoutLevels
            .Where(x => x.Level == Difficulty.Beginner || x.Level == Difficulty.Intermediate)
            .ToListAsync();

        var muscleName = dto.MusclePriorities?.Select(x => x.GroupName).ToList();

        var muscleProperties = await _context.Bodies
            .Where(z => muscleName.Contains(z.Name))
            .ToListAsync();

        if (dto.Level == Difficulty.Beginner)
        {
            exercisesPerSession = 5; // 4~5; => 5

            var firstSection = _context.Workouts
                .Where(w => workoutLevels.Any(wl => wl.WorkoutId == w.Id))
                .Where(w => w.BodyWorkouts.Any(bw => musclePriorities.Any(mp => mp.Id == bw.BodyId)))
                .Take(40);            

            var exercises = await _context.Workouts
                .Where(z => z.Level == workoutLevels)
                .Where(y => y.BodyWorkouts == musclePriorities)
                .ToListAsync();


            // devide plan into 2 parts, first part beginner level and 2nd part is intermediate level
            // generate plan according to exercises level are beginner and intermediate
        }
        else if(dto.Level == Difficulty.Intermediate)
        {
            exercisesPerSession = 5; // 5~6  // 1 superset. => 6
            // devide into 3 parts, first part mix of beginner and intermediate and 2nd part intermediate and 3rd part is mix of advanced and intermediate level
            // use somehow supersets
        }
        else if(dto.Level == Difficulty.Advanced)
        {
            exercisesPerSession = 6; // 6~7 // 2~3 superset => 8
            //devide into 3 parts, first part mix of intermediate and advanced and 2nd part advanced and 3rd part is expert and advanced level
            // and Also use harsh workouts and sets, for example 6 workouts per session and harsh reps per set.
            // use several supersets
        }
        else if(dto.Level == Difficulty.Expert)
        {
            exercisesPerSession = 7; // 7 // 3 superset => 10

            // devide into 2 parts, first part advanced level and 2nd part is expert level
            // and Also use harsh workouts and sets, for example 6 or 7 workouts per session and harsh reps per set.
            // use several supersets
        }
                
        //var contextWorkouts = await _context.Workouts.Where(x => x.)

        ; var workoutlist = await _unitOfWork.WorkoutRepository.GetAllAsync();

        ; var pln = new Plan
        {
            PlanCode = "PLAN12345",
            Level = dto.Level,
            Duration = dto.PlanDuration,
            DaysCount = dto.PlanDays.Count(),
            Place = dto.Place,
            AthleteId = Guid.NewGuid(), // should get athlete Id from athlete table
        };

        //var plan = await _unitOfWork.PlanRepository.CreateAsync(pln);

        //var exercise = await _unitOfWork.ExerciseRepository.CreateAsync(plan);




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
        return weightKg / (heightCm * heightCm);
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