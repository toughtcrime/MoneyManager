namespace Domain.Entities;

public class ExpenseItem
{
    public Guid Id { get; set; }
    public User? WhoSpent { get; set; }
    public string? Title { get; set; }
    public decimal Cost { get; set; }
    public DateOnly CreatedAt { get; set; }
}