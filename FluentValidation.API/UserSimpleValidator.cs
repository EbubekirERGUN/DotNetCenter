namespace FluentValidation.API;

public class UserSimpleValidator : AbstractValidator<User>
{
    public UserSimpleValidator()
    {
        RuleFor(u => u.Name).NotNull().NotEmpty();
        RuleFor(u => u.Email).EmailAddress();
        RuleFor(u => u.Address).NotNull().MaximumLength(100);

    }
}


