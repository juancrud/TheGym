namespace TheGym.DataAccess.Interfaces
{
    public interface ITransactionalRepository
    {
        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
