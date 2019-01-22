using NUnit.Framework;

namespace GtdExpertSystem.Tests
{
    [TestFixture]
    public class ResultConcluderTests
    {
        [Test]
        public void ShouldReturnTrash()
        {
            var questionsValue = new Questions()
            {
                RequireAction = false,
                WorthKeeping = false
            };

            var sut = new ResultConcluder(questionsValue);

            Assert.Pass();
        }
    }
}
