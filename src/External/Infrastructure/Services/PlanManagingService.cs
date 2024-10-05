namespace Infrastructure.Services;

public class PlanManagingService
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

        // Injuries Table
        List<AthleteInjuries> injuries = new List<AthleteInjuries>();
        foreach (var item in dto.Injuries)
        {
            var injury = new AthleteInjuries
            {
                AthleteId = Guid.NewGuid(),
                Name = item.name,
                Description = item.description,
            };
            injuries.Add(injury);
        }
        await _unitOfWork.AthleteInjuriesRepository.CreateRangeAsync(injuries);


        // Diseases Table
        List<Disease> diseases = new List<Disease>();
        foreach (var item in dto.Diseases)
        {
            var disease = new Disease
            { 
                AthleteId= Guid.NewGuid(), // ???????????????? 
                Name = item.name,
                Description = item.description,
            };
            diseases.Add(disease);
        }
        await _unitOfWork.DiseaseRepository.CreateRangeAsync(diseases);


    }


    //public async Task<PlanResponseDto> PlanGeneratingManagement(RegisterDto dto)
    public async Task PlanGeneratingManagement(RegisterDto dto)
    {
        // Plan itself =====>  it's really imporant 

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
        foreach (var item in dto.MusclePriorities)
        {
            var muscle = new MusclePriority
            {
                PlanId= Guid.NewGuid(), // ????????????????? replace it with correct muscle
                BodyId = item.Id // replace it with correct property
            };
            musclePriorities.Add(muscle);
        }
        await _unitOfWork.MusclePriorityRepository.CreateRangeAsync(musclePriorities);


        List<Equipment> equipments = new List<Equipment>();
        foreach (var item in dto.Equipments)
        {
            var equipment = new Equipment
            {
                Id = item.Id,
                Name = item.Name,
            };
            equipments.Add(equipment);
        }
        await _unitOfWork.EquipmentRepository.CreateRangeAsync(equipments);

        //after generating plan and set filters on it clarify exercise.
        List<Exercise> exercises = new List<Exercise>();
        foreach (var item in dto.Exercises)
        {
            var exercise = new Exercise
            {
                PlanId = Guid.NewGuid(), // ????????????????????? make it ok 
                WorkoutId = 1, // ????????????????????? make it ok 
                //ExerciseType =  , // ??????????????????? fix io
                RecommendSet = item.RecomendSet,
                RecommendWeight = item.RecomendWeight,
            };
            exercises.Add(exercise);
        }

        await _unitOfWork.ExerciseRepository.CreateRangeAsync(exercises);
    }




}
