using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1.Models
{
    public interface IAnswerModel
    {
        event EventHandler<AnswersUpdatedEventArgs> AnswersUpdated;
        void SetAnswers(string theoretical1, string theoretical2, string practical);
    }
}
