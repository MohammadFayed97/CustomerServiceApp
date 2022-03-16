namespace Account.Shared.Validations;

public class UserForRegisterValidator : AbstractValidator<UserForRegisterViewModel>
{
    public UserForRegisterValidator()
    {
        RuleFor(e => e.FirstName).NotEmpty();
        RuleFor(e => e.LastName).NotEmpty();
        RuleFor(e => e.UserName).NotEmpty();
        RuleFor(e => e.Password).NotEmpty().Length(8);
    }
}
