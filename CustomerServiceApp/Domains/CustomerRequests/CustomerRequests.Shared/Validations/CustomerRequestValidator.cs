namespace CustomerRequests.Shared.Validations;

public class CustomerRequestValidator : BaseValidator<CustomerRequestViewModel>
{
    public CustomerRequestValidator() : base()
    {
        RuleFor(e => e.CustomerId).NotEmpty();
        RuleFor(e => e.ServiceId).NotEmpty();
        RuleFor(e => e.TransactionDate).NotEmpty();
    }
}
