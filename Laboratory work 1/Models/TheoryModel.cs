using Laboratory_work_1.Presenters;
using System;

namespace Laboratory_work_1.Models
{
    class TheoryModel
    {
        public event EventHandler<FormEventArgs> CreateNewForm;
        public event EventHandler<FormEventArgs> SaveForm;

        public string answerOne { get; set; } = string.Empty;
        public string answerTwo { get; set; } = string.Empty;

        public void OpenTheoryForm()
        {
            TheoreticalForm t_form = new TheoreticalForm();

            TheoryPresenter theoryPresenter = new TheoryPresenter(t_form);

            CreateNewForm?.Invoke(this, new FormEventArgs(t_form, true));
        }
    }
}
