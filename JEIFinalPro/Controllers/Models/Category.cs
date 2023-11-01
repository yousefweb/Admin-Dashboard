using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class Category : CommonProp
    {
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Max Length 20 char")]
        public string CategoryName { get; set; }
    }
}
