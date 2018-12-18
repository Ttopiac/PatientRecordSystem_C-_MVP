using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public interface IHISDataset : IUnitOfWork
    {
        IOperatorRepository operatorRepository { get; }
        ISystem_InfoRepository system_InfoRepository { get; }
        IClinicRepository clinicRepository { get; }
        IProfileRepository profileRepository { get; }
        IVillageRepository villageRepository { get; }
        IHIslandRepository hIslandRepository { get; }
        IReligionRepository religionRepository { get; }
        IOccupationRepository occupationRepository { get; }
        IRecordRepository recordRepository { get; }
        IHabitRepository habitRepository { get; }
        IFamilyRepository familyRepository { get; }
    }
}
