public class Transaction
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public TransactionType Type { get; set; }
    public int CategoryId { get; set; }     // FK
    public Category Category { get; set; } = null!;   // Navegación
    public int UserId { get; set; }     // FK
    public User User { get; set; } = null!;   // Navegación
}

public enum TransactionType { Income, Expense }