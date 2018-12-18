using System;
using System.Windows.Forms;

namespace HIS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=HIS.accdb;Jet OLEDB:Database Password=thegreatwall";
            var unitOfWork = new Model.HISDataset(connectionString);
            var view = new View.LoginForm();
            var presenter = new Presenter.LoginPresenter(view, unitOfWork);
            Application.Run(view);
        }
    }
}