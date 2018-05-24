using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace ZZSystem.Database.Connections
{
    public class Repository<TEntity> where TEntity : class
    {
        internal DbContext Context;
        internal DbSet<TEntity> DbSet;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public Repository(DbContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Get(
            Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "")
        {
            try
            {
                IQueryable<TEntity> query = DbSet;


                if (filter != null)
                {
                    query = query.Where(filter);
                }

                var properties = includeProperties.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var includeProperty in properties)
                {
                    query = query.Include(includeProperty);
                }


                if (orderBy != null)
                {
                    return orderBy(query).ToList();
                }

                var qry = query.ToList();

                return qry;
                //return await orderBy?.Invoke(query).ToListAsync() ?? query.ToListAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TEntity GetById(object id)
        {
            TEntity entity = DbSet.Find(id);
            return entity;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual TEntity Insert(TEntity entity)
        {
            DbSet.Add(entity);
            return entity;
        }

        public virtual void InsertList(List<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                DbSet.Add(entity);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(object id)
        {
            TEntity entityToDelete = DbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityToDelete"></param>
        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                DbSet.Attach(entityToDelete);
            }
            DbSet.Remove(entityToDelete);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public virtual void Update(TEntity entityToUpdate)
        {
            DbSet.Attach(entityToUpdate);
            Context.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
