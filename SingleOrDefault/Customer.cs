namespace SingleOrDefault;

public class Customer
{
    public int Id { get; init; }
    public string Email { get; init; } = default!;
    public string FullName { get; set; } = default!;
    public DateTime DateOfBirth { get; set; }
}