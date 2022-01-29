using Entity.Concrete;
using FluentValidation;

namespace Business.Validations.FluentValidations
{
    public class ProductValidation : AbstractValidator<Products>
    {
        public ProductValidation()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.ProductName).MaximumLength(150).WithMessage("Maximum 150 Karakter Yazabilirsiniz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Description).MaximumLength(180).WithMessage("Maximum 180 Karakter Yazabilirsiniz.");
            RuleFor(x => x.MainImage).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Stock).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.CategoriesId).NotEmpty().WithMessage("Boş Bırakılamaz.");
        }
    }
}
