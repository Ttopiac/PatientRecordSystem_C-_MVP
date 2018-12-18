using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IOperatorRepository:IRepository<Operator>
    {
        Operator GetByUsernameAndPswd(String username, String pswd);
        Operator GetById(Int32 id);
    }
}
