using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class ProductValidator : AbstractValidator<Artist>
{
    public ProductValidator()
    {
        // RuleFor(p => p.Name).NotEmpty();
        // RuleFor(p => p.Name).Length(2, 30);
        // RuleFor(p => p.LastName).NotEmpty();
    }
}