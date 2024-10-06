using System.Data;
using FluentValidation;
using FluentValidations.Entity;

namespace FluentValidations.Validation;

public class AdressValidator : AbstractValidator<Adress>
{
    public AdressValidator()
    {
        RuleFor(adress => adress.City).NotNull().WithMessage("City cannot be empty");
        RuleFor(a => a.Country).NotNull()
            .Must(c=> c == "Uzbekistan");
        RuleFor(a => a.ZipCode)
            .LessThan(110000).GreaterThan(100000);

        When(a => a.Street is not null, () =>
        {
            RuleFor(a => a.Street).MinimumLength(5)
                .MaximumLength(32);
        });
    }
}