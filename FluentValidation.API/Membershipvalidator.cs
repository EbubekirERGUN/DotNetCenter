namespace FluentValidation.API;

public class Membershipvalidator : AbstractValidator<Membership>
{
    public Membershipvalidator()
    {
        RuleFor(u => u.Name).NotNull().NotEmpty();
    }
}
