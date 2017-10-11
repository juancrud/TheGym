using System;
using System.Linq;
using NHibernate;
using NHibernate.Linq;
using TheGym.DataAccess.Interfaces;

namespace TheGym.DataAccess
{
    public abstract class BaseRepository<T> : IBaseRepository<T>, ITransactionalRepository, IDisposable
    {
        protected ISession Session;
        protected ITransaction Transaction;

        #region Constructors

        protected BaseRepository()
        {
        }

        protected BaseRepository(ISession session)
        {
            Session = session;
        }

        #endregion

        #region Transactions and Session Management

        public void BeginTransaction()
        {
            Transaction = Session.BeginTransaction();
        }

        public void CommitTransaction()
        {
            Transaction.Commit();
            CloseTransaction();
        }

        public void RollbackTransaction()
        {
            Transaction.Rollback();
            CloseTransaction();
            CloseSession();
        }

        private void CloseTransaction()
        {
            Transaction.Dispose();
            Transaction = null;
        }

        private void CloseSession()
        {
            Session.Close();
            Session.Dispose();
            Session = null;
        }

        #endregion

        #region Repository Methods

        public T Get(int id)
        {
            return Session.Load<T>(id);
        }

        public IQueryable<T> Get()
        {
            return Session.Query<T>();
        }

        public IQueryable<T> Get(Func<T, bool> predicate)
        {
            return Session.Query<T>().Where(predicate).AsQueryable();
        }

        public void Save(T dao)
        {
            Session.SaveOrUpdate(dao);
        }

        public void Delete(T dao)
        {
            Session.Delete(dao);
        }

        #endregion

        public void Dispose()
        {
            if (Transaction != null)
            {
                CommitTransaction();
            }

            if (Session != null)
            {
                Session.Flush();
                CloseSession();
            }
        }
    }
}
