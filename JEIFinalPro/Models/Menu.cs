using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class Menu : CommonProp
    {
        public int MenuId { get; set; }

        [Required(ErrorMessage ="Enter Menu Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Enter Menu Url")]
        [Display(Name ="Title Url")]
        public string TitleUrl { get; set; }

        [Required]
        public int ParentId { get; set; }
    }
}
