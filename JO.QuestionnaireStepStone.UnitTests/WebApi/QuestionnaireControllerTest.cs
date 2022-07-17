using JO.QuestionnaireStepStone.Data.Models;
using JO.QuestionnaireStepStone.Interfaces.Core;
using JO.QuestionnaireStepStone.Interfaces.Data.Models;
using JO.QuestionnaireStepStone.WebAPI.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionnaireStepStone.UnitTests.WebApi
{
    internal class QuestionnaireControllerTest
    {
        [Test]
        public async Task GetQuestionnairTestAsync()
        {
            var questionnaireService = new Mock<IQuestionnaireService>();
            IQuestionnaire questionnaireserviceReturn = new Questionnaire()
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>()
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?",
                }
            };

            questionnaireService.Setup(m => m.GetQuestionnaireAsync()).ReturnsAsync(questionnaireserviceReturn);

            QuestionnaireController questionnaireController = new QuestionnaireController(questionnaireService.Object);
            var questionnaire = await questionnaireController.Get();

            var expectedOutcome = new Questionnaire()
            {
                QuestionnaireTitle = "Geography Questions",
                QuestionsText = new List<string>()
                {
                    "What is the capital of Cuba?",
                    "What is the capital of France?",
                    "What is the capital of Poland?",
                    "What is the capital of Germany?",
                }
            };

            Assert.IsNotNull(questionnaire);
            Assert.That(questionnaire.QuestionnaireTitle, Is.EqualTo(expectedOutcome.QuestionnaireTitle));
            Assert.That(questionnaire.QuestionsText[0], Is.EqualTo(expectedOutcome.QuestionsText[0]));
            Assert.That(questionnaire.QuestionsText[1], Is.EqualTo(expectedOutcome.QuestionsText[1]));
            Assert.That(questionnaire.QuestionsText[2], Is.EqualTo(expectedOutcome.QuestionsText[2]));
            Assert.That(questionnaire.QuestionsText[3], Is.EqualTo(expectedOutcome.QuestionsText[3]));


        }
    }
}
