namespace PersonnelManagementSystem.Models.Models;

// Образование
public record Education
{
    public Guid Id { get; init; }
    public string EducationLevel { get; set; } = string.Empty;
}