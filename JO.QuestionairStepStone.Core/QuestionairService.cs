using JO.QuestionairStepStone.Interfaces.Core;
using JO.QuestionairStepStone.Interfaces.Data;
using JO.QuestionairStepStone.Interfaces.Data.Models;

namespace JO.QuestionairStepStone.Core
{
    public class QuestionairService : IQuestionairService
    {
        private readonly IQuestionairRepository _questionairRepository;
        public QuestionairService(IQuestionairRepository questionairRepository)
        {
            _questionairRepository = questionairRepository;
        }

        public async Task<IQuestionair> GetQuestionairAsync()
        {
            return await _questionairRepository.GetQuestionairAsync();
        }
    }
}