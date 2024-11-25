namespace Application.DTOs;

public record PlanDaysDto
{
    public int Id { get; set; }
    public DayOfWeek Day { get; set; }
    public TimeSpan Hour { get; set; }
    public bool PreviousDayWork { get; set; }
    public bool NextDayWork { get; set; }
}
