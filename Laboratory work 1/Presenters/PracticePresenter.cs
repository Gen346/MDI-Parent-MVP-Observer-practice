using Laboratory_work_1.Models;
using Laboratory_work_1.Views;
using System;
using System.Windows.Forms;

namespace Laboratory_work_1.Presenters
{
    class PracticePresenter
    {
        private readonly IViewForms _IView;
        private readonly PracticeModel _model; //Change to practice for test #COMPLETE

        public PracticePresenter(IViewForms practiceView)
        {
            _IView = practiceView;
            _model = new PracticeModel(); //Don`t forget about constructor

            _IView.CreateNewForm += OnNewFormClick;
            _IView.SaveForm += OnSaveFormClick;


            _model.CreateNewForm += OnPracticeFormCreated;
            //_model.SaveResult += OnSavePracticeFormClick; //TODO implement SavePracticeFormClick event in MainModel
        }

        private void OnNewFormClick(object sender, EventArgs e)
        {
            _model.OpenPracticeForm();
        }
        private void OnSaveFormClick(object sender, EventArgs e)
        {
            _model.SavePracticeForm();
        }
        private void OnPracticeFormCreated(object sender, FormEventArgs e)
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
            e.FormInstance.Text = $"Практичні питання {e.FormCount}";
            e.FormInstance.Show();
        }
    }
}