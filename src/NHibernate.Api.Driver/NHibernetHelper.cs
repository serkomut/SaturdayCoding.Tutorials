using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;

namespace NHibernate.Api.Driver
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSesionFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeSesionFactory()
        {
            const string trusted = @"Server=PAXDEVQ3\SQLEXPRESS;Database=NHibnateDb;Trusted_Connection=True;";
            _sessionFactory = Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(trusted).ShowSql())
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MyKasa>())
            .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
            .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
