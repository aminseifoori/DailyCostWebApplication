using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.ViewModels
{
    public class CostRegisteredViewModel
    {
        [Display(Name = "Cost Amount")]
        [DataType(DataType.Currency)]
        public decimal Amount { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        [Display(Name = "Selected Category")]
        [DisplayFormat(NullDisplayText = "Category Not Selected")]
        public string Category { get; set; }
        [Display(Name = "Payment Method")]
        [ScaffoldColumn(true)]
        public string PaymentMethod { set; get; }
        [DataType(DataType.Url)]
        public string WebSite { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Time)]
        public DateTime CurrentTime { get; set; }
    }
}
