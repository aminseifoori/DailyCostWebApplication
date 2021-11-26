using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public interface IPaymentMethodRepository
    {
        List<PaymentMethod> GetAll();
        string GetPaymentMethodbyID(int ID);
    }
}
