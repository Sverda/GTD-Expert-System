using FluentValidation;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic.Validators
{
    internal class TrashValidator : AbstractValidator<Questions>
    {
        public TrashValidator()
        {
            RuleFor(q => q.RequireAction).Equal(false);
            RuleFor(q => q.WorthKeeping).Equal(false);
            RuleFor(q => q.RequireActionLater).Null();
            RuleFor(q => q.OneAction).Null();
            RuleFor(q => q.TwoMinutes).Null();
            RuleFor(q => q.RightPerson).Null();
            RuleFor(q => q.SpecificTime).Null();
        }
    }
}
