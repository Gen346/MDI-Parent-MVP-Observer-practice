using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_work_1.Views
{
    public interface IFormView
    {
        event EventHandler FormOpened;
        event EventHandler FormSaved;
    }
}
