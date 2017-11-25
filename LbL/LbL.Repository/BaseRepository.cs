using LbLModel;
using LbLModel.Model;
using System.Data.Entity;
using System.Linq;


namespace LbL.Repository
{
    public class BaseRepository<T> where T : Entity
    {
        protected BusinessDbContext db;
        public BaseRepository()
        {
            this.db = new BusinessDbContext();
        }
        public bool Add(T obj)
        {
            DbSet<T> dbSet = this.db.Set<T>();
            T add = dbSet.Add(obj);
            int i = this.db.SaveChanges();
            return i > 0;

        }
        public IQueryable<T> Get()
        {
            DbSet<T> dbSet = this.db.Set<T>();
            return this.db.Set<T>().AsQueryable();
        }
        public T GetDetail(string id)
        {
            return this.db.Set<T>().Find(id);
        }
        public bool Edit(T entity)
        {
            this.db.Entry(entity).State = EntityState.Modified;
            int i = this.db.SaveChanges();
            return i > 0;
        }
        public bool Delete(string id)
        {
            var entity = GetDetail(id);
            if (entity == null)
            {
                this.db.Set<T>().Remove(entity);
                int i = this.db.SaveChanges();
                return i > 0;
            }
            return true;
        }

    }
}

