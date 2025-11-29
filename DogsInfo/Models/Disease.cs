namespace DogsInfo.Models;

public class Disease
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Symptoms { get; set; } = string.Empty;
    public string SuggestedAction { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty; // Low, Moderate, High
}
