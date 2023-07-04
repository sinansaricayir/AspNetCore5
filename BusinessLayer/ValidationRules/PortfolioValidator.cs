using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adı boş geçilemez!");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı minimum 5 karakter olmalıdır!");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje adı maximum 100 karakter olmalıdır!");
            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje url bilgisi boş geçilemez!");
            RuleFor(x=>x.StatusValue).NotEmpty().WithMessage("Tamamlanma Oranı bilgisi boş geçilemez!");
            RuleFor(x=>x.Date).NotEmpty().WithMessage("Tarih bilgisi boş geçilemez!");
        }
    }
}
