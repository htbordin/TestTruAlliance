using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTest01.Domain;
using System.Data.Entity;

namespace TechTest01.Repository
{
    public partial class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {

        private readonly ProductContext _context;
        private IDbSet<TEntity> _entities;

        public Repository(ProductContext context)
        {
            this._context = context;
        }

        public virtual ProductContext Context
        {
            get
            {
                return this._context;
            }
        }
        public virtual TEntity GetById(object Id)
        {
            return this.Entities.Find(Id);
        }

        public virtual IQueryable<TEntity> Table
        {
            get
            {
                return this.Entities;
            }
        }
        protected virtual IDbSet<TEntity> Entities
        {
            get
            {
                if (_entities == null)
                    _entities = _context.Set<TEntity>();
                return _entities;
            }
        }

    }
}
