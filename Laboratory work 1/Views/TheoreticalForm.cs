using Laboratory_work_1.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratory_work_1
{
    public partial class TheoreticalForm : Form, IViewForms
    {
        private readonly IViewForms _IView;

        public event EventHandler CreateNewForm;
        public event EventHandler SaveForm;

        public TheoreticalForm()
        {
            InitializeComponent();
        }

        private void New_pictureBox_Click(object sender, EventArgs e)
        {
            CreateNewForm?.Invoke(sender, EventArgs.Empty);
        }

        private void Save_pictureBox_Click(object sender, EventArgs e)
        {
            SaveForm?.Invoke(sender, EventArgs.Empty);
        }
        internal string GetAnswerOne()
        {
            string answer = string.Empty;

            if (A_rButton_1.Checked)
            {
                answer = "А";
            }
            else if (B_rButton_1.Checked)
            {
                answer = "Б";
            }
            else
            {
                answer = "В";
            }
            return answer;
        }

        internal string GetAnswerTwo()
        {
            string answer = string.Empty;

            if (A_rButton_2.Checked)
            {
                answer = "А";
            }
            else if (B_rButton_2.Checked)
            {
                answer = "Б";
            }
            else
            {
                answer = "В";
            }
            return answer;
        }
    }
}
