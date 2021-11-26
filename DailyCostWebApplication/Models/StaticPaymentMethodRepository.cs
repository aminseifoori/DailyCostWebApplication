using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class StaticPaymentMethodRepository : IPaymentMethodRepository
    {
        private List<PaymentMethod> PaymentMethods = new()
        {
            new PaymentMethod {ID=1,Method="Cash"},
            new PaymentMethod {ID=2 , Method="Credit Card"},
            new PaymentMethod {ID=3, Method="Debit Card"}
        };

        public List<PaymentMethod> GetAll()
        {
            return PaymentMethods;
        }

        public string GetPaymentMethodbyID(int ID)
        {
            var PM = PaymentMethods.FirstOrDefault(x => x.ID == ID);
            return PM.Method;
        }
    }
}
