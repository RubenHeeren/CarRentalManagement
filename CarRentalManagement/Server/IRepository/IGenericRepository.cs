using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    /// <summary>
    /// IGenericRepository of type T. T must be a class.
    /// </summary>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Gets all entries in the database.
        /// </summary>
        Task<IList<T>> GetAll
        (
            Expression<Func<T, bool>> expression = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<string> includes = null
        );

        /// <summary>
        /// Get a specific entry of the database.
        /// </summary>
        Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null);

        /// <summary>
        /// Inserts (adds) a new entry into the database.
        /// </summary>
        Task Insert(T entity);

        /// <summary>
        /// Inserts (adds) a range (list) of entities into the database.
        /// </summary>
        Task InsertRange(IEnumerable<T> entities);

        /// <summary>
        /// Deletes an entry in the database with the specified ID.
        /// </summary>
        Task Delete(int id);

        /// <summary>
        /// Deletes a range (list) of entities from the database.
        /// </summary>
        void DeleteRange(IEnumerable<T> entities);

        /// <summary>
        /// Updates an entity.
        /// </summary>
        void Update(T entity);
    }
}
