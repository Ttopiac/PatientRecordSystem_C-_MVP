using HIS.View;
using HIS.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HIS.Presenter
{
    public interface IYesNoFormPresenter
    {
        void YesActionByYNForm(String formName);
        void NoActionByYNForm(String formName);
        void CloseActionByYNForm(String formName);
    }
}
