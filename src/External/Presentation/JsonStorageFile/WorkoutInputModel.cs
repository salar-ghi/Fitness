using Newtonsoft.Json;

namespace Presentation.JsonStorageFile;

public class WorkoutInputModel
{

}

public class InputMuscle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string NameEnUs { get; set; }
    public int Level { get; set; }
    public int? Parent { get; set; }

}

public class InputCategory
{
    //public int Id { get; set; }
    public string Name { get; set; }
    //public string NameEnUs { get; set; }
}

public class InputDifficulty
{
    //public int Id { get; set; }
    public string Name { get; set; }
    //public string NameEnUs { get; set; }
}

public class WorkoutInput
{
    public List<InputMuscle> Muscles { get; set; }
    public InputCategory Category { get; set; }
    public InputDifficulty Difficulty { get; set; }

    [JsonProperty("Name")]
    public string Name { get; set; }
}