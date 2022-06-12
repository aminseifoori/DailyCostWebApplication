using DailyCostWebApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyCostWebApplication.Models
{
    public class SQLServerCostRepository : ICostRepository
    {
        private readonly WebAppDBContext context;

        public SQLServerCostRepository(WebAppDBContext _context)
        {
            context = _context;
        }
        public Cost Create(Cost NewCost)
        {
            context.Costs.Add(NewCost);
            context.SaveChanges();
            return NewCost;
        }

        public Cost Delete(int id)
        {
            Cost SelectedCost = context.Costs.FirstOrDefault(x => x.ID == id);
            if (SelectedCost != null)
            {
                context.Costs.Remove(SelectedCost);
                context.SaveChanges();
                return SelectedCost;
            }
            return null;
        }

        public IEnumerable<Cost> GetAllCost()
        {
            return context.Costs;
        }

        public Cost GetCostByID(int id)
        {
            return context.Costs.FirstOrDefault(x => x.ID == id);
        }

        public List<CostList> GetCostList(string searchby, string searchfor)
        {
            var CL = context.Costs.Join(context.Categories, costen => costen.CategoryID, caten => caten.ID, (costen, caten) => new { costen, caten }).
                Select(sel => new 
                {
                    sel.costen.ID,
                    sel.costen.Amount,
                    sel.costen.Comment,
                    sel.costen.PaymentMethod,
                    sel.caten.CategoryName
                }).ToList();
            if(searchby == "comment" && searchfor != null)
            {
                CL = CL.Where(ser => ser.Comment.ToLower().Contains(searchfor.ToLower())).ToList();
            }
            if (searchby == "category" && searchfor != null)
            {
                CL = CL.Where(ser => ser.CategoryName.ToLower() == searchfor.ToLower()).ToList();
            }
            List<CostList> costList = new();
            foreach (var cost in CL)
            {
                costList.Add(new CostList
                {
                    ID = cost.ID,
                    Amount = cost.Amount,
                    Comment = cost.Comment,
                    PaymentMethod = cost.PaymentMethod,
                    CategoryName = cost.CategoryName
                });
            }
            return costList;
        }

        public Cost Update(Cost UpdateCost)
        {
            //Cost SelectedCost = context.Costs.FirstOrDefault(x => x.ID == UpdateCose.ID);
            //if (SelectedCost != null)
            //{
            //    SelectedCost.Amount = UpdateCose.Amount;
            //    SelectedCost.RegisteredDate = UpdateCose.RegisteredDate;
            //    SelectedCost.CategoryID = UpdateCose.CategoryID;
            //    SelectedCost.Comment = UpdateCose.Comment;
            //    SelectedCost.PaymentMethod = UpdateCose.PaymentMethod;
            //    context.SaveChanges();
            //    return UpdateCose;
            //}
            //return null;
            var SelectedCost = context.Costs.Attach(UpdateCost);
            SelectedCost.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return UpdateCost;
        }
    }
}
