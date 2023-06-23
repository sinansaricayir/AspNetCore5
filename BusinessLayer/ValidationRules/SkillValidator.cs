using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Yetenek adı boş geçilemez!");
            RuleFor(x => x.Value).NotNull().WithMessage("Yetenek oranı boş geçilemez!");
        }
    }
}
