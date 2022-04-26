using DevoirRest.Context;
using DevoirRest.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevoirRest.PatternRepository
{

    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        public static readonly ApplicationDBContext _ctx = null;
        public static ApplicationDBContext Ctx
        {
            get
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();

                return _ctx ?? new ApplicationDBContext(optionsBuilder.Options);
            }

        }

        /// <summary>
        /// Underlying DbSet.
        /// </summary>
        protected DbSet<T> _DbSet;

        /// <summary>
        /// Underlying dbcontext
        /// </summary>
        protected DbContext _DbContext;


        /// <summary>
        /// Underlying queryable
        /// </summary>
        protected IQueryable<T> _Query;

        public Repository(DbContext dataContext, IQueryable<T> query = null)
        {
            _DbContext = dataContext;
            _DbSet = _DbContext.Set<T>();
            if (query != null)
            {
                _Query = query;
            }
        }
        public List<T> GetAll()
        {
            return GetByQuery().ToList<T>();
        }

        public List<T> GetAll(bool active)
        {
            return GetByQuery(t => t.IsActive.Equals(active)).ToList<T>();
        }

        public T GetById(int id)
        {
            return _DbSet.Find(id);
        }

        public IEnumerable<T> GetByQuery(Expression<Func<T, bool>> query = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {

            IQueryable<T> queryResult = null;
            if (queryResult == null)
            {
                queryResult = _DbSet;
            }


            //If there is a query, execute it against the dbset
            if (query != null)
            {
                queryResult = queryResult.Where(query);
            }

            //get the include requests for the navigation properties and add them to the query result
            foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                queryResult = queryResult.Include(property);
            }

            //if a sort request is made, order the query accordingly.
            if (orderBy != null)
            {
                return orderBy(queryResult).ToList();
            }
            //if not, return the results as is
            else
            {
                return queryResult.ToList();
            }
        }

        public void Insert(T entity)
        {
            _DbSet.Add(entity);
            _DbContext.Entry(entity).State = EntityState.Added;
            _DbContext.SaveChanges();
        }

        public void InsertRange(List<T> entities)
        {
            _DbSet.AddRange(entities);
            foreach (T entity in entities)
                _DbContext.Entry(entity).State = EntityState.Added;
            _DbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (_DbContext.Entry(entity).State == EntityState.Detached)
            {
                _DbSet.Attach(entity);
            }

            _DbContext.Entry(entity).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }
    }
}
