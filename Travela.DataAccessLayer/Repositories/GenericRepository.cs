using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Travela.DataAccessLayer.Abstract;
using Travela.DataAccessLayer.Context;
using Travela.EntityLayer.Abstract;

namespace Travela.DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity, TContext> : IGenericDal<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Delete(int id)
        {
            using (TContext context = new TContext())
            {
                var entity = context.Set<TEntity>().Find(id);
                if (entity != null)
                {
                    var deletedEntity = context.Entry(entity);
                    deletedEntity.State = EntityState.Deleted;
                    context.SaveChanges();
                }
                else
                {
                    // Belirtilen ID'ye sahip bir varlık bulunamazsa uygun bir işlem yapılabilir.
                    // Örneğin, bir hata fırlatılabilir veya bir geri dönüş değeri gönderilebilir.
                }
            }
        }


        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetListAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Insert(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
