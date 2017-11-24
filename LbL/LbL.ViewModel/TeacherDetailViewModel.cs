using LbLModel;

namespace LbL.ViewModel
{
    public class TeacherDetailViewModel : BaseViewModel
    {
        public TeacherDetailViewModel(Teacher teacher) : base(teacher)
        {
            this.Name = teacher.Name;
            this.Phone = teacher.Phone;
            this.Address = teacher.Address;
            this.Email = teacher.Email;

        }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }



}
