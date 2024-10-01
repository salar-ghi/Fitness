namespace Presentation.FunctionalTests;

public class UserApiTests : IClassFixture<WebApplicationFactory<Startup>>
{
    private readonly HttpClient _client;

    public UserApiTests(WebApplicationFactory<Startup> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetUser_ReturnsUser_WhenUserExists()
    {
        // Arrange
        var userId = 1; // assume this user exist in the database

        // Act
        var response = await _client.GetAsync($"/api/users/{userId}");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        content.Should().Contain("Salar Ghahremani"); // Replace with actual expected content
    }
}
