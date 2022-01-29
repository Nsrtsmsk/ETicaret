using Entity.Concrete;
using FluentValidation;

namespace Business.Validations.FluentValidations
{
    public class CategoriesValidation: AbstractValidator<Categories>
    {
        public CategoriesValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.CategoryName).MaximumLength(180).WithMessage("180 Karakterden Fazla Olamaz.");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Boş Bırakılamaz.");
        }

    }
}
