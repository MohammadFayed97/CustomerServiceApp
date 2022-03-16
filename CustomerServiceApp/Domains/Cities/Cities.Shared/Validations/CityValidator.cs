namespace Cities.Shared.Validations;

public class CityValidator : BaseValidator<CityViewModel>
{
    public CityValidator() : base()
    {
        RuleFor(e => e.Name).NotEmpty();
    }
}
