using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IUnitOfWork
    {
        void RegisterCreation(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterUpdate(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void RegisterDeletion(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository);
        void Commit();        
    }
}
