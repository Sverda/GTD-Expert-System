using FluentValidation;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic.Validators
{
    internal class ReferenceValidator : AbstractValidator<Questions>
    {
        public ReferenceValidator()
        {
            RuleFor(q => q.RequireAction).Equal(false);
            RuleFor(q => q.WorthKeeping).Equal(true);
            RuleFor(q => q.RequireActionLater).Equal(false);
            RuleFor(q => q.ManyActions).Null();
            RuleFor(q => q.TwoMinutes).Null();
            RuleFor(q => q.RightPerson).Null();
            RuleFor(q => q.SpecificTime).Null();
        }
    }
}
