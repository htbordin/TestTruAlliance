using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using TechTest01.Domain;

namespace TechTest01.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {

        TEntity GetById(object Id);
        IQueryable<TEntity> Table { get; }
        ProductContext Context { get; }
    }

}
