using JO.QuestionnaireStepStone.Data.Models;
using JO.QuestionnaireStepStone.Data.Repository;
using JO.QuestionnaireStepStone.Interfaces.Data;

namespace JO.QuestionnaireStepStone.UnitTests.Data
{
    public class QuestionnaireRepositoryTest
    {
        [Test]
        public async Task GetQuestionnairTestAsync()
        {
            IQuestionnaireRepository questionnairRepository = new QuestionnaireRepository();
            var questionnaire = await questionnairRepository.GetQuestionnaireAsync();

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