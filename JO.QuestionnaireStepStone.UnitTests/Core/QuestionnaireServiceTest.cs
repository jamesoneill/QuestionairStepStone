using JO.QuestionnaireStepStone.Interfaces.Data;
using JO.QuestionnaireStepStone.Interfaces.Core;
using JO.QuestionnaireStepStone.Core;
using Moq;
using JO.QuestionnaireStepStone.Data.Models;

namespace JO.QuestionnaireStepStone.UnitTests.Core
{
    public class QuestionnaireServiceTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task GetQuestionnaireTestAsync()
        {
            var questionnaireRepository = new Mock<IQuestionnaireRepository>();
            questionnaireRepository.Setup(m => m.GetQuestionnaireAsync()).ReturnsAsync(new Questionnaire()
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>()
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?",
                }
            });

            IQuestionnaireService questionnaireService = new QuestionnaireService(questionnaireRepository.Object);

            var questionnaire = await questionnaireService.GetQuestionnaireAsync();

            Assert.IsNotNull(questionnaire);
            Assert.That(questionnaire.QuestionnaireTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionnaire.QuestionsText[0], Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionnaire.QuestionsText[1], Is.EqualTo("What is the capital of France?"));
            Assert.That(questionnaire.QuestionsText[2], Is.EqualTo("What is the capital of Poland?"));
            Assert.That(questionnaire.QuestionsText[3], Is.EqualTo("What is the capital of Germany?"));

        }
    }
}