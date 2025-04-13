using Laboratory_work_1.Presenters;
using System;
using System.Windows.Forms;

namespace Laboratory_work_1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormContainer mainForm = new FormContainer();

            MainPresenter presenter = new MainPresenter(mainForm);

            Application.Run(mainForm);

        }
    }
}
