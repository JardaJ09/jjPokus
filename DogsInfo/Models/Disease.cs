namespace DogsInfo.Models;

public class Disease
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Symptoms { get; set; } = string.Empty;
    public string SuggestedActions { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty; // Low, Moderate, High
}
