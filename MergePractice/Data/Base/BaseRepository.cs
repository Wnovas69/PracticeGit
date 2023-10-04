using MergePractice.Context;
using Microsoft.EntityFrameworkCore;

namespace MergePractice.Data.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly PoSContext context;
        private readonly DbSet<TEntity> myDbSet;
        public BaseRepository(PoSContext context)
        {
            this.context = context;
            this.myDbSet = this.context.Set<TEntity>();
        }   
        public virtual void Agregar(TEntity entity)
        {
            this.myDbSet.Add(entity);
            this.context.SaveChanges();
        }

        public virtual List<TEntity> List()
        {
            return this.myDbSet.ToList();
        }

        public virtual void Modificar(TEntity entity)
        {
            this.myDbSet.Update(entity);
            this.context.SaveChanges();
        }

        public virtual TEntity ObtenerId(int id)
        {
            return this.myDbSet.Find(id);
        }

        public virtual void Remover(int Id)
        {
            var entity =this.ObtenerId(Id);
            this.myDbSet.Remove(entity);
            this.context.SaveChanges();
        }
    }
}
