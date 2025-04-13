using Laboratory_work_1.Models;
using Laboratory_work_1.Views;
using System;
using System.Windows.Forms;

namespace Laboratory_work_1.Presenters
{
    class TheoryPresenter
    {
        private readonly IViewForms _view;
        private readonly TheoryModel _model;

        public TheoryPresenter(IViewForms theoryView)
        {
            _view = theoryView;
            _model = new TheoryModel();

            _view.CreateNewForm += OnNewFormClick;
            _view.SaveForm += OnSaveFormClick;


            _model.CreateNewForm += OnTheoryFormCreated;
            //_model.SaveResult += OnSavePracticeFormClick; //TODO implement SavePracticeFormClick event in MainModel
        }

        private void OnNewFormClick(object sender, EventArgs e)
        {
            _model.OpenTheoryForm();
        }
        private void OnSaveFormClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //SavePracticeFormClick?.Invoke(sender, EventArgs.Empty);
        }
        private void OnTheoryFormCreated(object sender, FormEventArgs e)
        {
            FormContainer mdiParent = Application.OpenForms["FormContainer"] as FormContainer;

            if (mdiParent != null)
            {
                e.FormInstance.MdiParent = mdiParent;
            }
            else
            {
                MessageBox.Show("Error: MDI-Container does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            e.FormInstance.Text = $"Теоретичні питання {e.FormCount}";
            e.FormInstance.Show();
        }
    }
}
