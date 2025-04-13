using Laboratory_work_1.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laboratory_work_1
{
    public partial class PracticeForm : Form, IViewForms
    {
        private readonly IViewForms _IView;

        public event EventHandler CreateNewForm;
        public event EventHandler SaveForm; // TODO Save method. Release with Query

        public PracticeForm()
        {
            InitializeComponent();
        }

        private void New_pictureBox_Click(object sender, EventArgs e)
        {
            CreateNewForm?.Invoke(sender, EventArgs.Empty);
        }

        private void Save_pictureBox_Click(object sender, EventArgs e)
        {
            GetAnswers();
        }
        internal string GetAnswer()
        {
            string answer = string.Empty;

            if (A_rb.Checked)
            {
                answer = "А";
            }
            else if (B_rb.Checked)
            {
                answer = "Б";
            }
            else
            {
                answer = "В";
            }

            return answer;
        }
        public List<string> GetAnswers()
        {
            PracticeForm p_form = Application.OpenForms["PracticeForm"] as PracticeForm;
            List<string> p_answers = new List<string>();
            foreach (Control control in Practice_groupBox.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton rb = (RadioButton)control;

                    if (rb.Checked == true)
                    {
                        if (rb.Name.Contains("A"))
                        {
                            p_answers.Add("A");
                        }
                        else if (rb.Name.Contains("B"))
                        {
                            p_answers.Add("B");
                        }
                        else
                        {
                            p_answers.Add("C");
                        }
                    }
                }
            }
            return p_answers;
        }
        private void PracticeForm_Shown(object sender, EventArgs e)
        {
            A_rb.Checked = false;
            B_rb.Checked = false;
            C_rb.Checked = false;
        }
    }
}
