using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ExperienceValidator : AbstractValidator<Experience>
    {
        public ExperienceValidator()
        {
            RuleFor(x => x.ExperienceName).NotNull().WithMessage("Deneyim alanı boş bırakılamaz!");
            RuleFor(x => x.ExperienceName).MinimumLength(5).WithMessage("Deneyim alanı minimum 5 karakter olmalıdır!");
            RuleFor(x => x.ExperienceName).MaximumLength(50).WithMessage("Deneyim alanı maximum 50 karakter olmalıdır!");
            RuleFor(x => x.Date).NotNull().WithMessage("Tarih alanı boş bırakılamaz!");
            RuleFor(x => x.ImageUrl).NotNull().WithMessage("Resim alanı boş bırakılamaz!");
            RuleFor(x => x.Description).NotNull().WithMessage("Açıklama alanı boş bırakılamaz!");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Açıklama alanı minimum 10 karakter olmalıdır!");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Açıklama alanı maximum 500 karakter olmalıdır!");
            RuleFor(x => x.CompanyName).NotNull().WithMessage("Şirket adı alanı boş bırakılamaz!");
            RuleFor(x => x.CompanyName).MinimumLength(5).WithMessage("Şirket adı alanı minimum 5 karakter olmalıdır!");
            RuleFor(x => x.CompanyName).MaximumLength(50).WithMessage("Şirket adı alanı maximum 50 karakter olmalıdır!");
        }
    }
}
