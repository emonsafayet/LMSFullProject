using LbLModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LbLModel
{
    public class Teacher :Entity
    {
        [Index]
        [Required]
        [MaxLength(50)]
        public string Name { get; set;}

        [Index]
        [Required]
        [MaxLength(50)]
        public string Address { get; set;}

        [Index]
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Index]
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }


    }
}
