namespace Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string? Username { get; set; }
    public string? Salt { get; set; }
    public string? Password { get; set; }
    public ICollection<ExpenseItem>? ExpenseItems { get; set; }
}