namespace Services.Shared.Validations;

public class ServiceValidator : BaseValidator<ServiceViewModel>
{
    public ServiceValidator() : base()
    {
        RuleFor(e => e.Name).NotEmpty();
        RuleFor(e => e.Price).GreaterThanOrEqualTo(0);
    }
}
