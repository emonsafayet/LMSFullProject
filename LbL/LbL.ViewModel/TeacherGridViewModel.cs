using LbLModel;

namespace LbL.ViewModel
{
    public class TeacherGridViewModel :BaseViewModel
    {
        public TeacherGridViewModel(Teacher teacher) :base(teacher)
        {
            this.Name = teacher.Name;
            this.Phone = teacher.Phone;
       
        }
        public string Name { get; set; }
        public string Phone { get; set; }
      
    }



}
