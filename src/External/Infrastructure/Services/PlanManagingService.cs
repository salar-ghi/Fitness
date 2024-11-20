using Domain.Enums;

namespace Infrastructure.Services;

public class PlanManagingService : IPlanManagingService
{
    private readonly IUnitOfWork _unitOfWork;
    public PlanManagingService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
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
            Level = dto.PlanLevel,
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
                AthleteId= Guid.NewGuid(), // ???????????????? 
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
                PlanId= Guid.NewGuid(), // ????????????????? replace it with correct muscle
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

        //after generating plan and set filters on it clarify exercise.
        List<Exercise> exercises = new List<Exercise>();
        foreach (var item in dto.Exercises)
        {
            var exercise = new Exercise
            {
                PlanId = Guid.NewGuid(), // ????????????????????? make it ok 
                WorkoutId = 1, // ????????????????????? make it ok 
                //ExerciseType =  , // ??????????????????? fix io
                RecommendWeight = item.RecomendWeight,
            };
            exercises.Add(exercise);
        }

        await _unitOfWork.ExerciseRepository.CreateRangeAsync(exercises);
    }


    public async Task PlanAiGeneratingMangement(RegisterDto dto)
    {
        var duration = dto.PlanDuration;


        var muscleNum = dto.MusclePriorities.Count;
        List<Body> bodyList = new List<Body>();
        foreach (var item in dto.MusclePriorities)
        {
            Body body = new Body
            {
                Id = item.Id,
                Name = item.name,
            };
            bodyList.Add(body);
        }

        var equipmentNum = dto.Equipments.Count;
        List<Equipment> equipmentList = new List<Equipment>();
        foreach (var item in dto.Equipments)
        {
            Equipment equipment = new Equipment
            {
                Id = item.equipmentId,

            };
            equipmentList.Add(equipment);
        }










    }

}
