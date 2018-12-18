using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        void Create(IAggregateRoot _t);
        void Update(IAggregateRoot _t);
        void Delete(IAggregateRoot _t);
        void Create(IEntityWithReocord _t, String clinic, Int32 oper);
        void Update(IEntityWithReocord _t, String clinic, Int32 oper);
        void Delete(IEntityWithReocord _t, String clinic, Int32 oper);
    }
}
