namespace FluentValidation.API;

public class User
{

    public string? Name { get; set; }

    public int Age { get; set; }

    public DateTime Date { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public Membership[]? Membership { get; set; }
}
public record Membership(string Name);
