using JO.QuestionnaireStepStone.Interfaces.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionnaireStepStone.Interfaces.Data
{
    public interface IQuestionnaireRepository
    {
        Task<IQuestionnaire> GetQuestionnaireAsync();
    }
}
