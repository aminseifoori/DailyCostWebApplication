using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public string Description { get; set; }
        [Required]
        public CategoryActiveOptions Active { get; set; }
        public virtual Cost Cost { get; set; }
    }
}
