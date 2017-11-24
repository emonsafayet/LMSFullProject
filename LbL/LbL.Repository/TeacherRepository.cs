using LbLModel;
using System;
using System.Linq;


namespace LbL.Repository
{
    public class TeacherRepository
    {
        private BusinessDbContext db;

        public TeacherRepository()
        {
            this.db = new BusinessDbContext();
        }
        public bool Add(Teacher teacher)
        {
            teacher.Id = Guid.NewGuid().ToString();
            this.db.Teachers.Add(teacher);
            int savechanges = this.db.SaveChanges();
            return savechanges > 0;
        }
        public IQueryable<Teacher> Get()
        {
            return this.db.Teachers.AsQueryable();
        }
        public Teacher GetDetail(string id)
        {
            return this.db.Teachers.Find(id);
        }
    }
}

