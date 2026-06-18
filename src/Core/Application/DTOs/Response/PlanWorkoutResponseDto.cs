using Domain.Models;

namespace Application.DTOs.Response;

public sealed class PlanWorkoutResponseDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string PersianName { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
    public string PersianDescription { get; init; } = string.Empty;
    public string? ImgUrl { get; init; }
    public List<PlanWorkoutInstructionResponseDto> Instructions { get; init; } = new();

    public static PlanWorkoutResponseDto FromWorkout(Workout workout)
    {
        return new PlanWorkoutResponseDto
        {
            Id = workout.Id,
            Name = workout.Name,
            PersianName = PersianExerciseTextTranslator.TranslateExerciseText(workout.Name),
            Description = workout.Description,
            PersianDescription = PersianExerciseTextTranslator.TranslateExerciseText(workout.Description),
            ImgUrl = workout.ImgUrl,
            Instructions = workout.WorkoutInstructions
                .OrderBy(x => x.Step)
                .Select(x => new PlanWorkoutInstructionResponseDto
                {
                    Step = x.Step,
                    Instruction = x.Instruction,
                    PersianInstruction = PersianExerciseTextTranslator.TranslateExerciseText(x.Instruction),
                    ImgUrl = x.ImgUrl,
                    VideoUrl = x.VideoUrl,
                })
                .ToList(),
        };
    }
}

public sealed class PlanWorkoutInstructionResponseDto
{
    public int Step { get; init; }
    public string Instruction { get; init; } = string.Empty;
    public string PersianInstruction { get; init; } = string.Empty;
    public string? ImgUrl { get; init; }
    public string? VideoUrl { get; init; }
}

internal static class PersianExerciseTextTranslator
{
    private static readonly IReadOnlyDictionary<string, string> PhraseTranslations = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
    {
        ["Barbell"] = "هالتر",
        ["Dumbbell"] = "دمبل",
        ["Kettlebell"] = "کتل‌بل",
        ["Cable"] = "کابل",
        ["Machine"] = "دستگاه",
        ["Smith Machine"] = "دستگاه اسمیت",
        ["Bodyweight"] = "وزن بدن",
        ["Resistance Band"] = "کش مقاومتی",
        ["Bench Press"] = "پرس سینه",
        ["Incline"] = "شیب‌دار",
        ["Decline"] = "زیرسینه",
        ["Chest"] = "سینه",
        ["Back"] = "پشت",
        ["Shoulder"] = "سرشانه",
        ["Biceps"] = "جلو بازو",
        ["Triceps"] = "پشت بازو",
        ["Leg"] = "پا",
        ["Squat"] = "اسکوات",
        ["Lunge"] = "لانج",
        ["Row"] = "روئینگ",
        ["Press"] = "پرس",
        ["Pushup"] = "شنا",
        ["Push Up"] = "شنا",
        ["Pull Up"] = "بارفیکس",
        ["Deadlift"] = "ددلیفت",
        ["Fly"] = "فلای",
        ["Curl"] = "کرل",
        ["Extension"] = "اکستنشن",
        ["Bridge"] = "پل",
        ["Stretch"] = "کشش",
        ["Single Arm"] = "تک دست",
        ["Alternating"] = "تناوبی",
        ["Neutral"] = "خنثی",
        ["Weighted"] = "وزنه‌دار",
        ["Knee"] = "زانو",
        ["Floor"] = "روی زمین",
        ["High"] = "بالا",
        ["Low"] = "پایین",
        ["Reverse Grip"] = "گرفتن معکوس",
        ["Plate"] = "صفحه وزنه",
    };

    public static string TranslateExerciseText(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return string.Empty;
        }

        var translated = value;
        foreach (var phrase in PhraseTranslations.OrderByDescending(x => x.Key.Length))
        {
            translated = translated.Replace(phrase.Key, phrase.Value, StringComparison.OrdinalIgnoreCase);
        }

        return translated;
    }
}
