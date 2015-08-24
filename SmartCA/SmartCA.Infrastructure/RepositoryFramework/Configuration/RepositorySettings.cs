using System;
using System.Configuration;

namespace SmartCA.Infrastructure.RepositoryFramework.Configuration
{
    class RepositorySettings : ConfigurationSection
    {
        [ConfigurationProperty(RepositoryMappingConstants.ConfigurationPropertyName, IsDefaultCollection = true)]
        public RepositoryMappingCollection RespositoryMappings
        {
            get { return (RepositoryMappingCollection)base[RepositoryMappingConstants.ConfigurationPropertyName]; }
        }
    }
}
