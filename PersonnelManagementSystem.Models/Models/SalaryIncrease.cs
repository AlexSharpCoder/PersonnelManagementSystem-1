namespace PersonnelManagementSystem.Models.Models;

// Повышение зарплаты 

public record SalaryIncrease
{
    public Guid Id { get; init; }
    public int SalaryIncreasePercentage { get; set; }
}