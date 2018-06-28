using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System;

namespace restauranter.Models
{
    public abstract class BaseEntity { }
    public class Review : BaseEntity
    {
        [Key]
        public int id { get; set; }


        [Required(ErrorMessage = "cannot be empty")]
        // [MinLength(4, ErrorMessage = "Reviewer Cannot be empty")]
        public string reviewer { get; set; }
        

        [Required(ErrorMessage = "cannot be empty")]
        // [MinLength(4, ErrorMessage = "Reviewer Cannot be empty")]
        public string restaurant { get; set; }
       

        [Required(ErrorMessage = "cannot be empty")]
        // [MinLength(3, ErrorMessage = "Reviewer Cannot be empty")]
        public string review { get; set; }
       

        [Required(ErrorMessage = "cannot be empty")]
        public int  stars { get; set; }
       
       
        [Required(ErrorMessage = "cannot be empty")]
         public DateTime visit_date { get; set; }
    }
}