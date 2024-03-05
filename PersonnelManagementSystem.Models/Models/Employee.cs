namespace PersonnelManagementSystem.Models.Models;

// Сотрудник - (Worker)
public record Employee
{
    public Guid Id { get; init; }
    public int EmployeeNumber { get; init; } 
    public string FullName { get; set; } = string.Empty;
    public string Gender { get; init; } = string.Empty;
    public string DateBirth { get; init; } = string.Empty;
    public Department Department { get; set; }
    public Education Education { get; set; }
    public DateTime DateEmployment { get; init; }
    public DateTime DateTermination { get; set; }
}