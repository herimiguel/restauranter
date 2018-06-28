using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System;

namespace restauranter.Models
{
    
    public class ReviewViewModel : BaseEntity
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string reviewer { get; set; }
        
        [Required]

        public string restaurant { get; set; }
       
        [Required]
        public string review { get; set; }
       
        [Required]
        public int  stars { get; set; }
       
        [Required]
         public DateTime visit_date { get; set; }
    }
}