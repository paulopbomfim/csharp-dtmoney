namespace DtMoney.Models;

public class Transactions
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public string? Category { get; set; }
    public string? Type { get; set; }
    public string? Value { get; set; }
    public DateTime CreatedAt { get; set; }

}