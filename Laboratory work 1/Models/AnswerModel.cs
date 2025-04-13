using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_1.Models
{
    public class AnswerModel : IAnswerReceiver
    {
        private string _practiceAnswer;
        private string _theoryAnswer;
        private readonly ToolStripMenuItem _menuStrip;

        public AnswerModel(ToolStripMenuItem menuStrip)
        {
            _menuStrip = menuStrip;
        }

        public void ReceiveAnswer(string from, string answer)
        {
            if (from == "Practice")
                _practiceAnswer = answer;
            else if (from == "Theory")
                _theoryAnswer = answer;

            if (!string.IsNullOrEmpty(_practiceAnswer) && !string.IsNullOrEmpty(_theoryAnswer))
            {
                AddAnswersMenuItem();
            }
        }

        private void AddAnswersMenuItem()
        {
            var item = new ToolStripMenuItem("Відповіді отримані");
            _menuStrip.A.Add(item);
        }
    }

}
