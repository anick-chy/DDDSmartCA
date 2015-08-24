using SmartCA.Infrastructure.DomainBase;
using System;
using System.Collections.Generic;

namespace SmartCA.Infrastructure.RepositoryFramework
{
    public interface IUnitOfWorkRepository
    {
        void PersistNewItem(EntityBase item);
        void PersistUpdatedItem(EntityBase item);
        void PersistDeletedItem(EntityBase item);
    }
}
