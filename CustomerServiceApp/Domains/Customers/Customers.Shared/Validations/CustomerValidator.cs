namespace Customers.Shared.Validations;

public class CustomerValidator : BaseValidator<CustomerViewModel>
{
    public CustomerValidator() : base()
    {
        RuleFor(e => e.Name).NotEmpty();
        RuleFor(e => e.CityId).NotEmpty();
    }
}
