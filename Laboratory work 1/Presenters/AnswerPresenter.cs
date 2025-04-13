using Laboratory_work_1.Models;
using Laboratory_work_1.Views;

namespace Laboratory_work_1.Presenters
{
    public class AnswerPresenter
    {
        private readonly IAnswersView _view;
        private readonly IAnswerModel _model;

        public AnswerPresenter(IAnswersView view, IAnswerModel model)
        {
            _view = view;
            _model = model;

            _model.AnswersUpdated += OnAnswersUpdated;
        }

        private void OnAnswersUpdated(object? sender, AnswersUpdatedEventArgs e)
        {
            _view.DisplayAnswers(e.TheoreticalAnswer1, e.TheoreticalAnswer2, e.PracticeAnswer);
        }
    }
}
