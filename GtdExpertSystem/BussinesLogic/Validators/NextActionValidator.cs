﻿using FluentValidation;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic.Validators
{
    internal class NextActionValidator : AbstractValidator<Questions>
    {
        public NextActionValidator()
        {
            RuleFor(q => q.RequireAction).Equal(true);
            RuleFor(q => q.WorthKeeping).Null();
            RuleFor(q => q.RequireActionLater).Null();
            RuleFor(q => q.ManyActions).Equal(false);
            RuleFor(q => q.TwoMinutes).Equal(false);
            RuleFor(q => q.RightPerson).Equal(true);
            RuleFor(q => q.SpecificTime).Equal(false);
        }
    }
}