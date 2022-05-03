using DailyCostWebApplication.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyCostWebApplication.ViewModels
{
    public class CreateCostViewModel
    {
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Registered Data")]
        public DateTime RegisteredDate { get; set; }
        [MaxLength(150)]
        public string Comment { get; set; }
        [Required]
        [Display(Name = "Category")]
        [RegularExpression("^\\d+$", ErrorMessage ="Please select a category")]
        public int CategoryID { get; set; }
        [Display(Name = "Payment Method")]
        [Required(ErrorMessage ="This option is mandetory, please select a payment method")]
        public PaymentMethods? PaymentMethod { set; get; }
        public IFormFile UploadFile { get; set; }
    }
}
