using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık alanı 5 karakterden az olamaz!");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık alanı 50 karakterden fazla olamaz!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz!");
            RuleFor(x => x.Description).MinimumLength(10).WithMessage("Açıklama alanı 10 karakterden az olamaz!");
            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Açıklama alanı 500 karakterden fazla olamaz!");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş alanı boş bırakılamaz!");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz!");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon alanı boş bırakılamaz!");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres alanı boş bırakılamaz!");
            RuleFor(x => x.Address).MaximumLength(100).WithMessage("Adres alanı 100 karakterden fazla olamaz!");
        }
    }
}
