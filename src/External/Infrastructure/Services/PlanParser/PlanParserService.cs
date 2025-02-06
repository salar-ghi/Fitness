using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace Infrastructure.Services.PlanParser;

public class PlanParserService : IPlanParser
{


    public WarmUpCoolDown ExtractWarmUpCoolDownRoutine(string content)
    {
        var model = new WarmUpCoolDown();
        // Warm-up extraction
        var warmupMatches = Regex.Matches(content, @"\t\+\sWeek\s\d+-\d+:\s(.*?)(?=\n\t\+|\n\*|$)", RegexOptions.Singleline);
        model.WarmUp = warmupMatches.Select(m => m.Groups[1].Value.Trim()).ToList();
        // Cool-down extraction
        var cooldownMatches = Regex.Matches(content, @"\t\+\s(.*?)(?=\n\t\+|\n\*|$)", RegexOptions.Singleline);
        model.CoolDown = cooldownMatches.Select(m => m.Groups[1].Value.Trim()).ToList();

        return model;
    }

    public WarmUpCoolDownModel ExtractWarmUpCoolDown(string content)
    {
        var model = new WarmUpCoolDownModel();

        // Warm-up extraction
        var warmUpMatch = Regex.Match(content, @"Warm-up \(.*?\): (.*?)\n\* Stretching:", RegexOptions.Singleline);

        if (warmUpMatch.Success)
        {
            model.WarmUp = warmUpMatch.Groups[1].Value.Split(new[] { ", ", " or " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        // Cool-down extraction
        var coolDownMatch = Regex.Match(content, @"Cool-down \(.*?\): (.*?)(\n\*\*|$)", RegexOptions.Singleline);
        if (coolDownMatch.Success)
        {
            model.CoolDown = coolDownMatch.Groups[1].Value.Split(new[] { ", ", " and " }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        return model;
    }

    public List<WeekSchedule> ExtractWeeklySchedulesAlternative(string content)
    {
        var weeklySchedules = new List<WeekSchedule>();
        var weekMatches = Regex.Matches(content, @"Week (\d+):(.*?)(?=Week \d+:|$)", RegexOptions.Singleline);

        foreach (Match weekMatch in weekMatches)
        {
            var week = new WeekSchedule
            {
                WeekNumber = int.Parse(weekMatch.Groups[1].Value),
                WeekTitle = $"Week {weekMatch.Groups[1].Value}"
            };

            var dayMatches = Regex.Matches(weekMatch.Groups[2].Value, @"(\w+):\s(.*?)\n(.*?)(?=\n\n|\Z)", RegexOptions.Singleline);

            foreach (Match dayMatch in dayMatches)
            {
                var day = new DaySchedule
                {
                    DayName = dayMatch.Groups[1].Value,
                    FocusArea = dayMatch.Groups[2].Value.Replace(" Day", "").Trim(),
                    Exercises = ParseExercisesAlternative(dayMatch.Groups[3].Value)
                };
                week.Days.Add(day);
            }

            weeklySchedules.Add(week);
        }

        return weeklySchedules;
    }


    public List<WeekSchedule> ExtractWeeklySchedules(string content)
    {
        var weeklySchedules = new List<WeekSchedule>();

        // Split content by weeks
        var weekSections = Regex.Split(content, @"\*\*Weeks (\d+-\d+): (.*?)\*\*");

        for (int i = 1; i < weekSections.Length; i += 3)
        {
            var week = new WeekSchedule
            {
                WeekTitle = $"{weekSections[i + 1]} (Weeks {weekSections[i]})",
                WeekNumber = int.Parse(weekSections[i].Split('-')[0])
            };

            // Extract days and exercises
            var dayMatches = Regex.Matches(weekSections[i + 2], @"\t\+ (\w+) \((.*?)\):(.*?)(?=\t\+ |\n\* )", RegexOptions.Singleline);

            foreach (Match dayMatch in dayMatches)
            {
                var day = new DaySchedule
                {
                    DayName = dayMatch.Groups[1].Value,
                    Exercises = ParseExercises(dayMatch.Groups[3].Value)
                };
                week.Days.Add(day);
            }

            weeklySchedules.Add(week);
        }

        return weeklySchedules;
    }

    private List<ExerciseDetail> ParseExercisesAlternative(string exerciseText)
    {
        var exercises = new List<ExerciseDetail>();
        var exerciseMatches = Regex.Matches(exerciseText,
            @"-\s(.*?)\s\((\d+)\s+sets\s+of\s+(\d+)\s+reps,\s+(\d+)-second\s+rest");

        foreach (Match match in exerciseMatches)
        {
            var exercise = new ExerciseDetail
            {
                Name = match.Groups[1].Value.Trim(),
                Sets = int.Parse(match.Groups[2].Value),
                Reps = int.Parse(match.Groups[3].Value),
                RestBetweenSetsSeconds = int.Parse(match.Groups[4].Value),
                Equipment = ExtractEquipment(match.Groups[1].Value)
            };
            exercises.Add(exercise);
        }

        return exercises;
    }

    private string ExtractEquipment(string exerciseName)
    {
        if (exerciseName.Contains("Smith machine")) return "Smith Machine";
        if (exerciseName.Contains("dumbbell")) return "Dumbbells";
        if (exerciseName.Contains("resistance bands")) return "Resistance Bands";
        return "Bodyweight";
    }

    private List<ExerciseDetail> ParseExercises(string exerciseText)
    {
        var exercises = new List<ExerciseDetail>();
        var exerciseMatches = Regex.Matches(exerciseText, @"-\s(.*?)\s\((\d+)\s.*?(\d+)\sreps.*?rest\sfor\s(\d+)\sseconds");

        foreach (Match match in exerciseMatches)
        {
            exercises.Add(new ExerciseDetail
            {
                Name = match.Groups[1].Value.Trim(),
                Sets = int.Parse(match.Groups[2].Value),
                Reps =  int.Parse(match.Groups[3].Value),
                RestBetweenSetsSeconds = int.Parse(match.Groups[4].Value)
            });
        }

        return exercises;
    }


}