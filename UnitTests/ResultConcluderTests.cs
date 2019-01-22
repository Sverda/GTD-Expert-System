using GtdExpertSystem.BussinesLogic;
using GtdExpertSystem.Models;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class ResultConcluderTests
    {
        [Test]
        public void ShouldReturnTrash()
        {
            var questionsValue = new Questions
            {
                RequireAction = false,
                WorthKeeping = false,
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.Trash));
        }

        [Test]
        public void ShouldReturnReference()
        {
            var questionsValue = new Questions
            {
                RequireAction = false,
                WorthKeeping = true,
                RequireActionLater = false,
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.Reference));
        }

        [Test]
        public void ShouldReturnMaybeLater()
        {
            var questionsValue = new Questions
            {
                RequireAction = false,
                WorthKeeping = true,
                RequireActionLater = true
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.MaybeLater));
        }

        [Test]
        public void ShouldReturnProjects()
        {
            var questionsValue = new Questions
            {
                RequireAction = true,
                ManyActions = true
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.Projects));
        }

        [Test]
        public void ShouldReturnDoItNow()
        {
            var questionsValue = new Questions
            {
                RequireAction = true,
                ManyActions = false,
                TwoMinutes = true
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.DoItNow));
        }

        [Test]
        public void ShouldReturnDelegate()
        {
            var questionsValue = new Questions
            {
                RequireAction = true,
                ManyActions = false,
                TwoMinutes = false,
                RightPerson = false
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.Delegate));
        }

        [Test]
        public void ShouldReturnCalendar()
        {
            var questionsValue = new Questions
            {
                RequireAction = true,
                ManyActions = false,
                TwoMinutes = false,
                RightPerson = true,
                SpecificTime = true
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.Calendar));
        }

        [Test]
        public void ShouldReturnNextAction()
        {
            var questionsValue = new Questions
            {
                RequireAction = true,
                ManyActions = false,
                TwoMinutes = false,
                RightPerson = true,
                SpecificTime = false
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.NextAction));
        }

        [Test]
        public void ShouldReturnNone()
        {
            var questionsValue = new Questions
            {
                RequireAction = false,
                WorthKeeping = false,
                RequireActionLater = false,
                ManyActions = false,
                TwoMinutes = false,
                RightPerson = false,
                SpecificTime = false
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.None));
        }
    }
}
