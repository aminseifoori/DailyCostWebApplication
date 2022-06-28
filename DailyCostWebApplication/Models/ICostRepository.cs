using DailyCostWebApplication.ViewModels;
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
        Cost Create(Cost NewCost);
        Cost Update(Cost UpdateCost);
        Cost Delete(int id);
        List<CostList> GetCostList(string searchby, string searchfor, string sortby);
    }
}
