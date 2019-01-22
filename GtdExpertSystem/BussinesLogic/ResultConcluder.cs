using GtdExpertSystem.BussinesLogic.Validators;
using GtdExpertSystem.Models;

namespace GtdExpertSystem.BussinesLogic
{
    public class ResultConcluder
    {
        private readonly Questions _questions;

        public ResultConcluder(Questions questions)
        {
            _questions = questions;
        }

        public Results Conclude()
        {
            var trashValidator = new TrashValidator();
            var trashResult = trashValidator.Validate(_questions);
            if (trashResult.IsValid)
            {
                return Results.Trash;
            }

            var referenceValidator = new ReferenceValidator();
            var referenceResult = referenceValidator.Validate(_questions);
            if (referenceResult.IsValid)
            {
                return Results.Reference;
            }

            var maybeValidator = new MaybeValidator();
            var maybeResult = maybeValidator.Validate(_questions);
            if (maybeResult.IsValid)
            {
                return Results.MaybeLater;
            }

            var projectsValidator = new ProjectsValidator();
            var projectsResult = projectsValidator.Validate(_questions);
            if (projectsResult.IsValid)
            {
                return Results.Projects;
            }

            var nowValidator = new NowValidator();
            var nowResult = nowValidator.Validate(_questions);
            if (nowResult.IsValid)
            {
                return Results.DoItNow;
            }

            var rightPersonValidator = new RightPersonValidator();
            var rightPersonResult = rightPersonValidator.Validate(_questions);
            if (rightPersonResult.IsValid)
            {
                return Results.Delegate;
            }

            var calendarValidator = new CalendarValidator();
            var calendarResult = calendarValidator.Validate(_questions);
            if (calendarResult.IsValid)
            {
                return Results.Calendar;
            }
            
            var nextActionValidator = new NextActionValidator();
            var nextActionResult = nextActionValidator.Validate(_questions);
            if (nextActionResult.IsValid)
            {
                return Results.NextAction;
            }

            return Results.None;
        }
    }
}
