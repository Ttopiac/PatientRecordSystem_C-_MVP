using System;
using System.Collections.Generic;

namespace HIS.View
{
    public interface IYesNoView
    {
        Presenter.IYesNoFormPresenter Presenter { set; }
        #region message
        String formName { get; }
        String closerMessage { set; }
        #endregion
        void Show();
        void Close();
    }
}

