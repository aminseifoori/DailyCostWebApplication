using DailyCostWebApplication.CustomHtmlHelpers;
using DailyCostWebApplication.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.ViewModels
{
    public class CreateCostViewModel
    {
        [Display(Name ="Cost Amount")]
        [Range(0.0,100000.0)]
        public decimal Amount { get; set; }
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Range(typeof(DateTime),"01/01/1996","01/01/2050")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage ="Comment is mandatory")]
        //[StringLength(50,MinimumLength =5)]
        //[AllowedCharcterLength]
        [AllowedCharacterRange(ErrorMessage ="Comment should be between 5 to 10 characters")]
        public string Comment { get; set; }
        [Display(Name ="Selected Category")]
        [DisplayFormat(NullDisplayText ="Category Not Selected")]
        public string Category { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public List<string> SelectedCategories { get; set; }
        [Display(Name ="Payment Method")]
        public int PaymentMethod { set; get; }
        public List<PaymentMethod> PaymentMethods { get; set; }
        public bool MakeFormClear { get; set; }
    }
}
