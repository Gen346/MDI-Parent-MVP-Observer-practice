using Laboratory_work_1.Models;
using System;
using System.Windows.Forms;

namespace Laboratory_work_1.Presenters
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly MainModel _model;

        public MainPresenter(IMainForm view)
        {
            _view = view;
            _model = new MainModel();

            _view.TheoreticalFormOpenClick += OnTheoreticalFormOpen;
            _view.PracticeFormOpenClick += OnPracticeFormOpen;

            _model.TheoreticalFormOpened += OnTheoreticalFormCreated;
            _model.PracticeFormOpened += OnPracticeFormCreated;
        }

        private void OnTheoreticalFormOpen(object sender, EventArgs e)
        {
            _model.OpenTheoreticalForm();
        }

        private void OnPracticeFormOpen(object sender, EventArgs e)
        {
            _model.OpenPracticeForm();
        }

        private void OnTheoreticalFormCreated(object sender, FormEventArgs e)
        {
            e.FormInstance.MdiParent = (Form)_view;
            e.FormInstance.Text = $"Теоретичні питання {e.FormCount}";
            e.FormInstance.Show();
        }

        private void OnPracticeFormCreated(object sender, FormEventArgs e)
        {
            e.FormInstance.MdiParent = (Form)_view;
            e.FormInstance.Text = $"Практичні запитання {e.FormCount}";
            e.FormInstance.Show();
        }
    }
}