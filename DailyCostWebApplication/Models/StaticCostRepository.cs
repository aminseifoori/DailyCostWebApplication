using DailyCostWebApplication.ViewModels;
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
            new Cost{ID=1, Amount=100.00M,RegisteredDate=new DateTime(2022,02,19),CategoryID=1,Comment="New Record",PaymentMethod=PaymentMethods.Cash  },
            new Cost{ID=2, Amount=25.00M,RegisteredDate=new DateTime(2022,02,13),CategoryID=2,Comment="New Record",PaymentMethod=PaymentMethods.Credit  },
            new Cost{ID=3, Amount=700.00M,RegisteredDate=new DateTime(2022,02,11),CategoryID=3,Comment="New Record",PaymentMethod=PaymentMethods.Debit  }
        };

        public Cost Create(Cost NewCost)
        {
            costs.Add(NewCost);
            return NewCost;
        }

        public Cost Delete(int id)
        {
            Cost SelectedCost = costs.FirstOrDefault(x => x.ID == id);
            if(SelectedCost!= null)
            {
                costs.Remove(SelectedCost);
                return SelectedCost;
            }
            return null;
        }

        public IEnumerable<Cost> GetAllCost()
        {
            return costs;
        }

        public Cost GetCostByID(int id)
        {
            return costs.FirstOrDefault(c => c.ID == id);
        }

        public List<CostList> GetCostList(string serachby, string searchfor, string sortby)
        {
            throw new NotImplementedException();
        }

        public Cost Update(Cost UpdateCost)
        {
            Cost SelectedCost = costs.FirstOrDefault(x => x.ID == UpdateCost.ID);
            if (SelectedCost != null)
            {
                SelectedCost.Amount = UpdateCost.Amount;
                SelectedCost.RegisteredDate = UpdateCost.RegisteredDate;
                SelectedCost.CategoryID = UpdateCost.CategoryID;
                SelectedCost.Comment = UpdateCost.Comment;
                SelectedCost.PaymentMethod = UpdateCost.PaymentMethod;
                return UpdateCost;
            }
            return null;
        }
    }
}
