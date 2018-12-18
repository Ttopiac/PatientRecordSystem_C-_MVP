using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HIS.View
{
    public partial class YesNoForm : Form, IYesNoView
    {
        public YesNoForm(String formName)
        {
            _formName = formName;
            InitializeComponent();
        }
        private String _formName;
        public Presenter.IYesNoFormPresenter Presenter { private get; set; }
        public String formName { get { return _formName; } }
        public String closerMessage { set { messageLabel.Text = value; } }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Presenter.YesActionByYNForm(formName);
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Presenter.NoActionByYNForm(formName);
        }

        private void YesNoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Presenter.CloseActionByYNForm(formName);
        }
    }
}
