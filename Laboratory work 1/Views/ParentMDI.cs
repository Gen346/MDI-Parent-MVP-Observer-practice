using System;
using System.Windows.Forms;

namespace Laboratory_work_1
{
    public partial class FormContainer : Form, IMainForm
    {
        private readonly IMainForm _mainForm;
        public Form MDIParentForm => this;

        public event EventHandler TheoreticalFormOpenClick;
        public event EventHandler PracticeFormOpenClick;
        public event EventHandler AnswerFormOpenClick;

        public FormContainer()
        {
            InitializeComponent();
        }
        #region OpenFormsSender
        private void теоретичніЗапитанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TheoreticalFormOpenClick?.Invoke(sender, EventArgs.Empty);
        }
        private void практичніПитанняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracticeFormOpenClick?.Invoke(sender, EventArgs.Empty);
        }
        private void ShowAnswer(object sender, EventArgs e)
        {
            AnswerFormOpenClick?.Invoke(sender, EventArgs.Empty);
        }
        #endregion

        #region OpenFormMethods
        //private void OpenAnswerForm()
        //{
        //    foreach (Form form in Application.OpenForms)
        //    {
        //        if (form is TheoreticalForm tForm)
        //        {
        //            tForms.Add(tForm);
        //        }
        //    }

        //    TheoreticalForm lastTForm = tForms.Count > 0 ? tForms[tForms.Count - 1] : null;

        //    foreach (Form form in Application.OpenForms)
        //    {
        //        if (form is PracticeForm pForm)
        //        {
        //            pForms.Add(pForm);
        //        }
        //    }

        //    PracticeForm lastPForm = pForms.Count > 0 ? pForms[pForms.Count - 1] : null;

        //    string theoreticalAnswer1 = lastTForm != null ? lastTForm.GetAnswerOne() : "Немає відповіді";
        //    string theoreticalAnswer2 = lastTForm != null ? lastTForm.GetAnswerTwo() : "Немає відповіді";
        //    string practiceAnswer = lastPForm != null ? lastPForm.GetAnswer() : "Немає відповіді";



        //    AnswersForm a_form = new AnswersForm(theoreticalAnswer1, theoreticalAnswer2, practiceAnswer);
        //    a_form.MdiParent = this;
        //    a_form.Text = "Відповідь " + aform_counter.ToString();
        //    a_form.Show();
        //    pForms.Remove(pForms[pForms.Count - 1]);
        //    tForms.Remove(tForms[tForms.Count - 1]);
        //}

        #endregion

        //internal void CheckAnswersAddToolStrip()
        //{
        //    if (tf_container.Count > 0 && pf_container.Count > 0)
        //    {
        //        aform_counter++;

        //        ToolStripMenuItem answerItem = new ToolStripMenuItem();

        //        answerItem.Name = "Відповідь " + aform_counter.ToString();
        //        answerItem.Text = "Відповідь " + aform_counter.ToString();
        //        answerItem.Click += ShowAnswer;

        //        ToolStripMenuItem answersMenuItem = menuStrip1.Items["відповідьToolStripMenuItem"] as ToolStripMenuItem;

        //        if (answersMenuItem != null)
        //        {
        //            answersMenuItem.DropDownItems.Add(answerItem);
        //        }
        //        //TODO List first element clear
        //        pf_container.Clear();
        //        tf_container.Clear();
        //    }
        //}


    }
}