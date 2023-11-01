using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class Blog : CommonProp
    {
        public Guid BlogId { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Max Length 20 char")]
        public string BlogTitle { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string BlogDesc { get; set; }

        public string BlogImg { get; set; }
    }
}
