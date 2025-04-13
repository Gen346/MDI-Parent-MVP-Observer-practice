using System;

namespace Laboratory_work_1.Views
{
    public interface IViewForms
    {
        //All new view forms must be inherited from this interface to prevent unhandled exceptions 
        event EventHandler CreateNewForm;
        event EventHandler SaveForm;
    }
}
//If apllication need to be bigger, developer can easyly inharite this interface and add new functional