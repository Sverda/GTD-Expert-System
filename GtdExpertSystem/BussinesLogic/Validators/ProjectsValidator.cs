using FluentValidation;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic.Validators
{
    internal class ProjectsValidator : AbstractValidator<Questions>
    {
        public ProjectsValidator()
        {
            RuleFor(q => q.RequireAction).Equal(true);
            RuleFor(q => q.WorthKeeping).Null();
            RuleFor(q => q.RequireActionLater).Null();
            RuleFor(q => q.ManyActions).Equal(true);
            RuleFor(q => q.TwoMinutes).Null();
            RuleFor(q => q.RightPerson).Null();
            RuleFor(q => q.SpecificTime).Null();
        }
    }
}
