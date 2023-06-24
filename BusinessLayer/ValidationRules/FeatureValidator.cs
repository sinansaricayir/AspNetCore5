using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class FeatureValidator : AbstractValidator<Feature>
    {
        public FeatureValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Soyad alanı boş bırakılamaz!");
            RuleFor(x => x.Header).NotEmpty().WithMessage("Görev alanı boş bırakılamaz!");
        }
    }
}
