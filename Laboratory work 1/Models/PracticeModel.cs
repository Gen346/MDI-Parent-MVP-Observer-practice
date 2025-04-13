using Laboratory_work_1.Presenters;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Laboratory_work_1.Models
{
    class PracticeModel
    {
        public event EventHandler<FormEventArgs> CreateNewForm;
        public event EventHandler<FormEventArgs> SaveForm;
        public List<string> answers = new List<string>();

        public void OpenPracticeForm()
        {
            PracticeForm p_form = new PracticeForm();

            PracticePresenter practicePresenter = new PracticePresenter(p_form);

            CreateNewForm?.Invoke(this, new FormEventArgs(p_form, false));
        }
        public void SavePracticeForm() //прокинуть новое событие по презентерам
        {
            answers.Add()
            //SaveForm?.Invoke(sender, EventArgs.Empty)
        }
    }
}
