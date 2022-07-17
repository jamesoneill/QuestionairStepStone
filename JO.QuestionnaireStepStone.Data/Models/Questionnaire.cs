using JO.QuestionnaireStepStone.Interfaces.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionnaireStepStone.Data.Models
{
    public class Questionnaire : IQuestionnaire
    {
        public string QuestionnaireTitle { get; set; } = "";
        public IList<string> QuestionsText { get; set; } = new List<string>();
    }
}
