
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class Cost
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public DateTime RegisteredDate { get; set; }
        [MaxLength(150)]
        public string Comment { get; set; }
        [Required]
        public int CategoryID { get; set; }
        [ForeignKey(nameof(CategoryID))]
        public virtual Category Category { get; set; }
        public PaymentMethods PaymentMethod { set; get; }
        public string InvoiceImagePath { get; set; }
    }
}
