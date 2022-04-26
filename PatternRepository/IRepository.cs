using DevoirRest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevoirRest.PatternRepository
{
    /// <summary>
    ///     A genercic repository pattern interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T: class
    {
        /// <summary>
        /// Inserts a single entity into the DbSet
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);


        /// <summary>
        /// Inserts Range entities into the DbSet
        /// </summary>
        /// <param name="entities"></param>
        void InsertRange(List<T> entities);


        /// <summary>
        /// Returns an entity based on primary key.
        /// </summary>
        /// <param name="id">Primary Key.</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Returns an entity based on primary key.
        /// </summary>
        /// <param name="id">Primary Key.</param>
        /// <returns></returns>
        List<T> GetAll();
        List<T> GetAll(bool active);



        /// <summary>
        /// Returns an IEnumerable based on the query, order clause and the properties included
        /// </summary>
        /// <param name="query">Link query for filtering.</param>
        /// <param name="orderBy">Link query for sorting.</param>
        /// <param name="includeProperties">Navigation properties seperated by comma for eager loading.</param>
        /// <returns>IEnumerable containing the resulting entity set.</returns>
        IEnumerable<T> GetByQuery(Expression<Func<T, bool>> query = null,
                                  Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                  string includeProperties = "");


        /// <summary>
        /// Updates an entity.
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);


    }
}
