using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface ISystem_InfoRepository: IRepository<System_Info>
    {
        System_Info GetById(Int32 id);
    }
}
