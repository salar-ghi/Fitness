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
        User userDto = new User() 
        {

        };


        var user = await _unitOfWork.UserRepository.CreateAsync()

    }




}
