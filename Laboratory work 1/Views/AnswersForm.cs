using System;
using System.Windows.Forms;

namespace Laboratory_work_1
{
    public partial class AnswersForm : Form
    {
        private string theoreticalAnswer1;
        private string theoreticalAnswer2;
        private string practiceAnswer;

        public AnswersForm()
        {
            InitializeComponent();

            this.theoreticalAnswer1 = theoreticalAnswer1;
            this.theoreticalAnswer2 = theoreticalAnswer2;
            this.practiceAnswer = practiceAnswer;

            if(theoreticalAnswer1 == "А")
            {
                A_rButton_1.Checked = true;
            }
            else if (theoreticalAnswer1 == "Б")
            {
                B_rButton_1.Checked = true;
            }
            else
            {
                C_rButton_1.Checked = true;
            }

            if (theoreticalAnswer2 == "А")
            {
                A_rButton_2.Checked = true;
            }
            else if (theoreticalAnswer2 == "Б")
            {
                B_rButton_2.Checked = true;
            }
            else
            {
                C_rButton_2.Checked = true;
            }

            if(practiceAnswer == "А")
            {
                A_radioButton_1.Checked = true;
            }
            else if(practiceAnswer == "Б")
            {
                B_radioButton_1.Checked = true;
            }
            else
            {
                C_radioButton_1.Checked = true;
            }

                //tAnswer_label_1.Text = theoreticalAnswer1;
                //tAnswer_label_2.Text = theoreticalAnswer2;
                //tAnswer_label_3.Text = practiceAnswer;

                ContextMenuStrip contextMenu = new ContextMenuStrip();

            ToolStripMenuItem checkAnswersItem = new ToolStripMenuItem("Перевірити відповіді");

            checkAnswersItem.Click += CheckAnswers_Click;

            contextMenu.Items.Add(checkAnswersItem);

            this.ContextMenuStrip = contextMenu;
        }

        private void CheckAnswers_Click(object sender, EventArgs e)
        {
            int score = 0;

            if (theoreticalAnswer1 == "Б")
            {
                score++;
            }
            if (theoreticalAnswer2 == "Б")
            {
                score++;
            }
            if(practiceAnswer == "А")
            {
                score++;
            }

            MessageBox.Show($"Зараховано балів: {score}", "Результат перевірки", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
