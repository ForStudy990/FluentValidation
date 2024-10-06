using FluentValidation;
using FluentValidations.Entity;
using FluentValidations.Models;

namespace FluentValidations.Validation;

public class RegisterValidator : AbstractValidator<CreateUserModel>
{
    public RegisterValidator()
    {
        RuleFor(u=> u.Email).NotNull().EmailAddress();
        RuleFor(u=> u.FirstName).NotNull().NotEmpty().MaximumLength(15)
            .MinimumLength(3);
        When(u => u.Age is not null, () =>
        {
            RuleFor(u => Convert.ToInt32(u.Age))
                .Must(a => a < 120 && 6 < a);
        });
        When(u => u.UserAdress is not null, () =>
        {
            RuleFor(u => u.UserAdress)
                .SetValidator(new AdressValidator()!);
        });
    }
}