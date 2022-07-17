using JO.QuestionairStepStone.Interfaces.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionairStepStone.Data.Models
{
    public class Questionair : IQuestionair
    {
        public string QuestionairTitle { get; set; } = "";
        public IList<string> QuestionsText { get; set; } = new List<string>();
    }
}
