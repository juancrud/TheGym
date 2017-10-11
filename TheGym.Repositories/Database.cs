using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using TheGym.Repositories.Mappings;

namespace TheGym.Repositories
{
    public class Database
    {
        private const string ConnectionString = "DbConnection";

        private static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[ConnectionString].ConnectionString;
        }

        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory != null)
                {
                    return _sessionFactory;
                }

                var connectionString = GetConnectionString();
                _sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2012.ConnectionString(connectionString))
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<UserMap>())
                    .ExposeConfiguration(UpdateSchema)
                    .BuildSessionFactory();

                return SessionFactory;
            }
        }

        private static void UpdateSchema(Configuration cfg)
        {
            new SchemaUpdate(cfg).Execute(false, true);
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

    }
}
