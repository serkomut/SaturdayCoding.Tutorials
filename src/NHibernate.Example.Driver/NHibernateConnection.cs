using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Example.Driver.Property;
using NHibernate.Tool.hbm2ddl;

namespace NHibernate.Example.Driver
{
    public class NHibernateConnection
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeSessionFactory();
                }
                return _sessionFactory;
            }
        }
        private static void InitializeSessionFactory()
        {
            const string connectionString = @"Server=PAXDEVQ3\SQLEXPRESS;Database=NHibnateDb;Trusted_Connection=True;";
            _sessionFactory =
                Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(connectionString).ShowSql())
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Users>())
                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                    .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
