namespace PersonnelManagementSystem.Models.Models;

//Подразделение
public record Department
{
    public Guid Id { get; init; }
    public string DepartmentName { get; set; } = string.Empty;
}