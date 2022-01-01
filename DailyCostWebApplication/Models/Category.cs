using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class Category
    {
        public string ID { get; set; }
        [Required]
        [Display(Name = "Category Name")]
        [MaxLength(50)]
        [MinLength(3)]
        public string CategoryName { get; set; }
        [RegularExpression(@"^(\w*\ *\.*\-*\\*\/*)*$", ErrorMessage = "Comment does not accept some special characters")]
        public string Description { get; set; }
        [Required]
        public CategoryActiveOptions Active { get; set; }
    }
}
