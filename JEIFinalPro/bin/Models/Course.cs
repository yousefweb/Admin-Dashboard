using JEIFinalPro.Models.SharedProp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JEIFinalPro.Models
{
    public class Course : CommonProp
    {
        public int CourseId { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage ="Max Length 20 char")]
        public string CourseName { get; set; }

        [Required]
        [MaxLength(35, ErrorMessage = "Max Length 35 char")]
        public string SubTitle { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string CourseDesc { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }

        public string CourseImg { get; set; }

        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Select Venu")]
        public MyVenu Venu { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
    public enum MyVenu
    { 
    Recorded,Online,Offline
    }
}

