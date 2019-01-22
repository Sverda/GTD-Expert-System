using FluentValidation;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic.Validators
{
    class MaybeValidator : AbstractValidator<Questions>
    {
        public MaybeValidator()
        {
            RuleFor(q => q.RequireAction).Equal(false);
            RuleFor(q => q.WorthKeeping).Equal(true);
            RuleFor(q => q.RequireActionLater).Equal(true);
            RuleFor(q => q.ManyActions).Null();
            RuleFor(q => q.TwoMinutes).Null();
            RuleFor(q => q.RightPerson).Null();
            RuleFor(q => q.SpecificTime).Null();
        }
    }
}
