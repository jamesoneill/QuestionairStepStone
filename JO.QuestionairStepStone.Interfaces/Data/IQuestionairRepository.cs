using JO.QuestionairStepStone.Interfaces.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionairStepStone.Interfaces.Data
{
    public interface IQuestionairRepository
    {
        Task<IQuestionair> GetQuestionairAsync();
    }
}
