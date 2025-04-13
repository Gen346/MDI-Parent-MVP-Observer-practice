using Laboratory_work_1.Presenters;
using System;
using System.Windows.Forms;

namespace Laboratory_work_1.Models
{
    public class MainModel
    {
        // События для уведомления Presenter'а
        public event EventHandler<FormEventArgs> TheoreticalFormOpened;
        public event EventHandler<FormEventArgs> PracticeFormOpened;

        public void OpenTheoreticalForm()
        {
            TheoreticalForm t_form = new TheoreticalForm();

            TheoryPresenter theoryPresenter = new TheoryPresenter(t_form);

            TheoreticalFormOpened?.Invoke(this, new FormEventArgs(t_form, true));
        }

        public void OpenPracticeForm()
        {
            PracticeForm p_form = new PracticeForm();

            PracticePresenter practicePresenter = new PracticePresenter(p_form);

            PracticeFormOpened?.Invoke(this, new FormEventArgs(p_form, false));
        }
    }

    public class FormEventArgs : EventArgs
    {
        private static int theoreticalCounter = 0;
        private static int practiceCounter = 0;
        //private static int praticeCounterSaved = 0;
        //private static int theoreticaCounterSaved = 0;
        public Form FormInstance { get; }
        public int FormCount { get; }
        //public int TheoreticalSaved { get; }
        //public int Practicesaved { get; }

        public FormEventArgs(Form formInstance, bool isTheoretical)
        {
            FormInstance = formInstance;

            if (isTheoretical)
                FormCount = ++theoreticalCounter;
            else
                FormCount = ++practiceCounter;
        }
    }
}