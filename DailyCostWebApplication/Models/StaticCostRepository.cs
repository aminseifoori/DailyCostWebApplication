using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class StaticCostRepository : ICostRepository
    {
        private List<Cost> costs = new List<Cost>
        {
            new Cost {ID=1, Amount=100, Date=DateTime.Now, Category="Bill", Comment="Payment for Mobile bill", PhotoPath="/images/invoice.png", AltText="Cost Receipt Image"},
            new Cost{ID=2, Category="Grocery", Date=DateTime.Now,  Amount=40, Comment="Payment for buying milk and vegetables"},
            new Cost{ID=3, Category="Grocery",  Date=DateTime.Now, Amount=40, Comment="Payment for buying meat abd chicken"},
        };

        public IEnumerable<Cost> GetAllCost()
        {
            return costs;
        }

        public Cost GetCostByID(int id)
        {
            return costs.FirstOrDefault(c => c.ID == id);
        }

    }
}
