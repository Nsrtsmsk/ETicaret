using Entity.Concrete;
using FluentValidation;

namespace Business.Validations.FluentValidations
{
    public class AdministratorsValidation: AbstractValidator<Administrators>
    {
        public AdministratorsValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Boş Bırakılamaz.");

            RuleFor(x => x.EMail).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Boş Bırakılamaz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Boş Bırakılamaz.");

            RuleFor(x => x.EMail).MaximumLength(80).WithMessage("80 Karakterden Fazla Olamaz.");
            RuleFor(x => x.Phone).MaximumLength(50).WithMessage("15 Karakterden Fazla Olamaz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("50 Karakterden Fazla Olamaz.");
            RuleFor(x => x.Surname).MaximumLength(50).WithMessage("50 Karakterden Fazla Olamaz.");

            RuleFor(x => x.Password).MaximumLength(30).WithMessage("30 Karakterden Fazla Olamaz.");
        }
    }
}
