namespace Infrastructure.Services;

public class TokenizeGPT
{
    public static Dictionary<string, List<string>> ExtractSections(string text)
    {
        var sections = new Dictionary<string, List<string>>();
        var lines = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        string currentSection = null;
        var instructions = new List<string>();

        foreach (var line in lines) 
        {

            if (line.EndsWith(":")) // section  handling
            {
                if (currentSection != null)
                {
                    sections[currentSection] = instructions;
                    instructions = new List<string>();
                }
                currentSection = line.TrimEnd(':').Trim();
            }
            else if (currentSection != null) 
            {
                instructions.Add(currentSection);
            }
        }
        if (currentSection != null) 
        {
            sections[currentSection] = instructions;
        }
        return sections;
    }


    public async Task<List<FitnessSection>> ProcessSectionAsync(Dictionary<string, List<string>> sections)
    {
        List<FitnessSection> fitnessSections = new List<FitnessSection>();
        foreach (var section in sections)
        {
            FitnessSection fit = new()
            {
                SectionName = section.Key,
                Instructions = string.Join(", ", section.Value)
            };
            fitnessSections.Add(fit);
        }
        return fitnessSections;
    }

    public async Task ProcessText(string text)
    {
        var sections = ExtractSections(text);
        if (sections.ContainsKey("warm-up")) 
        { 
        }
    }



}


public class FitnessSection
{
    public int Id { get; set; }
    public string SectionName { get; set; }
    public string Instructions { get; set; }
}