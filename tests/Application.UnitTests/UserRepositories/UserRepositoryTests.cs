using Domain.IRepositories;
using Domain.Models;
using Infrastructure.Repositories;
using Moq;

namespace Application.UnitTests;
public class UserRepositoryTests
{
    private readonly Mock<IUserRepository> _userRepositoryMock;
    private readonly UserRepository _userRepo;


    //public UserRepositoryTests()
    //{
    //    _userRepositoryMock = new Mock<IUserRepository>();
    //    _userRepo = new UserRepository(_userRepositoryMock.Object);
    //}


    //[Fact]
    //public async Task CreateUser_ShouldReturnUser_WhenUserIsValid()
    //{
    //    // Arrange
    //    var user = new User { FName = "salar", LName = "Ghahremani", PhoneNumber = "09108592503" };
    //    _userRepositoryMock.Setup(z => z.CreateAsync(It.IsAny<User>())).ReturnsAsync(user);

    //    //Act
    //    var result = await _userRepo.CreateAsync(user);

    //    //Assert
    //    //result.Should()
    //}


}
