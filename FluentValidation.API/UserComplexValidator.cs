namespace FluentValidation.API;

public class UserComplexValidator : AbstractValidator<User>
{
    public UserComplexValidator()
    {
        RuleFor(u => u.Address)
                 .Must(a => a?.ToLower().Contains("Street") == true)
                 .WithMessage("Address must contain 'Street'");
        RuleForEach(u => u.Membership).SetValidator(new Membershipvalidator());
    }
}
