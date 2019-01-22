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
                WorthKeeping = false
            };

            var sut = new ResultConcluder(questionsValue);
            var result = sut.Conclude();

            Assert.That(result, Is.EqualTo(Results.Trash));
        }
    }
}
