using JO.QuestionairStepStone.Interfaces.Data;
using JO.QuestionairStepStone.Interfaces.Core;
using JO.QuestionairStepStone.Core;
using Moq;
using JO.QuestionairStepStone.Data.Models;

namespace JO.QuestionairStepStone.UnitTests.Core
{
    public class QuestionairServiceTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task GetQuestionairTestAsync()
        {
            var questionairRepository = new Mock<IQuestionairRepository>();
            questionairRepository.Setup(m => m.GetQuestionairAsync()).ReturnsAsync(new Questionair()
            {
                QuestionairTitle = "Geography Questions",
                QuestionsText = new List<string>()
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?",
                }
            });

            IQuestionairService questionairService = new QuestionairService(questionairRepository.Object);

            var questionair = await questionairService.GetQuestionairAsync();

            Assert.IsNotNull(questionair);
            Assert.That(questionair.QuestionairTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionair.QuestionsText[0], Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionair.QuestionsText[1], Is.EqualTo("What is the capital of France?"));
            Assert.That(questionair.QuestionsText[2], Is.EqualTo("What is the capital of Poland?"));
            Assert.That(questionair.QuestionsText[3], Is.EqualTo("What is the capital of Germany?"));

        }
    }
}