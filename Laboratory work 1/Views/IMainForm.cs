using System;
using System.Windows.Forms;

namespace Laboratory_work_1
{
    public interface IMainForm
    {
        Form MDIParentForm { get; }
        //Прокидую події для методів відкриття інших форм.
        //Батківська форма може тільки відкривати вікна, тому додаткові поля не прописую.

        event EventHandler TheoreticalFormOpenClick;
        event EventHandler PracticeFormOpenClick;
        event EventHandler AnswerFormOpenClick;
    }
}