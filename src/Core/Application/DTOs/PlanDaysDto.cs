namespace Application.DTOs;

public record PlanDaysDto
{
    public DayOfWeek Day { get; set; }
    public TimeSpan Hour { get; set; }
}
