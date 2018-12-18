using System.Collections.Generic;
using System;
namespace HIS.View
{
    public interface ILoginView
    {
        List<String> clinicList { set; }
        String clinic { get; set; }
        String searchedUsername { get; }
        String searchedPswd { get; }
        String loginMessage { set; }
        void Hide();
        void Show();
        Presenter.LoginPresenter Presenter { set; }
    }
}
