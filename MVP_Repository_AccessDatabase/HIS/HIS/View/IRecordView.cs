using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.View
{
    public interface IRecordView
    {
        Double PID { get; set; }
        String FullName { set; }
        String Gender { set; }
        UInt16 age { set; }
        String Allergy { set; }
        Presenter.RecordPresenter Presenter{ set; }
    }
}
