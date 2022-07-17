using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.QuestionairStepStone.Interfaces.Data.Models
{
    public interface IQuestionair
    {
        string QuestionairTitle { get; set; }
        IList<string> QuestionsText { get; set; } 
    }
}
