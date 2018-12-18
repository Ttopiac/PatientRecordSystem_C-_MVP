using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IReligionRepository:IRepository<Religion>
    {
        List<String> religionNameList { get; }
    }
}
