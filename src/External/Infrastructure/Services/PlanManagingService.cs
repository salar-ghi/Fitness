using Domain.Enums;
using Domain.Models;
using Microsoft.Identity.Client;
using Microsoft.ML.Runtime;

namespace Infrastructure.Services;

public class PlanManagingService : IPlanManagingService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IChatService _chatService;
    public PlanManagingService(IUnitOfWork unitOfWork, IChatService chatService)
    {
        _unitOfWork = unitOfWork;
        _chatService = chatService;
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

        // ____________________________--------------------------


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
                PlanId = item.planId,
                EquipmentId = item.equipmentId,
            };
            equipments.Add(equipment);
        }
        await _unitOfWork.PlanEquipmentRepository.CreateRangeAsync(equipments);

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
        int age  = today.Year - dto.DateOfBirth.Year;

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
                Name = item.name,
            };
            bodyList.Add(body);
        }

        // equipment does not have limitations
        var equipmentNum = dto.Equipments.Count;
        List<Equipment> equipmentList = new List<Equipment>();
        foreach (var item in dto.Equipments)
        {
            var eqips = await _unitOfWork.EquipmentRepository.GetByIdAsync(item.equipmentId);
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
            var body  = await _unitOfWork.BodyRepository.GetByIdAsync(item.bodyId);
            bodyDisease.Add(body);
        }




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
