using JO.QuestionairStepStone.Data.Repository;
using JO.QuestionairStepStone.Interfaces.Data;

namespace JO.QuestionairStepStone.UnitTests.Core
{
    public class QuestionairRepositoryTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task GetQuestionairTesAsync()
        {
            IQuestionairRepository questionairRepository = new QuestionairRepository();
            var questionair = await questionairRepository.GetQuestionairAsync();
            
            Assert.IsNotNull(questionair);
            Assert.That(questionair.QuestionairTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionair.QuestionsText[0], Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionair.QuestionsText[1], Is.EqualTo("What is the capital of France?"));
            Assert.That(questionair.QuestionsText[2], Is.EqualTo("What is the capital of Poland?")); 
            Assert.That(questionair.QuestionsText[3], Is.EqualTo("What is the capital of Germany?"));


        }
    }
}