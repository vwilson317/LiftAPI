﻿using System.Configuration;
using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Context;
using NHibernate.Tool.hbm2ddl;

//Reference http://www.codeproject.com/Articles/687107/NHibernate-Setup-for-ASP-NET
namespace NHibernateImp
{
    /// <summary>
    /// Here basic NHibernate manipulation methods are implemented.
    /// </summary>
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory = null;

        /// <summary>
        /// In case there is an already instantiated NHibernate ISessionFactory,
        /// retrieve it, otherwise instantiate it.
        /// </summary>
        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    // build a Session Factory
                    _sessionFactory = CreateSessionFactory();
                }
                return _sessionFactory;
            }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
              .Database(
                MsSqlConfiguration.MsSql2012
                .ConnectionString(ConfigurationManager.ConnectionStrings["SqlDBServer"].ToString())
                .ShowSql())
              .Mappings(m =>
                  m.FluentMappings
                  .AddFromAssemblyOf<NamedEntity>())
              //.ExposeConfiguration(BuildSchema)//TODO:Revist
              .BuildSessionFactory();
        }

        private static void BuildSchema(NHibernate.Cfg.Configuration config)
        {
            new SchemaExport(config).Execute(false, true, false);

            //new SchemaUpdate(config)
            //    .Execute(false, true);
        }

        /// <summary>
        /// Open an ISession based on the built SessionFactory.
        /// </summary>
        /// <returns>Opened ISession.</returns>
        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();

        }
        /// <summary>
        /// Create an ISession and bind it to the current tNHibernate Context.
        /// </summary>
        public void CreateSession()
        {
            CurrentSessionContext.Bind(OpenSession());
        }

        /// <summary>
        /// Close an ISession and unbind it from the current
        /// NHibernate Context.
        /// </summary>
        public void CloseSession()
        {
            if (CurrentSessionContext.HasBind(SessionFactory))
            {
                CurrentSessionContext.Unbind(SessionFactory).Dispose();
            }
        }

        /// <summary>
        /// Retrieve the current binded NHibernate ISession, in case there
        /// is any. Otherwise, open a new ISession.
        /// </summary>
        /// <returns>The current binded NHibernate ISession.</returns>
        public ISession GetCurrentSession()
        {
            if (!CurrentSessionContext.HasBind(SessionFactory))
            {
                CurrentSessionContext.Bind(SessionFactory.OpenSession());
            }
            return SessionFactory.GetCurrentSession();
        }
    }
}
