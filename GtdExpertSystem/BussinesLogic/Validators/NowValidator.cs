using FluentValidation;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic.Validators
{
    internal class NowValidator : AbstractValidator<Questions>
    {
        public NowValidator()
        {
            RuleFor(q => q.RequireAction).Equal(true);
            RuleFor(q => q.WorthKeeping).Null();
            RuleFor(q => q.RequireActionLater).Null();
            RuleFor(q => q.ManyActions).Equal(false);
            RuleFor(q => q.TwoMinutes).Equal(true);
            RuleFor(q => q.RightPerson).Null();
            RuleFor(q => q.SpecificTime).Null();
        }
    }
}
