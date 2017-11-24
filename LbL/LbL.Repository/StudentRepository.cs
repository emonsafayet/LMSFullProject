using LbLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LbL.Repository
{
    public class StudentRepository
    {
        private BusinessDbContext db;

        public StudentRepository()
        {
            this.db = new BusinessDbContext();
        }
        public bool Add(Student student)
        {
            student.Id = Guid.NewGuid().ToString();
            this.db.Students.Add(student);
            int savechanges = this.db.SaveChanges();
            return savechanges>0;
        }
        public IQueryable<Student> Get()
        {
            return this.db.Students.AsQueryable();
        }
        public Student GetDetail(string id)
        {
            return this.db.Students.Find(id);
        }
    }
}

