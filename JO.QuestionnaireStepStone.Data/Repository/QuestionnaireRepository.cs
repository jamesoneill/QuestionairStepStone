using JO.QuestionnaireStepStone.Data.Models;
using JO.QuestionnaireStepStone.Interfaces.Data;
using JO.QuestionnaireStepStone.Interfaces.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionnaireStepStone.Data.Repository
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        public async Task<IQuestionnaire> GetQuestionnaireAsync()
        {
            return await Task.FromResult(new Questionnaire()
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
        }
    }
}
