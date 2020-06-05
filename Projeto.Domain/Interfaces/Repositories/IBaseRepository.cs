using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Projeto.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        IQueryable<TEntity> GetAll();
        TEntity GetById(Guid id);
    }
}
