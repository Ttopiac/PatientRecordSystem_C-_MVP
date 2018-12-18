using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IRecordRepository: IRepository<Record>
    {
        Record GetByKey(Double id, DateTime date, String tableName);
        Record GetNewEntity(Double id, DateTime date, String clinic, Int32 oper, String tableName);
    }
}
