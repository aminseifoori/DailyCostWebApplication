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
