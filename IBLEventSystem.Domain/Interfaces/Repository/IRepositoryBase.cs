using System;
using System.Collections.Generic;

namespace IBLEventSystem.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void AddOrUpdate(TEntity obj);
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void Remove(TEntity obj);
        void Dispose();
    }
}
