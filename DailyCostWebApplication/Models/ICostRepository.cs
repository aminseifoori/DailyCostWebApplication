using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public interface ICostRepository
    {
        Cost GetCostByID(int id);
        IEnumerable<Cost> GetAllCost();
    }
}
