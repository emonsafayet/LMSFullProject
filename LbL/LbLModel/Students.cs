using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LbLModel.Model;

namespace LbLModel
{
    public class Student : Entity
    {
       [Index]
       [Required]
       [MaxLength(50)]
       public string Name { get; set; }

        [Required]
        [MaxLength]
        public string Address { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }


    }        
}
