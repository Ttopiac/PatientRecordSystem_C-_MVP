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
    public partial class RecordForm : Form, IRecordView
    {
        public RecordForm()
        {
            InitializeComponent();
        }
        public Double PID
        {
            get
            {
                return Convert.ToDouble(PIDTextbox.Text);
            }
            set
            {
                PIDTextbox.Text = value.ToString();
            }
        }
        public String FullName
        {
            set
            {
                profileNameLabel.Text = value;
            }
        }
        public String Gender
        {
            set
            {
                profileGenderLabel.Text = value;
            }
        }
        public UInt16 age
        {
            set
            {
                profileAgeLabel.Text = value.ToString();
            }
        }
        public String Allergy
        {
            set
            {
                profileNameLabel.Text = value;
            }
        }

        public Presenter.RecordPresenter Presenter { private get; set; }
    }
}
