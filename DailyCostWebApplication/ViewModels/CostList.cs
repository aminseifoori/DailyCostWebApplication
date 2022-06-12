using DailyCostWebApplication.Models;

namespace DailyCostWebApplication.ViewModels
{
    public class CostList
    {
        public int ID { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public string CategoryName { get; set; }
        public PaymentMethods? PaymentMethod { set; get; }
    }
}
