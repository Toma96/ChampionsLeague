using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using global::NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.IO;
using ChampionsLeague.DataAccessLayer.Mappings;

namespace ChampionsLeague.DataAccessLayer
{
    public class NHibernateService
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory OpenSessionFactory()
        {
            string dataSource = "Championship.db";

            var fluentConfig = Fluently.Configure()
                                .Database(SQLiteConfiguration.Standard
                                .UsingFile(dataSource))
                                .Mappings(mappings => mappings.FluentMappings.AddFromAssemblyOf<GroupMap>());

            var nhConfig = fluentConfig.BuildConfiguration();
            _sessionFactory = nhConfig.BuildSessionFactory();

            if (File.Exists(dataSource))
            {
                var schemaExport = new SchemaExport(nhConfig);
                schemaExport.Create(false, true);
            }

            return _sessionFactory;
        }

        public static ISession OpenSession()
        {
            if (_sessionFactory == null)
            {
                _sessionFactory = OpenSessionFactory();
            }
            ISession session = _sessionFactory.OpenSession();
            return session;
        }
    }
}
