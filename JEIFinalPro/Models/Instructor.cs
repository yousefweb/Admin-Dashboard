using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class Instructor : CommonProp
    {
        [Key]
        public Guid InsId { get; set; }

        [Required]
        public string  InsName{ get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Position { get; set; }

        public string FbUrl { get; set; }
    }
}
