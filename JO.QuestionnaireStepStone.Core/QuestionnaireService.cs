using JO.QuestionnaireStepStone.Interfaces.Core;
using JO.QuestionnaireStepStone.Interfaces.Data;
using JO.QuestionnaireStepStone.Interfaces.Data.Models;

namespace JO.QuestionnaireStepStone.Core
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly IQuestionnaireRepository _questionnaireRepository;
        public QuestionnaireService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<IQuestionnaire> GetQuestionnaireAsync()
        {
            return await _questionnaireRepository.GetQuestionnaireAsync();
        }
    }
}