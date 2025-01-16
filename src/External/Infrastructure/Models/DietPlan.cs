namespace Infrastructure.Models;

public class DietPlan
{
    public List<MonthPlan> Months { get; set; } =  new List<MonthPlan>();
}

public class MonthPlan
{
    public int MonthNumber { get; set; }
    public List<WeekPlan> Weeks { get; set; } = new List<WeekPlan>();
}


public class WeekPlan
{
    public int WeekNumber { get; set; }
    public List<DayPlan> Days { get; set; } = new List<DayPlan>();
}


public class DayPlan
{
    public int DayNumber { get; set; }
    public List<ExerciseDto> Exercises { get; set; }
}

public class ExerciseDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Instruction { get; set; }

}