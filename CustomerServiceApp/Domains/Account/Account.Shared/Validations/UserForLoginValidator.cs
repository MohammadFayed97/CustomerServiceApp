namespace Account.Shared.Validations;

public class UserForLoginValidator : AbstractValidator<UserForLoginViewModel>
{
    public UserForLoginValidator()
    {
        RuleFor(e => e.UserName).NotEmpty();
        RuleFor(e => e.Password).NotEmpty();
    }
}
