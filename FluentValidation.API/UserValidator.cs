namespace FluentValidation.API;

public class UserValidator : AbstractValidator<User>
{
    public UserValidator()
    {
        Include(new UserSimpleValidator());
        Include(new UserComplexValidator());
    }
}
