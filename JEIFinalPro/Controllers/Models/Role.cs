using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class Role : CommonProp
    {
        public int RoleId { get; set; }

        [Required]
        public string  RoleName { get; set; }


    }
}
