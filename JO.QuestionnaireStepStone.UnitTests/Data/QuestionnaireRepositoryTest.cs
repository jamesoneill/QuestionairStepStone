using JO.QuestionnaireStepStone.Data.Repository;
using JO.QuestionnaireStepStone.Interfaces.Data;

namespace JO.QuestionnaireStepStone.UnitTests.Core
{
    public class QuestionnaireRepositoryTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public async Task GetQuestionnairTestAsync()
        {
            IQuestionnaireRepository questionnairRepository = new QuestionnaireRepository();
            var questionnaire = await questionnairRepository.GetQuestionnaireAsync();
            
            Assert.IsNotNull(questionnaire);
            Assert.That(questionnaire.QuestionnaireTitle, Is.EqualTo("Geography Questions"));
            Assert.That(questionnaire.QuestionsText[0], Is.EqualTo("What is the capital of Cuba?"));
            Assert.That(questionnaire.QuestionsText[1], Is.EqualTo("What is the capital of France?"));
            Assert.That(questionnaire.QuestionsText[2], Is.EqualTo("What is the capital of Poland?")); 
            Assert.That(questionnaire.QuestionsText[3], Is.EqualTo("What is the capital of Germany?"));


        }
    }
}