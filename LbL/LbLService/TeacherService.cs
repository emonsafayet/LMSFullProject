using LbL.Repository;
using LbLModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbLService
{
    public class TeacherService
    {
        public  void Temp()
        {
            BaseRepository<Teacher> teaceherRepository = new BaseRepository<Teacher>();
            IQueryable<Teacher> teachers = teaceherRepository.Get();
        }
    }
}
