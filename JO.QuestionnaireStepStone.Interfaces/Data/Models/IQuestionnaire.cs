using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionnaireStepStone.Interfaces.Data.Models
{
    public interface IQuestionnaire
    {
        string QuestionnaireTitle { get; set; }
        IList<string> QuestionsText { get; set; } 
    }
}
