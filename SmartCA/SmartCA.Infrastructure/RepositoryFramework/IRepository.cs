using SmartCA.Infrastructure.DomainBase;
using System;

namespace SmartCA.Infrastructure.RepositoryFramework
{
    public interface IRepository<T> where T : EntityBase
    {
        T FindBy(object key);
        void Add(T item);
        T this[object key] { get; set; }
        void Remove(T item);
    }
}
