namespace FluentValidation.API;

public interface IUserManager
{
    public Task Manage(User user);
}
