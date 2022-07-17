using JO.QuestionairStepStone.Data.Models;
using JO.QuestionairStepStone.Interfaces.Data;
using JO.QuestionairStepStone.Interfaces.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionairStepStone.Data.Repository
{
    public class QuestionairRepository : IQuestionairRepository
    {
        public async Task<IQuestionair> GetQuestionairAsync()
        {
            return await Task.FromResult(new Questionair()
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
        }
    }
}
