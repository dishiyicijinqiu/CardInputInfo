using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ContainerModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data.Instrumentation;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SQLite;

namespace CardInputInfo.Core
{
    [ConfigurationElementType(typeof(SQLiteDatabaseData))]
    public class SQLiteDatabase : Database
    {
        public SQLiteDatabase(string connectionString, DbProviderFactory dbProviderFactory, IDataInstrumentationProvider instrumentationProvider)
            : base(connectionString, dbProviderFactory, instrumentationProvider)
        {
        }
        protected override void DeriveParameters(DbCommand discoveryCommand)
        {
            throw new NotImplementedException("The method or operation is not implemented.");
        }
    }

    public class SQLiteDatabaseData : DatabaseData
    {
        public SQLiteDatabaseData(ConnectionStringSettings connectionStringSettings, IConfigurationSource configurationSource)
            : base(connectionStringSettings, configurationSource)
        {
        }
        public string ProviderName
        {
            get { return ConnectionStringSettings.ProviderName; }
        }
        public override IEnumerable<TypeRegistration> GetRegistrations()
        {
            yield return new TypeRegistration<Database>(
                () => new SQLiteDatabase(ConnectionString,
                   SQLiteFactory.Instance,
                    Container.Resolved<IDataInstrumentationProvider>(Name)))
            {
                Name = Name,
                Lifetime = TypeRegistrationLifetime.Transient
            };
        }
    }
}
