namespace FluentValidation.API;

public class UserManager : IUserManager
{
    private readonly IValidator<User> validator;

    public UserManager(IValidator<User> validator)
    {
        this.validator = validator;
    }

    public async Task Manage(User user)
    {
        await validator.ValidateAsync(user);
    }
}
