using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_work_1.View
{
    class TheoreticalView
    {
        //string firstAnswer { get; }
        //string secondAnswer { get; }

        private Button _saveButton;
        private Button _newButton;
        private GroupBox _groupBox;
        public void DisplaySaveResult()
        {
            this._groupBox.Enabled = false;
            MessageBox.Show($"Відповідь збережено", "Повідомлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void SaveButtonClick()
        {
            //_saveButton.Click += _presenter.SaveAnswer();
        }
        private void NewButtonClick()
        {
            //_newButton.Click += _presenter.NewForm();
        }
    }
}
