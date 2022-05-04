using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCleanArchitecture.Domain.common;

namespace MyCleanArchitecture.Domain.Common
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        /// <summary>
        ///     Gets the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        T Get(Guid id);

        /// <summary>
        ///  Gets all specified entities.
        /// <returns></returns>
        /// </summary>
        IEnumerable<T> GetAll();


        /// <summary>
        ///     Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Add(T entity);

        /// <summary>
        ///     Adds the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void AddRange(IEnumerable<T> entities);

        /// <summary>
        ///     Removes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Remove(T entity);

        /// <summary>
        ///     Removes the range.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>
        ///     Update the Entity
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void UpdateEntity(T entityToUpdate);
    }
}
