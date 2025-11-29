namespace DogsInfo.Models;

public class Breed
{
    public string Name { get; set; } = string.Empty;
    public string Origin { get; set; } = string.Empty;
    public string SizeCategory { get; set; } = string.Empty; // Small, Medium, Large
    public string Temperament { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}
