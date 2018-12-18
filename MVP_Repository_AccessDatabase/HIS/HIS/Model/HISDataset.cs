using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HIS.Model
{
    public class HISDataset : IHISDataset
    {
        public IOperatorRepository operatorRepository { get; }
        public ISystem_InfoRepository system_InfoRepository { get; }
        public IClinicRepository clinicRepository { get; }
        public IProfileRepository profileRepository { get; }
        public IVillageRepository villageRepository { get; }
        public IHIslandRepository hIslandRepository { get; }
        public IReligionRepository religionRepository { get; }
        public IOccupationRepository occupationRepository { get; }
        public IRecordRepository recordRepository { get; }
        public IHabitRepository habitRepository { get; }
        public IFamilyRepository familyRepository { get; }
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> addedEntities;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> changedEntities;
        private Dictionary<IAggregateRoot, IUnitOfWorkRepository> deletedEntities;
        public HISDataset(String connectionString)
        {
            addedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            changedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            deletedEntities = new Dictionary<IAggregateRoot, IUnitOfWorkRepository>();
            operatorRepository = new OperatorRepository(connectionString, this);
            system_InfoRepository = new System_InfoRepository(connectionString, this);
            clinicRepository = new ClinicRepository(connectionString, this);
            profileRepository = new ProfileRepository(connectionString, this);
            villageRepository = new VillageRepository(connectionString, this);
            hIslandRepository = new HIslandRepository(connectionString, this);
            religionRepository = new ReligionRepository(connectionString, this);
            occupationRepository = new OccupationRepository(connectionString, this);
            recordRepository = new RecordRepository(connectionString, this);
            habitRepository = new HabitRepository(connectionString, this);
            familyRepository = new FamilyRepository(connectionString, this);
        }
        public void RegisterCreation(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!addedEntities.ContainsKey(entity))
            {
                addedEntities.Add(entity, unitofWorkRepository);
            };
        }
        public void RegisterUpdate(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!changedEntities.ContainsKey(entity))
            {
                changedEntities.Add(entity, unitofWorkRepository);
            }
        }
        public void RegisterDeletion(IAggregateRoot entity, IUnitOfWorkRepository unitofWorkRepository)
        {
            if (!deletedEntities.ContainsKey(entity))
            {
                deletedEntities.Add(entity, unitofWorkRepository);
            }
        }
        public void Commit()
        {
            foreach (IAggregateRoot entity in this.addedEntities.Keys)
            {
                this.addedEntities[entity].PersistCreationOf(entity);
            }
            this.addedEntities.Clear();
            foreach (IAggregateRoot entity in this.changedEntities.Keys)
            {
                this.changedEntities[entity].PersistUpdateOf(entity);
            }
            this.changedEntities.Clear();
            foreach (IAggregateRoot entity in this.deletedEntities.Keys)
            {
                this.deletedEntities[entity].PersistDeletionOf(entity);
            }
            this.deletedEntities.Clear();
        }

    }
}
