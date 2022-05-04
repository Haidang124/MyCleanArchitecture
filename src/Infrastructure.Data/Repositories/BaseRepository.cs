using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Persistence.Models;
using Microsoft.EntityFrameworkCore;
using MyCleanArchitecture.Domain.Common;
using MyCleanArchitecture.Infrastructure.Persistence.ConnectDatabase.Context;

namespace Infrastructure.Data.Repositories
{
    public class BaseRepository<T, TD> : IRepository<T> where T : IAggregateRoot where TD : BasePersistenceModel
    {
        private readonly EcommerceDbContext _context;

        private readonly DbSet<TD> _entities;


        /// <summary>
        ///     Initializes a new instance of the BaseRepository /> class.
        ///     Note that here I've stored Context.Set
        ///     <AggregateRoot>
        ///         () in the constructor and store it in a private field like _entities.
        ///         This way, the implementation  of our methods would be cleaner:        ///
        ///         _entities.ToList();
        ///         _entities.Where();
        ///         _entities.SingleOrDefault();
        ///     </AggregateRoot>
        /// </summary>
        protected BaseRepository(EcommerceDbContext context)
        {
            _context = context;
            _entities = _context.Set<TD>();
        }

        /// <summary>
        ///     Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public virtual T Get(Guid id)
        {
            return _entities.AsNoTracking().FirstOrDefault(e => e.Id == id)?.ToEntity() as T;
        }

        /// <summary>
        ///  Gets all specified entities.
        /// <returns></returns>
        /// </summary>
        public IEnumerable<T> GetAll()
        {
            return _entities.AsNoTracking().Select(e => e.ToEntity() as T).ToList();
        }


        /// <summary>
        ///     Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Add(T entity)
        {
            if ((BasePersistenceModel.FromEntity(entity) as TD) is not { } model)
                return;
            _entities.Add(model);
            _context.SaveChanges();
        }

        /// <summary>
        ///     Adds the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void AddRange(IEnumerable<T> entities)
        {
            var models = entities.Select(e => BasePersistenceModel.FromEntity(e) as TD);
            _entities.AddRange(models);
            _context.SaveChanges();
        }

        /// <summary>
        ///     Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public void Remove(T entity)
        {
            if (BasePersistenceModel.FromEntity(entity) is not TD model)
                return;
            _entities.Remove(model);
            _context.SaveChanges();
        }

        /// <summary>
        ///     Removes the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void RemoveRange(IEnumerable<T> entities)
        {
            var models = entities.Select(e => BasePersistenceModel.FromEntity(e) as TD);
            _entities.RemoveRange(models);
            _context.SaveChanges();
        }


        /// <summary>
        ///     Update the Entity
        /// </summary>
        /// <param name="entity"></param>
        public virtual void UpdateEntity(T entity)
        {
            if (BasePersistenceModel.FromEntity(entity) is not TD model) return;
            _entities.Attach(model);
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
