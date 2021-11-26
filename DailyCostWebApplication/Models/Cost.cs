
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class Cost
    {
        [HiddenInput(DisplayValue =false)]
        public int ID { get; set; }
        [Required(ErrorMessage ="Amount property is mandatory")]
        public decimal Amount { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }
        [StringLength(20,MinimumLength =5,ErrorMessage ="Comment should be between 5 to 20 characters")]
        [Required(ErrorMessage ="Comment field is mandatory")]
        public string Comment { get; set; }
        public string Category { get; set; }
        public int PaymentMethod { set; get; }
        public string PhotoPath { get; set; }
        public string AltText { get; set; }
    }
}
