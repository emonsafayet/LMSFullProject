using LbLModel.Model;
using System;

namespace LbL.ViewModel
{
    public class BaseViewModel
    {
        public BaseViewModel(Entity entity)
        {
            Id = entity.Id;
            Created = entity.Created;
            CreatedBy = entity.CreatedBy;
            ModifiedBy = entity.ModifiedBy;
            Modified = entity.Modified;
        }
        public string Id { get; set; }
        public string Created { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Modified { get; set; }
        public string ModifiedBy { get; set; }
    }
}
