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

            return Results.NextAction;
        }
    }
}
